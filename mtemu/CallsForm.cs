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
            mainForm_.AddCall();
        }

        private void SaveCall(object sender, EventArgs e)
        {
            mainForm_.EditCall();
        }

        private void CreateCommand(object sender, EventArgs e)
        {
            mainForm_.AddCommand();
        }

        private void EditCommand(object sender, EventArgs e)
        {
            mainForm_.EditCommand();
        }

        private void DeleteCommand(object sender, EventArgs e)
        {
            mainForm_.RemoveCommand();
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
            int index = listViewCommand.SelectedIndices[0];
        }

        private void SelectCall(object sender, EventArgs e)
        {
            int index = callList.SelectedIndices[0];
        }
    }
}
