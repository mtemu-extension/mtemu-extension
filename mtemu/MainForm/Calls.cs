﻿using System.Drawing;
using System.Windows.Forms;

namespace mtemu
{
    partial class MainForm
    {
        public void UpdateCallHandler()
        {
            isCallSaved_ = false;

        }

        private void LoadCall_(Call call)
        {
            currentCall_ = call;
            UpdateCallHandler();
            isCallSaved_ = true;
        }

        ////////////////////
        //   CALLS LIST   //
        ////////////////////

        private void SelectCall_(int index, Color selectedColor)
        {
            if (0 <= selectedCall_ && selectedCall_ < callsForm_.callList.Items.Count) {
                callsForm_.callList.Items[selectedCall_].BackColor = enabledColor_;
            }
            selectedCall_ = index;
            if (0 <= selectedCall_ && selectedCall_ < callsForm_.callList.Items.Count) {
                callsForm_.callList.Items[selectedCall_].BackColor = selectedColor;
                callsForm_.callList.EnsureVisible(selectedCall_);
            }
        }

        private void ChangeCall_(int newSelected, Color color, bool force = false)
        {
            if (newSelected < -1 || callsForm_.callList.Items.Count <= newSelected) {
                return;
            }

            if (newSelected != selectedCall_ || force) {
                if (!isCallSaved_ && !force) {
                    DialogResult saveRes = MessageBox.Show(
                        "Сохранить текущий вызов?",
                        "Сохранение",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1
                    );
                    if (saveRes == DialogResult.Cancel) {
                        return;
                    }
                    if (saveRes == DialogResult.Yes) {
                        SaveCall();
                    }
                }
                SelectCall_(newSelected, color);

                if (newSelected == -1) {
                    LoadCall_(Call.GetDefault());
                }
                else {
                    LoadCall_(new Call(emulator_.GetCall(newSelected)));

                    if (newSelected == 0) {
                    }
                    else {
                    }
                    if (newSelected == callsForm_.callList.Items.Count - 1) {
                    }
                    else {
                    }
                }
            }
        }


        private ListViewItem CallToItems(Call call)
        {
            return new ListViewItem(new string[] { "", $"0x{call.GetAddress():X3}", call.GetComment() });
        }

        public int GetCallIndex()
        {
            return selectedCall_;
        }

        public void ChangeCallByIndex(int index)
        {
            ChangeCall_(index, selectedColor_);
        }

        ////////////////////
        //    CONTROLS    //
        ////////////////////

        public void SetCallAddress(int address)
        {
            currentCall_.SetAddress(address);
        }

        public void SetCallComment(string comment)
        {
            currentCall_.SetComment(comment);
        }

        public void AddCall()
        {
            isProgramSaved_ = false;
            isCallSaved_ = true;

            int index = selectedCall_ + 1;
            emulator_.AddCall(index, new Call(currentCall_));
            callsForm_.callList.Items.Insert(index, CallToItems(emulator_.GetCall(index)));

            for (int i = index; i < emulator_.CallsCount(); ++i) {
                callsForm_.callList.Items[i] = CallToItems(emulator_.GetCall(i));
            }
            ChangeCall_(index, selectedColor_);
        }

        public void SaveCall()
        {
            isProgramSaved_ = false;
            isCallSaved_ = true;

            int number = selectedCall_;
            if (number != -1) {
                emulator_.UpdateCall(number, new Call(currentCall_));
                for (int i = number; i < emulator_.CallsCount(); ++i) {
                    callsForm_.callList.Items[i] = CallToItems(emulator_.GetCall(i));
                }
                ChangeCall_(number, selectedColor_, true);
            }
        }

        public void RemoveCall()
        {
            if (0 <= selectedCall_ && selectedCall_ < callsForm_.callList.Items.Count) {
                isProgramSaved_ = false;

                int number = selectedCall_;
                emulator_.RemoveCall(number);
                callsForm_.callList.Items.RemoveAt(number);
                if (number >= callsForm_.callList.Items.Count) {
                    number = callsForm_.callList.Items.Count - 1;
                }

                if (number != -1) {
                    for (int i = number; i < emulator_.CallsCount(); ++i) {
                        callsForm_.callList.Items[i] = CallToItems(emulator_.GetCall(i));
                    }
                }

                ChangeCall_(number, selectedColor_, true);
            }
        }

        public void MoveUpCall()
        {
            int index = selectedCall_;
            if (index == 0) {
                return;
            }
            emulator_.MoveCallUp(index);

            for (int i = index - 1; i < emulator_.CallsCount(); ++i) {
                callsForm_.callList.Items[i] = CallToItems(emulator_.GetCall(i));
            }

            ChangeCall_(index - 1, selectedColor_);

            isProgramSaved_ = false;
        }

        public void MoveDownCall()
        {
            int index = selectedCall_;
            if (index == callsForm_.callList.Items.Count - 1) {
                return;
            }
            emulator_.MoveCallDown(index);

            for (int i = index; i < emulator_.CallsCount(); ++i) {
                callsForm_.callList.Items[i] = CallToItems(emulator_.GetCall(i));
            }

            ChangeCall_(index + 1, selectedColor_);

            isProgramSaved_ = false;
        }

    }
}
