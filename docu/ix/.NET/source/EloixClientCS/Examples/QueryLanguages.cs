using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    public class QueryLanguages
    {
        // URL to IndexServer
        public String url;

        // [X] Account to authenticate 
        public String userName = "Administrator";
        public String userPwd = "";

        public void run()
        {
            IXConnFactory connFact = null;
            IXConnection conn = null;
            try
            {
                IXProperties connProps = IXConnFactory.CreateConnProperties(url);
                IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
                connFact = new IXConnFactory(connProps, sessOpts);
                conn = connFact.Create(userName, userPwd, "myComputer", null);
                Logger.instance().log("login OK");

                Logger.instance().log("Check whether OCR is available...");
                bool avail = checkOcrAvail(conn);
                Logger.instance().log("OCR is available=" + avail);

                if (avail)
                {
                    Logger.instance().log("Query languages:");
                    OcrInfo ocrInfo = new OcrInfo();
                    ocrInfo.queryLanguages = new OcrInfoQueryLanguages();

                    // Extenal language names should be returned in this language
                    ocrInfo.messagesLanguage = OcrInfoC.MESSAGES_LANGUAGE_GERMAN;

                    OcrResult ocrResult = conn.Ix.processOcr(ocrInfo);
                    for (int i = 0; i < ocrResult.queryLanguages.externalLangs.Length; i++)
                    {
                        Logger.instance().log("external=" + ocrResult.queryLanguages.externalLangs[i]);
                        Logger.instance().log("internal=" + ocrResult.queryLanguages.internalLangs[i]);
                    }
                }


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Logout
                if (conn != null)
                {
                    Logger.instance().log("IX logout...");
                    conn.Logout();
                    Logger.instance().log("IX logout OK");
                }
            }
        }

private bool checkOcrAvail(IXConnection conn)
{
    bool ocrAvail = true;
    try
    {
        conn.Ix.processOcr(new OcrInfo());
    }
    catch (Exception e)
    {
        if (conn.Ix.parseException(e.ToString()).exceptionType != IXExceptionC.UNSUPPORTED_FUNCTION)
        {
            throw e;
        }
        ocrAvail = false;
    }
    return ocrAvail;
}


    }
}
