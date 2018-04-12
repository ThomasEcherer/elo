using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// http://www.codegod.de/WebAppCodeGod/treeview-scrolling-synchronisieren-AID241.aspx


namespace EloixClientUI.Utils
{
  /// <summary>
  /// Helper functions for the TreeView control.
  /// </summary>
  public class TreeViewHelper
  {
    /// <summary>
    /// Structure for the ScrollInfo
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ScrollInfoStruct
    {
      /// <summary>
      /// Size of this structure
      /// </summary>
      public int cbSize;
      /// <summary>
      /// Bitset of valid members
      /// </summary>
      public int fMask;
      /// <summary>
      /// Minimum scroll position
      /// </summary>
      public int nMin;
      /// <summary>
      /// Maximum scroll position
      /// </summary>
      public int nMax;
      /// <summary>
      /// see Win32 API
      /// </summary>
      public int nPage;
      /// <summary>
      /// Scroll position
      /// </summary>
      public int nPos;
      /// <summary>
      /// see Win32 API
      /// </summary>
      public int nTrackPos;
    }

    /// <summary>
    /// Win32-Methods and Constants
    /// </summary>
    internal sealed class NativeMethods
    {
      [DllImport("user32.dll", SetLastError = true)]
      internal static extern int GetScrollInfo(IntPtr hWnd, int n,
          ref ScrollInfoStruct lpScrollInfo);

      [DllImport("user32.dll")]
      internal static extern int SetScrollInfo(int hWnd, int n,
          [MarshalAs(UnmanagedType.Struct)] ref ScrollInfoStruct lpcScrollInfo,
          bool b);


      [DllImport("user32.dll", EntryPoint = "SendMessageA")]
      internal static extern int SendMessageLong(
          int hwnd,
          uint wMsg,
          int wParam,
          int lParam);


      // Win32 Const
      public const int SBM_SETSCROLLINFO = 0x00E9;
      public const int WM_VSCROLL = 0x115;
      public const int WM_MOUSEWHEEL = 0x20A;
      public const int SB_VERT = 1;
      public const int SB_THUMBTRACK = 5;

      public const int SIF_TRACKPOS = 0x10;
      public const int SIF_RANGE = 0x1;
      public const int SIF_POS = 0x4;
      public const int SIF_PAGE = 0x2;
      public const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;

    }

    /// <summary>
    /// Scroll to a vertical position
    /// </summary>
    /// <param name="treeView">TreeView</param>
    /// <param name="si">Scroll information</param>
    public static void ScrollToPosition(TreeView treeView, ScrollInfoStruct si)
    {
      ScrollInfoStruct siOwn = new ScrollInfoStruct();
      siOwn.fMask = NativeMethods.SIF_ALL;
      siOwn.cbSize = Marshal.SizeOf(si);

      NativeMethods.GetScrollInfo(treeView.Handle, NativeMethods.SB_VERT, ref siOwn);

      if (siOwn.nPos != si.nPos)
      {
        NativeMethods.SetScrollInfo(treeView.Handle.ToInt32(), NativeMethods.SB_VERT, ref si, true);
        NativeMethods.SendMessageLong(treeView.Handle.ToInt32(), NativeMethods.WM_VSCROLL,
            NativeMethods.SB_THUMBTRACK + 0x10000 * si.nPos, 0);
      }

    }
    /// <summary>
    /// Returns the vertical scroll position
    /// </summary>
    /// <param name="treeView">TreeView</param>
    /// <param name="si">Scroll information</param>
    public static void GetScrollPosition(TreeView treeView, ref ScrollInfoStruct si)
    {
      si.fMask = NativeMethods.SIF_ALL;
      si.cbSize = Marshal.SizeOf(si);
      NativeMethods.GetScrollInfo(treeView.Handle, NativeMethods.SB_VERT, ref si);
    }
  }
}
