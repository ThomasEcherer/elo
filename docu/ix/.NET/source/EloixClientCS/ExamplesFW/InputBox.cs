using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamplesFW
{
  public partial class InputBox : Form
  {
    public InputBox()
    {
      InitializeComponent();
    }

    public static String Show(String caption, String prompt)
    {
      InputBox frm = new InputBox();
      frm.Text = caption;
      frm.label1.Text = prompt;
      
      String ret = "";
      if (frm.ShowDialog() == DialogResult.OK)
      {
        return frm.textBox1.Text;
      }

      return ret;
    }

  }
}
