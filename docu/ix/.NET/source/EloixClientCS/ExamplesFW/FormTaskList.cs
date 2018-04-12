using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW.Workflow;
using EloixClient.IndexServerFW;

namespace ExamplesFW
{
  public partial class FormTaskList : Form
  {
    public FormTaskList()
    {
      InitializeComponent();
    }

    public static void ShowList(FWConnection conn, FWFindTasksCache tasksCache)
    {
      FormTaskList frm = new FormTaskList();
      frm.taskListView1.Conn = conn;
      frm.taskListView1.TasksCache = tasksCache;
      frm.ShowDialog();
    }


  }
}
