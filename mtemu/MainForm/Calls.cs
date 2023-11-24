using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mtemu
{
    partial class MainForm
    {
        private ListViewItem CallToItems_(Call call)
        {
            return new ListViewItem(new string[] { "", call.GetCode().ToString(), call.GetArg0().ToString(), call.GetArg1().ToString() });
        }

        private ListViewItem CallMapToItems_(KeyValuePair<int, System.Tuple<string, int>> callMap)
        {
            return new ListViewItem(new string[] { callMap.Value.Item1, callMap.Key.ToString(), callMap.Value.Item2.ToString() });
        }

        public void EditCall(int code, int arg0, int arg1)
        {
            Call call = new Call(code, arg0, arg1);
            emulator_.UpdateCall(selectedCall_, call);
        }


        public void AddCall(int code, int arg0, int arg1)
        {
            Call call = new Call(code, arg0, arg1);
            emulator_.AddCall(selectedCall_, call);
        }

        public void RemoveCall()
        {
            emulator_.RemoveCall(selectedCall_);
        }

        public void AddMapCall(int code, string name, int addr)
        {
            emulator_.AddMapCall(1, "", 1);
        }

        public void RemoveMapCall()
        {
            emulator_.RemoveMapCall(1);
        }

        public void EditMapCall()
        {
            emulator_.UpdateMapCall(1, "", 1);
        }

        public List<ListViewItem> GetItemsMapCall()
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            foreach (KeyValuePair<int, System.Tuple<string, int>> callMap in emulator_.GetMapCall())
            {
                CallMapToItems_(callMap);
                listViewItems.Add(CallMapToItems_(callMap));
            }
            return listViewItems;
        }

        public List<ListViewItem> GetItemsCalls()
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            for (int i = 0; i < emulator_.CallsCount(); ++i)
            {
                listViewItems.Add(CallToItems_(emulator_.GetCall(i)));
            }
            return listViewItems;
        }
    }
}
