using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how to search for objects by given index values.
	/// 
	/// 1. Create archive structure:
	///   s1
	///     name=ka-mo, mask=Email, from=karl@x.com, to=mona@x.com
	///     name=ka-fi, mask=Email, from=karl@x.com, to=finn@x.com
	///     name=mo-ka, mask=Email, from=mona@x.com, to=karl@x.com
	///     name=mo-fi, mask=Email, from=mona@x.com, to=finn@x.com
	///     name=fi-mo, mask=Email, from=finn@x.com, to=mona@x.com
	///     name=fi-ka, mask=Email, from=finn@x.com, to=karl@x.com
	///     name=ka-mofi, mask=Email, from=karl@x.com, to=mona@x.com,finn@x.com
	///     
	/// 2. Find emails sent from karl to mona: ka-mo, ka-mofi
	/// 3. Find emails sent from karl to anyone: ka-mo, ka-fi, ka-mofi
	/// 4. Find emails sent from or to karl: ka-mo, ka-fi, mo-ka, fi-ka, ka-mofi
	/// 5. Find emails sent from karl or from mona: ka-mo, ka-fi, mo-ka, mo-fi, ka-mofi
	/// 6. Find emails sent to mona and finn: ka-mofi
	/// 7. Find emails sent to mona or finn: ka-mo, ka-fi, mo-fi, fi-mo, ka-mofi
	/// 
	/// </summary>
	public class FindByIndexValues
	{
		// email addresses
		public String karl = "karl@x.com";
		public String mona = "mona@x.com";
		public String finn = "finn@x.com";

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

				// 1. Create archive structure
				Logger.instance().log("create structure...");

				// create root folder s1
				EditInfo ed = ix.Ix.createSord("1", "0", EditInfoC.mbAll);
				Sord s1 = ed.sord;
				s1.name = "s1 C# example FindByIndexValues";
				s1.id = ix.Ix.checkinSord(s1, SordC.mbAll, LockC.NO);

				//     name=ka-mo, mask=Email, from=karl@x.com, to=mona@x.com
				//     name=ka-fi, mask=Email, from=karl@x.com, to=finn@x.com
				//     name=mo-ka, mask=Email, from=mona@x.com, to=karl@x.com
				//     name=mo-fi, mask=Email, from=mona@x.com, to=finn@x.com
				//     name=fi-mo, mask=Email, from=finn@x.com, to=mona@x.com
				//     name=fi-ka, mask=Email, from=finn@x.com, to=karl@x.com
				//     name=ka-mofi, mask=Email, from=karl@x.com, to=mona@x.com,finn@x.com
				Sord d1 = internalCreateEmail(ix, CONST, s1.guid, "ka-mo", karl, mona);
				Sord d2 = internalCreateEmail(ix, CONST, s1.guid, "ka-fi", karl, finn);
				Sord d3 = internalCreateEmail(ix, CONST, s1.guid, "mo-ka", mona, karl);
				Sord d4 = internalCreateEmail(ix, CONST, s1.guid, "mo-fi", mona, finn);
				Sord d5 = internalCreateEmail(ix, CONST, s1.guid, "fi-mo", finn, mona);
				Sord d6 = internalCreateEmail(ix, CONST, s1.guid, "fi-ka", finn, karl);
				Sord d7 = internalCreateEmail(ix, CONST, s1.guid, "ka-mofi", karl, mona + "," + finn);

				Logger.instance().log("create structure OK");

				// 2. Find emails sent from karl to mona: ka-mo, ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "*karl*", "*mona*");

				// 3. Find emails sent from karl to anyone: ka-mo, ka-fi, ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "*karl*", "*");

				// 4. Find emails sent from or to karl: ka-mo, ka-fi, mo-ka, fi-ka, ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "*karl*", "*karl*");

				// 5. Find emails sent from karl or from mona: ka-mo, ka-fi, mo-ka, mo-fi, ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "\"*karl*\" + \"*mona*\"", "*");

				// 6. Find emails sent to mona and finn: ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "*", "\"*mona*\" & \"*finn*\"");

				// 7. Find emails sent to mona or finn: ka-mo, ka-fi, mo-fi, fi-mo, ka-mofi
				internalFindEmailsFromTo(ix, CONST, s1.guid, "*", "\"*mona*\" + \"*finn*\"");

				bool cleanUp = true;
				if (cleanUp)
				{
					Logger.instance().log("clean up...");
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, s1.guid, LockC.NO, delOpts);
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

		private Sord internalCreateEmail(IXConnection ix,  
			IXServicePortC CONST, String parentId, String name, String from, String to) 
		{
			Sord d1 = ix.Ix.createDoc(parentId, "Email", null, EditInfoC.mbSord).sord;
			d1.name = name;
			d1.objKeys[0].data = new String[] {from};
			d1.objKeys[1].data = new String[] {to};
			d1.id = ix.Ix.checkinSord(d1, SordC.mbAll, LockC.NO);
			Logger.instance().log("name=" + name + ", from=" + from + ", to=" + to);
			return d1;
		}

		private FindInfo internalMakeFindInfo(String parentId, 
			String from, String to)
		{
			FindInfo findInfo = new FindInfo();

			// constrain results to children of s1
      findInfo.findChildren = new EloixClient.IndexServer.FindChildren();
			findInfo.findChildren.parentId = parentId;

			findInfo.findByIndex = new FindByIndex();
			findInfo.findByIndex.objKeys = new ObjKey[2];
	
			findInfo.findByIndex.objKeys[0] = new ObjKey();
			findInfo.findByIndex.objKeys[0].name = "ELOOUTL1";
			findInfo.findByIndex.objKeys[0].data = new String[] {from};

			findInfo.findByIndex.objKeys[1] = new ObjKey();
			findInfo.findByIndex.objKeys[1].name = "ELOOUTL2";
			findInfo.findByIndex.objKeys[1].data = new String[] {to};

			return findInfo;
		}
		
		private void internalFindEmailsFromTo(IXConnection ix, 
			IXServicePortC CONST, String parentId, String from, String to)
		{
			Logger.instance().log("find from=" + from + ", to=" + to + "...");

			// select names only
			SordZ mbName = new SordZ();
			mbName.bset = SordC.mbName;

			// find
			FindInfo findInfo = internalMakeFindInfo(parentId, from, to);
			Sord[] sords = ix.Ix.findFirstSords(findInfo, 1000, mbName).sords;
			String nameList = "";
			for (int i = 0; i < sords.Length; i++) 
			{
				if (i != 0) nameList += ",";
				nameList += sords[i].name;
			}
			Logger.instance().log("find OK, sords=" + nameList);
		}
	}
}
