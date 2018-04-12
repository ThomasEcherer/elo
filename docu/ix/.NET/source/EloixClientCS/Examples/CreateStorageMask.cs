using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// This example shows how to create, checkin, checkout and delete
	/// a storage mask.
	/// </summary>
	public class CreateStorageMask
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

				// create storage mask
				Logger.instance().log("create mask...");
				DocMask docMask = ix.Ix.createDocMask(null);
				Logger.instance().log("create mask OK");

				// set some mask values
				docMask.name = "C# Example Mask";								// mask name
				docMask.details.documentMask = true;							// can be used as template for documents and structure elements
				docMask.details.searchMask = true;								// can be used to search for archive items
				docMask.details.archivingMode = ArchivingModeC.VERSION;   // documents of this mask are stored with version controll
				
				// assign index lines
				docMask.lines = new DocMaskLine[3];
				docMask.lines[0] = new DocMaskLine();
				docMask.lines[0].id = 0;
				docMask.lines[0].name = "Author";
				docMask.lines[0].key = "AUTHOR";
				docMask.lines[0].type = DocMaskLineC.TYPE_TEXT;
				docMask.lines[0].labelCol = 1;
				docMask.lines[0].labelRow = 4;
				docMask.lines[0].editCol = 14;
				docMask.lines[0].editRow = 4;
				docMask.lines[0].editWidth = 20;
				
				docMask.lines[1] = new DocMaskLine();
				docMask.lines[1].id = 1;
				docMask.lines[1].name = "Title";
				docMask.lines[1].key = "TITLE";
				docMask.lines[1].type = DocMaskLineC.TYPE_TEXT;
				docMask.lines[1].labelCol = 1;
				docMask.lines[1].labelRow = 5;
				docMask.lines[1].editCol = 14;
				docMask.lines[1].editRow = 5;
				docMask.lines[1].editWidth = 20;

				docMask.lines[2] = new DocMaskLine();
				docMask.lines[2].id = 2;
				docMask.lines[2].name = "Released at";
				docMask.lines[2].key = "DATE";
				docMask.lines[2].type = DocMaskLineC.TYPE_ISO_DATE;
				docMask.lines[2].labelCol = 1;
				docMask.lines[2].labelRow = 6;
				docMask.lines[2].editCol = 14;
				docMask.lines[2].editRow = 6;
				docMask.lines[2].editWidth = 20;

				// checkin
				Logger.instance().log("checkin...");
				docMask.id = ix.Ix.checkinDocMask(docMask, DocMaskC.mbAll, LockC.NO);
				Logger.instance().log("checkin OK, docMask.id=" + docMask.id);

				// checkout
				Logger.instance().log("checkout...");
				docMask = ix.Ix.checkoutDocMask(docMask.name, DocMaskC.mbAll, LockC.NO);
				Logger.instance().log("checkout OK, name=" + docMask.name);
				
				// Create a Sord object with this mask
				Logger.instance().log("create sord...");
				Sord sord = ix.Ix.createSord("1", docMask.name, EditInfoC.mbSord).sord;
				Logger.instance().log("create sord OK");

				Logger.instance().log("sord index lines: ");
				for (int i = 0; i < sord.objKeys.Length; i++) 
				{
					Logger.instance().log("  id=" + sord.objKeys[i].id + ", group=" + sord.objKeys[i].name);
				}

				// checkin Sord
				ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);

				// delete mask
				// - must fail, since there is still a sord object related to this mask
				try 
				{
					Logger.instance().log("delete mask...");
					ix.Ix.deleteDocMask(docMask.name, null, LockC.NO);
					Logger.instance().log("Error: delete mask must fail");
				} 
				catch (Exception e) 
				{
					Logger.instance().log("OK, delete mask failed, err=" + formatException(e));
				}

				// delete the mask and specify an alternative mask (with mask-ID "0") 
				// for Sord objects related to the mask
				Logger.instance().log("delete mask...");
				ix.Ix.deleteDocMask(docMask.name, "0", LockC.NO);
				Logger.instance().log("delete mask OK");

				// delete sord
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, sord.guid, LockC.NO, delOpts);
						
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
