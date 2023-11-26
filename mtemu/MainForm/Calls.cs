using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mtemu
{
    partial class MainForm
    {
        private ListViewItem CallToItems_(Call call)
        {
            
            return new ListViewItem(new string[] { "", Helpers.IntToBinary(call.GetCode(), 8), Helpers.IntToBinary(call.GetArg0(), 8), Helpers.IntToBinary(call.GetArg1(), 8) });
        }

        private ListViewItem CallMapToItems_(KeyValuePair<int, System.Tuple<string, int>> callMap)
        {
            return new ListViewItem(new string[] { Helpers.IntToHex(callMap.Value.Item2, 4), Helpers.IntToBinary(callMap.Key, 8), callMap.Value.Item1 });
        }

        public List<ListViewItem> EditCall(int code, int arg0, int arg1)
        {
            int index = selectedCall_ + 1;
            emulator_.UpdateCall(index, code, arg0, arg1);
            return GetItemsCalls();
        }


        public List<ListViewItem> AddCall(int code, int arg0, int arg1)
        {
            int index = selectedCall_ + 1;
            emulator_.AddCall(index, code, arg0, arg1);
            return GetItemsCalls();
        }

        public List<ListViewItem> RemoveCall()
        {
            int index = selectedCall_ + 1;
            emulator_.RemoveCall(index);
            return GetItemsCalls();
        }

        public List<ListViewItem> AddMapCall(int code, string name, int addr)
        {
            emulator_.AddMapCall(code, name, addr);
            return GetItemsMapCall();

        }

        public List<ListViewItem> RemoveMapCall(int code)
        {
            emulator_.RemoveMapCall(code);
            return GetItemsMapCall();
        }

        public List<ListViewItem> EditMapCall(int code, string name, int addr)
        {
            emulator_.UpdateMapCall(code, name, addr);
            return GetItemsMapCall();
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

        public void ChangeSelectCall(int selected)
        {
            if (selected < emulator_.CallsCount()) selectedCall_ = selected;
        }
    }
}
