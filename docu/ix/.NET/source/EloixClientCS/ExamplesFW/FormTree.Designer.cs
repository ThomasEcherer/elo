namespace ExamplesFW
{
  partial class FormTree
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
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.edSelectedPath = new System.Windows.Forms.TextBox();
      this.ckAllowOpenDocument = new System.Windows.Forms.CheckBox();
      this.ckAllowDrop = new System.Windows.Forms.CheckBox();
      this.ckAllowDrag = new System.Windows.Forms.CheckBox();
      this.ckShowReferences = new System.Windows.Forms.CheckBox();
      this.ckShowDocuments = new System.Windows.Forms.CheckBox();
      this.bnClose = new System.Windows.Forms.Button();
      this.arcTreeView1 = new EloixClientUI.Controls.ArcTreeView();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.edSelectedPath);
      this.panel2.Controls.Add(this.ckAllowOpenDocument);
      this.panel2.Controls.Add(this.ckAllowDrop);
      this.panel2.Controls.Add(this.ckAllowDrag);
      this.panel2.Controls.Add(this.ckShowReferences);
      this.panel2.Controls.Add(this.ckShowDocuments);
      this.panel2.Controls.Add(this.bnClose);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel2.Location = new System.Drawing.Point(336, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(226, 295);
      this.panel2.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 136);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Selected Path";
      // 
      // edSelectedPath
      // 
      this.edSelectedPath.Location = new System.Drawing.Point(12, 153);
      this.edSelectedPath.Name = "edSelectedPath";
      this.edSelectedPath.Size = new System.Drawing.Size(202, 20);
      this.edSelectedPath.TabIndex = 10;
      this.edSelectedPath.TextChanged += new System.EventHandler(this.edSelectedPath_TextChanged);
      // 
      // ckAllowOpenDocument
      // 
      this.ckAllowOpenDocument.AutoSize = true;
      this.ckAllowOpenDocument.Location = new System.Drawing.Point(12, 94);
      this.ckAllowOpenDocument.Name = "ckAllowOpenDocument";
      this.ckAllowOpenDocument.Size = new System.Drawing.Size(126, 17);
      this.ckAllowOpenDocument.TabIndex = 9;
      this.ckAllowOpenDocument.Text = "AllowOpenDocument";
      this.ckAllowOpenDocument.UseVisualStyleBackColor = true;
      // 
      // ckAllowDrop
      // 
      this.ckAllowDrop.AutoSize = true;
      this.ckAllowDrop.Location = new System.Drawing.Point(12, 71);
      this.ckAllowDrop.Name = "ckAllowDrop";
      this.ckAllowDrop.Size = new System.Drawing.Size(74, 17);
      this.ckAllowDrop.TabIndex = 8;
      this.ckAllowDrop.Text = "AllowDrop";
      this.ckAllowDrop.UseVisualStyleBackColor = true;
      this.ckAllowDrop.CheckedChanged += new System.EventHandler(this.ckAllowDrop_CheckedChanged);
      // 
      // ckAllowDrag
      // 
      this.ckAllowDrag.AutoSize = true;
      this.ckAllowDrag.Location = new System.Drawing.Point(12, 48);
      this.ckAllowDrag.Name = "ckAllowDrag";
      this.ckAllowDrag.Size = new System.Drawing.Size(74, 17);
      this.ckAllowDrag.TabIndex = 7;
      this.ckAllowDrag.Text = "AllowDrag";
      this.ckAllowDrag.UseVisualStyleBackColor = true;
      this.ckAllowDrag.CheckedChanged += new System.EventHandler(this.ckAllowDrag_CheckedChanged);
      // 
      // ckShowReferences
      // 
      this.ckShowReferences.AutoSize = true;
      this.ckShowReferences.Location = new System.Drawing.Point(12, 25);
      this.ckShowReferences.Name = "ckShowReferences";
      this.ckShowReferences.Size = new System.Drawing.Size(108, 17);
      this.ckShowReferences.TabIndex = 6;
      this.ckShowReferences.Text = "ShowReferences";
      this.ckShowReferences.UseVisualStyleBackColor = true;
      this.ckShowReferences.CheckedChanged += new System.EventHandler(this.ckShowReferences_CheckedChanged);
      // 
      // ckShowDocuments
      // 
      this.ckShowDocuments.AutoSize = true;
      this.ckShowDocuments.Location = new System.Drawing.Point(12, 2);
      this.ckShowDocuments.Name = "ckShowDocuments";
      this.ckShowDocuments.Size = new System.Drawing.Size(107, 17);
      this.ckShowDocuments.TabIndex = 5;
      this.ckShowDocuments.Text = "ShowDocuments";
      this.ckShowDocuments.UseVisualStyleBackColor = true;
      this.ckShowDocuments.CheckedChanged += new System.EventHandler(this.ckShowDocuments_CheckedChanged);
      // 
      // bnClose
      // 
      this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnClose.Location = new System.Drawing.Point(44, 245);
      this.bnClose.Name = "bnClose";
      this.bnClose.Size = new System.Drawing.Size(75, 23);
      this.bnClose.TabIndex = 4;
      this.bnClose.Text = "Close";
      this.bnClose.UseVisualStyleBackColor = true;
      this.bnClose.Click += new System.EventHandler(this.bnClose_Click_1);
      // 
      // arcTreeView1
      // 
      this.arcTreeView1.AllowDrag = true;
      this.arcTreeView1.AllowDrop = true;
      this.arcTreeView1.AllowOpenDocument = true;
      this.arcTreeView1.Conn = null;
      this.arcTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.arcTreeView1.HideSelection = false;
      this.arcTreeView1.Location = new System.Drawing.Point(0, 0);
      this.arcTreeView1.Name = "arcTreeView1";
      this.arcTreeView1.ParentFolder = null;
      this.arcTreeView1.SelectedPath = "";
      this.arcTreeView1.ShowDocuments = true;
      this.arcTreeView1.ShowReferences = true;
      this.arcTreeView1.Size = new System.Drawing.Size(336, 295);
      this.arcTreeView1.TabIndex = 6;
      this.arcTreeView1.BeforeCheckin += new EloixClientUI.Common.DocumentDataObject.CheckinHandler(this.arcTreeView1_BeforeCheckin);
      this.arcTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.arcTreeView1_AfterSelect);
      this.arcTreeView1.AfterCheckin += new EloixClientUI.Common.DocumentDataObject.CheckinHandler(this.arcTreeView1_AfterCheckin);
      // 
      // FormTree
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(562, 295);
      this.Controls.Add(this.arcTreeView1);
      this.Controls.Add(this.panel2);
      this.Name = "FormTree";
      this.Text = "FormTree";
      this.Load += new System.EventHandler(this.FormTree_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTree_FormClosed);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.CheckBox ckShowReferences;
    private System.Windows.Forms.CheckBox ckShowDocuments;
    private System.Windows.Forms.Button bnClose;
    private System.Windows.Forms.CheckBox ckAllowDrop;
    private System.Windows.Forms.CheckBox ckAllowDrag;
    private EloixClientUI.Controls.ArcTreeView arcTreeView1;
    private System.Windows.Forms.CheckBox ckAllowOpenDocument;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edSelectedPath;
  }
}