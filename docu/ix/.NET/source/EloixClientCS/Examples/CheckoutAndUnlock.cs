using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	///
	/// 1. Create a Sord object under the current account
	/// 2. Create a new user "Fritz"
	/// 3. Login as "Fritz" 
	/// 4. Fritz locks Sord
	/// 5. Try to lock with current account
	/// 6. Try to get lock forced with current account
	/// 7. Unlock
	/// 8. Fritz deletes Sord
	///
	/// </summary>
	public class CheckoutAndUnlock
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

				// 1. Create Sord 
				Sord sord = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sord.name = "C# example CheckoutAndUnlock";
				sord.id = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				Logger.instance().log("sord.id=" + sord.id);

				// 2. Create a new test user
				UserInfo uiFritz = ix.Ix.createUser("0");
				uiFritz.name = "Fritz"; // [X]
				uiFritz.pwd = "Fritz password"; 
				int[] uids = ix.Ix.checkinUsers(new UserInfo[] {uiFritz}, CheckinUsersC.PASSWORD, LockC.NO);
				Logger.instance().log("created account for " + uiFritz.name + ", uid=" + uids[0]);

				// 3. Login
        IXConnection ixFritz = connFact.Create(uiFritz.name, uiFritz.pwd, "mycomp", null);
				Logger.instance().log(uiFritz.name + " logged in successfully");
                				
				// 4. Firtz locks Sord
        sord = ixFritz.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.YES).sord;
				Logger.instance().log("Fritz checked out with lock, lockId=" + sord.lockId + " == Fritz's user ID");
				
				// 5. Try to lock with current account
				try 
				{
					sord = ix.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.YES).sord;
					throw new System.InvalidOperationException("ERROR: current user can lock Sord");
				} 
				catch (Exception e) 
				{
					Logger.instance().log("OK, current user cannot lock Sord: " + formatException(e));
				}

				// 6. Try to get lock forced with current account
				try 
				{
					sord = ix.Ix.checkoutSord(sord.guid, EditInfoC.mbSord, LockC.FORCE).sord;
					Logger.instance().log("OK, current user is administrator and can lock Sord");
				} 
				catch (Exception e) 
				{
					Logger.instance().log("OK, current user is not an administrator and cannot lock Sord: " + formatException(e));
				}

				// 7. Unlock
				ix.Ix.checkinSord(sord, SordC.mbOnlyUnlock, LockC.YES);
				Logger.instance().log("Sord unlocked");

				// 8. Fritz deletes Sord
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ixFritz.Ix.deleteSord(null, sord.guid, LockC.NO, null);
        ixFritz.Ix.deleteSord(null, sord.guid, LockC.NO, delOpts);
				Logger.instance().log("Sord deleted");

				// clean up
        ixFritz.Logout();
				ix.Ix.deleteUsers(new String[] {uiFritz.name}, LockC.NO);
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
