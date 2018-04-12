using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW;
using EloixClientUI.Dialogs;
using EloixClient.IndexServer;

namespace ExamplesFW
{
  public partial class FormTextBoxKeyword : Form
  {
    public FormTextBoxKeyword()
    {
      InitializeComponent();
    }

    public static void DoDialog(FWConnection conn, String keywordListId)
    {
      FormTextBoxKeyword dlg = new FormTextBoxKeyword();
      dlg.keywordTextBox1.KeywordList = conn.MasterData.Keywords[keywordListId];
      dlg.keywordTextBox2.KeywordList = conn.MasterData.Keywords[keywordListId];
      dlg.keywordTextBox3.KeywordList = conn.MasterData.Keywords[KeywordC.KWID_USER_LIST];
      dlg.ShowDialog();
    }

    private void keywordTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void FormTextBoxKeyword_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      //FormKeywordList dlg = new FormKeywordList();
      //dlg.ShowDialog();
      FormKeywordList.ShowToolWindow(this, null, "", false, Bounds);
    }
  }
}
