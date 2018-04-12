using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für ViewUserRights.
	/// </summary>
	public class ViewUserRights
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

				String name = userName;
				UserInfo ui = ix.Ix.checkoutUsers(new String[] {name},
					CheckoutUsersC.BY_IDS, LockC.NO)[0];

				Logger.instance().log("Main admin                 " + ((ui.flags & AccessC.FLAG_ADMIN) != 0));
				Logger.instance().log("Edit configuration         " + ((ui.flags & AccessC.FLAG_EDITCONFIG) != 0));
				Logger.instance().log("Edit archive structure     " + ((ui.flags & AccessC.FLAG_EDITSTRUCTURE) != 0));
				Logger.instance().log("Edit documents             " + ((ui.flags & AccessC.FLAG_EDITDOCS) != 0));
				Logger.instance().log("Change password            " + ((ui.flags & AccessC.FLAG_CHANGEPW) != 0));
				Logger.instance().log("Change revision            " + ((ui.flags & AccessC.FLAG_CHANGEREV) != 0));
				Logger.instance().log("Edit user rights           " + ((ui.flags & AccessC.FLAG_SUBADMIN) != 0));
				Logger.instance().log("Edit workflows             " + ((ui.flags & AccessC.FLAG_EDITWF) != 0));
				Logger.instance().log("Start workflows            " + ((ui.flags & AccessC.FLAG_STARTWF) != 0));
				Logger.instance().log("Delete documents           " + ((ui.flags & AccessC.FLAG_DELDOC) != 0));
				Logger.instance().log("Delete structure           " + ((ui.flags & AccessC.FLAG_DELSTRUC) != 0));
				Logger.instance().log("SAP admin                  " + ((ui.flags & AccessC.FLAG_SAPADMIN) != 0));
				Logger.instance().log("Import                     " + ((ui.flags & AccessC.FLAG_IMPORT) != 0));
				Logger.instance().log("Export                     " + ((ui.flags & AccessC.FLAG_EXPORT) != 0));
				Logger.instance().log("Edit storage masks         " + ((ui.flags & AccessC.FLAG_EDITMASK) != 0));
				Logger.instance().log("Edit scripts               " + ((ui.flags & AccessC.FLAG_EDITSCRIPT) != 0));
				Logger.instance().log("Edit expiration date       " + ((ui.flags & AccessC.FLAG_EDITDUEDATE) != 0));
				Logger.instance().log("Edit buzzword lists        " + ((ui.flags & AccessC.FLAG_EDITSWL) != 0));
				Logger.instance().log("Delete read-only Documents " + ((ui.flags & AccessC.FLAG_DELREADONLY) != 0));
				Logger.instance().log("Edit replication sets      " + ((ui.flags & AccessC.FLAG_EDITREPL) != 0));
				Logger.instance().log("Edit ACL                   " + ((ui.flags & AccessC.FLAG_EDITACL) != 0));
				Logger.instance().log("Ignore ACL                 " + ((ui.flags & AccessC.FLAG_IGNOREACL) != 0));
				Logger.instance().log("Edit scanner configuration " + ((ui.flags & AccessC.FLAG_EDITSCAN) != 0));
				Logger.instance().log("Change storage mask        " + ((ui.flags & AccessC.FLAG_CHANGEMASK) != 0));
				Logger.instance().log("Edit activity projects     " + ((ui.flags & AccessC.FLAG_EDITACT) != 0));
				Logger.instance().log("Edit storage path          " + ((ui.flags & AccessC.FLAG_CHANGEPATH) != 0));
				Logger.instance().log("Inhibit login              " + ((ui.flags & AccessC.FLAG_NOLOGIN) != 0));
				Logger.instance().log("Delete document version    " + ((ui.flags & AccessC.FLAG_DELVERSION) != 0));

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
