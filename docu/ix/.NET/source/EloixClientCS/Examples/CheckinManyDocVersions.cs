using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	///
	/// 1. Create new document without an associated file
	/// 2. Checkout document
	/// 3. Checkin some files as a new Versions
	/// 4. Checkout and show all versions
	///
	/// </summary>
	public class CheckinManyDocVersions
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

				// Hint: Now, the document is locked and we keep the lock until all 
				//       versions are inserted.

				// 3. Checkin some files as a new Versions 
				int nbOfVersions = 3;
				for (int i = 0; i < nbOfVersions; i++) 
				{
					String text = "version " + (i+1);
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
					ed.document.docs[0].version = "" + (i+1) + ".0";
					ed.document.docs[0].comment = "IndexServer C# example - " + (i+1);

					// CheckinDocEnd: uploadResult contains the document information from ELODM.
					// Pass this information to 
					ed.document = ix.Ix.checkinDocEnd(null, null, ed.document, LockC.NO);
							
					// Hint: It's not nessesary to pass a Sord object to IndexServer in checkinDocEnd,
					//       if the indexing information was not changed. IndexServer gets the
					//       object ID from ed.document.objId.

					Logger.instance().log("inserted document version:");
					Logger.instance().log("  objId=" + ed.document.objId);
					Logger.instance().log("  docId=" + ed.document.docs[0].id);
					Logger.instance().log("  doc-guid=" + ed.document.docs[0].guid);
					Logger.instance().log("  URL=" + ed.document.docs[0].url);

					// delete local version
					System.IO.File.Delete(testFile);

				}				

				// unlock 
				ix.Ix.checkinSord(ed.sord, SordC.mbOnlyUnlock, LockC.YES);

				// 4. Checkout and show all versions
				ed = ix.Ix.checkoutDoc(ed.sord.guid, "-1", EditInfoC.mbSordDocAtt, LockC.NO);

				// Show document versions
				String[] tempFiles = new String[ed.document.docs.Length];
				for (int i = 0; i < ed.document.docs.Length; i++) 
				{
					tempFiles[i] = internalMakeTempFileName(ed.document.docs[0].ext);
					ix.Download(ed.document.docs[i].url, tempFiles[i]);

          // Uncomment this to show document in notepad:
          // System.Diagnostics.Process.Start("notepad.exe", tempFiles[i]);
				}

				// give notepad.exe some time to read the files before deleting them
				System.Threading.Thread.Sleep(3000);
				for (int i = 0; i < tempFiles.Length; i++) 
				{
					System.IO.File.Delete(tempFiles[i]);
				}
							
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
