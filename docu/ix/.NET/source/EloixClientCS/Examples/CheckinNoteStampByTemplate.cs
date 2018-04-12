using System;
using System.Collections.Generic;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    /// <summary>
    /// This class writes annotation notes based on note templates.
    /// They can be either text or image. 
    /// </summary>
    public class CheckinNoteStampByTemplate
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
                ed.sord.name = "document with annotations";
                ed.document = new Document();
                ed.document.docs = new DocVersion[1] { new DocVersion() };
                ed.document.docs[0].ext = "tif";
                ed.document.docs[0].pathId = ed.sord.path;
                ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;
                ed.document = ix.Ix.checkinDocBegin(ed.document);
                ed.document.docs[0].uploadResult = ix.Upload(ed.document.docs[0].url, @"..\..\00000001.TIF");
                ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);


                // Create NoteTemplate objects
                int[] noteTemplateIds = InternalCreateNoteTemplates(ix);

                // noteTemplateIds[0] ... Text "ACCEPTED"
                // noteTemplateIds[1] ... Image Stempel1.jpg



                List<Note> notes = new List<Note>();

                // Text "ACCEPTED"
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, 0, noteTemplateIds[0].ToString());

                    note.XPos = 100;
                    note.YPos = 200;
                    note.width = 1000;
                    note.height = 500;

                    notes.Add(note);
                }


                // Image
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, 0, noteTemplateIds[1].ToString());

                    note.XPos = 100;
                    note.YPos = 800;
                    note.width = 1000;
                    note.height = 500;

                    notes.Add(note);
                }


                int[] noteIds = ix.Ix.checkinNotes(null, notes.ToArray(), NoteC.mbAll, LockC.NO);
                Logger.instance().log("noteIds=" + noteIds);


            }
            finally
            {
                ix.Logout();
            }
        }

        /// <summary>
        /// Checkin two NoteTemplate objects used in this example.
        /// </summary>
        /// <param name="ix">IX connection object</param>
        /// <returns>IDs of NoteTemplate objects</returns>
        private int[] InternalCreateNoteTemplates(IXConnection ix)
        {
            // Try to find the note templates in the archive database
            try
            {
                NoteTemplate[] existingNoteTemplates = ix.Ix.checkoutNoteTemplates(ix.UserId.ToString(),
                new string[] { "Text Template ACCEPTED", "Image Template Stempel1.jpg" }, NoteTemplateC.mbMin, LockC.NO);
                return new int[] { existingNoteTemplates[0].id, existingNoteTemplates[1].id };
            }
            catch (Exception) { }

            List<NoteTemplate> noteTemplates = new List<NoteTemplate>();

            // Create a NoteTemplate with text "ACCEPTED"
            {
                NoteTemplate noteTemplate = ix.Ix.createNoteTemplate(ix.UserId.ToString());
                noteTemplate.name = "Text Template ACCEPTED";
                noteTemplate.noteText = new NoteText();
                noteTemplate.noteText.text = "ACCEPTED";
                noteTemplate.noteText.fontInfo = new FontInfo();
                noteTemplate.noteText.fontInfo.underline = true;
                noteTemplate.noteText.fontInfo.height = 30;
                noteTemplates.Add(noteTemplate);
            }

            // Create a NoteTemplate with an image
            {
                NoteTemplate noteTemplate = ix.Ix.createNoteTemplate(ix.UserId.ToString());
                noteTemplate.name = "Image Template Stempel1.jpg";
                noteTemplate.noteImage = new NoteImage();
                noteTemplate.noteImage.fileName = "Stempel1.jpg";
                noteTemplate.noteImage.fileData = new FileData();
                noteTemplate.noteImage.fileData.contentType = "image/jpeg";
                noteTemplate.noteImage.fileData.data = System.IO.File.ReadAllBytes(@"..\..\Stempel1.jpg");
                noteTemplates.Add(noteTemplate);
            }

            return ix.Ix.checkinNoteTemplates(noteTemplates.ToArray(), NoteTemplateC.mbAll, LockC.NO);
        }
    }
}