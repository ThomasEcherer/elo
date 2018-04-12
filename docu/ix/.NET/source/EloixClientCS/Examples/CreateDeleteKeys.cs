using System;
using EloixClient.IndexServer;

namespace Examples
{
	/// <summary>
	/// Creates and deletes a key.
	/// </summary>
	public class CreateDeleteKeys
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
				
				// lock key data 
				// This is optional since checkinKeys and 
				// deleteKeys check the lock too.
				Logger.instance().log("lock key data...");
				ix.Ix.checkoutKeys(null, LockC.YES);
				Logger.instance().log("lock key data OK");

				// create key 
				// - be aware to set KeyInfo.id = -1 to create a new key!
				Logger.instance().log("create key...");
				KeyInfo ki = new KeyInfo();
				ki.id = -1;
				ki.name = "C# Example Key";
				ki.id = ix.Ix.checkinKeys(new KeyInfo[] {ki}, LockC.NO)[0];
				Logger.instance().log("create key OK, name=" + ki.name + ", id=" + ki.id);

				// delete key and unlock
				Logger.instance().log("delete key...");
				ix.Ix.deleteKeys(new String[] {ki.name}, LockC.YES);
				Logger.instance().log("delete key OK");
				
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
