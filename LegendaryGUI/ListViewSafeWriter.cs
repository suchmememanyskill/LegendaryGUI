using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendaryGUI
{
    public class ListViewSafeWriter
    {
        private ListView listView;
        private delegate void SafeCallAdd(ListViewItem item);
        private delegate void SafeCall();

        public ListViewSafeWriter(ListView lv)
        {
            listView = lv;
        }

        public void Add(ListViewItem item)
        {
            if (listView.InvokeRequired)
            {
                var d = new SafeCallAdd(Add);
                listView.Invoke(d, new object[] { item });
            }
            else
            {
                listView.Items.Add(item);
            }
        }
        public void Clear()
        {
            if (listView.InvokeRequired)
            {
                var d = new SafeCall(Clear);
                listView.Invoke(d);
            }
            else
            {
                listView.Items.Clear();
            }
        }
    }
}
