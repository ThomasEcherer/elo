using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows the usage of FindFirstSord/FindNextSord
	/// 
	/// 1. Create a root folder
	/// 2. Create 30 sords under the root folder with a name that contains the search term
	/// 3. Execute find
	/// 
	/// </summary>
	public class FindFirstFindNext
	{
		public String searchTerm = "Order";
		public int nbOfSords = 30;

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
				
				// 1. Create a root folder
				Sord sordRoot = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sordRoot.name = "C# example FindFirstFindNext";
				sordRoot.id = ix.Ix.checkinSord(sordRoot, SordC.mbAll, LockC.NO);
                
				// 2. Create 30 sords under the root folder with a name that contains the search term
				Logger.instance().log("create " + nbOfSords + " sords...");
				for (int i = 0; i < nbOfSords; i++) 
				{
					String namePrefix = "" + i;
					while (namePrefix.Length < 4) namePrefix = "0" + namePrefix;
					Sord sord = ix.Ix.createSord(sordRoot.guid, null, EditInfoC.mbSord).sord;
					sord.name = namePrefix + "-" + searchTerm + "-" + namePrefix;
					sord.id = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				}
				Logger.instance().log("create sords OK");

				// 3. Execute find
				Logger.instance().log("find...");

				// Prepare FindInfo object
				FindInfo findInfo = new FindInfo();
				findInfo.findByIndex = new FindByIndex();
				findInfo.findByIndex.name = "*" + searchTerm + "*";

				// find
				int maxSordsPerLoop = 9;
				int idx = 0;

        SordZ sordZ = new SordZ();

				FindResult findResult = ix.Ix.findFirstSords(findInfo, maxSordsPerLoop, SordC.mbAll);

				do 
				{
					// log find results
					Logger.instance().log("found #=" + findResult.sords.Length);
					for (int i = 0; i < findResult.sords.Length; i++)
					{
						Logger.instance().log("sord.id=" + findResult.sords[i].id + ", sord.name=" + findResult.sords[i].name);
					}

					// more results?
					if (!findResult.moreResults) 
						break;

					// next results
					idx += findResult.sords.Length;
					findResult = ix.Ix.findNextSords(findResult.searchId, idx, maxSordsPerLoop, SordC.mbAll);

				} while (true);

				// release find result buffer in IndexServer
				ix.Ix.findClose(findResult.searchId);
				Logger.instance().log("find OK");

				// clean up
				bool cleanUp = true;
				if (cleanUp)
				{
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, sordRoot.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, sordRoot.guid, LockC.NO, delOpts);
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
