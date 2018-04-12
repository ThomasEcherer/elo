using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using EloixClient.IndexServer;

namespace Examples
{
    public class OcrRecognizeAsync
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
                    String fileName = "..\\..\\sample.tif";

                    Logger.instance().log("Recognize file asynchronously");
                    String text = recognizeFileAsync(conn, fileName, 30);
                    Logger.instance().log("text=" + text.Substring(0, 100) + "...");

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


        // Synchronisation object
        private Object syncObject = ("syncObj").Clone();

        // OCR Result
        private OcrResult result;

        private String recognizeFileAsync(IXConnection conn, String fileName, int timeoutSeconds)
        {
            // Open an event bus private to the session ticket and add a listener.
            // OCR results are send over this bus.
            EventBusApi.Bus eventBus = conn.EventBusApi.OpenEventBusChannel(conn.LoginResult.clientInfo.ticket);
            eventBus.AddListener(EventBusC.EVENT_OCR_RESULT);

            // Add a handler function for events.
            conn.EventBusApi.EventBusHandler += new EventBusApi.ProcessEventBusEvents(EventBusApi_EventBusHandler);

            OcrInfo ocrInfo = new OcrInfo();
            ocrInfo.recognizeFile = new OcrInfoRecognizeFile();
            ocrInfo.recognizeFile.imageData = new FileData();
            ocrInfo.recognizeFile.imageData.data = File.ReadAllBytes(fileName);
            ocrInfo.recognizeFile.imageData.contentType = ".TIF";
            ocrInfo.recognizeFile.recognizeLangs = new String[] { "English" };
            ocrInfo.recognizeFile.timeoutSeconds = timeoutSeconds;
            ocrInfo.recognizeFile.outputFormat = OcrInfoC.TEXT;
            ocrInfo.recognizeFile.pageNo = -1; // All pages

            // Set this properties for asynchronous processing:

            // Event bus that receives the result
            ocrInfo.busId = eventBus.Id;
            // ID for the request, unique for all open OCR requests on ocrInfo.busId
            ocrInfo.eventId = 123; 

            // Process OCR
            conn.Ix.processOcr(ocrInfo);

            // Wait for result
            lock (syncObject)
            {
                long t1 = DateTime.Now.Ticks / 10000;
                int dt = timeoutSeconds * 1000;
                while (result == null)
                {
                    Monitor.Wait(syncObject, dt);
                    long t2 = DateTime.Now.Ticks / 10000;
                    dt -= (int)(t2 - t1);
                    if (dt <= 0) throw new Exception("Timeout");
                    t1 = t2;
                }
            }

            String text = result.recognizeFile.text;
            return text;
        }

        // Event handler function.
        private void EventBusApi_EventBusHandler(long subsId, Event[] events)
        {
            foreach (Event ev in events)
            {
                if (ev.type == EventBusC.EVENT_OCR_RESULT)
                {
                    lock (syncObject)
                    {
                        this.result = (OcrResult)AnyToObject.ToObject(ev.any);

                        // Wakeup thread in recognizeFileAsync()
                        Monitor.PulseAll(syncObject);
                    }
                }
            }
        }

    }

}
