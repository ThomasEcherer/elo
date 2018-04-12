using System.ComponentModel;
using System.Windows.Forms;

namespace EloixClientUI.Controls
{
    public delegate void HeaderRightClickEventHandler(object sender, ColumnClickEventArgs e);

    public class ListViewEx : ListView
    {
        private HeaderControl _headerControl = null;
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x7B:
                    if (!HandleContextMenu(ref m))
                        base.WndProc(ref m);
                    break;
                default:
                    try
                    {
                        base.WndProc(ref m);
                    }
                    catch { }
                    break;
            }
        }

        private bool HandleContextMenu(ref Message m)
        {
            if (this.DesignMode)
                return false;
            if (((int)m.LParam) == -1)
                return false;
            if (m.WParam != this.HeaderControl.Handle)
                return false;
            return HandleHeaderRightClick(0);
        }

        private bool HandleHeaderRightClick(int column)
        {
            ColumnClickEventArgs e = new ColumnClickEventArgs(0);
            this.OnHeaderRightClick(e);
            return true;
        }

        [Browsable(false)]
        public HeaderControl HeaderControl
        {
            get
            {
                if (_headerControl == null)
                {
                    _headerControl = new HeaderControl(this);
                }
                return _headerControl;
            }
        }

        protected virtual void OnHeaderRightClick(ColumnClickEventArgs e)
        {
            if (this.HeaderRightClick != null)
                this.HeaderRightClick(this, e);
        }

        /// <summary>
        /// Triggered when a column header is right clicked.
        /// </summary>
        [Category("Behavior"),
        Description("This event is triggered when the user right clicks a column header.")]
        internal event HeaderRightClickEventHandler HeaderRightClick;
    }
}
