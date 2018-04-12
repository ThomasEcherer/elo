using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	///
	/// 1. Create new document without an associated file
	/// 2. Checkout document
	/// 3. Checkin a file as a new Version 
	///
	/// </summary>
	public class CheckinNewDocVersion
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

				// 1. Create document without an associated file
				EditInfo ed = ix.Ix.createDoc("1", "0", null, EditInfoC.mbSord);
				ed.sord.name = "C# example CheckinNewDocument";
				ed.sord.id = ix.Ix.checkinSord(ed.sord, SordC.mbAll, LockC.NO);

				// Create test file
				// 2. Checkout document
				ed = ix.Ix.checkoutDoc(ed.sord.guid, null, EditInfoC.mbSordDocAtt, LockC.YES);
				Logger.instance().log("checkout sord succeeded, objId=" + ed.document.objId);

				// Hint: Now the document is locked and will be unlocked by checkinDocEnd

				// 3. Checkin a file as a new Version 
				String text = "version 1";
				String testFile = internalCreateTestFile(text, "txt");

				// Supply the extension of the document
				ed.document.docs = new DocVersion[1];
				ed.document.docs[0] = new DocVersion();
                ed.document.docs[0].ext = ix.GetFileExt(testFile);
                ed.document.docs[0].pathId = ed.sord.path;
                ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;

				// CheckinDocBegin: let IndexServer generate an URL to upload the document
				ed.document = ix.Ix.checkinDocBegin(ed.document);

				// Upload the document
				String uploadResult = ix.Upload(ed.document.docs[0].url, testFile);
				ed.document.docs[0].uploadResult = uploadResult;

				// Set version comment
				ed.document.docs[0].version = "1.0";
				ed.document.docs[0].comment = "IndexServer C# example";

				// CheckinDocEnd: uploadResult contains the document information from ELODM.
				// Pass this information to 
				ed.document = ix.Ix.checkinDocEnd(null, null, ed.document, LockC.YES);
						
				// Hint: It's not nessesary to pass a Sord object to IndexServer in checkinDocEnd,
				//       if the indexing information was not changed. IndexServer gets the
				//       object ID from ed.document.objId.

				Logger.instance().log("inserted document version:");
				Logger.instance().log("  objId=" + ed.document.objId);
				Logger.instance().log("  docId=" + ed.document.docs[0].id);
				Logger.instance().log("  doc-guid=" + ed.document.docs[0].guid);
				Logger.instance().log("  URL=" + ed.document.docs[0].url);

				// 2. Checkout and show document
				ed = ix.Ix.checkoutDoc(ed.sord.guid, ed.document.docs[0].guid, EditInfoC.mbAll, LockC.YES);
				String tempName2 = internalMakeTempFileName(ed.document.docs[0].ext);
				ix.Download(ed.document.docs[0].url, tempName2);

        // Uncomment this to show document in notepad:
        //System.Diagnostics.Process.Start("notepad.exe", tempName2);
        //System.Threading.Thread.Sleep(3000);

        System.IO.File.Delete(tempName2);
							
        // insert second version
        //text = "version 2";
        //testFile = internalCreateTestFile(text, "txt");
        //ed.document.docs = new DocVersion[1];
        //ed.document.docs[0] = new DocVersion();
        //ed.document.docs[0].ext = IXClient.getFileExt(testFile);
        //ed.document = ix.Ix.checkinDocBegin(ed.document);
        //uploadResult = ix.Upload(ed.document.docs[0].url, testFile);
        //ed.document.docs[0].uploadResult = uploadResult;
        //ed.document.docs[0].version = "2.0";
        //ed.document.docs[0].comment = "2.0 IndexServer C# example";
        //ed.document = ix.Ix.checkinDocEnd(null, null, ed.document, LockC.YES);

				bool cleanUp = true;
				if (cleanUp)
				{
					// Delete Document
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, ed.sord.guid, LockC.NO, null);
          ix.Ix.deleteSord(null, ed.sord.guid, LockC.NO, delOpts);
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

		private String internalMakeTempFileName(String ext)
		{
			Random r = new Random((int)DateTime.Now.Ticks);
			String tempDir = System.IO.Path.GetTempPath();
			String tempName = "";
			do
			{
				tempName = tempDir + "eloix" + r.Next() + "." + ext;
			} while (System.IO.File.Exists(tempName));
			return tempName;
		}

		private String internalCreateTestFile(String text, String ext)
		{
			String tempName = internalMakeTempFileName(ext);
			System.IO.FileStream fstrm = new System.IO.FileStream(tempName, 
				System.IO.FileMode.Create, System.IO.FileAccess.Write);
			System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
			int n = encoding.GetByteCount(text);
			byte[] buf = new byte[n];
			encoding.GetBytes(text, 0, text.Length, buf, 0);
			fstrm.Write(buf, 0, buf.Length);
			fstrm.Close();
			return tempName;
		}
	}
}
