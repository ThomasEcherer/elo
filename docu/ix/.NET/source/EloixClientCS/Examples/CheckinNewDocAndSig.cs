using System;
using EloixClient.IndexServer;

namespace Examples
{
	/// <summary>
	///
	/// 1. Checkin version and signature
	/// 2. Checkout document and show version and signature
	///
	/// </summary>
	public class CheckinNewDocAndSig
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

				// 1. Checkin version and signature

				// Initialize Sord object
				EditInfo ed = ix.Ix.createDoc("1", "0", null, EditInfoC.mbSordDocAtt);
				ed.sord.name = "C# example CheckinNewDocAndSig";

				// Create file for document version
				String testFile = internalCreateTestFile("CheckinNewDocAndSig example file", "txt");

				// Supply the extension of the document
				ed.document.docs = new DocVersion[1];
				ed.document.docs[0] = new DocVersion();
                ed.document.docs[0].ext = ix.GetFileExt(testFile);
        ed.document.docs[0].pathId = ed.sord.path;
        ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;

				// Create signature file (we use a dummy and not a real signature)
				String sigFile = internalCreateTestFile("Signature dummy", "txt");
				ed.document.docs[0].sig = new DocVersion();
                ed.document.docs[0].sig.ext = ix.GetFileExt(sigFile);
        // ed.document.docs[0].sig.pathId ... uses ed.document.docs[0].pathId by default
        // ed.document.docs[0].encryptionSet ... cannot be encrypted

				// CheckinDocBegin: let IndexServer generate an URL to upload the document
				ed.document = ix.Ix.checkinDocBegin(ed.document);
				Logger.instance().log("prepared upload URL=" + ed.document.docs[0].url + ", doc-guid=" + ed.document.docs[0].guid);

				// Upload document version
				ed.document.docs[0].uploadResult = ix.Upload(ed.document.docs[0].url, testFile);
				Logger.instance().log("upload document version succeeded");

				// Upload signature
				ed.document.docs[0].sig.uploadResult = ix.Upload(ed.document.docs[0].sig.url, sigFile);
				Logger.instance().log("upload signature succeeded");

				// CheckinDocEnd: uploadResult contains the document information from ELODM.
				// Pass this information to 
				ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);
				Logger.instance().log("inserted document:");
				Logger.instance().log("  objId=" + ed.document.objId);
				Logger.instance().log("  docId=" + ed.document.docs[0].id);
				Logger.instance().log("  doc-guid=" + ed.document.docs[0].guid);
				Logger.instance().log("  URL=" + ed.document.docs[0].url);
				Logger.instance().log("  sigId=" + ed.document.docs[0].sig.id);
				Logger.instance().log("  sig-guid=" + ed.document.docs[0].sig.guid);
				Logger.instance().log("  URL=" + ed.document.docs[0].sig.url);

				System.IO.File.Delete(testFile);
				System.IO.File.Delete(sigFile);
			
				// 2. Checkout document and show version and signature
				ed = ix.Ix.checkoutDoc(ed.sord.guid, null, EditInfoC.mbSordDocAtt, LockC.NO);

				// Show document version 
				String tempNameDoc = internalMakeTempFileName(ed.document.docs[0].ext);
				ix.Download(ed.document.docs[0].url, tempNameDoc);

        // Uncomment this to show document in notepad:
        //System.Diagnostics.Process.Start("notepad.exe", tempNameDoc);

				// Show signature 
				String tempNameSig = internalMakeTempFileName(ed.document.docs[0].sig.ext);
				ix.Download(ed.document.docs[0].sig.url, tempNameSig);

        // Uncomment this to show document in notepad:
        //System.Diagnostics.Process.Start("notepad.exe", tempNameSig);

				// give notepad.exe some time to read the files before deleting them
				System.Threading.Thread.Sleep(3000);
				System.IO.File.Delete(tempNameDoc);
				System.IO.File.Delete(tempNameSig);
							
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
