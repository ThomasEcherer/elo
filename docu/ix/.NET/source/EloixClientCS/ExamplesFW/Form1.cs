using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.Workflow;
using EloixClientUI.Dialogs;
using System.IO;
using EloixClient.IndexServerFW.Utils;



namespace ExamplesFW
{
  /// <summary>
  /// Example Form
  /// </summary>
  public partial class Form1 : Form
  {
    /// <summary>
    /// URL to IndexServer
    /// </summary>
    //String url = "http://srvpelo1:6080/ix-lldo_prod/ix";
    //String url = "https://srvt02:8443/ix-elo70/ix";
    //string url = "http://srvt02:8080/ix-elo80/ix";
    //String url = "http://localhost:8084/ix/ix";
    string url = "http://localhost:8084/ix-elo100/ix";
    /// <summary>
    /// ELO user name
    /// </summary>
    String userName = "Administrator";
    /// <summary>
    /// Password of userName
    /// </summary>
    String userPwd = "elo";

    /// <summary>
    /// Connection object
    /// </summary>
    FWConnection conn;

    /// <summary>
    /// True, if ELOFS is installed and its session should be used.
    /// </summary>
    bool useELOFS = false;


    /// <summary>
    /// Constructor, creates the connection to IndexServer
    /// </summary>
    public Form1()
    {
      try
      {
        // Connection to IndexServer
        FWConnFactory connFact = new FWConnFactory(url, "ExampleFW", "1.0");
        try
        {
        conn = connFact.CreateSso(System.Environment.MachineName);
        MessageBox.Show("SSO successful");
        }
        catch (Exception e)
        {
                    MessageBox.Show(e.ToString());
                    conn = connFact.Create(null, userName, userPwd, System.Environment.MachineName, null);
        }

        if (conn != null)
        {
            ///////////////////////
            // encrypt and decrypt documents
            conn.Session.Options[SessionOptionsC.ENCRYPT_DOCUMENTS] = "true";
            conn.Session.Options[SessionOptionsC.DECRYPT_DOCUMENTS] = "true";
            conn.Session.Options.Checkin();
            // supply encryption password
            //conn.Session.EncrPasswords["1"] = "elo";
            //conn.Session.EncrPasswords.Checkin();
        }

        InitializeComponent();
      }
      catch (Exception e)
      {
        System.Windows.Forms.MessageBox.Show(e.ToString());
      }

      this.Icon = EloixClientUI.Properties.Resources.MainIcon;
    }

private void incrSordCounter(IXConnection conn, int objId)
{
    SordZ sordZ = new SordZ(SordC.mbObjKeys);
    Sord sord = null;
    try
    {
        sord = readSord(conn, objId, sordZ);

        foreach (ObjKey okey in sord.objKeys)
        {
            if (okey.name == "COUNTER")
            {
                int current = Convert.ToInt32(okey.data[0]);
                okey.data = new String[] { Convert.ToString(current + 1) };
                break;
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Cannot increment Sord counter, sord.id=" + objId + ", error=" + e);
    }
    finally
    {
        if (sord != null)
        {
            writeSord(conn, sord, sordZ);
        }
    }
}

private Sord readSord(IXConnection conn, int objId, SordZ sordZ)
{
    Sord ret = null;
    try
    {
        EditInfoZ editZ = new EditInfoZ(0, sordZ);
        EditInfo ed = conn.Ix.checkoutSord(Convert.ToString(objId), editZ, LockC.IF_FREE);
        ret = ed.sord;
    }
    catch (Exception e)
    {
        throw new IOException("Cannot read sord, sord.id=" + objId, e);
    }
    return ret;
}

private void writeSord(IXConnection conn, Sord sord, SordZ sordZ)
{
    conn.Ix.checkinSord(sord, sordZ, LockC.YES);
}


    /// <summary>
    /// This function shows how to list sub items of a given folder.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bnSubItems_Click(object sender, EventArgs e)
    {
      // get parent folder
      FWFolder parentFolder = conn.Content.GetFolder(edObjId.Text);

      // get sub folders
      IResultCache<FWSord> subFolders = parentFolder.Folders;
      FormListbox.ShowList("Sub Folders", subFolders);

      // list documents
      IResultCache<FWSord> docs = parentFolder.Documents;
      FormListbox.ShowList("Documents", docs);

      // list all sub items (folders + documents)
      IResultCache<FWSord> sords = parentFolder.Sords;
      FormListbox.ShowList("Sub Items", sords);

    }

    /// <summary>
    /// Display document
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bnShowDoc_Click(object sender, EventArgs e)
    {
      try
      {
        // Get document object
        FWDocument doc = conn.Content.GetDocument(edObjId.Text);

        // Download the current version into a temporary directory 
        String file = doc.File;

        // Start Explorer to display the document file
        System.Diagnostics.Process.Start(file);
      }
      catch (Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Checkout/checkin document.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void checkoutDocument_Click(object sender, EventArgs e)
    {
      try {

          FWSord sord = conn.Content.GetSord(edObjId.Text);
          ArcPath[] arcPath = sord.RefPaths;

          Sord sord2 = conn.Ix.checkoutSord(edObjId.Text, EditInfoC.mbAll, LockC.NO).sord;
          ArcPath[] arcPath2 = sord2.refPaths;


        // Get document locked
        FWDocument doc = conn.Content.LockDocument(edObjId.Text);
        if (doc == null) return;

        // Download the documents file
        String file = doc.File; // same as doc.Version.File

        // Start application to edit the file
        System.Diagnostics.Process.Start(file);
        
        if (MessageBox.Show("Checkin?", "Checkin or unlock", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            MD5 md5 = new MD5(doc.File);
            if (!md5.ToString().Equals(doc.Version.Core.md5))
            {
                doc.Version.Version = conn.DateToIso(DateTime.Now);
                doc.Version.Comment = "New version " + doc.Version.Version;
                doc.Checkin();
            }
            else
            {
                doc.Unlock();
            }
        }
        else
        {
          doc.Unlock();
        }

      }
      catch (Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.ToString());
      }
    }

    private void btnCreateDocFromTempl_Click(object sender, EventArgs e)
    {
        string name = "test-" + conn.DateToIso(DateTime.Now);

        // Archiveintrag für neues Dokument ohne Datei anlegen
        FWDocument doc = conn.Content.CreateDocument("1", "Email");
        doc.Name = name;

        doc.ObjKeys["ELOOUTL1"].Value = "albert@berta.com";
        doc.ObjKeys["ELOOUTL2"].Value = "charlotte@dorothea.com";

        doc.Checkin();

        // Vorlage ermitteln
        FWDocument templ = conn.Content.GetDocument("21318");

        // Vorlagedatei dem Dokument zuordnen
        conn.Content.ApplyDocumentTemplate(doc, templ);


        // .... Dokument ändern, Programm neu starten



        // Dokument aus dem Checkout-Verzeichnis ermitteln
        string[] filesCo = conn.Content.CheckedOutDocumentsManager.GetCheckedoutFiles(new string[] { "xml" });
        foreach (string destFile in filesCo)
        {
            if (destFile.IndexOf(name) >= 0)
            {
                doc = conn.Content.DownloadManager.GetFWDocumentFromFile(destFile);

                //Einchecken
                doc.Checkin();
            }
        }
    }

    /// <summary>
    /// Create a new document, set/add index values.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void createDocument_Click(object sender, EventArgs e)
    {
        FWFolder folder = conn.Content.GetFolder(edObjId.Text);

        FWDocument doc = conn.Content.CreateDocument(Convert.ToString(folder.Id), "Email");
        doc.Version.File = "c:\\elofsinst.log";

        doc.ObjKeys["ELOOUTL1"].Value = "albert@berta.com";
        doc.ObjKeys["ELOOUTL2"].Value = "charlotte@dorothea.com";

        doc.Checkin();
    }

    /// <summary>
    /// Find sords.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bnFindSords_Click(object sender, EventArgs e)
    {
      // Prompt for short description
      String s = InputBox.Show("Find", "Short description:");
      if (s != null && s.Length != 0)
      {
        // Prepare FindInfo object
        FindInfo findInfo = new FindInfo();
        findInfo.findByIndex = new FindByIndex();
        findInfo.findByIndex.name = s;

        this.Cursor = Cursors.WaitCursor;
        try
        {
          // Find
          FWFindSordsCache<FWSord> findCache = conn.Content.FindSords(findInfo);

          // Before retrieving any results, set the Sord members to be read from the archive
          findCache.SordZ.bset |= SordC.mbRefPaths|SordC.mbDocVersionMembers;

          // Show result in list box
          FormSordList.ShowList(conn, findCache);

        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
      }
    }

    private void showArcTree_Click(object sender, EventArgs e)
    {
      FormTree.ShowTree(conn, conn.Content.GetFolder(edObjId.Text));
    }

    private void rbObjId_CheckedChanged(object sender, EventArgs e)
    {
      if (rbObjId.Checked)
      {
        edObjId.Text = "1";
      }
    }

    private void rbArcPath_CheckedChanged(object sender, EventArgs e)
    {
      if (rbArcPath.Checked)
      {
        edObjId.Text = "ARCPATH:/<folder1>/<folder2>/document1";
      }
    }

    private void rbFsPath_CheckedChanged(object sender, EventArgs e)
    {
      if (rbFsPath.Checked)
      {
        edObjId.Text = "FSPATH:/<folder1>/<folder2>/document1.doc";
      }
    }

    private void rbObjKey_CheckedChanged(object sender, EventArgs e)
    {
      if (rbObjKey.Checked)
      {
        edObjId.Text = "OKEY:<GROUP>=<value>";
      }
    }

    private void rbMD5_CheckedChanged(object sender, EventArgs e)
    {
      if (rbMD5.Checked)
      {
        edObjId.Text = "MD5:<md5-hash>";
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      conn.Logout();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void bnTasks_Click(object sender, EventArgs e)
    {
      FWFindTasksCache taskCache = conn.Workflow.GetUserTasks();
      FormTaskList.ShowList(conn, taskCache);
    }

    private void bnUserListView_Click(object sender, EventArgs e)
    {
      List<int> selectIds = new List<int>();
      selectIds.Add(1);

      FormSelectUser frm = FormSelectUser.Create(conn,
        FormSelectUserFlags.ShowGroups | FormSelectUserFlags.MultiSelect, 
        selectIds, null);
      frm.Icon = EloixClientUI.Properties.Resources.MainIcon;

      if (frm.ShowDialog() == DialogResult.OK)
      {
        StringBuilder sbuf = new StringBuilder();
        sbuf.Append("Selected users=");
        foreach (UserName un in frm.SelectedUsers)
        {
          sbuf.Append(un.name).Append(",");
        }
        System.Windows.Forms.MessageBox.Show(sbuf.ToString());
      }

    }

    private void bnTextBoxKeyword_Click(object sender, EventArgs e)
    {
        FormTextBoxKeyword.DoDialog(conn, KeywordC.KWID_STANDARD_LIST);
        //FormTextBoxKeyword.DoDialog(conn, KeywordC.KWID_USER_LIST);
    }

    private void bnArcExplorer_Click(object sender, EventArgs e)
    {
      FormExplorer.DoDialog(conn, edObjId.Text);
    }

    private void bnNewVersion_Click(object sender, EventArgs e)
    {

    }

    private void bnShowCheckedout_Click(object sender, EventArgs e)
    {
      IFWCheckedOutDocumentsManager mgr = conn.Content.CheckedOutDocumentsManager;
      string[] files = mgr.GetCheckedoutFiles(new string[] { "doc", "docx", "txt" });
      FormListbox.ShowList("Checkout", files);
    }


  }
}
