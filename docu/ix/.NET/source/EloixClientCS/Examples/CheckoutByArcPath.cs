using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// 
	/// 1. Create structure:
	/// - e1
	///   - e2
	///     - e3
	///       - e4
	/// 
	/// 2. Checkout Sord by archive path: /e1/e2/e3/e4
	///
	/// </summary>
	public class CheckoutByArcPath
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
				// 1. Create structure
				Sord e1 = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				e1.name = "e1";
				e1.id = ix.Ix.checkinSord(e1, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e1: id=" + e1.id);

				Sord e2 = ix.Ix.createSord(e1.guid, "0", EditInfoC.mbSord).sord;
				e2.name = "e2";
				e2.id = ix.Ix.checkinSord(e2, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e2: id=" + e2.id);

				Sord e3 = ix.Ix.createSord(e2.guid, "0", EditInfoC.mbSord).sord;
				e3.name = "e3";
				e3.id = ix.Ix.checkinSord(e3, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e3: id=" + e3.id);

				Sord e4 = ix.Ix.createSord(e3.guid, "0", EditInfoC.mbSord).sord;
				e4.name = "e4";
				e4.id = ix.Ix.checkinSord(e4, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e4: id=" + e4.id);

				// 2. Checkout Sord by archive path: /e1/e2/e3/e4
				Sord sord = ix.Ix.checkoutSord("ARCPATH:¶e1¶e2¶e3¶e4", 
					EditInfoC.mbSord, LockC.NO).sord;
				Logger.instance().log("¶e1¶e2¶e3¶e4, id=" + sord.id + " == e4.id=" + e4.id);

				// Hint: The first character in the archive path defines the delimiter
				//       character used to seperate the archive levels.
				//       Thus you can use any character as delimiter. But consider 
				//		 that this character should not be used in Sord names.

				sord = ix.Ix.checkoutSord("ARCPATH:\\e1\\e2\\e3\\e4", 
					EditInfoC.mbSord, LockC.NO).sord;
				Logger.instance().log("\\e1\\e2\\e3\\e4, id=" + sord.id + " == e4.id=" + e4.id);

				bool cleanUp = true;
				if (cleanUp) 
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
					ix.Ix.deleteSord(null, e1.guid, LockC.NO, delOpts);
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
	}
}
