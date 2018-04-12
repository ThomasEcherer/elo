using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ExamplesFW
{
  public partial class FormListbox : Form
  {
    IEnumerable list;

    public FormListbox()
    {
      InitializeComponent();
    }

    private void FormListbox_Load(object sender, EventArgs e)
    {
      foreach (Object obj in list)
      {
        listBox1.Items.Add(obj.ToString());
      }
    }

    public static void ShowList(String dialogCaption, IEnumerable list)
    {
      FormListbox frm = new FormListbox();
      frm.Text = dialogCaption;
      frm.list = list;
      frm.ShowDialog();
    }
  }
}
