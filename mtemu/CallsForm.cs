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

            List<String> listAddr = new List<string>() { "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002" };
            List<String> listName = new List<string>() { "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002" };
            List<String> listCode = new List<string>() { "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002", "00003", "00001", "00002", "00001", "00002", "00001", "00002", "00001", "00002" };


            //listViewCommand.Items.Add()
            ListViewItem item3 = new ListViewItem();
            listViewCommand.Items.Add(item3);
            for (int i =0; i < listAddr.Count; ++i)
            {
                ListViewItem item = new ListViewItem(listAddr[i]);
                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listCode[i]);
                listViewCommand.Items.Add(item);
                
            }
            ListViewItem item2 = new ListViewItem("1");
            item2.SubItems.Add("1");
            item2.SubItems.Add("!");
            //listViewCommand.Items.Insert(6, item2);
        }


        private void CallsFormClosing_(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

    }
}
