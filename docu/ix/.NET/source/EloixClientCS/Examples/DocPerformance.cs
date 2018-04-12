using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	///
	/// 1. Create 100 Documents with one version under a root folder. 
	///    File size is approximatly 100KByte, see member fileSize
	/// 2. Read the created Documents
	/// 3. Delete root folder logically (implicitly deletes the 100 included Documents)
	/// 4. Delete root folder finally (implicitly deletes the 100 included Documents)
	///
	/// </summary>
	public class DocPerformance
	{
		public int nbOfDocs = 100;
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

				// Create a root folder
				Sord e1 = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				e1.name = "e1";
				e1.id = ix.Ix.checkinSord(e1, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e1: id=" + e1.id);

				// Create 100 Sords
				String[] guids = new String[nbOfDocs];

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
					String docFile = internalCreateTestFile("DocPerformance " + ed.sord.name, "txt");

					// checkinDocBegin
					ed.document.docs = new DocVersion[1];
					ed.document.docs[0] = new DocVersion();
                    ed.document.docs[0].ext = ix.GetFileExt(docFile);
          ed.document.docs[0].pathId = ed.sord.path;
          ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;
          ed.document = ix.Ix.checkinDocBegin(ed.document);

					// upload
					t1 = System.DateTime.Now.Ticks;
					ed.document.docs[0].uploadResult = ix.Upload(ed.document.docs[0].url, docFile);
					t2 = System.DateTime.Now.Ticks;
					diffTicks += (t2-t1);

					// checkinDocEnd
					t1 = System.DateTime.Now.Ticks;
					ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);
					t2 = System.DateTime.Now.Ticks;
					diffTicks += (t2-t1);
                    
					guids[i] = ed.sord.guid;
					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("create: " + (i+1) + "/" + nbOfDocs);
					}

					System.IO.File.Delete(docFile);
				}

				// Log time values
				logTimeValues("create", diffTicks, nbOfDocs);
		
				// 2. Read 100 Documents
				diffTicks = 0;
				for (int i = 0; i < nbOfDocs; i++) 
				{
					// checkoutDoc
					long t1 = System.DateTime.Now.Ticks;
					EditInfo ed = ix.Ix.checkoutDoc(guids[i], null, EditInfoC.mbSordDocAtt, LockC.NO);

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

				// 3. Delete root folder logically (implicitly deletes the 100 included Sords)
				Logger.instance().log("delete logically...");
				DateTime startTime = System.DateTime.Now;
				ix.Ix.deleteSord(null, e1.guid, LockC.NO, null);
				DateTime endTime = System.DateTime.Now;
				logTimeValues("delete logically", startTime, endTime, nbOfDocs);

				// 4. Delete root folder finally (implicitly deletes the 100 included Sords)
				Logger.instance().log("delete finally...");
				startTime = System.DateTime.Now;
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, e1.guid, LockC.NO, delOpts);
				endTime = System.DateTime.Now;
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
