using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für FindReport.
	/// </summary>
	public class FindReport
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

				// Create a Sord object to generate some report information
				Logger.instance().log("create sord...");
				Sord sord = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sord.name = "C# Example Report";
				sord.id = ix.Ix.checkinSord(sord, SordC.mbLean, LockC.NO);
				Logger.instance().log("create sord OK");

				// Wait some seconds. Report information is wirtten with a little
				// time delay after the action was taken. 
				Logger.instance().log("sleep two seconds ...");
				System.Threading.Thread.Sleep(2000);
				Logger.instance().log("sleep two seconds OK");

				// Find report entries to sord 
				Logger.instance().log("find report...");
				FindReportInfo findReport = new FindReportInfo();
				findReport.objId = sord.guid;
        FindResult findResult = ix.Ix.findFirstReportInfos(findReport, 10);

        int idx = 0;
        while (true)
        {
          ReportInfo[] rinfos = findResult.reportInfos;
          Logger.instance().log("find report OK, #infos=" + rinfos.Length);

          // Dump report information.
          // There could be more information since already deleted sord objects 
          // could have had the same ID. 
          for (int i = 0; i < rinfos.Length; i++)
          {
            Logger.instance().log("  action=" + rinfos[i].action);
            Logger.instance().log("    time=" + rinfos[i].actTimeISO);
            Logger.instance().log("    user=" + rinfos[i].userId);
            Logger.instance().log("    text=" + rinfos[i].text);
          }

          if (!findResult.moreResults)
          {
            break;
          }

          idx += rinfos.Length;
          findResult = ix.Ix.findNextReportInfos(findResult.searchId, idx, 10);
        }

        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, sord.guid, LockC.NO, null);
        ix.Ix.deleteSord(null, sord.guid, LockC.NO, delOpts);
								
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
