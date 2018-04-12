using System;
using EloixClient.IndexServer;

namespace Examples
{
	/// <summary>
	/// This class shows how to checkin a new keyword list.
	/// The follwoing keyword tree is beeing inserted:
	/// 
	/// C#-Example-Keywords
	///      |
	///      +--------- Simple Folder
	///      |               +------------- Simple Text 1
	///      |               +------------- Simple Text 2
	///      |               
	///      +--------- Special Folder  (add)
	///      |               +------------- User name = \"{username}\"
	///      |               +------------- Date = {date}
	///      |
  ///      +--------- Counter = {counterName} = {counter-value}
	/// 
	/// </summary>
	public class CheckinKeywords
	{
    // URL to IndexServer
    public String url;

    // [X] Account to authenticate 
    public String userName = "Administrator"; 
    public String userPwd = "";					

    public String keywordListId = "C#-Example-Keywords"; // try "ELOOUTL1" and verify keyword list in ELO-CLIENT, storage mask "EMail"
    
    // Specify a counter name to create a keyword that contains a counter value.
    // Be aware that counters cannot be deleted.
    public String counterName = "C#excnt";

    // Delete keywords at the end of example
    public bool deleteOnExit = true;

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

        // Lock keyword database against concurrent modification
        ix.Ix.checkoutKeywords(null, KeywordC.mbEdit, -1, LockC.YES);

        // create counter, if it does not exist
        if (counterName.Length > 0) 
        {
          CounterInfo[] counters = ix.Ix.checkoutCounters(null, false, LockC.NO);
          bool found = false;
          for (int i = 0; i < counters.Length && !found; i++) 
          {
            found = counters[i].name.Equals(counterName);
          }
          if (!found)
          {
            CounterInfo counterInfo = new CounterInfo();
            counterInfo.name = counterName;
            counterInfo.value = 123;
            ix.Ix.checkinCounters(new CounterInfo[] {counterInfo}, LockC.NO);
          } 
        }

        // Build keyword tree

        // root keyword: "C#-Example-Keywords"
        Keyword kwRoot = new Keyword();
        kwRoot.id = keywordListId; 
          // Hint 1 : Maximum length of Keyword.id = KeywordC.lnRootId
          // Hint 2 : The ID of a root keyword must not contain "."
        kwRoot.text = "C#-Example-Keywords";
        kwRoot.children = new Keyword[(counterName.Length > 0) ? 3 : 2];

        // Simple Folder
        Keyword kwSimpleFolder = kwRoot.children[0] = new Keyword();
        kwSimpleFolder.text = "Simple Folder";
        kwSimpleFolder.children = new Keyword[2];

        // Simple Text 1
        kwSimpleFolder.children[0] = new Keyword();
        kwSimpleFolder.children[0].enabled = true;
        kwSimpleFolder.children[0].text = "Simple Text 1";
          
        // Simple Text 2
        kwSimpleFolder.children[1] = new Keyword();
        kwSimpleFolder.children[1].enabled = true;
        kwSimpleFolder.children[1].text = "Simple Text 2";

        // Special Folder
        Keyword kwSpecialFolder = kwRoot.children[1] = new Keyword();
        kwSpecialFolder.text = "Special Folder ";
        kwSpecialFolder.add = true;
        kwSpecialFolder.children = new Keyword[2];

        // User name
        kwSpecialFolder.children[0] = new Keyword();
        kwSpecialFolder.children[0].enabled = true;
        kwSpecialFolder.children[0].text = "User name = \"" + KeywordC.PLACEHOLDER_USER_NAME + "\"";

        // Date
        kwSpecialFolder.children[1] = new Keyword();
        kwSpecialFolder.children[1].enabled = true;
        kwSpecialFolder.children[1].text = "date = " + KeywordC.PLACEHOLDER_DATE;

        // Counter
        if (counterName.Length > 0) 
        {
          Keyword kwCounter = kwRoot.children[2] = new Keyword();
          kwCounter.text = counterName + " = " + 
            KeywordC.PLACEHOLDER_COUNTER_BEGIN + counterName + KeywordC.PLACEHOLDER_COUNTER_END;
          kwCounter.enabled = true;
        }

        // Checkin new keyword list
        ix.Ix.checkinKeywords(new Keyword[] {kwRoot}, LockC.NO);

        // Checkout for editing, placeholders are not substitued.
        // This call could be used to fill dialog to edit keywords.
        Keyword kwRootEdit = ix.Ix.checkoutKeywords(new String[] {kwRoot.id}, KeywordC.mbEdit, -1, LockC.NO)[0];
        Logger.instance().log("keyword tree for editing:");
        dumpKeyword(kwRootEdit, "  ");

        // Checkout to select a keyword, placeholders except counter are substitued
        // This call could be used to fill dialog to show keywords.
        Keyword kwRootView = ix.Ix.checkoutKeywords(new String[] {kwRoot.id}, KeywordC.mbView, -1, LockC.NO)[0];
        Logger.instance().log("keyword tree to select:");
        dumpKeyword(kwRootView, "  ");

        // If the user selects a keyword for an indexing value, 
        // call cookKeyword with the keyword ID if the keyword is "raw".
        // This function substitues all placeholders and concatinates the upper
        // nodes that have specified the "add" option.
        selectKeyword(ix, kwRootView.children[1].children[0]);

        // select counter keyword 5 times (counter is beeing incremented)
        for (int i = 0; i < 5; i++) 
        {
          selectKeyword(ix, kwRootView.children[2]);
        }

        if (deleteOnExit) 
        {
          // delete keywords and unlock
          ix.Ix.deleteKeywords(new String[] {kwRoot.id}, LockC.YES);
        } 
        else 
        {
          // unlock
          ix.Ix.checkinKeywords(null, LockC.YES);
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

    /// <summary>
    /// This function calls cookKeyword to evaluate the resulting keyword text with substituted
    /// placeholders and concatinated upper nodes.
    /// </summary>
    /// <param name="ix"></param>
    /// <param name="ci"></param>
    /// <param name="kw"></param>
    /// <returns></returns>
    private String selectKeyword(IXConnection ix, Keyword kw)
    {
      String keywordText = "";

      // cookKeyword throws an exception, if the keyword is not enabled
      if (kw.enabled)
      {
        // cookKeyword need only be called for raw keywords
        if (kw.raw)
        {
          keywordText = ix.Ix.cookKeyword(kw.id);
        } 
        else
        {
          keywordText = kw.text;
        }
        Logger.instance().log("cooked keyword: id=" + kw.id + ", raw-text=" + kw.text + ", cooked-text=" + keywordText);
      } 
      else 
      {
        Logger.instance().log("cannot select disabled keyword: id=" + kw.id);
      }
      return keywordText;
    }

    private void dumpKeyword(Keyword kw, String indent) 
    {
      Logger.instance().log(indent + "kw.id=" + kw.id);
      Logger.instance().log(indent + " text=" + kw.text);
      Logger.instance().log(indent + " add=" + kw.add);
      Logger.instance().log(indent + " enabled=" + kw.enabled);
      Logger.instance().log(indent + " raw=" + kw.raw);
      Logger.instance().log(indent + " hasChildren=" + (kw.children != null) + ", #children=" + ((kw.children != null) ? kw.children.Length : 0));
      if (kw.children != null) 
      {
        for (int i = 0; i < kw.children.Length; i++) 
        {
          dumpKeyword(kw.children[i], indent + "  ");
        }
      }
    }
	}

}
