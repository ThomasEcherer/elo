using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    public class EventBusWatchFolder
    {
        // URL to IndexServer
        public String url;

        // [X] Account to authenticate 
        public String userName = "Administrator";
        public String userPwd = "";

        public void run()
        {
            IXConnFactory connFact = null;
            IXConnection ix1 = null;

            try
            {
                IXProperties connProps = IXConnFactory.CreateConnProperties(url);
                IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
                connFact = new IXConnFactory(connProps, sessOpts);
                Logger.instance().log("create IXConnFactory OK");

                // LOGIN
                Logger.instance().log("login connections...");
                ix1 = connFact.Create(userName, userPwd, "myComputer-conn1", null);
                // ci = ix.Login.ci
                Logger.instance().log("login OK");

                EventBusWatchFolderEventsDlg dlg = new EventBusWatchFolderEventsDlg(ix1);
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
                if (ix1 != null)
                {
                    Logger.instance().log("IX logout...");
                    ix1.Logout();
                    Logger.instance().log("IX logout OK");
                }
            }

        }
    }
}
