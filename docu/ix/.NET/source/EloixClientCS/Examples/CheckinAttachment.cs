using System;
using EloixClient.IndexServer;
namespace Examples
{
	/// <summary>
	///
	/// 1. Create sord for document without version
	/// 2. Checkin attachment
	/// 3. Checkout and show document 
	///
	/// </summary>
	public class CheckinAttachment
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

				// 1. Create sord for document without version

				// Initialize Sord object
				EditInfo ed = ix.Ix.createDoc("1", "0", null, EditInfoC.mbSordDocAtt);
				ed.sord.name = "C# example CheckinAttachment";

				// Create attachment file
				String attFile = internalCreateTestFile("CheckinNewAttachment attachment file", "txt");

				// Supply the extension of the document
				ed.document.atts = new DocVersion[1];
				ed.document.atts[0] = new DocVersion();
                ed.document.atts[0].ext = ix.GetFileExt(attFile);
        ed.document.atts[0].pathId = ed.sord.path;
        // ed.document.atts[0].encryptionSet = ignored

				// CheckinDocBegin: let IndexServer generate an URL to upload the document
				ed.document = ix.Ix.checkinDocBegin(ed.document);
				Logger.instance().log("prepared upload URL=" + ed.document.atts[0].url + ", att-guid=" + ed.document.atts[0].guid);

				// Upload the document
				String uploadResult = ix.Upload(ed.document.atts[0].url, attFile);
				ed.document.atts[0].uploadResult = uploadResult;
				Logger.instance().log("upload succeeded");
				System.IO.File.Delete(attFile);

				// CheckinDocEnd: uploadResult contains the document information from ELODM.
				// Pass this information to 
				ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);
				Logger.instance().log("inserted document:");
				Logger.instance().log("  objId=" + ed.document.objId);
				Logger.instance().log("  attId=" + ed.document.atts[0].id);
				Logger.instance().log("  att-guid=" + ed.document.atts[0].guid);
				Logger.instance().log("  URL=" + ed.document.atts[0].url);

				// 2. Checkout and show document
				ed = ix.Ix.checkoutDoc(ed.sord.guid, null, EditInfoC.mbAll, LockC.NO);
				String tempName2 = internalMakeTempFileName(ed.document.atts[0].ext);
				ix.Download(ed.document.atts[0].url, tempName2);

        // Uncomment this to show document in notepad:
        // System.Diagnostics.Process.Start("notepad.exe", tempName2);
        // System.Threading.Thread.Sleep(3000);
        
        System.IO.File.Delete(tempName2);
							
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
