using System;
using System.Windows.Forms;

namespace Examples
{
	/// <summary>
	/// Loggs text lines to a RichTextBox
	/// </summary>
	public class Logger
	{
		private RichTextBox txLog;

		private static Logger c_log;

		static public Logger instance() 
		{
			if (c_log == null) c_log = new Logger();
			return c_log;
		}
		
		public void init(RichTextBox txLog) 
		{
			this.txLog = txLog;
		}

		public void log(String msg)
		{
			if (txLog != null)
			{
				DateTime dt = DateTime.Now;
				String strMillis = "" + dt.Millisecond;
				while (strMillis.Length < 3) strMillis = "0" + strMillis;
				String strTime = dt.ToLongTimeString() + "," + strMillis;
				txLog.AppendText(strTime + "\t" + msg + "\n");
				txLog.Refresh();
				txLog.SelectionStart = txLog.TextLength;
				txLog.Focus();
				txLog.ScrollToCaret();
			}
		}
	}
}
