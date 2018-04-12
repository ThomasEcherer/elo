namespace ExamplesFW
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
        this.createDocument = new System.Windows.Forms.Button();
        this.showArcTree = new System.Windows.Forms.Button();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.rbMD5 = new System.Windows.Forms.RadioButton();
        this.rbObjKey = new System.Windows.Forms.RadioButton();
        this.rbFsPath = new System.Windows.Forms.RadioButton();
        this.rbArcPath = new System.Windows.Forms.RadioButton();
        this.rbObjId = new System.Windows.Forms.RadioButton();
        this.edObjId = new System.Windows.Forms.TextBox();
        this.checkoutDocument = new System.Windows.Forms.Button();
        this.bnShowDoc = new System.Windows.Forms.Button();
        this.bnSubItems = new System.Windows.Forms.Button();
        this.bnFindSords = new System.Windows.Forms.Button();
        this.bnTasks = new System.Windows.Forms.Button();
        this.bnUserListView = new System.Windows.Forms.Button();
        this.bnTextBoxKeyword = new System.Windows.Forms.Button();
        this.bnArcExplorer = new System.Windows.Forms.Button();
        this.bnNewVersion = new System.Windows.Forms.Button();
        this.bnShowCheckedout = new System.Windows.Forms.Button();
        this.btnCreateDocFromTempl = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // createDocument
        // 
        this.createDocument.Location = new System.Drawing.Point(18, 246);
        this.createDocument.Name = "createDocument";
        this.createDocument.Size = new System.Drawing.Size(167, 23);
        this.createDocument.TabIndex = 8;
        this.createDocument.Text = "Create Document";
        this.createDocument.UseVisualStyleBackColor = true;
        this.createDocument.Click += new System.EventHandler(this.createDocument_Click);
        // 
        // showArcTree
        // 
        this.showArcTree.Location = new System.Drawing.Point(208, 158);
        this.showArcTree.Name = "showArcTree";
        this.showArcTree.Size = new System.Drawing.Size(167, 23);
        this.showArcTree.TabIndex = 10;
        this.showArcTree.Text = "ArcTreeView";
        this.showArcTree.UseVisualStyleBackColor = true;
        this.showArcTree.Click += new System.EventHandler(this.showArcTree_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.rbMD5);
        this.groupBox1.Controls.Add(this.rbObjKey);
        this.groupBox1.Controls.Add(this.rbFsPath);
        this.groupBox1.Controls.Add(this.rbArcPath);
        this.groupBox1.Controls.Add(this.rbObjId);
        this.groupBox1.Controls.Add(this.edObjId);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(532, 140);
        this.groupBox1.TabIndex = 12;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Object-ID";
        // 
        // rbMD5
        // 
        this.rbMD5.AutoSize = true;
        this.rbMD5.Location = new System.Drawing.Point(197, 117);
        this.rbMD5.Name = "rbMD5";
        this.rbMD5.Size = new System.Drawing.Size(76, 17);
        this.rbMD5.TabIndex = 8;
        this.rbMD5.Text = "MD5 Hash";
        this.rbMD5.UseVisualStyleBackColor = true;
        this.rbMD5.CheckedChanged += new System.EventHandler(this.rbMD5_CheckedChanged);
        // 
        // rbObjKey
        // 
        this.rbObjKey.AutoSize = true;
        this.rbObjKey.Location = new System.Drawing.Point(197, 94);
        this.rbObjKey.Name = "rbObjKey";
        this.rbObjKey.Size = new System.Drawing.Size(136, 17);
        this.rbObjKey.TabIndex = 7;
        this.rbObjKey.Text = "ObjKey, GROUP=value";
        this.rbObjKey.UseVisualStyleBackColor = true;
        this.rbObjKey.CheckedChanged += new System.EventHandler(this.rbObjKey_CheckedChanged);
        // 
        // rbFsPath
        // 
        this.rbFsPath.AutoSize = true;
        this.rbFsPath.Location = new System.Drawing.Point(197, 71);
        this.rbFsPath.Name = "rbFsPath";
        this.rbFsPath.Size = new System.Drawing.Size(160, 17);
        this.rbFsPath.TabIndex = 6;
        this.rbFsPath.Text = "Archive Path + Ext (FS Path)";
        this.rbFsPath.UseVisualStyleBackColor = true;
        this.rbFsPath.CheckedChanged += new System.EventHandler(this.rbFsPath_CheckedChanged);
        // 
        // rbArcPath
        // 
        this.rbArcPath.AutoSize = true;
        this.rbArcPath.Location = new System.Drawing.Point(196, 48);
        this.rbArcPath.Name = "rbArcPath";
        this.rbArcPath.Size = new System.Drawing.Size(86, 17);
        this.rbArcPath.TabIndex = 5;
        this.rbArcPath.Text = "Archive Path";
        this.rbArcPath.UseVisualStyleBackColor = true;
        this.rbArcPath.CheckedChanged += new System.EventHandler(this.rbArcPath_CheckedChanged);
        // 
        // rbObjId
        // 
        this.rbObjId.AutoSize = true;
        this.rbObjId.Checked = true;
        this.rbObjId.Location = new System.Drawing.Point(196, 25);
        this.rbObjId.Name = "rbObjId";
        this.rbObjId.Size = new System.Drawing.Size(102, 17);
        this.rbObjId.TabIndex = 4;
        this.rbObjId.TabStop = true;
        this.rbObjId.Text = "Object-ID/GUID";
        this.rbObjId.UseVisualStyleBackColor = true;
        this.rbObjId.CheckedChanged += new System.EventHandler(this.rbObjId_CheckedChanged);
        // 
        // edObjId
        // 
        this.edObjId.Location = new System.Drawing.Point(6, 19);
        this.edObjId.Name = "edObjId";
        this.edObjId.Size = new System.Drawing.Size(167, 20);
        this.edObjId.TabIndex = 3;
        this.edObjId.Text = "1";
        // 
        // checkoutDocument
        // 
        this.checkoutDocument.Location = new System.Drawing.Point(18, 217);
        this.checkoutDocument.Name = "checkoutDocument";
        this.checkoutDocument.Size = new System.Drawing.Size(167, 23);
        this.checkoutDocument.TabIndex = 15;
        this.checkoutDocument.Text = "Checkout document";
        this.checkoutDocument.UseVisualStyleBackColor = true;
        this.checkoutDocument.Click += new System.EventHandler(this.checkoutDocument_Click);
        // 
        // bnShowDoc
        // 
        this.bnShowDoc.Location = new System.Drawing.Point(18, 188);
        this.bnShowDoc.Name = "bnShowDoc";
        this.bnShowDoc.Size = new System.Drawing.Size(167, 23);
        this.bnShowDoc.TabIndex = 14;
        this.bnShowDoc.Text = "Show document";
        this.bnShowDoc.UseVisualStyleBackColor = true;
        this.bnShowDoc.Click += new System.EventHandler(this.bnShowDoc_Click);
        // 
        // bnSubItems
        // 
        this.bnSubItems.Location = new System.Drawing.Point(18, 158);
        this.bnSubItems.Name = "bnSubItems";
        this.bnSubItems.Size = new System.Drawing.Size(167, 23);
        this.bnSubItems.TabIndex = 13;
        this.bnSubItems.Text = "List subitems";
        this.bnSubItems.UseVisualStyleBackColor = true;
        this.bnSubItems.Click += new System.EventHandler(this.bnSubItems_Click);
        // 
        // bnFindSords
        // 
        this.bnFindSords.Location = new System.Drawing.Point(208, 188);
        this.bnFindSords.Name = "bnFindSords";
        this.bnFindSords.Size = new System.Drawing.Size(167, 23);
        this.bnFindSords.TabIndex = 16;
        this.bnFindSords.Text = "SordListView";
        this.bnFindSords.UseVisualStyleBackColor = true;
        this.bnFindSords.Click += new System.EventHandler(this.bnFindSords_Click);
        // 
        // bnTasks
        // 
        this.bnTasks.Location = new System.Drawing.Point(209, 250);
        this.bnTasks.Name = "bnTasks";
        this.bnTasks.Size = new System.Drawing.Size(167, 23);
        this.bnTasks.TabIndex = 17;
        this.bnTasks.Text = "TaskListView";
        this.bnTasks.UseVisualStyleBackColor = true;
        this.bnTasks.Click += new System.EventHandler(this.bnTasks_Click);
        // 
        // bnUserListView
        // 
        this.bnUserListView.Location = new System.Drawing.Point(210, 279);
        this.bnUserListView.Name = "bnUserListView";
        this.bnUserListView.Size = new System.Drawing.Size(165, 23);
        this.bnUserListView.TabIndex = 18;
        this.bnUserListView.Text = "UserListView";
        this.bnUserListView.UseVisualStyleBackColor = true;
        this.bnUserListView.Click += new System.EventHandler(this.bnUserListView_Click);
        // 
        // bnTextBoxKeyword
        // 
        this.bnTextBoxKeyword.Location = new System.Drawing.Point(401, 158);
        this.bnTextBoxKeyword.Name = "bnTextBoxKeyword";
        this.bnTextBoxKeyword.Size = new System.Drawing.Size(143, 23);
        this.bnTextBoxKeyword.TabIndex = 20;
        this.bnTextBoxKeyword.Text = "TextBox with Keywordlist";
        this.bnTextBoxKeyword.UseVisualStyleBackColor = true;
        this.bnTextBoxKeyword.Click += new System.EventHandler(this.bnTextBoxKeyword_Click);
        // 
        // bnArcExplorer
        // 
        this.bnArcExplorer.Location = new System.Drawing.Point(210, 221);
        this.bnArcExplorer.Name = "bnArcExplorer";
        this.bnArcExplorer.Size = new System.Drawing.Size(166, 23);
        this.bnArcExplorer.TabIndex = 21;
        this.bnArcExplorer.Text = "ArcExplorer";
        this.bnArcExplorer.UseVisualStyleBackColor = true;
        this.bnArcExplorer.Click += new System.EventHandler(this.bnArcExplorer_Click);
        // 
        // bnNewVersion
        // 
        this.bnNewVersion.Location = new System.Drawing.Point(18, 306);
        this.bnNewVersion.Name = "bnNewVersion";
        this.bnNewVersion.Size = new System.Drawing.Size(167, 23);
        this.bnNewVersion.TabIndex = 22;
        this.bnNewVersion.Text = "New Document Version";
        this.bnNewVersion.UseVisualStyleBackColor = true;
        this.bnNewVersion.Click += new System.EventHandler(this.bnNewVersion_Click);
        // 
        // bnShowCheckedout
        // 
        this.bnShowCheckedout.Location = new System.Drawing.Point(404, 197);
        this.bnShowCheckedout.Name = "bnShowCheckedout";
        this.bnShowCheckedout.Size = new System.Drawing.Size(140, 23);
        this.bnShowCheckedout.TabIndex = 23;
        this.bnShowCheckedout.Text = "Show checked out files";
        this.bnShowCheckedout.UseVisualStyleBackColor = true;
        this.bnShowCheckedout.Click += new System.EventHandler(this.bnShowCheckedout_Click);
        // 
        // btnCreateDocFromTempl
        // 
        this.btnCreateDocFromTempl.Location = new System.Drawing.Point(18, 275);
        this.btnCreateDocFromTempl.Name = "btnCreateDocFromTempl";
        this.btnCreateDocFromTempl.Size = new System.Drawing.Size(167, 23);
        this.btnCreateDocFromTempl.TabIndex = 24;
        this.btnCreateDocFromTempl.Text = "Create Doc From Templ";
        this.btnCreateDocFromTempl.UseVisualStyleBackColor = true;
        this.btnCreateDocFromTempl.Click += new System.EventHandler(this.btnCreateDocFromTempl_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(559, 352);
        this.Controls.Add(this.btnCreateDocFromTempl);
        this.Controls.Add(this.bnShowCheckedout);
        this.Controls.Add(this.bnNewVersion);
        this.Controls.Add(this.bnArcExplorer);
        this.Controls.Add(this.bnTextBoxKeyword);
        this.Controls.Add(this.bnUserListView);
        this.Controls.Add(this.bnTasks);
        this.Controls.Add(this.bnFindSords);
        this.Controls.Add(this.checkoutDocument);
        this.Controls.Add(this.bnShowDoc);
        this.Controls.Add(this.bnSubItems);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.showArcTree);
        this.Controls.Add(this.createDocument);
        this.Name = "Form1";
        this.Text = "Form1";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        this.Load += new System.EventHandler(this.Form1_Load);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button createDocument;
    private System.Windows.Forms.Button showArcTree;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbObjKey;
    private System.Windows.Forms.RadioButton rbFsPath;
    private System.Windows.Forms.RadioButton rbArcPath;
    private System.Windows.Forms.RadioButton rbObjId;
    private System.Windows.Forms.TextBox edObjId;
    private System.Windows.Forms.RadioButton rbMD5;
    private System.Windows.Forms.Button checkoutDocument;
    private System.Windows.Forms.Button bnShowDoc;
    private System.Windows.Forms.Button bnSubItems;
    private System.Windows.Forms.Button bnFindSords;
    private System.Windows.Forms.Button bnTasks;
    private System.Windows.Forms.Button bnUserListView;
    private System.Windows.Forms.Button bnTextBoxKeyword;
    private System.Windows.Forms.Button bnArcExplorer;
    private System.Windows.Forms.Button bnNewVersion;
    private System.Windows.Forms.Button bnShowCheckedout;
    private System.Windows.Forms.Button btnCreateDocFromTempl;

  }
}

