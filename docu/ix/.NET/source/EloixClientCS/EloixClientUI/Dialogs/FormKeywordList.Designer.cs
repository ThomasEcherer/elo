namespace EloixClientUI.Dialogs
{
  partial class FormKeywordList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnSeparator = new System.Windows.Forms.Panel();
            this.bnOk = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.keywordTreeView1 = new EloixClientUI.Controls.KeywordTreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pnSeparator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 20);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pnSeparator
            // 
            this.pnSeparator.BackColor = System.Drawing.SystemColors.Control;
            this.pnSeparator.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSeparator.Location = new System.Drawing.Point(437, 0);
            this.pnSeparator.Name = "pnSeparator";
            this.pnSeparator.Size = new System.Drawing.Size(2, 16);
            this.pnSeparator.TabIndex = 2;
            // 
            // bnOk
            // 
            this.bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOk.Location = new System.Drawing.Point(368, 47);
            this.bnOk.Name = "bnOk";
            this.bnOk.Size = new System.Drawing.Size(75, 23);
            this.bnOk.TabIndex = 1;
            this.bnOk.TabStop = false;
            this.bnOk.Text = "OK";
            this.bnOk.UseVisualStyleBackColor = true;
            this.bnOk.Click += new System.EventHandler(this.bnOk_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Image = global::EloixClientUI.Properties.Resources.CloseButtonX;
            this.bnCancel.Location = new System.Drawing.Point(368, 73);
            this.bnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 22);
            this.bnCancel.TabIndex = 4;
            this.bnCancel.TabStop = false;
            this.bnCancel.UseVisualStyleBackColor = false;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // keywordTreeView1
            // 
            this.keywordTreeView1.AllowEdit = true;
            this.keywordTreeView1.HideSelection = false;
            this.keywordTreeView1.KeywordFilter = null;
            this.keywordTreeView1.KeywordList = null;
            this.keywordTreeView1.LabelEdit = true;
            this.keywordTreeView1.Location = new System.Drawing.Point(0, 47);
            this.keywordTreeView1.Modified = false;
            this.keywordTreeView1.Name = "keywordTreeView1";
            this.keywordTreeView1.Size = new System.Drawing.Size(121, 97);
            this.keywordTreeView1.TabIndex = 2;
            this.keywordTreeView1.KeywordSelected += new System.EventHandler(this.keywordTreeView1_KeywordSelected);
            // 
            // FormKeywordList
            // 
            this.AcceptButton = this.bnOk;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(443, 343);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.keywordTreeView1);
            this.Controls.Add(this.bnOk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKeywordList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Keyword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKeywordList_FormClosing);
            this.Load += new System.EventHandler(this.FormKeywordList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel pnSeparator;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button bnOk;
    private EloixClientUI.Controls.KeywordTreeView keywordTreeView1;
    private System.Windows.Forms.Button bnCancel;


  }
}