using System;
using System.Drawing;
using System.Windows.Forms;
using EloixClient.IndexServerFW.MasterData;

namespace EloixClientUI.Dialogs
{
  public partial class FormKeywordList : Form
  {
    Control parentDialog;
    bool applyFilter;
    String keywordFilter;
    bool lockTextChanged;


    public FormKeywordList()
    {
      InitializeComponent();
    }


    public static String ShowToolWindow(Control parentDialog, FWKeyword keywordList, String keywordFilter, bool applyFilter, Rectangle rect)
    {
      FormKeywordList dlg = new FormKeywordList();

      dlg.keywordTreeView1.KeywordList = keywordList;
      dlg.parentDialog = parentDialog;
      dlg.applyFilter = applyFilter;
      dlg.keywordFilter = keywordFilter;

      Rectangle rectDlg = dlg.Bounds;

      Rectangle rectTextBox =
        dlg.RectangleToScreen(dlg.textBox1.Bounds);
      int top1 = dlg.textBox1.Top;

      int x = rect.Left - rectTextBox.Left;
      int y = rect.Top - rectTextBox.Top;
      int wd = rect.Width + 6;
      int ht = 200;

      Rectangle workingArea = Screen.GetWorkingArea(parentDialog);
      if (y + ht > workingArea.X + workingArea.Height)
      {
        int y1 = rect.Bottom + 3;
        y = y1 - ht;
        dlg.panel1.Dock = DockStyle.Bottom;
      }

      dlg.Bounds = new Rectangle(x, y, wd, ht);

      // .NET BUG? 
      // If MinimumSize is set, the dialog does not come to front
      // on ALT+TAB.
      //dlg.MinimumSize = new Size(wd, dlg.textBox1.Height + 6);

      String ret = null;
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        ret = dlg.keywordTreeView1.GetSelectedKeywordText();
      }
      return ret;
    }

    private void FormKeywordList_Load(object sender, EventArgs e)
    {
      keywordTreeView1.Dock = DockStyle.Fill;

      bnCancel.Left = bnCancel.Top = bnCancel.Width = bnCancel.Height = 0;
      bnOk.Left = bnOk.Top = bnOk.Width = bnOk.Height = 0;

      lockTextChanged = true;
      textBox1.Text = keywordFilter;
      lockTextChanged = false;

      if (applyFilter)
      {
        textBox1.SelectionStart = keywordFilter.Length;
        keywordTreeView1.KeywordFilter = keywordFilter;
      }
      else
      {
        textBox1.SelectAll();
      }

      textBox1.Focus();
    }

    private void bnOk_Click(object sender, EventArgs e)
    {
      keywordTreeView1.Checkin();

      if (keywordTreeView1.SelectedKeyword != null && keywordTreeView1.SelectedKeyword.Enabled)
      {
        this.DialogResult = DialogResult.OK;
      }
      else
      {
        if (keywordTreeView1.SelectedNode != null)
        {
          keywordTreeView1.SelectedNode.Expand();
        }
        this.DialogResult = DialogResult.None;
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (lockTextChanged) return;
      keywordTreeView1.KeywordFilter = textBox1.Text;
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
      {
        keywordTreeView1.Focus();
      }
    }

    private void keywordTreeView1_KeywordSelected(object sender, EventArgs e)
    {
      if (keywordTreeView1.SelectedKeyword != null && keywordTreeView1.SelectedKeyword.Enabled)
      {
        bnOk.PerformClick();
      }
    }

    private void bnCancel_Click(object sender, EventArgs e)
    {
    }

    private void FormKeywordList_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (keywordTreeView1.Modified)
      {
        String title = EloixClientUI.Properties.Resources.MsgBoxConfirm;
        String msg = EloixClientUI.Properties.Resources.QuerySaveModifiedKeywordList;
        DialogResult res = System.Windows.Forms.MessageBox.Show(msg, title, MessageBoxButtons.YesNoCancel);
        switch (res)
        {
          case DialogResult.Yes: 
            keywordTreeView1.Checkin();
            e.Cancel = false;
            break;
          case DialogResult.Cancel:
            e.Cancel = true;
            break;
          default:
            e.Cancel = false;
            break;
        }
      }
    }
          
  }
}
