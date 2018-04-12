using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW;

namespace ExamplesFW
{
  public partial class FormExplorer : Form
  {
    public FormExplorer()
    {
      InitializeComponent();
    }

    public static void DoDialog(FWConnection conn, String parentId)
    {
      FormExplorer dialog = new FormExplorer();
      dialog.arcTreeView1.Conn = conn; dialog.arcTreeView1.ShowDocuments = true;
      dialog.sordListView1.ColumnHeaderArcPath.Width = 0;
      dialog.sordListView1.ColumnHeaderMaskName.Width = 0;
      dialog.sordListView1.ColumnHeaderIDate.Width = 0;
      dialog.sordListView1.ColumnHeaderOwner.Width = 0;
      dialog.sordListView1.ColumnHeaderVersion.Width = 0;
      dialog.sordListView1.ColumnHeaderVersionDate.Width = 0;
      dialog.sordListView1.ColumnHeaderVersionUser.Width = 0;
      dialog.sordListView1.ColumnHeaderLockName.Width = 100;
       
      //dialog.sordListView1.ColumnHeaderVersion.DisplayIndex = 1;
      dialog.ShowDialog();
    }

    private void neuerOrdnerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      arcTreeView1.NewFolder();
    }

    private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      arcTreeView1.DeleteSord();
    }

    private void umbenennenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      arcTreeView1.BeginEditSordName();
    }

    private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      arcTreeView1.Refresh();
    }
  }
}
