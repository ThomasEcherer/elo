using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// create a simple structure
	/// s1 - C# example DeleteSord
	///  - o1
	///    - r1
	///    - r2
	/// 
	/// 1. delete o1 logically - will recursively mark all children as logically deleted too
	/// 2. delete s1 finally - will recursively delete all children too
	/// </summary>
	public class DeleteSord
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

				// s1
				Sord s1 = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				s1.name = "s1 C# example DeleteSord";
				s1.id = ix.Ix.checkinSord(s1, SordC.mbAll, LockC.NO);
				Logger.instance().log("s1: guid=" + s1.guid + ", id=" + s1.id);

				// o1
				Sord o1 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o1.name = "o1";
				o1.id = ix.Ix.checkinSord(o1, SordC.mbAll, LockC.NO);
				Logger.instance().log("o1: guid=" + o1.guid + ", id=" + o1.id);

				// r1
				Sord r1 = ix.Ix.createSord(o1.guid, null, EditInfoC.mbSord).sord;
				r1.name = "r1";
				r1.id = ix.Ix.checkinSord(r1, SordC.mbAll, LockC.NO);
				Logger.instance().log("r1: guid=" + r1.guid + ", id=" + r1.id);

				// r2
				Sord r2 = ix.Ix.createSord(o1.guid, null, EditInfoC.mbSord).sord;
				r2.name = "r2";
				r2.id = ix.Ix.checkinSord(r2, SordC.mbAll, LockC.NO);
				Logger.instance().log("r2: guid=" + r2.guid + ", id=" + r2.id);

				// DELETE o1 logically
				ix.Ix.deleteSord(null, o1.guid, LockC.NO, null);				
				
				// VERIFY o1, r1, r2 deleted logically, s1 still visible
				s1 = ix.Ix.checkoutSord(s1.guid, EditInfoC.mbSord, LockC.NO).sord;
				o1 = ix.Ix.checkoutSord(o1.guid, EditInfoC.mbSord, LockC.NO).sord;
				r1 = ix.Ix.checkoutSord(r1.guid, EditInfoC.mbSord, LockC.NO).sord;
				r2 = ix.Ix.checkoutSord(r2.guid, EditInfoC.mbSord, LockC.NO).sord;

				// objects are logically deleted if Sord.status != 0
				Logger.instance().log("s1 deleted=" + s1.deleted);
				Logger.instance().log("o1 deleted=" + o1.deleted);
				Logger.instance().log("r1 deleted=" + r1.deleted);
				Logger.instance().log("r2 deleted=" + r2.deleted);
				
				// DELETE s1 finally
            ix.Ix.deleteSord(null, s1.guid, LockC.NO, null);
            DeleteOptions delOpts = new DeleteOptions();
            delOpts.deleteFinally = true;
            ix.Ix.deleteSord(null, s1.guid, LockC.NO, delOpts);
				
				// VERIFY, if s1, o1, r1, r2 does not exist, checkoutSord will throw an exception

				try
				{
					s1 = ix.Ix.checkoutSord(s1.guid, EditInfoC.mbSord, LockC.NO).sord;
					Logger.instance().log("s1 not deleted !!!");
				} 
				catch (Exception e)
				{
					Logger.instance().log("s1 deleted, exception=" + formatException(e));
				}

				try
				{
					o1 = ix.Ix.checkoutSord(o1.guid, EditInfoC.mbSord, LockC.NO).sord;
					Logger.instance().log("o1 not deleted !!!");
				} 
				catch (Exception e)
				{
					Logger.instance().log("o1 deleted, exception=" + formatException(e));
				}

				try
				{
					r1 = ix.Ix.checkoutSord(r1.guid, EditInfoC.mbSord, LockC.NO).sord;
					Logger.instance().log("r1 not deleted !!!");
				} 
				catch (Exception e)
				{
					Logger.instance().log("r1 deleted, exception=" + formatException(e));
				}
				
				try
				{
					r2 = ix.Ix.checkoutSord(r2.guid, EditInfoC.mbSord, LockC.NO).sord;
					Logger.instance().log("r2 not deleted !!!");
				} 
				catch (Exception e)
				{
					Logger.instance().log("r2 deleted, exception=" + formatException(e));
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
