namespace ExamplesFW
{
  partial class FormSordList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSordList));
      this.panel1 = new System.Windows.Forms.Panel();
      this.bnGotoLast = new System.Windows.Forms.Button();
      this.bnGotoFirst = new System.Windows.Forms.Button();
      this.lbSelect = new System.Windows.Forms.Label();
      this.edSelection = new System.Windows.Forms.TextBox();
      this.bnClose = new System.Windows.Forms.Button();
      this.sordListView1 = new EloixClientUI.Controls.SordListView();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.bnGotoLast);
      this.panel1.Controls.Add(this.bnGotoFirst);
      this.panel1.Controls.Add(this.lbSelect);
      this.panel1.Controls.Add(this.edSelection);
      this.panel1.Controls.Add(this.bnClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(500, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(152, 457);
      this.panel1.TabIndex = 6;
      // 
      // bnGotoLast
      // 
      this.bnGotoLast.Location = new System.Drawing.Point(13, 119);
      this.bnGotoLast.Name = "bnGotoLast";
      this.bnGotoLast.Size = new System.Drawing.Size(129, 23);
      this.bnGotoLast.TabIndex = 10;
      this.bnGotoLast.Text = "Goto Last";
      this.bnGotoLast.UseVisualStyleBackColor = true;
      this.bnGotoLast.Click += new System.EventHandler(this.bnGotoLast_Click);
      // 
      // bnGotoFirst
      // 
      this.bnGotoFirst.Location = new System.Drawing.Point(13, 90);
      this.bnGotoFirst.Name = "bnGotoFirst";
      this.bnGotoFirst.Size = new System.Drawing.Size(129, 23);
      this.bnGotoFirst.TabIndex = 9;
      this.bnGotoFirst.Text = "Goto first";
      this.bnGotoFirst.UseVisualStyleBackColor = true;
      this.bnGotoFirst.Click += new System.EventHandler(this.bnGotoFirst_Click);
      // 
      // lbSelect
      // 
      this.lbSelect.AutoSize = true;
      this.lbSelect.Location = new System.Drawing.Point(15, 17);
      this.lbSelect.Name = "lbSelect";
      this.lbSelect.Size = new System.Drawing.Size(85, 13);
      this.lbSelect.TabIndex = 8;
      this.lbSelect.Text = "Selected indices";
      // 
      // edSelection
      // 
      this.edSelection.Location = new System.Drawing.Point(13, 33);
      this.edSelection.Name = "edSelection";
      this.edSelection.Size = new System.Drawing.Size(129, 20);
      this.edSelection.TabIndex = 7;
      this.edSelection.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // bnClose
      // 
      this.bnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bnClose.Location = new System.Drawing.Point(13, 174);
      this.bnClose.Name = "bnClose";
      this.bnClose.Size = new System.Drawing.Size(129, 23);
      this.bnClose.TabIndex = 6;
      this.bnClose.Text = "Close";
      this.bnClose.UseVisualStyleBackColor = true;
      this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
      // 
      // sordListView1
      // 
      this.sordListView1.AllowDrag = false;
      this.sordListView1.AllowOpenDocument = true;
      this.sordListView1.Conn = null;
      this.sordListView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sordListView1.HideSelection = false;
      this.sordListView1.Location = new System.Drawing.Point(0, 0);
      this.sordListView1.Name = "sordListView1";
      this.sordListView1.ObjectsCache = null;
      this.sordListView1.SelectedIndices = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("sordListView1.SelectedIndices")));
      this.sordListView1.ShowObjKeyColumns = false;
      this.sordListView1.Size = new System.Drawing.Size(500, 457);
      this.sordListView1.SordsCache = null;
      this.sordListView1.TabIndex = 7;
      this.sordListView1.UseCompatibleStateImageBehavior = false;
      this.sordListView1.View = System.Windows.Forms.View.Details;
      this.sordListView1.VirtualMode = true;
      this.sordListView1.SelectedIndexChanged += new System.EventHandler(this.sordListView1_SelectedIndexChanged);
      // 
      // FormSordList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(652, 457);
      this.Controls.Add(this.sordListView1);
      this.Controls.Add(this.panel1);
      this.Name = "FormSordList";
      this.Text = "FormSordList";
      this.Load += new System.EventHandler(this.FormSordList_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button bnGotoLast;
    private System.Windows.Forms.Button bnGotoFirst;
    private System.Windows.Forms.Label lbSelect;
    private System.Windows.Forms.TextBox edSelection;
    private System.Windows.Forms.Button bnClose;
    private EloixClientUI.Controls.SordListView sordListView1;
  }
}