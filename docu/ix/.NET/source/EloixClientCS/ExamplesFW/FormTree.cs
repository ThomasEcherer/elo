using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Controls;

namespace ExamplesFW
{
  public partial class FormTree : Form
  {
    private bool lockSelectedPathChanged = false;
    private String PROFILE_OPTION_TREE_PATH = "FormTree.arcTreeView1.path";

    private ContextMenuStrip _arcTreeContextMenu;

    public FormTree()
    {
      InitializeComponent();
    }

    public static void ShowTree(FWConnection conn, FWFolder parentFolder)
    {
      FormTree frm = new FormTree();
      frm.arcTreeView1.ParentFolder = parentFolder;
      frm.ckShowDocuments.Checked = frm.arcTreeView1.ShowDocuments;
      frm.ckShowReferences.Checked = frm.arcTreeView1.ShowReferences;
      frm.ckAllowDrag.Checked = frm.arcTreeView1.AllowDrag;
      frm.ckAllowDrop.Checked = frm.arcTreeView1.AllowDrop;
      frm.ckAllowOpenDocument.Checked = frm.arcTreeView1.AllowOpenDocument;
      frm.ShowDialog();
    }

    private void bnClose_Click(object sender, EventArgs e)
    {

    }

    private void FormTree_Load(object sender, EventArgs e)
    {
      String path = null;
      if (arcTreeView1.Conn.Session.UserProfile.Application.TryGetValue(PROFILE_OPTION_TREE_PATH, out path))
      {
        arcTreeView1.SelectedPath = path;
      }

      BuildContextMenu();
    }

    private void BuildContextMenu()
    {
        _arcTreeContextMenu = new ContextMenuStrip();

        ToolStripMenuItem tsmiDummy = new ToolStripMenuItem();
        tsmiDummy.Name = "tsmiDummy";
        tsmiDummy.Text = "Dummy";

        _arcTreeContextMenu.Items.Add(tsmiDummy);
        _arcTreeContextMenu.Opening += new CancelEventHandler(_arcTreeContextMenu_Opening);
        arcTreeView1.ContextMenuStrip = _arcTreeContextMenu;
    }

    void _arcTreeContextMenu_Opening(object sender, CancelEventArgs e)
    {
        Point p = arcTreeView1.PointToClient(MousePosition);
        TreeNode activeTreeNode = arcTreeView1.GetNodeAt(p);

        if (activeTreeNode == null)
        {
            e.Cancel = true;
            return;
        }

        FWSord sord = arcTreeView1.GetSordFromNode(activeTreeNode);
        sord = sord.Conn.Content.GetSord(sord.Id);

        if (sord is FWDocument)
        {
            ToolStripMenuItem tsmiReferences = (ToolStripMenuItem)_arcTreeContextMenu.Items[0];
            if (tsmiReferences == null)
                return;

            tsmiReferences.DropDownItems.Clear();

            FWDocument document = sord as FWDocument;
            EloixClient.IndexServer.ArcPath[] refPaths = sord.RefPaths;
            foreach (EloixClient.IndexServer.ArcPath refPath in refPaths)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                //tsmi.Text = arcTreeView1.GetAbsoluteArcPathString(refPath, document.Id, document.Name, nodePath[0], "//"); //BuildRefPathString(nodePath[0], refPath.path, _activeTreeNode.Text);
                //tsmi.Tag = _arcTreeViewEx.GetAbsoluteArcPathString(refPath, document.Id, document.Name, nodePath[0]);
                tsmi.Text = sord.ArcPathString;

                //tsmi.Click += new EventHandler(tsmiRefPath_Click);
                //IdName[] idNames = refPath.path;

                //if ((idNames.Length == 0 && nodePath.Count == 2) || (idNames.Length > 0 && nodePath.Count > 2 && idNames[idNames.Length - 1].name.Equals(nodePath[nodePath.Count - 2])))
                //{
                //    tsmi.Checked = true;
                //}

                tsmiReferences.DropDownItems.Add(tsmi);
            }
        }
    }

    private void arcTreeView1_TreeDoubleClick(TreeNode tn, FWSord sord)
    {
      
    }

    private void ckShowDocuments_CheckedChanged(object sender, EventArgs e)
    {
      arcTreeView1.ShowDocuments = ckShowDocuments.Checked;
    }

    private void ckShowReferences_CheckedChanged(object sender, EventArgs e)
    {
      arcTreeView1.ShowReferences = ckShowReferences.Checked;
    }

    private void ckAllowDrag_CheckedChanged(object sender, EventArgs e)
    {
      arcTreeView1.AllowDrag = ckAllowDrag.Checked;
    }

    private void ckAllowDrop_CheckedChanged(object sender, EventArgs e)
    {
      arcTreeView1.AllowDrop = ckAllowDrop.Checked;
    }

    private void arcTreeView1_AfterCheckin(EloixClientUI.Common.CheckinEventArgs e)
    {
      MessageBox.Show("new sord, id=" + e.Sord.Id);
    }

    private void arcTreeView1_BeforeCheckin(EloixClientUI.Common.CheckinEventArgs e)
    {
      FWSord parentSord = arcTreeView1.Conn.Content.GetFolder(e.ParentId);
      if (MessageBox.Show("Do you want to checkin " + e.Sord.Name + " into " + parentSord + "?", 
        "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
      {
        e.Cancel = true;
      }
    }

    private void bnClose_Click_1(object sender, EventArgs e)
    {

    }

    private void edSelectedPath_TextChanged(object sender, EventArgs e)
    {
      if (lockSelectedPathChanged) return;
      arcTreeView1.SelectedPath = edSelectedPath.Text;
    }

    private void arcTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      lockSelectedPathChanged = true;
      edSelectedPath.Text = arcTreeView1.SelectedPath;
      lockSelectedPathChanged = false;
    }

    private void FormTree_FormClosed(object sender, FormClosedEventArgs e)
    {
      String path = arcTreeView1.SelectedPath;
      arcTreeView1.Conn.Session.UserProfile.Application[PROFILE_OPTION_TREE_PATH] = path;
    }

  }
}
