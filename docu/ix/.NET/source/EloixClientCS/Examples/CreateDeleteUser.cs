using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// 1. Creates a group and a user who is a member of the group.
	/// 2. Deletes the user and the group.
	/// </summary>
	public class CreateDeleteUser
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
				
				// 1. Creates a user and a group.

				// Lock user data.
				// This is optional since checkinUsers and 
				// deleteUsers check the lock too.
				Logger.instance().log("lock user data...");
				ix.Ix.checkoutUsers(null, CheckoutUsersC.NOTHING, LockC.YES);
				Logger.instance().log("lock user data OK");
				
				// create group "C# Example Group"
				Logger.instance().log("create group...");
				UserInfo gi = ix.Ix.createUser(null);
				gi.type = UserInfoC.TYPE_GROUP;
				gi.name = "C# Example Group";
				gi.flags = AccessC.FLAG_EDITSTRUCTURE|AccessC.FLAG_EDITDOCS;
				gi.id = ix.Ix.checkinUsers(new UserInfo[] {gi}, 
					                    CheckinUsersC.WRITE,
										LockC.NO)[0];
				Logger.instance().log("create group OK, gi.id=" + gi.id);

				// create user "C# Example User" with password "elo"
				Logger.instance().log("create user...");
				UserInfo ui = ix.Ix.createUser(null);
				ui.type = UserInfoC.TYPE_USER;
				ui.name = "C# Example User";
				ui.pwd = "elo";
				ui.flags = AccessC.FLAG_IMPORT;
				ui.groupList = new int[] {gi.id};
				ui.id = ix.Ix.checkinUsers(new UserInfo[] {ui}, 
					CheckinUsersC.WRITE,
					LockC.NO)[0];
				Logger.instance().log("create user OK, ui.id=" + ui.id);

				// 2. Deletes the user and the group
				Logger.instance().log("delete users...");
				ix.Ix.deleteUsers(new String[] {gi.name, ui.name}, LockC.NO);
				Logger.instance().log("delete users OK");

				// unlock user data 
				Logger.instance().log("unlock user data...");
				ix.Ix.checkinUsers(null, CheckinUsersC.NOTHING, LockC.YES);
				Logger.instance().log("unlock user data OK");

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
