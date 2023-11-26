using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mtemu
{
    public partial class CallsForm : Form
    {
        MainForm mainForm_;
        TextBox[] textBoxes_;

        public CallsForm(MainForm mainForm)
        {
            InitializeComponent();

            mainForm_ = mainForm;
            textBoxes_ = new TextBox[]
            {
                textBoxNameMapCall,
                textBoxCodeMapCall,
                textBoxAddrMapCall,
                textBoxNameCall,
                textBoxOperand1,
                textBoxOperand2
            };



        }

        public void Reset()
        {
            foreach (ListViewItem item in mainForm_.GetItemsMapCall())
            {
                listViewCallMap.Items.Add(item);
            }
        }


        private void CallsFormClosing_(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void DeleteCall(object sender, EventArgs e)
        {
            listViewCall.Items.Clear();
            int addr = 0;
            foreach (ListViewItem item in mainForm_.RemoveCall())
            {
                item.SubItems[0].Text = addr.ToString();
                ++addr;
                listViewCall.Items.Add(item);
            }
        }

        private void AddCall(object sender, EventArgs e)
        {
            listViewCall.Items.Clear();
            int addr = 0;
            foreach (ListViewItem item in mainForm_.AddCall(Helpers.BinaryToInt(textBoxNameCall.Text), Helpers.BinaryToInt(textBoxOperand1.Text), Helpers.BinaryToInt(textBoxOperand2.Text)))
            {
                item.SubItems[0].Text = addr.ToString();
                ++addr;
                listViewCall.Items.Add(item);
            }
        }

        private void SaveCall(object sender, EventArgs e)
        {
            listViewCall.Items.Clear();
            int addr = 0;
            foreach (ListViewItem item in mainForm_.EditCall(Helpers.BinaryToInt(textBoxNameCall.Text), Helpers.BinaryToInt(textBoxOperand1.Text), Helpers.BinaryToInt(textBoxOperand2.Text)))
            {
                item.SubItems[0].Text = addr.ToString();
                ++addr;
                listViewCall.Items.Add(item);
            }
        }

        private void CreateCallMap(object sender, EventArgs e)
        {
            listViewCallMap.Items.Clear();
            foreach (ListViewItem item in mainForm_.AddMapCall(Helpers.BinaryToInt(textBoxCodeMapCall.Text), textBoxNameMapCall.Text, Helpers.HexToInt(textBoxAddrMapCall.Text)))
            {
                listViewCallMap.Items.Add(item);
            }
        }

        private void EditCallMap(object sender, EventArgs e)
        {
            listViewCallMap.Items.Clear();
            foreach (ListViewItem item in mainForm_.EditMapCall(Helpers.BinaryToInt(textBoxCodeMapCall.Text), textBoxNameMapCall.Text, Helpers.HexToInt(textBoxAddrMapCall.Text)))
            {
                listViewCallMap.Items.Add(item);
            }
        }

        private void DeleteCallMap(object sender, EventArgs e)
        {
            listViewCallMap.Items.Clear();
            foreach (ListViewItem item in mainForm_.RemoveMapCall(Helpers.BinaryToInt(textBoxCodeMapCall.Text)))
            {
                listViewCallMap.Items.Add(item);
            }
        }

        private void Discard(object sender, EventArgs e)
        {
            mainForm_.ResetEmulator();
        }

        private void Auto(object sender, EventArgs e)
        {
            mainForm_.ExecAllEmulator();
        }

        private void Step(object sender, EventArgs e)
        {
            mainForm_.ExecOneCall();
        }

        private bool DefaultTextChanged_(int index, int coder = 0)
        {
            TextBox textBox = textBoxes_[index];

            int selPos = textBox.SelectionStart;
            int selLen = textBox.SelectionLength;
            if (coder == 0) textBox.Text = Helpers.ClearBinary(textBox.Text, ref selPos);
            else textBox.Text = Helpers.ClearHex(textBox.Text, ref selPos);
            textBox.SelectionStart = selPos;
            textBox.SelectionLength = selLen;
            return true;
        }

        private void ChangeTextCodeCallMap(object sender, EventArgs e)
        {
            DefaultTextChanged_(1);
        }

        private void ChangeTextAddrCallMap(object sender, EventArgs e)
        {
            DefaultTextChanged_(2, 1);
        }

        private void ChangeTextCodeCall(object sender, EventArgs e)
        {
            DefaultTextChanged_(3);
        }

        private void ChangeTextOperand1(object sender, EventArgs e)
        {
            DefaultTextChanged_(4);
        }

        private void ChangeTextOperand2(object sender, EventArgs e)
        {
            DefaultTextChanged_(5);
        }

        private void SelectCall(object sender, EventArgs e)
        {
            if (listViewCall.SelectedIndices.Count != 0)
            {
                mainForm_.ChangeSelectCall(listViewCall.SelectedIndices[0]);
            }
        }
    }
}
