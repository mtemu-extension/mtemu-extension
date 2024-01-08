using System;
using System.Windows.Forms;

namespace mtemu
{
    public partial class CtrlRegForm : Form
    {
        public CtrlRegForm()
        {
            InitializeComponent();
        }

        private void CtrlRegFormClosing_(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
