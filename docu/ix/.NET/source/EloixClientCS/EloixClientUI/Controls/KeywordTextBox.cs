using System;
using System.Drawing;
using System.Windows.Forms;
using EloixClient.IndexServerFW.MasterData;
using EloixClientUI.Dialogs;

namespace EloixClientUI.Controls
{
  public partial class KeywordTextBox : ComboBox
  {
    protected FWKeyword keywordListValue;
    protected bool lockTextChanged;
    protected bool _isEditable;










    public KeywordTextBox()
    {
      InitializeComponent();
    }






    public bool Editable
    {
        get { return _isEditable; }
        set { _isEditable = value; }
    }



    public virtual FWKeyword KeywordList
    {
      get { return keywordListValue; }
      set { keywordListValue = value; InternalRefresh();  }
    }

    protected virtual void InternalRefresh()
    {
      Refresh();
    }

    protected override void OnTextChanged(EventArgs e)
    {
        if (DesignMode) return;
        if (_isEditable) return;
        if (lockTextChanged) return;
        base.OnTextChanged(e);
        BeginInvoke(new InvokeDelegate(ShowToolWindow));
    }

    protected override void OnDropDown(EventArgs e)
    {
      //base.OnDropDown(e);
      BeginInvoke(new InvokeDelegate(ShowToolWindow));
    }

    private delegate void InvokeDelegate();

    private void ShowToolWindow()
    {
      if (KeywordList != null)
      {
        lockTextChanged = true;
        Rectangle rect = this.Bounds;
        rect = Parent.RectangleToScreen(rect);

        bool applyFilter = this.SelectionLength == 0;

        String keywordText = this.Text;

        String s = FormKeywordList.ShowToolWindow(this.FindForm(), KeywordList, keywordText, applyFilter, rect);
        if (s != null)
        {
          this.Text = s;
          this.SelectAll();
        }
        else
        {
          this.Text = keywordText;
          this.SelectAll();
        }

        lockTextChanged = false;
      }
    }
  }
}
