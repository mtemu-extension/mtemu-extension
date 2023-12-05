using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mtemu
{
    partial class MainForm
    {
        private ListViewItem CallToItems_(Call call)
        {
            return new ListViewItem(new string[] { "", GetNameCallByCode(call.GetCode()), Helpers.IntToBinary(call.GetArg0(), 8), Helpers.IntToBinary(call.GetArg1(), 8) });
        }

        public string GetNameCallByCode(int code)
        {
            return emulator_.GetNameByCode(code);
        }

        public int GetCodeCallByName(string name)
        {
            return emulator_.GetCodeByName(name);
        }

        private ListViewItem CallMapToItems_(KeyValuePair<int, System.Tuple<string, int>> callMap)
        {
            return new ListViewItem(new string[] { Helpers.IntToHex(callMap.Value.Item2, 4), Helpers.IntToBinary(callMap.Key, 8), callMap.Value.Item1 });
        }

        public List<ListViewItem> EditCall(int code, int arg0, int arg1)
        {
            if (selectedCall_ >= emulator_.CallsCount()) selectedCall_ = emulator_.CallsCount() - 1;
            if (selectedCall_ >= 0)
            {
                if (!emulator_.UpdateCall(selectedCall_, code, arg0, arg1)) IncorrectCallDialog();
            }  
            return GetItemsCalls();
        }


        public List<ListViewItem> AddCall(int code, int arg0, int arg1)
        {
            if (selectedCall_ >= emulator_.CallsCount()) selectedCall_ = emulator_.CallsCount() - 1;
            ++selectedCall_;
            if (!emulator_.AddCall(selectedCall_, code, arg0, arg1)) IncorrectCallDialog();
            return GetItemsCalls();
        }

        public List<ListViewItem> RemoveCall()
        {
            if (selectedCall_ >= emulator_.CallsCount()) selectedCall_ = emulator_.CallsCount() - 1;
            if (selectedCall_ >= 0)
            {
                emulator_.RemoveCall(selectedCall_);
            }
            return GetItemsCalls();
        }

        public List<ListViewItem> AddMapCall(int code, string name, int addr)
        {
            if (!emulator_.AddMapCall(code, name, addr)) IncorrectCallMapDialog();
            return GetItemsMapCall();

        }

        public List<ListViewItem> RemoveMapCall(int code)
        {
            if (!emulator_.RemoveMapCall(code)) IncorrectCallMapDialog();
            return GetItemsMapCall();
        }

        public List<ListViewItem> EditMapCall(int code, string name, int addr)
        {
            if (!emulator_.UpdateMapCall(code, name, addr)) IncorrectCallMapDialog();
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

        private void IncorrectCallDialog()
        {
            MessageBox.Show(
                "В одной из ячеек введено неправильное значение!",
                "Неправильная команда!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }

        private void IncorrectCallMapDialog()
        {
            MessageBox.Show(
                "В одной из ячеек введено неправильное значение!",
                "Неправильная команда!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }
    }
}
