using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Lists the names of ELO users.
	/// </summary>
	public class ListUserNames
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

				// List all users and groups
				Logger.instance().log("all users and groups:");
				UserName[] allNames = ix.Ix.getUserNames(null, CheckoutUsersC.ALL_USERS_AND_GROUPS);
				dumpUserNames("  ", CONST, allNames);

				// List all groups
				Logger.instance().log("all groups:");
				UserName[] groupNames = ix.Ix.getUserNames(null, CheckoutUsersC.ALL_GROUPS);
				dumpUserNames("  ", CONST, groupNames);

				// List members of groups
				for (int i = 0; i < groupNames.Length; i++)
				{
					String name = groupNames[i].name;
					Logger.instance().log("users of group " + name + ":");
					UserName[] memberNames = ix.Ix.getUserNames(new String[] {name}, CheckoutUsersC.MEMBERS_OF_GROUP);
					dumpUserNames("    ", CONST, memberNames);
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

		private void dumpUserNames(String indent, IXServicePortC CONST, UserName[] uns) 
		{
			for (int i = 0; i < uns.Length; i++) 
			{
				String type = (uns[i].type == UserInfoC.TYPE_GROUP) ? "group" : "user";
				Logger.instance().log(indent + type + ": name=" + uns[i].name + ", id=" + uns[i].id);
			}
		}
	}
}
