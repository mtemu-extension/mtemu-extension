using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mtemu
{
    public partial class CallsForm : Form
    {
        MainForm mainForm_;

        public CallsForm(MainForm mainForm)
        {
            InitializeComponent();

            mainForm_ = mainForm;
        }

        public void Reset()
        {
            foreach (ListViewItem item in mainForm_.GetItemsMapCall())
            {
                listViewCommand.Items.Add(item);
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
            mainForm_.RemoveCall();
        }

        private void AddCall(object sender, EventArgs e)
        {
            mainForm_.AddCall(1, 1, 1);
        }

        private void SaveCall(object sender, EventArgs e)
        {
            mainForm_.EditCall(1, 1, 1);
        }

        private void CreateCommand(object sender, EventArgs e)
        {
            mainForm_.AddMapCall(1, "", 1);
        }

        private void EditCommand(object sender, EventArgs e)
        {
            mainForm_.EditMapCall();
        }

        private void DeleteCommand(object sender, EventArgs e)
        {
            mainForm_.RemoveMapCall();
        }

        private void Discard(object sender, EventArgs e)
        {

        }

        private void Auto(object sender, EventArgs e)
        {

        }

        private void Step(object sender, EventArgs e)
        {
            mainForm_.ExecOneCall();
        }

        private void SelectCommand(object sender, EventArgs e)
        {
           // int index = listViewCommand.SelectedIndices[0];
        }

        private void SelectCall(object sender, EventArgs e)
        {
          //  int index = callList.SelectedIndices[0];
        }
    }
}
