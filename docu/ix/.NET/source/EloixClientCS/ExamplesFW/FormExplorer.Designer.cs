namespace ExamplesFW
{
  partial class FormExplorer
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorer));
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.arcTreeView1 = new EloixClientUI.Controls.ArcTreeView();
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.neuerOrdnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.umbenennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.sordListView1 = new EloixClientUI.Controls.SordListView();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.contextMenuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // splitContainer1
        // 
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        this.splitContainer1.Panel1.Controls.Add(this.arcTreeView1);
        // 
        // splitContainer1.Panel2
        // 
        this.splitContainer1.Panel2.Controls.Add(this.sordListView1);
        this.splitContainer1.Size = new System.Drawing.Size(532, 348);
        this.splitContainer1.SplitterDistance = 198;
        this.splitContainer1.TabIndex = 0;
        // 
        // arcTreeView1
        // 
        this.arcTreeView1.AllowDrag = false;
        this.arcTreeView1.AllowDrop = true;
        this.arcTreeView1.AllowOpenDocument = false;
        this.arcTreeView1.Conn = null;
        this.arcTreeView1.ContextMenuStrip = this.contextMenuStrip1;
        this.arcTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.arcTreeView1.LabelEdit = true;
        this.arcTreeView1.Location = new System.Drawing.Point(0, 0);
        this.arcTreeView1.Name = "arcTreeView1";
        this.arcTreeView1.ParentFolder = null;
        this.arcTreeView1.SelectedPath = "";
        this.arcTreeView1.ShowDocuments = false;
        this.arcTreeView1.ShowReferences = false;
        this.arcTreeView1.Size = new System.Drawing.Size(198, 348);
        this.arcTreeView1.SubItemsList = this.sordListView1;
        this.arcTreeView1.TabIndex = 0;
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerOrdnerToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.umbenennenToolStripMenuItem,
            this.aktualisierenToolStripMenuItem});
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(156, 92);
        // 
        // neuerOrdnerToolStripMenuItem
        // 
        this.neuerOrdnerToolStripMenuItem.Name = "neuerOrdnerToolStripMenuItem";
        this.neuerOrdnerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
        this.neuerOrdnerToolStripMenuItem.Text = "Neuer Ordner...";
        this.neuerOrdnerToolStripMenuItem.Click += new System.EventHandler(this.neuerOrdnerToolStripMenuItem_Click);
        // 
        // löschenToolStripMenuItem
        // 
        this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
        this.löschenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
        this.löschenToolStripMenuItem.Text = "Löschen ...";
        this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
        // 
        // umbenennenToolStripMenuItem
        // 
        this.umbenennenToolStripMenuItem.Name = "umbenennenToolStripMenuItem";
        this.umbenennenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
        this.umbenennenToolStripMenuItem.Text = "Umbenennen";
        this.umbenennenToolStripMenuItem.Click += new System.EventHandler(this.umbenennenToolStripMenuItem_Click);
        // 
        // aktualisierenToolStripMenuItem
        // 
        this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
        this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
        this.aktualisierenToolStripMenuItem.Text = "Aktualisieren";
        this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
        // 
        // sordListView1
        // 
        this.sordListView1.AllowDrag = false;
        this.sordListView1.AllowOpenDocument = true;
        this.sordListView1.Conn = null;
        this.sordListView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.sordListView1.Location = new System.Drawing.Point(0, 0);
        this.sordListView1.Name = "sordListView1";
        this.sordListView1.ObjectsCache = null;
        this.sordListView1.SelectedIndices = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("sordListView1.SelectedIndices")));
        this.sordListView1.SettingsService = null;
        this.sordListView1.ShowDocuments = true;
        this.sordListView1.ShowFolders = false;
        this.sordListView1.ShowHourglass = true;
        this.sordListView1.ShowObjKeyColumns = true;
        this.sordListView1.Size = new System.Drawing.Size(330, 348);
        this.sordListView1.SordsCache = null;
        this.sordListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
        this.sordListView1.TabIndex = 0;
        this.sordListView1.UseCompatibleStateImageBehavior = false;
        this.sordListView1.View = System.Windows.Forms.View.Details;
        this.sordListView1.VirtualMode = true;
        // 
        // FormExplorer
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(532, 348);
        this.Controls.Add(this.splitContainer1);
        this.Name = "FormExplorer";
        this.Text = "FormExplorer";
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.ResumeLayout(false);
        this.contextMenuStrip1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private EloixClientUI.Controls.ArcTreeView arcTreeView1;
    private EloixClientUI.Controls.SordListView sordListView1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem neuerOrdnerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem umbenennenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
  }
}