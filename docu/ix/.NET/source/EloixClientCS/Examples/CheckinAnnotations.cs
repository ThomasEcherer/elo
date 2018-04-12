using System;
using System.Collections.Generic;
using System.Text;
using EloixClient.IndexServer;

namespace Examples
{
    /// <summary>
    /// This class creates various types of annotations.
    /// </summary>
    public class CheckinAnnotations
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

                List<Note> notes = new List<Note>();

                // -------------------------------------------------------
                // Do not use the member Note.desc for annotations because
                // it contains position and formatting information.
                // -------------------------------------------------------

                // Text on a opaque rectangle
                if (true) 
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_NOTE_WITHFONT, null);
                    note.noteText.text = "This is an annotation with font=" + note.noteText.fontInfo.faceName;

                    note.color = NetColorToEloColor(System.Drawing.Color.RosyBrown);
                    note.noteText.fontInfo.height *= 2;
                    note.noteText.fontInfo.bold = true;
                    note.noteText.fontInfo.italic = true;
                    note.noteText.fontInfo.RGB = NetColorToEloColor(System.Drawing.Color.SkyBlue);
                    
                    note.XPos = 100;
                    note.YPos = 200;
                    note.width = 1000;
                    note.height = 500;

                    notes.Add(note);
                }

                // Horizontal line
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_HORIZONTAL_LINE, null);
                    PointInfo p1 = new PointInfo();
                    p1.x = 100;
                    p1.y = 750;
                    PointInfo p2 = new PointInfo();
                    p2.x = p1.x + 900;
                    p2.y = p1.y;
                    note.noteFreehand.points = new PointInfo[] { p1, p2 };

                    note.noteFreehand.width = 20; // Pen width

                    note.color = NetColorToEloColor(System.Drawing.Color.Violet);

                    notes.Add(note);
                }

                // Freehand line (this example draws a circle)
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_FREEHAND, null);
                    List<PointInfo> points = new List<PointInfo>();
                    for (int i = 0; i < 360; i += 5)
                    {
                        double alpha = 2 * Math.PI * (double) i / 360.0;
                        PointInfo p = new PointInfo();
                        p.x = 200 + (int)(Math.Sin(alpha) * 100);
                        p.y = 900 + (int)(Math.Cos(alpha) * 100);
                        points.Add(p);
                    }
                    note.noteFreehand.points = points.ToArray();

                    note.noteFreehand.width = 50; // Pen width

                    note.color = NetColorToEloColor(System.Drawing.Color.Tomato);

                    notes.Add(note);
                }

                // Draws a half-transparent rectangle
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_MARKER, null);
                    note.XPos = 400;
                    note.YPos = 800;
                    note.width = 300;
                    note.height = 200;
                    note.color = NetColorToEloColor(System.Drawing.Color.YellowGreen);

                    notes.Add(note);
                }

                // Draws a filled (opaque) rectangle
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_FILLEDRECTANGLE, null);
                    note.XPos = 800;
                    note.YPos = 800;
                    note.width = 300;
                    note.height = 200;
                    note.color = NetColorToEloColor(System.Drawing.Color.YellowGreen);

                    notes.Add(note);
                }

                // Draws a strikeout line
                if (true)
                {
                    Note note = ix.Ix.createNote2(ed.document.objId, NoteC.TYPE_ANNOTATION_STRIKEOUT, null);
                    
                    PointInfo p1 = new PointInfo();
                    p1.x = 100;
                    p1.y = 1100;
                    PointInfo p2 = new PointInfo();
                    p2.x = p1.x + 900;
                    p2.y = p1.y;
                    note.noteFreehand.points = new PointInfo[] { p1, p2 };

                    note.noteFreehand.width = 100;
                    note.noteFreehand.strikeoutWidth = 20;
                    note.noteFreehand.strikeoutColor = NetColorToEloColor(System.Drawing.Color.Red);

                    note.color = NetColorToEloColor(System.Drawing.Color.Yellow);

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

        public static int NetColorToEloColor(System.Drawing.Color ncolor)
        {
            int col = ncolor.ToArgb();
            int rgb = ((col & 0xff) << 16) | (col & 0xff00) | ((col >> 16) & 0xff);
            return rgb;
        }

        public static System.Drawing.Color EloColorToNetColor(int rgb)
        {
            return System.Drawing.Color.FromArgb(((rgb & 0xff) << 16) | (rgb & 0xff00) | ((rgb >> 16) & 0xff));
        }
    }
}
