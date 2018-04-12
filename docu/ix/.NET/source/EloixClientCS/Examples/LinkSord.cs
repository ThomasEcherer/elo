using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für LinkSord.
	/// </summary>
	public class LinkSord
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
				s1.name = "s1 C# Example LinkSord";
				s1.id = ix.Ix.checkinSord(s1, SordC.mbAll, LockC.NO);
				Logger.instance().log("s1.id=" + s1.id);

				// create Sord o1
				Sord o1 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o1.name = "o1";
				o1.id = ix.Ix.checkinSord(o1, SordC.mbAll, LockC.NO);
				Logger.instance().log("o1.id=" + o1.id);

				// create Sord o2
				Sord o2 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o2.name = "o2";
				o2.id = ix.Ix.checkinSord(o2, SordC.mbAll, LockC.NO);
				Logger.instance().log("o2.id=" + o2.id);

				// create Sord o3
				Sord o3 = ix.Ix.createSord(s1.guid, null, EditInfoC.mbSord).sord;
				o3.name = "o3";
				o3.id = ix.Ix.checkinSord(o3, SordC.mbAll, LockC.NO);
				Logger.instance().log("o3.id=" + o3.id);

				// Link o1 to o2 and o3 
				Logger.instance().log("link Sords...");
				ix.Ix.linkSords(o1.guid, new String[] {o2.guid, o3.guid}, CONST.LINK_SORD.NOTHING);
				Logger.instance().log("link Sords OK");

				// Dump links
				internalDumpLinks(ix, CONST, o1.guid);
				internalDumpLinks(ix, CONST, o2.guid);
				internalDumpLinks(ix, CONST, o3.guid);

				// Delete link o1 -> o2
				Logger.instance().log("unlink Sords...");
				ix.Ix.unlinkSords(o1.guid, new String[] {o2.guid}, CONST.LINK_SORD.NOTHING);
				Logger.instance().log("unlink Sords OK");

				// Dump links
				internalDumpLinks(ix, CONST, o1.guid);
				internalDumpLinks(ix, CONST, o2.guid);
				internalDumpLinks(ix, CONST, o3.guid);

				// Delete Sords
				Logger.instance().log("delete Sords...");
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, s1.guid, LockC.NO, null);
        ix.Ix.deleteSord(null, s1.guid, LockC.NO, delOpts);
				Logger.instance().log("delete Sords OK");

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

		private void internalDumpLinks(IXConnection ix, IXServicePortC CONST, 
			String guid) 
		{
			// Checkout sord to get the new links
			Sord sord = ix.Ix.checkoutSord(guid, EditInfoC.mbSord, LockC.NO).sord;

			Logger.instance().log("links of " + sord.name + " {");
			for (int i = 0; i < sord.linksGoOut.Length; i++) 
			{
				Sord linkToSord = ix.Ix.checkoutSord(sord.linksGoOut[i].id, 
					EditInfoC.mbSordLean, LockC.NO).sord;

				Logger.instance().log("    ->" + linkToSord.name); // + ", guid=" + sord.linksGoOut[i].id + ", linkId=" + sord.linksGoOut[i].linkId);
			}
			for (int i = 0; i < sord.linksComeIn.Length; i++) 
			{
				Sord linkFromSord = ix.Ix.checkoutSord(sord.linksComeIn[i].id, 
					EditInfoC.mbSordLean, LockC.NO).sord;

				Logger.instance().log("    <-" + linkFromSord.name); // + ", guid=" + sord.linksComeIn[i].id + ", linkId=" + sord.linksComeIn[i].linkId);
			}
			Logger.instance().log("}");
		}
	}
}
