using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This sample shows how to browse throu the archive hirarchie
	/// 1. Create root folder with 30 children
	/// 2. List children of root folder
	/// </summary>
	public class FindChildren
	{
		public int nbOfChildren = 30;

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
				
				// 1. Create archive hirarchie

				// root folder
				Sord sordRoot = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
				sordRoot.name = "C# example FindFirstFindNext";
				sordRoot.id = ix.Ix.checkinSord(sordRoot, SordC.mbAll, LockC.NO);
                
				// create sords
				Logger.instance().log("create sords...");
				for (int i = 0; i < nbOfChildren; i++) 
				{
					String namePrefix = "" + i;
					while (namePrefix.Length < 4) namePrefix = "0" + namePrefix;
					Sord sord = ix.Ix.createSord(sordRoot.guid, null, EditInfoC.mbSord).sord;
					sord.name = namePrefix + "-o-" + namePrefix;
					sord.id = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				}
				Logger.instance().log("create sords OK");

				// 2. List hirarchie
				Logger.instance().log("find...");

				// Prepare FindInfo object
				FindInfo findInfo = new FindInfo();
        findInfo.findChildren = new EloixClient.IndexServer.FindChildren();
				findInfo.findChildren.parentId = sordRoot.guid;

				// find
				FindResult findResult = ix.Ix.findFirstSords(findInfo, 1000, SordC.mbAll);
				Logger.instance().log("found #=" + findResult.sords.Length);
				for (int i = 0; i < findResult.sords.Length; i++) 
				{
					Logger.instance().log("sord.id=" + findResult.sords[i].id + ", sord.name=" + findResult.sords[i].name);
				}
				ix.Ix.findClose(findResult.searchId);
				Logger.instance().log("find OK");

				bool cleanUp = true;
				if (cleanUp)
				{
					Logger.instance().log("clean up...");
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, sordRoot.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, sordRoot.guid, LockC.NO, delOpts);
					Logger.instance().log("clean up OK");
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