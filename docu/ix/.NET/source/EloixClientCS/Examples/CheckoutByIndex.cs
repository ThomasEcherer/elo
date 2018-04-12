using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// 
	/// 1. Create a Sord with index attribute (ObjKey object)
	/// 2. Checkout Sord by index attribute
	///
	/// </summary>
	public class CheckoutByIndex
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

				// 1. Create a Sord with index attribute
				Sord sord = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				sord.name = "C# example CheckoutByIndex";
				sord.objKeys = new ObjKey[1];
				sord.objKeys[0] = new ObjKey();
				sord.objKeys[0].name = "VENDOR";
				sord.objKeys[0].data = new String[] {"ELO Digital Office GmbH"};
				sord.id = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				Logger.instance().log("created sord: id=" + sord.id);

				// 2. Checkout Sord by index attribute
				sord = ix.Ix.checkoutSord("OKEY:VENDOR=ELO digital OFFICE gmbh", 
					EditInfoC.mbSord, LockC.NO).sord;
				Logger.instance().log("checkout sord, id=" + sord.id);

				bool cleanUp = true;
				if (cleanUp) 
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, sord.guid, LockC.NO, null);
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
	}

}
