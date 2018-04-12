using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how createSord can be used to list basic data
	/// like storage mask names and storage paths.
	/// </summary>
	public class ListBasicData
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
				
				// use createSord to get mask names
				Logger.instance().log("createSord...");
				EditInfo ed = ix.Ix.createSord(null, null, EditInfoC.mbBasicData);
				Logger.instance().log("createSord OK");
				
				Logger.instance().log("mask names:");
				for (int i = 0; i < ed.maskNames.Length; i++) 
				{
					Logger.instance().log("  name=" + ed.maskNames[i].name + ", id=" + ed.maskNames[i].id);
				}

				Logger.instance().log("marker names:");
				for (int i = 0; i < ed.markerNames.Length; i++) 
				{
					Logger.instance().log("  name=" + ed.markerNames[i].name + ", id=" + ed.markerNames[i].id);
				}

				Logger.instance().log("path names:");
				for (int i = 0; i < ed.pathNames.Length; i++) 
				{
					Logger.instance().log("  name=" + ed.pathNames[i].name + ", id=" + ed.pathNames[i].id);
				}

				Logger.instance().log("replication set names:");
				for (int i = 0; i < ed.replNames.Length; i++) 
				{
					Logger.instance().log("  name=" + ed.replNames[i].name + ", id=" + ed.replNames[i].id);
				}
				
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
