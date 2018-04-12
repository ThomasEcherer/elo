using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how to view report options
	/// </summary>
	public class ReportOptions
	{
		// URL to IndexServer
		public String url;

		// [X] Account to authenticate 
		public String userName = "Administrator"; 
		public String userPwd = "";					

		public void run()
		{
			IXConnFactory connFact = null;
			IXConnection ix = null;
			try 
			{
				IXProperties connProps = IXConnFactory.CreateConnProperties(url);
				IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
				connFact = new IXConnFactory(connProps, sessOpts);
				Logger.instance().log("create IXConnFactory OK");

				// Prepare ClientInfo object with language and country
				// ClientInfo ci = new ClientInfo();
				// ci.language = "de";
				// ci.country = "DE";

				// LOGIN
				Logger.instance().log("login...");
				ix = connFact.Create(userName, userPwd, "myComputer", null);
				// ci = ix.Login.ci
				Logger.instance().log("login OK");

				// get constants
				Logger.instance().log("get const...");
				IXServicePortC CONST = ix.CONST;
				Logger.instance().log("get const OK");
				
				// checkout report options
				Logger.instance().log("checkout ...");
        EloixClient.IndexServer.ReportOptions reportOptions = ix.Ix.checkoutReportOptions(LockC.YES);
				Logger.instance().log("checkout OK");

				// log report mode
				String strMode = "";
				if (reportOptions.mode.bset == ReportModeC.NO.bset) 
				{
					strMode = "NO";
				} 
				else if (reportOptions.mode.bset == ReportModeC.LIMITED.bset)
				{
					strMode = "LIMITED";
				}
				else if (reportOptions.mode.bset == ReportModeC.VERBOSE.bset)
				{
					strMode = "VERBOSE";
				}
				else if (reportOptions.mode.bset == ReportModeC.FULL.bset)
				{
					strMode = "FULL";
				}
				Logger.instance().log("mode=" + strMode);

				// list 
				Logger.instance().log("Report actions: ");
				for (int i = 0; i < reportOptions.erpCodes.Length; i++) 
				{
					ReportErpCode erp = reportOptions.erpCodes[i];
					Logger.instance().log("  id=" + erp.id + ", name=" + erp.name + ", verbose=" + erp.verbose + ", limited=" + erp.limited);
				}

				// unlock report data
				Logger.instance().log("unlock...");
				ix.Ix.checkinReportOptions(null, LockC.YES);
				Logger.instance().log("unlock OK");
								
			} 
			catch (Exception e) 
			{
				throw e;
			} 
			finally 
			{
				// Logout
				// --
				if (ix != null) 
				{
					Logger.instance().log("IX logout...");
					ix.Logout();
					Logger.instance().log("IX logout OK");
				}
			}
		}
	}
}
