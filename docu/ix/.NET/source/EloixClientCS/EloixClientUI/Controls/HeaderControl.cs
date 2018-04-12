using System;
using System.Windows.Forms;
using EloixClientUI.Common;

namespace EloixClientUI.Controls
{
    public class HeaderControl : NativeWindow
    {
        private ListView _listView;

        public HeaderControl(ListView listView)
        {
            this.ListView = listView;
            this.AssignHandle(NativeMethods.GetHeaderControl(listView));
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        public ListView ListView
        {
            get { return _listView; }
            set { _listView = value; }
        }

        public new IntPtr Handle
        {
            get { return NativeMethods.GetHeaderControl(this.ListView); }
        }
    }
}
