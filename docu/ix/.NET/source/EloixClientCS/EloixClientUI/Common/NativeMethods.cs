using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EloixClientUI.Common
{
    class NativeMethods
    {
        #region Constants

        private const int LVM_FIRST = 0x1000;
        private const int LVM_GETHEADER = LVM_FIRST + 31;

        #endregion

        #region Entry points

        // Various flavours of SendMessage: plain vanilla, and passing references to various structures
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, int lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

        #endregion

        public static IntPtr GetHeaderControl(ListView list)
        {
            return SendMessage(list.Handle, LVM_GETHEADER, 0, 0);
        }
    }
}
