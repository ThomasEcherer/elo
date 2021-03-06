﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ExamplesFW
{
  class Shell32
  {
    private const int SW_SHOW = 5;
    private const uint SEE_MASK_INVOKEIDLIST = 12;
    private const uint SEE_MASK_NOCLOSEPROCESS = 0x00000040;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct SHELLEXECUTEINFO
    {
      public int cbSize;
      public uint fMask;
      public IntPtr hwnd;
      [MarshalAs(UnmanagedType.LPTStr)]
      public string lpVerb;
      [MarshalAs(UnmanagedType.LPTStr)]
      public string lpFile;
      [MarshalAs(UnmanagedType.LPTStr)]
      public string lpParameters;
      [MarshalAs(UnmanagedType.LPTStr)]
      public string lpDirectory;
      public int nShow;
      public IntPtr hInstApp;
      public IntPtr lpIDList;
      [MarshalAs(UnmanagedType.LPTStr)]
      public string lpClass;
      public IntPtr hkeyClass;
      public uint dwHotKey;
      public IntPtr hIcon;
      public IntPtr hProcess;
    }

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);

    public static void ShellExeucte_Open(String fileName, bool waitForExit)
    {
      SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
      info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
      info.lpVerb = "open";
      info.lpFile = fileName;
      info.nShow = (int)SW_SHOW;
      info.fMask = SEE_MASK_NOCLOSEPROCESS;
      ShellExecuteEx(ref info); 
      
      if (waitForExit)
      {
        WaitForSingleObject(info.hProcess, -1);
      }
    }
  }
}
