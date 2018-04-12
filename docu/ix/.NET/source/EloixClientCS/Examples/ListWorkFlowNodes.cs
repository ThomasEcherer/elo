using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Lists the currently acitve workflow nodes for a given user.
	/// </summary>
	public class ListWorkFlowNodes
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

				Logger.instance().log("get nodes...");
        FindTasksInfo findInfo = new FindTasksInfo();
        findInfo.inclWorkflows = true;
        FindResult findResult = ix.Ix.findFirstTasks(findInfo, 10);

        int idx = 0;
        while (true)
        {
          Logger.instance().log("#nodes=" + findResult.tasks.Length);
          for (int i = 0; i < findResult.tasks.Length; i++)
          {
            WFCollectNode node = findResult.tasks[i].wfNode;
            Logger.instance().log("name=" + node.nodeName);
            Logger.instance().log("  flowId=" + node.nodeId + ", nodeId=" + node.nodeId);
            Logger.instance().log("  objId=" + node.objId + ", userId=" + node.userId);
          }

          if (!findResult.moreResults)
          {
            break;
          }

          idx += findResult.tasks.Length;
          findResult = ix.Ix.findNextTasks(findResult.searchId, idx, 10);
        }

        Logger.instance().log("get nodes OK");

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
