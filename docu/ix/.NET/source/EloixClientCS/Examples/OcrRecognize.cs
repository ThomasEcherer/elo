using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using EloixClient.IndexServer;

namespace Examples
{
    public class OcrRecognize
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

                    Logger.instance().log("Recognize file synchronously");
                    String text = recognizeFileSync(conn, fileName);
                    Logger.instance().log("text=" + text.Substring(0, 100) + "...");

                    // Recognize rectangle.
                    // Rectangle units are given in per thousand of document width resp. height.
                    Logger.instance().log("Recognize rect ");
                    int pmLeft = 50, pmTop = 100, pmRight = 200, pmBottom = 1000;
                    text = recognizeRect(conn, fileName, pmLeft, pmTop, pmRight, pmBottom);
                    Logger.instance().log("text=" + text.Substring(0, 100) + "...");

                    // Return character positions
                    Logger.instance().log("Recognize file return character positions");
                    recognizeFileCharPos(conn, fileName);

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

        private String recognizeFileSync(IXConnection conn, String fileName)
        {
            OcrInfo ocrInfo = new OcrInfo();
            ocrInfo.recognizeFile = new OcrInfoRecognizeFile();
            ocrInfo.recognizeFile.imageData = new FileData();
            ocrInfo.recognizeFile.imageData.data = File.ReadAllBytes(fileName);
            ocrInfo.recognizeFile.imageData.contentType = ".TIF";
            ocrInfo.recognizeFile.recognizeLangs = new String[] { "English" };
            ocrInfo.recognizeFile.timeoutSeconds = 30;
            ocrInfo.recognizeFile.outputFormat = OcrInfoC.TEXT;
            ocrInfo.recognizeFile.pageNo = -1; // All pages

            OcrResult ocrResult = conn.Ix.processOcr(ocrInfo);
            String text = ocrResult.recognizeFile.text;
            return text;
        }

        private void recognizeFileCharPos(IXConnection conn, string fileName)
        {
            OcrInfo ocrInfo = new OcrInfo();
            ocrInfo.recognizeFile = new OcrInfoRecognizeFile();
            ocrInfo.recognizeFile.imageData = new FileData();
            ocrInfo.recognizeFile.imageData.data = File.ReadAllBytes(fileName);
            ocrInfo.recognizeFile.imageData.contentType = ".TIF";
            ocrInfo.recognizeFile.recognizeLangs = new String[] { "English" };
            ocrInfo.recognizeFile.timeoutSeconds = 30;
            ocrInfo.recognizeFile.outputFormat = OcrInfoC.CHAR_AND_RECT_EX;
            ocrInfo.recognizeFile.pageNo = 0; // First pages

            // Recognize document
            OcrResult ocrResult = conn.Ix.processOcr(ocrInfo);

            // Put result bytes into BinaryReader
            byte[] data = ocrResult.recognizeFile.textData.data;
            BinaryReader rd = new BinaryReader(new MemoryStream(data));

            // Read header
            int magic = rd.ReadInt32();
            if (magic != 0x52434F45) throw new Exception("Unrecognized format");
            int version = rd.ReadInt32();
            if (version > 3) throw new Exception("Unsupported version");
            double skew = rd.ReadDouble();
            int width = rd.ReadInt32();
            int height = rd.ReadInt32();

            Logger.instance().log("magic=0x" + Convert.ToString(magic, 16));
            Logger.instance().log("version=" + version);
            Logger.instance().log("skew=" + skew);
            Logger.instance().log("width=" + width);
            Logger.instance().log("height=" + height);

            // Read characters
            int headerSize = 4 + 4 + 8 + 4 + 4;
            int charSize = 2 + 4 + 4 + 4 + 4 + 4 + 2;
            int nbOfChars = (data.Length - headerSize) / charSize;
            for (int i = 0; i < Math.Min(100, nbOfChars); i++)
            {
                char ch = (char)rd.ReadInt16();
                int left = rd.ReadInt32();
                int top = rd.ReadInt32();
                int right = rd.ReadInt32();
                int bottom = rd.ReadInt32();
                int percent = rd.ReadInt32();
                char chOrig = (char)rd.ReadInt16();

                Logger.instance().log("char " + i + ": '" + ch + "'");
                Logger.instance().log("  rect=(" + left + "," + top + "," + right + "," + bottom + ")");
                Logger.instance().log("  confidence=" + percent + ", orig='" + chOrig + "'");
            }
        }

        private String recognizeRect(IXConnection conn, String fileName, int pmLeft, int pmTop, int pmRight, int pmBottom)
        {
            OcrInfo ocrInfo = new OcrInfo();
            ocrInfo.recognizeFile = new OcrInfoRecognizeFile();
            ocrInfo.recognizeFile.imageData = new FileData();
            ocrInfo.recognizeFile.imageData.data = File.ReadAllBytes(fileName);
            ocrInfo.recognizeFile.imageData.contentType = ".TIF";
            ocrInfo.recognizeFile.recognizeLangs = new String[] { "English" };
            ocrInfo.recognizeFile.timeoutSeconds = 30;
            ocrInfo.recognizeFile.outputFormat = OcrInfoC.TEXT;
            ocrInfo.recognizeFile.pageNo = 0;
            ocrInfo.recognizeFile.recognizeRects = new OcrRect[] { new OcrRect(pmLeft, pmTop, pmRight, pmBottom) };
            ocrInfo.recognizeFile.rectUnit = OcrInfoC.UNIT_PER_THOUSAND;

            OcrResult ocrResult = conn.Ix.processOcr(ocrInfo);
            String text = ocrResult.recognizeFile.text;
            return text;
        }


    }

}
