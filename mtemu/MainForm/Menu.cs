﻿using System;
using System.IO;
using System.Windows.Forms;

namespace mtemu
{
    partial class MainForm
    {
        private bool BeforeCloseProgram_()
        {
            if (!isProgramSaved_)
            {
                DialogResult res = MessageBox.Show(
                    "Текущие изменения не сохранены. Хотите сохранить?",
                    "Вы уверены?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );
                if (res == DialogResult.Yes)
                {
                    return SaveDialog_();
                }
                if (res == DialogResult.No)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        private void NewMenuItemClick_(object sender, EventArgs e)
        {
            if (BeforeCloseProgram_())
            {
                Reset_();
            }
        }

        private bool OpenDialog_()
        {
            openFileDialog.FileName = Path.GetFileName(filename_);
            DialogResult openRes = openFileDialog.ShowDialog();
            if (openRes == DialogResult.OK)
            {
                if (openFileDialog.FileName != filename_)
                {
                    if (!Reset_(openFileDialog.FileName))
                    {
                        MessageBox.Show(
                            "Выбран файл некорректного формата!",
                            "Не удалось открыть файл!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                        );
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void OpenMenuItemClick_(object sender, EventArgs e)
        {
            if (BeforeCloseProgram_())
            {
                OpenDialog_();
            }
        }

        private bool SaveDialog_(bool asNew = false)
        {
            if (filename_ == null || asNew)
            {
                saveFileDialog.FileName = Path.GetFileName(filename_);
                DialogResult saveRes = saveFileDialog.ShowDialog();
                if (saveRes != DialogResult.OK)
                {
                    return false;
                }
                filename_ = saveFileDialog.FileName;
            }
            if (!emulator_.SaveFile(filename_))
            {
                MessageBox.Show(
                    "Недостаточно прав для выполнения данного действия!",
                    "Не удалось сохранить файл!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
                return false;
            }
            isProgramSaved_ = true;
            return true;
        }

        private void SaveMenuItemClick_(object sender, EventArgs e)
        {
            SaveDialog_();
        }

        private void SaveAsMenuItemClick_(object sender, EventArgs e)
        {
            SaveDialog_(true);
        }

        private void ExitMenuItemClick_(object sender, EventArgs e)
        {
            Close();
        }

        private void StackMenuItemClick_(object sender, EventArgs e)
        {
            if (!stackForm_.Visible)
            {
                stackForm_.Show(this);
                StackFormMove_();
                this.Focus();
            }
        }

        private void MemoryMenuItemClick_(object sender, EventArgs e)
        {
            if (!memoryForm_.Visible)
            {
                memoryForm_.Show(this);
                MemoryFormMove_();
                this.Focus();
            }
        }

        private void SchemeMenuItemClick_(object sender, EventArgs e)
        {
            if (!schemeForm_.Visible)
            {
                schemeForm_.Show(this);
                SchemeFormMove_();
            }
        }

        private void ProgramMenuItemClick_(object sender, EventArgs e)
        {
            if (!callsForm_.Visible)
            {
                callsForm_.Show(this);
                callsForm_.Init();
                CallsFormMove_();
            }
        }

        private void ExtenderSettingsMenuItemClick_(object sender, EventArgs e)
        {
            var deviceOpened = portExtender_.IsDeviceOpened();
            if (deviceOpened)
                portExtender_.CloseDevice();

            DialogResult dr = extenderSettingsForm_.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                PortExtender.DeviceInfo devInfo = extenderSettingsForm_.GetSelectedDeviceInfo();
                bool res = portExtender_.SelectDevice(devInfo);
                if (!res)
                {
                    deviceInfoBox.Text = "Устройство: нет подключения";

                    MessageBox.Show(
                        "Не удалось выбрать внешнее устройство",
                        "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    portExtender_.StatusPoll();
                    deviceInfoBox.Text = "Устройство: MTPE-" + devInfo.serial;
                }
            }
            else
            {
                if (deviceOpened)
                {
                    portExtender_.ReopenLastDevice();
                    portExtender_.StatusPoll();
                }
            }
        }

        private void DeviceRemovedStatusUpdate()
        {
            deviceInfoBox.BeginInvoke(
                (MethodInvoker)(() =>
                deviceInfoBox.Text = "Устройство: нет подключения"
                ));

            MessageBox.Show(
                "Устройство было отключено",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        public void DeviceRemovedHandler(object sender, System.Management.EventArrivedEventArgs e)
        {
            System.Management.ManagementEventWatcher removal = (System.Management.ManagementEventWatcher)sender;

            var targetInstanceData = e.NewEvent.Properties["TargetInstance"];
            var targetInstanceObject = (System.Management.ManagementBaseObject)targetInstanceData.Value;

            foreach (var prop in targetInstanceObject.Properties)
            {
                if (prop.Name == "PNPDeviceID")
                {
                    var pnpDeviceId = targetInstanceObject["PNPDeviceID"].ToString();

                    if (pnpDeviceId.Contains("USB\\VID_0483&PID_5740"))
                    {
                        var deviceId = targetInstanceObject["DeviceID"].ToString();
                        if (portExtender_.CheckDeviceRemoved())
                        {
                            removal.Stop();
                            portExtender_.CloseDevice();

                            DeviceRemovedStatusUpdate();
                        }
                    }
                    return;
                }
            }

            removal.WaitForNextEvent();
        }

        private void HelpMenuItemClick_(object sender, EventArgs e)
        {
            helpForm_.ShowDialog(this);
        }

        private void DebugMenuItemClick_(object sender, EventArgs e)
        {
            int diff = commandsPanel.Margin.Right + debugPanel.Margin.Left + debugPanel.Width;

            if (debugPanel.Visible)
            {
                debugPanel.Hide();
                debugMenuItem.Text = debugMenuPrefix + " (показать)";

                Width -= diff;
                infoPanel.Left -= diff;
            }
            else
            {
                debugPanel.Show();
                debugMenuItem.Text = debugMenuPrefix + " (скрыть)";

                Width += diff;
                infoPanel.Left += diff;
            }

            MemoryFormMove_();
            StackFormMove_();
        }

        private void InfoMenuItemClick_(object sender, EventArgs e)
        {
            int marginOfLeftElem = debugPanel.Visible ? debugPanel.Margin.Right : commandsPanel.Margin.Right;
            int diff = marginOfLeftElem + infoPanel.Margin.Left + infoPanel.Width;

            if (infoPanel.Visible)
            {
                infoPanel.Hide();
                infoMenuItem.Text = infoMenuPrefix + " (показать)";

                Width -= diff;
            }
            else
            {
                infoPanel.Show();
                infoMenuItem.Text = infoMenuPrefix + " (скрыть)";

                Width += diff;
            }

            MemoryFormMove_();
            StackFormMove_();
        }
    }
}
