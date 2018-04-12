using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Create this archive structure:
	/// - s1 C# example MoveSord
	///   - o1
	///     - r1
	///   - o2
	/// 
	/// Link R1 into O2
	/// </summary>
	public class CopySord
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

				// create Sord s1
				Sord s1 = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				s1.name = "s1 C# example MoveSord";
				s1.id = ix.Ix.checkinSord(s1, SordC.mbAll, LockC.NO);
				Logger.instance().log("s1.id=" + s1.id);

				// create Sord o1
				Sord o1 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o1.name = "o1";
				o1.id = ix.Ix.checkinSord(o1, SordC.mbAll, LockC.NO);
				Logger.instance().log("o1.id=" + o1.id);

				// create Sord r1
				Sord r1 = ix.Ix.createSord(o1.guid, null, EditInfoC.mbSord).sord;
				r1.name = "r1";
				r1.id = ix.Ix.checkinSord(r1, SordC.mbAll, LockC.NO);
				Logger.instance().log("r1.id=" + r1.id);

				// create Sord o2
				Sord o2 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o2.name = "o2";
				o2.id = ix.Ix.checkinSord(o2, SordC.mbAll, LockC.NO);
				Logger.instance().log("o2.id=" + o2.id);

				// VERIFY o1 contains r1
				String childIdsO1 = internalFindSordIdsInParent(ix, o1.guid);
				String childIdsO2 = internalFindSordIdsInParent(ix, o2.guid);
				Logger.instance().log("before move: o1:(" + childIdsO1 + "), o2:(" + childIdsO2 + ")");

				// LINK r1 -> o2
				ix.Ix.copySord(o2.guid, r1.guid, null, CopySordC.REFERENCE);

				// VERIFY o2 contains r1
				childIdsO1 = internalFindSordIdsInParent(ix, o1.guid);
				childIdsO2 = internalFindSordIdsInParent(ix, o2.guid);
				Logger.instance().log("after move: o1:(" + childIdsO1 + "), o2:(" + childIdsO2 + ")");

				// VERIFY o2 contains r1 as reference (logical copy).
				// In other words: r1.parentId != o2
				Sord r1AfterLink = ix.Ix.checkoutSord(r1.guid, EditInfoC.mbSord, LockC.NO).sord;
				Logger.instance().log("parent of r1 is still o1, r1.parentId=" + r1AfterLink.parentId + ", o1.id=" + o1.id);

				// Clean up?
				bool cleanUp = true;
				if (cleanUp) 
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, s1.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, s1.guid, LockC.NO, delOpts);
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

		// Helper function to find the subentries of an object
		private String internalFindSordIdsInParent(IXConnection ix, 
			String parentId)
		{
			IXServicePortC CONST = ix.CONST;
			
			FindInfo findInfo = new FindInfo();
      findInfo.findChildren = new EloixClient.IndexServer.FindChildren();
			findInfo.findChildren.parentId = parentId;
			
			FindResult findResult = ix.Ix.findFirstSords(findInfo, 100, SordC.mbOnlyId);
			if (findResult.ids == null) return "";

			if (findResult.searchId != null) 
			{
				ix.Ix.findClose(findResult.searchId);
			}

			String strList = "";
			for (int i = 0; i < findResult.ids.Length; i++) 
			{
				if (i != 0) strList += ",";
				strList += findResult.ids[i];
			}
            				
			return strList;
		}
	}
}

