using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Login/logout user with single-sign-on login
	/// </summary>
	public class SingleSignOnLogin
	{
		// URL to IndexServer
		public String url;

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
				Logger.instance().log("login ...");
                ClientInfo ci = new ClientInfo();
                ci.timeZone = "GMT+01:00"; // "Europe/Berlin";
                ix = connFact.CreateSso(ci, Environment.MachineName);
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
