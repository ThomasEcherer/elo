using System;
using System.IO;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für DocPerformanceSmall.
	/// </summary>
	public class DocPerformanceSmall
	{
    public int nbOfDocs  = 100;
    public int fileSize = 10 * 1000;

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

        // Create 100 small documents
        long diffTicks = 0;
        string[] guids = new string[nbOfDocs];
        for (int docIdx = 0; docIdx < nbOfDocs; docIdx++) 
        {
          if ((docIdx % 20) == 0) 
          {
            Logger.instance().log(docIdx + "/" + nbOfDocs);
          }

          long t1 = System.DateTime.Now.Ticks;
          EditInfo d1 = ix.Ix.createDoc(e1.guid, null, null, EditInfoC.mbSordDoc);
          long t2 = System.DateTime.Now.Ticks;
          guids[docIdx] = d1.sord.guid;
          d1.sord.name = "doc" + (docIdx + 1);
          d1.document.docs = new DocVersion[1];
          d1.document.docs[0] = new DocVersion();
          d1.document.docs[0].ext = "tmp";
          d1.document.docs[0].pathId = d1.sord.path;
          d1.document.docs[0].encryptionSet = d1.sord.details.encryptionSet;

          byte[] buf = new byte[fileSize];
          for (int i = 0; i < buf.Length; i++) buf[i] = (byte)(i & 0xFF);
          d1.document.docs[0].fileData = new FileData();
          d1.document.docs[0].fileData.data = buf;
          
          // Since we do not need to call ix.Ix.checkinDocBegin
          // we must mark the version explicitly as work-version.
          d1.document.docs[0].workVersion = true;

          t1 = System.DateTime.Now.Ticks;
          d1.document = ix.Ix.checkinDocEnd(d1.sord, SordC.mbAll, d1.document, LockC.NO);
          t2 = System.DateTime.Now.Ticks;
          diffTicks += (t2-t1);

        }
        Logger.instance().log(nbOfDocs + "/" + nbOfDocs);
        
        // log duration
        logTimeValues("checkin", diffTicks, nbOfDocs);

        // checkout 100 small documents
        long diffTicksCheckout = 0;
        long diffTicksWriteFile = 0;
        for (int docIdx = 0; docIdx < nbOfDocs; docIdx++) 
        {
          if ((docIdx % 20) == 0) 
          {
            Logger.instance().log(docIdx + "/" + nbOfDocs);
          }

          long t1 = System.DateTime.Now.Ticks;
          EditInfo d1 = ix.Ix.checkoutDoc(guids[docIdx], null, 
            EditInfoC.mbSordDocSmallContent, LockC.NO);
          long t2 = System.DateTime.Now.Ticks;
          diffTicksCheckout += (t2-t1);

          byte[] buf = d1.document.docs[0].fileData.data;
          string fileName = Path.GetTempFileName();
          t1 = System.DateTime.Now.Ticks;
          FileStream fstrm = new FileStream(fileName, FileMode.Create, FileAccess.Write);
          fstrm.Write(buf, 0, buf.Length);
          fstrm.Close();
          t2 = System.DateTime.Now.Ticks;
          diffTicksWriteFile += (t2-t1);

          File.Delete(fileName);
        }
        Logger.instance().log(nbOfDocs + "/" + nbOfDocs);
        
        // log duration
        logTimeValues("checkout", diffTicksCheckout, nbOfDocs);

        // clean up
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
        ix.Ix.deleteSord(null, e1.guid, LockC.NO, null);
        ix.Ix.deleteSord(null, e1.guid, LockC.NO, delOpts);
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
