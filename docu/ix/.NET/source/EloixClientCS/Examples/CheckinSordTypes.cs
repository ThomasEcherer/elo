using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für CheckinSordTypes.
	/// </summary>
  public class CheckinSordTypes
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
        IXServicePortC CONST = ix.CONST;

        // List current sord types
        SordType[] sordTypes = ix.Ix.checkoutSordTypes(null, SordTypeC.mbAllJPG, LockC.NO);
        dumpSordTypes(sordTypes);

        // Add new sord type for documents with extensions ".ABC" and ".DEF"
        Logger.instance().log("insert sord type...");
        SordType sordTypeABC = new SordType();
        sordTypeABC.id = sordTypes[sordTypes.Length-1].id + 1;
        sordTypeABC.name = "ABC an DEF documents";
        sordTypeABC.extensions = new String[] {"ABC", "DEF"};
        ix.Ix.checkinSordTypes(new SordType[] {sordTypeABC}, LockC.NO);
        Logger.instance().log("insert sord type OK, id=" + sordTypeABC.id);
        
        // List current sord types
        sordTypes = ix.Ix.checkoutSordTypes(null, SordTypeC.mbAllJPG, LockC.NO);
        dumpSordTypes(sordTypes);

        // delete sord type
        Logger.instance().log("delete sord type, id=" + sordTypeABC.id);
        ix.Ix.deleteSordTypes(new int[] {sordTypeABC.id}, LockC.NO);
        Logger.instance().log("delete sord type OK");

        // List current sord types
        sordTypes = ix.Ix.checkoutSordTypes(null, SordTypeC.mbAllJPG, LockC.NO);
        dumpSordTypes(sordTypes);
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

    private void dumpSordTypes(SordType[] sordTypes) 
    {
      for (int i = 0; i < sordTypes.Length; i++) 
      {
        Logger.instance().log("sordTypes[" + i + "], id=" + sordTypes[i].id + ", name=" + sordTypes[i].name);
      }
    }
  }
}
