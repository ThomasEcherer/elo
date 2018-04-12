using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// 
	/// 1. Create Sord 
	/// 2. Create a test user "Fritz"
	/// 3. Assign read access to Sord for user "Fritz"
	/// 4. Login as "Fritz" and try to read Sord
	/// 5. Try to lock, write and delete as "Fritz" (exception expected)
	///
	/// </summary>
	public class SordACL
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

				String fritzName = "Fritz"; // [X]

				// 1. Create Sord
				Sord sord = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				sord.name = "C# example SordACL";

				// 2. Create a new test user (if nessesary)
				UserInfo uiFritz = ix.Ix.createUser(null);
				uiFritz.name = fritzName; 
				uiFritz.pwd = fritzName + " password";
				uiFritz.flags = AccessC.FLAG_EDITSTRUCTURE; // Fritz is allowed to edit structure elements in general
				int[] uids = ix.Ix.checkinUsers(new UserInfo[] {uiFritz}, CheckinUsersC.PASSWORD, LockC.NO);
				uiFritz.id = uids[0];
        Logger.instance().log("created account for " + uiFritz.name + ", uid=" + uids[0]);

				// 3. Assign read access to Sord for user "Fritz"
				AclItem aclItemFritz = new AclItem();
				aclItemFritz.name = uiFritz.name; 
				// alternative: aclItem.id = uiFritz.id
				aclItemFritz.access = AccessC.LUR_READ;

				// assign all access for current user
				AclItem aclItemCu = new AclItem();
				aclItemCu.name = userName; 
				aclItemCu.access = AccessC.LUR_ALL;

				// checkin
				sord.aclItems = new AclItem[] {aclItemFritz, aclItemCu};
				sord.id = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				Logger.instance().log("created sord with read access for Fritz: id=" + sord.id);

				// 4. Login as "Fritz" and try to read Sord
        IXConnection ixFritz = connFact.Create(uiFritz.name, uiFritz.pwd, "myComputer", null);
				Logger.instance().log(uiFritz.name + " logged in successfully");

				// read Sord
        Sord sordForFritz = ixFritz.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.NO).sord;
				Logger.instance().log(uiFritz.name + " read sord successfully");

				// 5. Try to lock, write and delete as "Fritz" (exception expected)
				try
				{
					// lock
          sord = ixFritz.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.YES).sord;
					Logger.instance().log("ERROR: " + uiFritz.name + " must not be able to checkout sord");
				}
				catch (Exception e)
				{
					Logger.instance().log("OK, " + uiFritz.name + " is not allowed to lock sord, exception=" + formatException(e));
				}
				try
				{
					// write
          sord = ixFritz.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.NO).sord;
					sord.desc = "changed by Fritz";
          ixFritz.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
					Logger.instance().log("ERROR: " + uiFritz.name + " must not be able to write sord");
				}
				catch (Exception e)
				{
					Logger.instance().log("OK, " + uiFritz.name + " is not allowed to write sord, exception=" + formatException(e));
				}
				try
				{
					// delete
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ixFritz.Ix.deleteSord(null, sord.guid, LockC.NO, delOpts);
					Logger.instance().log("ERROR: " + uiFritz.name + " must not be able to delete sord");
				}
				catch (Exception e)
				{
					Logger.instance().log("OK, " + uiFritz.name + " is not allowed to delete sord, exception=" + formatException(e));
				}

				// logout Fritz
        ixFritz.Logout();
				ix.Ix.deleteUsers(new String[] {uiFritz.name}, LockC.NO);

				bool cleanUp = true;
				if (cleanUp) 
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, sord.guid, LockC.NO, delOpts);
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

		private String formatException(Exception e) 
		{
			String raw = e.ToString();
			int p = raw.IndexOf("[ELOIX");
			if (p < 0) return raw;
			int start = raw.IndexOf("]", p);
			if (start < 0) return raw;
			start++;
			int end = raw.IndexOf(")\r\n", start);
			if (end < 0) end = raw.Length;
			String msg = raw.Substring(start, end - start);
			return msg;
		}
	}
}
