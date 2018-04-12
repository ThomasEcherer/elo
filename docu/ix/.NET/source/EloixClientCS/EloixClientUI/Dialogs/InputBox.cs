using System;
using System.Windows.Forms;

namespace EloixClientUI.Dialogs
{
  public partial class InputBox : Form
  {
    public InputBox()
    {
      InitializeComponent();
    }

    public static String DoDialog(String labelText)
    {
      InputBox dialog = new InputBox();
      dialog.Text = EloixClientUI.Properties.Resources.InputBoxCaption;
      dialog.label1.Text = labelText;
      dialog.Icon = EloixClientUI.Properties.Resources.MainIcon;
      String ret = "";
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        ret = dialog.textBox1.Text;
      }
      return ret;
    }
  }
}
