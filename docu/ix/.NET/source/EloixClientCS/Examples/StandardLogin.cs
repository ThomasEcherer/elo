using System;
using EloixClient.IndexServer;
using System.Security.Principal;


namespace Examples
{
	/// <summary>
	/// Login/logout user
	/// </summary>
	public class StandardLogin
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

				// LOGIN
				Logger.instance().log("login...");
        ix = connFact.Create(userName, userPwd, "myComputer", null);

        Logger.instance().log("Version=" + connFact.Version);
        Logger.instance().log("ImplVersion=" + ix.ImplVersion);
        Logger.instance().log("InterfaceVersion=" + ix.InterfaceVersion);
        Logger.instance().log("ClientVersion=" + ix.ClientVersion);

        LoginResult loginResult = ix.LoginResult;

				// If successfully logged on, you can find the ticket here: 
				// loginResult.clientInfo.ticket.
				Logger.instance().log("login successfully, ticket=" + loginResult.clientInfo.ticket);
				Logger.instance().log("ticket lifetime seconds=" + loginResult.ticketLifetime);
				Logger.instance().log("user ID=" + loginResult.user.id);

                // Otherwise an exception was thrown in ix.Ix.login() and you will not 
                // reach this lines.

                // Use in subsequent calls always the returned ClientInfo object (contains ticket).
                // ci = ix.Login.ci


                ix.Ix.checkoutWorkflowTemplate("6439", "", WFDiagramC.mbAll, LockC.NO);
                FindWorkflowInfo findInfo = new FindWorkflowInfo();
                findInfo.type = WFTypeC.TEMPLATE;
                FindResult findResult = ix.Ix.findFirstWorkflows(findInfo, 100, WFDiagramC.mbLean);
                Logger.instance().log("wfs=" + findResult.workflows);

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
					ix.Dispose();
					Logger.instance().log("IX logout OK");
				}
			}
		}
	}
}
