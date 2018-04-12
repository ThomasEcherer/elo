using System;
using System.Collections.Generic;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    /// <summary>
    /// This class shows how to checkin sticky notes that are displayed on the vertical bar 
    /// between the archive tree and the document preview.
    /// </summary>
    public class CheckinNoteOnVerticalBar
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

                // Create a document 
                EditInfo ed = ix.Ix.createDoc("1", null, null, EditInfoC.mbSordDoc);
                ed.sord.name = "document with sticky notes";
                ed.document = new Document();
                ed.document.docs = new DocVersion[1] { new DocVersion() };
                ed.document.docs[0].ext = "tif";
                ed.document.docs[0].pathId = ed.sord.path;
                ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;
                ed.document = ix.Ix.checkinDocBegin(ed.document);
                ed.document.docs[0].uploadResult = ix.Upload(ed.document.docs[0].url, @"..\..\00000001.TIF");
                ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);

                Note[] notes = new Note[3];

                // Create a normal sticky note
                notes[0] = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_NORMAL, null);
                notes[0].desc = "This is a normal sticky note";

                // Create a personal note
                notes[1] = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_PERSONAL, null);
                notes[1].desc = "This is a personal note";

                // Create a stamp note
                notes[2] = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_STAMP, null);
                notes[2].desc = "This is a stamp note";

                int[] noteIds = ix.Ix.checkinNotes(null, notes, NoteC.mbAll, LockC.NO);
                Logger.instance().log("noteIds=" + noteIds);


            }
            finally
            {
                ix.Logout();
            }
        }
    }
}
