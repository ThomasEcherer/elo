using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Lists the name of active and finished workflows and workflow templates.
	/// </summary>
	public class ListWorkFlows
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

				// get templates
				Logger.instance().log("get workflow templates...");
				IdName[] idNames = ix.Ix.collectWorkFlows(WFTypeC.TEMPLATE);
				Logger.instance().log("  #workflows=" + idNames.Length);
				for (int i = 0; i < idNames.Length; i++) 
				{
					Logger.instance().log("  id=" + idNames[i].id + ", name=" + idNames[i].name);
				}
				Logger.instance().log("get workflow templates OK");

				// get active workflows
				Logger.instance().log("get active workflows...");
				idNames = ix.Ix.collectWorkFlows(WFTypeC.ACTIVE);
				Logger.instance().log("  #workflows=" + idNames.Length);
				for (int i = 0; i < idNames.Length; i++) 
				{
					Logger.instance().log("  id=" + idNames[i].id + ", name=" + idNames[i].name);
				}
				Logger.instance().log("get active workflows OK");

				// get finished workflows
				Logger.instance().log("get finished workflows...");
				idNames = ix.Ix.collectWorkFlows(WFTypeC.FINISHED);
				Logger.instance().log("  #workflows=" + idNames.Length);
				for (int i = 0; i < idNames.Length; i++) 
				{
					Logger.instance().log("  id=" + idNames[i].id + ", name=" + idNames[i].name);
				}
				Logger.instance().log("get finished workflows OK");

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
