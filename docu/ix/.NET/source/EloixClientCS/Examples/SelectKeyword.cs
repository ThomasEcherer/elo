using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für SelectKeyword.
	/// </summary>
  public class SelectKeyword
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
      
        SelectKeywordDlg dlg = new SelectKeywordDlg(ix);
        dlg.ShowDialog();


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
  }
}
