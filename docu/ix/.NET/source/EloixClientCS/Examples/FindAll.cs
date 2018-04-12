using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how to search over all index attributes.
	/// 
	/// 1. Create test sords with search term in name, desc and index data
	/// 2. Execute find
	/// 
	/// </summary>
	public class FindAll
	{
		public String searchAllFor = "hallodallo";

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
				
				// 1. Create test sords with search term in name, desc and index data

				// sord1 has search term in name attribute
				Sord sord1 = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sord1.name = "C# example FindAll sord1 " + searchAllFor;
				sord1.id = ix.Ix.checkinSord(sord1, SordC.mbAll, LockC.NO);
				Logger.instance().log("sord1.id=" + sord1.id);

				// sord2 has search term in desc attribute
				Sord sord2 = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sord2.name = "C# example FindAll sord2";
				sord2.desc = searchAllFor;
				sord2.id = ix.Ix.checkinSord(sord2, SordC.mbAll, LockC.NO);
				Logger.instance().log("sord2.id=" + sord2.id);

				// sord3 has search term in index attribute
				Sord sord3 = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sord3.name = "C# example FindAll sord3";
				ObjKey okey = new ObjKey();
				okey.id = 0;
				okey.name = "IX-EXAMPLE";
				okey.data = new String[] {"find " + searchAllFor + " in index line"};
        sord3.objKeys = new ObjKey[] { okey };
				sord3.id = ix.Ix.checkinSord(sord3, SordC.mbAll, LockC.NO);
				Logger.instance().log("sord3.id=" + sord3.id);

				// 2. Execute find
				
				// Prepare FindInfo object
				Logger.instance().log("find ...");
				FindInfo findInfo = new FindInfo();
				findInfo.findByIndex = new FindByIndex();
				findInfo.findByIndex.name = "#" + searchAllFor;

				// find
				FindResult findResult = ix.Ix.findFirstSords(findInfo, 1000, SordC.mbAll);
				if (findResult.sords != null)
				{
					Logger.instance().log("found #=" + findResult.sords.Length);
					for (int i = 0; i < findResult.sords.Length; i++)
					{
						Logger.instance().log("sord.id=" + findResult.sords[i].id + ", sord.name=" + findResult.sords[i].name);
					}
				}
				ix.Ix.findClose(findResult.searchId);
				Logger.instance().log("find OK");

				bool cleanUp = true;
				if (cleanUp)
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, sord1.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, sord2.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, sord3.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, sord1.guid, LockC.NO, delOpts);
          ix.Ix.deleteSord(null, sord2.guid, LockC.NO, delOpts);
          ix.Ix.deleteSord(null, sord3.guid, LockC.NO, delOpts);
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
