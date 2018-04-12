using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    public class FindISearch
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

                // LOGIN
                Logger.instance().log("login...");
                ix = connFact.Create(userName, userPwd, "myComputer", null);
                // ci = ix.Login.ci
                Logger.instance().log("login OK");

                FindInfo findInfo = new FindInfo();
                findInfo.findDirect = new FindDirect();
                findInfo.findDirect.query = "buch sord.type:[254 TO 255]";
                findInfo.findDirect.searchInFulltext = true;
                findInfo.findDirect.searchInIndex = true;
                findInfo.findDirect.searchInMemo = true;
                findInfo.findDirect.searchInSordName = true;

                FindResult findResult = ix.Ix.findFirstSords(findInfo, 100, SordC.mbAll);
                for (int i = 0; i < findResult.sords.Length; i++)
                {
                    Logger.instance().log(findResult.sords[i].name + "," + findResult.sords[i].type);
                }

                ix.Ix.findClose(findResult.searchId);

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
