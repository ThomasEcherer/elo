namespace ExamplesFW
{
  partial class FormTaskList
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskList));
      this.panel1 = new System.Windows.Forms.Panel();
      this.bnClose = new System.Windows.Forms.Button();
      this.taskListView1 = new EloixClientUI.Controls.TaskListView();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.bnClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(417, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(150, 354);
      this.panel1.TabIndex = 0;
      // 
      // bnClose
      // 
      this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnClose.Location = new System.Drawing.Point(20, 12);
      this.bnClose.Name = "bnClose";
      this.bnClose.Size = new System.Drawing.Size(118, 22);
      this.bnClose.TabIndex = 0;
      this.bnClose.Text = "Close";
      this.bnClose.UseVisualStyleBackColor = true;
      // 
      // taskListView1
      // 
      this.taskListView1.AllowDrag = false;
      this.taskListView1.AllowOpenDocument = true;
      this.taskListView1.Conn = null;
      this.taskListView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.taskListView1.HideSelection = false;
      this.taskListView1.Location = new System.Drawing.Point(0, 0);
      this.taskListView1.Name = "taskListView1";
      this.taskListView1.ObjectsCache = null;
      this.taskListView1.Size = new System.Drawing.Size(417, 354);
      this.taskListView1.TabIndex = 1;
      this.taskListView1.TasksCache = null;
      this.taskListView1.UseCompatibleStateImageBehavior = false;
      this.taskListView1.View = System.Windows.Forms.View.Details;
      this.taskListView1.VirtualMode = true;
      // 
      // FormTaskList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bnClose;
      this.ClientSize = new System.Drawing.Size(567, 354);
      this.Controls.Add(this.taskListView1);
      this.Controls.Add(this.panel1);
      this.Name = "FormTaskList";
      this.Text = "FormTaskList";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button bnClose;
    private EloixClientUI.Controls.TaskListView taskListView1;
  }
}