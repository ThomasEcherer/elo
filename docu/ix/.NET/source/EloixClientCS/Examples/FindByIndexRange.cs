using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how to search for objects by a given index value range.
	/// 
	/// 1. Create archive entries:
	///   s1 
	///     d1, name=The Inner Circle,		AUTHOR=T. Coraghessan Boyle,	PRICE=39
	///     d2  name=The Shifting Tide,		AUTHOR=Anne Perry,				PRICE=37
	///     d3  name=Feel,					AUTHOR=Robbie Williams,			PRICE=42
	///     d4	name=The Da Vinci Code,     AUTHOR=Dan Brown,				PRICE=32
	///     
	/// 2. Find books from Authors with names from "A" to "J"
	///     
	/// </summary>
	public class FindByIndexRange
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

				// 1. Create archive structure
				Logger.instance().log("create structure...");

				// create root folder s1
				EditInfo ed = ix.Ix.createSord("1", "0", EditInfoC.mbAll);
				Sord s1 = ed.sord;
				s1.name = "s1 C# example FindByIndexValues";
				s1.id = ix.Ix.checkinSord(s1, SordC.mbAll, LockC.NO);

				///     d1, name=The Inner Circle,		AUTHOR=T. Coraghessan Boyle,	PRICE=039
				///     d2  name=The Shifting Tide,		AUTHOR=Anne Perry,				PRICE=037
				///     d3  name=Feel,					AUTHOR=Robbie Williams,			PRICE=142
				///     d4	name=The Da Vinci Code,     AUTHOR=Dan Brown,				PRICE=032
				///     
				Sord d1 = internalCreateBook(ix, CONST, s1.guid, "The Inner Circle", "T. Coraghessan Boyle", "039");
				Sord d2 = internalCreateBook(ix, CONST, s1.guid, "The Shifting Tide", "Anne Perry", "037");
				Sord d3 = internalCreateBook(ix, CONST, s1.guid, "Feel", "Robbie Williams", "142");
				Sord d4 = internalCreateBook(ix, CONST, s1.guid, "The Da Vinci Code", "Dan Brown", "032");

				Logger.instance().log("create structure OK");

				// 2. Find books from Authors with names from "A" to "J"
				internalFindBooks(ix, CONST, s1.guid, "A* ... J*", "");
					// Finds: The Da Vinci Code,The Shifting Tide

				// 3. Find books from Authors with names from "J"
				internalFindBooks(ix, CONST, s1.guid, "J*...*", "");
					// Finds: Feel,The Inner Circle

				// 4. Find books from Authors with names from "J" and price higher than 100
				internalFindBooks(ix, CONST, s1.guid, "J*...", "100...*");
					// Finds: Feel

				bool cleanUp = true;
				if (cleanUp)
				{
					Logger.instance().log("clean up...");
					ix.Ix.deleteSord(null, s1.guid, LockC.NO, null);
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

		private Sord internalCreateBook(IXConnection ix, 
			IXServicePortC CONST, String parentId, String name, String author, String price) 
		{
			Sord d1 = ix.Ix.createDoc(parentId, "0", null, EditInfoC.mbSord).sord;
			d1.name = name;
			d1.objKeys = new ObjKey[2];
			d1.objKeys[0] = new ObjKey();
			d1.objKeys[0].id = 0;
			d1.objKeys[0].name = "AUTHOR";
			d1.objKeys[0].data = new String[] {author};
			d1.objKeys[1] = new ObjKey();
			d1.objKeys[1].id = 1;
			d1.objKeys[1].name = "PRICE";
			d1.objKeys[1].data = new String[] {price};
			d1.id = ix.Ix.checkinSord(d1, SordC.mbAll, LockC.NO);
			Logger.instance().log("name=" + name + ", author=" + author);
			return d1;
		}

		private FindInfo internalMakeFindInfo(String parentId, 
			String author, String price)
		{
			FindInfo findInfo = new FindInfo();

			// constrain results to children of s1
      findInfo.findChildren = new EloixClient.IndexServer.FindChildren();
			findInfo.findChildren.parentId = parentId;

			findInfo.findByIndex = new FindByIndex();

			ObjKey okeyAuthor = null;
			if (author.Length != 0) 
			{
				okeyAuthor = new ObjKey();
				okeyAuthor.name = "AUTHOR";
				okeyAuthor.data = new String[] {author};
			}

			ObjKey okeyPrice = null;
			if (price.Length != 0)
			{
				okeyPrice = new ObjKey();
				okeyPrice.name = "PRICE";
				okeyPrice.data = new String[] {price};
			}

			int n = ((okeyAuthor != null) ? 1 : 0) + ((okeyPrice != null) ? 1 : 0);
			findInfo.findByIndex.objKeys = new ObjKey[n];
			int i = 0;
			if (okeyAuthor != null) 
			{
				findInfo.findByIndex.objKeys[i++] = okeyAuthor;
			}
			if (okeyPrice != null) 
			{
				findInfo.findByIndex.objKeys[i++] = okeyPrice;
			}

			return findInfo;
		}
		
		private void internalFindBooks(IXConnection ix, 
			IXServicePortC CONST, String parentId, 
			String author, String price)
		{
			Logger.instance().log("find author=" + author + ", price=" + price);

			// select names only
			SordZ mbName = new SordZ();
			mbName.bset = SordC.mbName;

			// find
			FindInfo findInfo = internalMakeFindInfo(parentId, author, price);
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
