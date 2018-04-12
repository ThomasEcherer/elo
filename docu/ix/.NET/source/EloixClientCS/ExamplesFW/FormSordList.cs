using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;

namespace ExamplesFW
{
  public partial class FormSordList : Form
  {
    private bool lockEdSelection = false;
    private bool lockListViewSords = false;

    public FormSordList()
    {
      InitializeComponent();
    }

    public static void ShowList(FWConnection conn, FWFindSordsCache<FWSord> sordsCache)
    {
      FormSordList frm = new FormSordList();
      frm.sordListView1.Conn = conn;
      frm.sordListView1.SordsCache = sordsCache;
      if (frm.ShowDialog() == DialogResult.OK)
      {
        IEnumerable<FWSord> sords = frm.sordListView1.SelectedSords;
        StringBuilder sbuild = new StringBuilder();
        sbuild.Append("Selected Sords: ");
        foreach (FWSord sord in sords)
        {
          sbuild.Append(sord.Name).Append(",");
        }
        System.Windows.Forms.MessageBox.Show(sbuild.ToString());
      }
    }

    private void FormSordList_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (lockEdSelection) return;
      lockListViewSords = true;
      String s = edSelection.Text;
      String[] strIdxes = s.Split(',');
      List<int> lstIdxes = new List<int>();
      foreach (String sidx in strIdxes)
      {
        if (sidx.Trim().Length > 0) lstIdxes.Add(Convert.ToInt32(sidx));
      }
      sordListView1.SelectedIndices = lstIdxes;
      lockListViewSords = false;
    }

    private void bnGotoFirst_Click(object sender, EventArgs e)
    {
      sordListView1.EnsureVisible(0);
    }

    private void bnGotoLast_Click(object sender, EventArgs e)
    {
      sordListView1.EnsureVisible(-1);
    }

    private void sordListView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lockListViewSords) return;
      
      StringBuilder sbuf = new StringBuilder();
      foreach (int idx in sordListView1.SelectedIndices)
      {
        sbuf.Append(idx).Append(",");
      }
      lockEdSelection = true;
      edSelection.Text = sbuf.ToString();
      lockEdSelection = false;
      
    }

    private void bnClose_Click(object sender, EventArgs e)
    {

    }



  }
}
