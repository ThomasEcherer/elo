using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Example for checkinDocsBegin/checkinDocsEnd
	/// 
	/// 1. Create a root folder.
	/// 2. Create but do not checkin: 100 sords and files with approximatly 100KByte, see member fileSize
	/// 3. Checkin 100 documents from 2. with checkinDocsBegin/checkinDocsEnd
	/// 4. Read documents
	/// 5. Delete root folder finally (implicitly deletes the 100 included Documents)
	///
	/// </summary>
	public class DocPerformance2
	{
		public int nbOfDocs  = 100;
		public int fileSize = 100 * 1000;

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
				Sord e1 = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				e1.name = "e1";
				e1.id = ix.Ix.checkinSord(e1, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e1: id=" + e1.id);

				// 2. Create but do not checkin: 100 sords and files with approximatly 100KByte, see member fileSize
				Sord[] sords = new Sord[nbOfDocs];
				Document[] documents = new Document[nbOfDocs];
				String[] docFiles = new String[nbOfDocs];

				long diffTicks = 0;
				for (int i = 0; i < nbOfDocs; i++) 
				{
					// Initialize a EditInfo object
					long t1 = System.DateTime.Now.Ticks;
					EditInfo ed = ix.Ix.createDoc(e1.guid, "Email", null, EditInfoC.mbSordDocAtt);
					long t2 = System.DateTime.Now.Ticks;
					diffTicks += (t2-t1);

					// Add some index attributes
					ed.sord.name = "e1." + i;
					for (int idx = 0; idx < ed.sord.objKeys.Length; idx++) 
					{
						ed.sord.objKeys[idx].data = new String[] {ed.sord.name + ".idx" + idx};
					}

					// Create a file 
					docFiles[i] = internalCreateTestFile("DocPerformance " + ed.sord.name, "txt");

					// checkinDocBegin
					ed.document.docs = new DocVersion[1];
					ed.document.docs[0] = new DocVersion();
                    ed.document.docs[0].ext = ix.GetFileExt(docFiles[i]);
          ed.document.docs[0].pathId = ed.sord.path;
          ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;

					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("create sord/file: " + (i+1) + "/" + nbOfDocs);
					}

					sords[i] = ed.sord;
					documents[i] = ed.document;
				}

				// 3. Checkin 100 documents from 2.
				Logger.instance().log("checkinDocsBegin...");

				// checkinDocsBegin
				long t3 = System.DateTime.Now.Ticks;
				documents = ix.Ix.checkinDocsBegin(documents);
				Logger.instance().log("checkinDocsBegin OK");

				// upload 100 files
				Logger.instance().log("upload " + nbOfDocs + " files ...");
				for (int i = 0; i < nbOfDocs; i++)
				{
					documents[i].docs[0].uploadResult = ix.Upload(documents[i].docs[0].url, docFiles[i]);
					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("upload file: " + (i+1) + "/" + nbOfDocs);
					}
				}
				Logger.instance().log("upload OK");

				// checkinDocsEnd
				Logger.instance().log("checkinDocsEnd...");
				documents = ix.Ix.checkinDocsEnd(sords, 
					new SordZ[] {SordC.mbAll}, 
					documents, LockC.NO);
				Logger.instance().log("checkinDocsEnd OK");
				long t4 = System.DateTime.Now.Ticks;
				diffTicks = t4 - t3;
                
				// Log time values
				logTimeValues("checkin", diffTicks, nbOfDocs);
		
				// 4. Read 100 Documents
				diffTicks = 0;
				for (int i = 0; i < nbOfDocs; i++) 
				{
					// checkoutDoc
					long t1 = System.DateTime.Now.Ticks;
					EditInfo ed = ix.Ix.checkoutDoc(sords[i].guid, null, EditInfoC.mbSordDocAtt, LockC.NO);

					// download
					String docFile = internalMakeTempFileName(ed.document.docs[0].ext);
					ix.Download(ed.document.docs[0].url, docFile);
					long t2 = System.DateTime.Now.Ticks;
					diffTicks += (t2-t1);

					System.IO.FileInfo fi = new System.IO.FileInfo(docFile);
					if (fi.Length < fileSize) 
					{
						throw new InvalidOperationException("download failed");
					}

					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("read: " + (i+1) + "/" + nbOfDocs);
					}

					System.IO.File.Delete(docFile);
				}

				// Log time values
				logTimeValues("read", diffTicks, nbOfDocs);

				// 5. Delete root folder finally (implicitly deletes the 100 included Sords)
				Logger.instance().log("delete finally...");
				DateTime startTime = System.DateTime.Now;
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, e1.guid, LockC.NO, delOpts);
				DateTime endTime = System.DateTime.Now;
				logTimeValues("delete finally", startTime, endTime, nbOfDocs);

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
			
			System.IO.StreamWriter sr = System.IO.File.CreateText(tempName);
			
			int n = text.Length;
			int lineCount = fileSize / (n + 1);

			for (int i = 0; i < lineCount; i++) 
			{
				sr.WriteLine(text);
			}

			sr.Close();

			return tempName;
		}

		private void logTimeValues(String actionName, DateTime startTime, DateTime endTime, int n)
		{
			logTimeValues(actionName, endTime.Ticks - startTime.Ticks, n);
		}
	
		private void logTimeValues(String actionName, long diffTicks, int n)
		{
			double ns100 = 1000L * 1000L * 10;
			double dt = diffTicks;
			dt /= ns100;
			double secondsPerAction = dt / (double)n;
			double actionsPerSecond = 1.0 / secondsPerAction;
			Logger.instance().log("action=" + actionName + ": dt=" + dt);
			Logger.instance().log("  secondsPerAction=" + secondsPerAction);
			Logger.instance().log("  actionsPerSecond=" + actionsPerSecond);
		}
	}
}