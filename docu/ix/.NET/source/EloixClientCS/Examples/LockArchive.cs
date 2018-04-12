using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Locks the archive with a key.
	/// </summary>
	public class LockArchive
	{
		// URL to IndexServer
		public String url;

		// Account to authenticate
		public String userName = "Administrator";
		public String userPwd = "";

		// [X] This key is used to lock the archive. 
		// Make sure that it exists before your run the example.
		public String lockKey = "mykey";

		public void run()
		{
      lockKey = "mykey";

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

				// Get the current archive key
				int keyIdBeforeLock = ix.Ix.lockArchive(null);
				Logger.instance().log("key before lock=" + keyIdBeforeLock);

				// LOCK
				int keyIdBeforeLock2 = ix.Ix.lockArchive(lockKey);

				// Get the current archive key
				int keyIdAfterLock = ix.Ix.lockArchive(null);
				Logger.instance().log("key after lock=" + keyIdAfterLock);

				// UNLOCK
				int keyIdBeforeUnlock = ix.Ix.lockArchive("0");

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
