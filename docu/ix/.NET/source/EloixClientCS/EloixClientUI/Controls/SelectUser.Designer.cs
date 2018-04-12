namespace EloixClientUI.Controls
{
  partial class SelectUser
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUser));
      this.panel1 = new System.Windows.Forms.Panel();
      this.ckGroups = new System.Windows.Forms.CheckBox();
      this.ckUsers = new System.Windows.Forms.CheckBox();
      this.edSearch = new System.Windows.Forms.TextBox();
      this.lbSearch = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.userListView1 = new EloixClientUI.Controls.UserListView();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ckGroups);
      this.panel1.Controls.Add(this.ckUsers);
      this.panel1.Controls.Add(this.edSearch);
      this.panel1.Controls.Add(this.lbSearch);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(330, 48);
      this.panel1.TabIndex = 0;
      // 
      // ckGroups
      // 
      this.ckGroups.AutoSize = true;
      this.ckGroups.Location = new System.Drawing.Point(200, 27);
      this.ckGroups.Name = "ckGroups";
      this.ckGroups.Size = new System.Drawing.Size(60, 17);
      this.ckGroups.TabIndex = 2;
      this.ckGroups.Text = "Groups";
      this.ckGroups.UseVisualStyleBackColor = true;
      this.ckGroups.CheckedChanged += new System.EventHandler(this.ckGroups_CheckedChanged);
      // 
      // ckUsers
      // 
      this.ckUsers.AutoSize = true;
      this.ckUsers.Location = new System.Drawing.Point(200, 4);
      this.ckUsers.Name = "ckUsers";
      this.ckUsers.Size = new System.Drawing.Size(53, 17);
      this.ckUsers.TabIndex = 1;
      this.ckUsers.Text = "Users";
      this.ckUsers.UseVisualStyleBackColor = true;
      this.ckUsers.CheckedChanged += new System.EventHandler(this.ckUsers_CheckedChanged);
      // 
      // edSearch
      // 
      this.edSearch.Location = new System.Drawing.Point(0, 17);
      this.edSearch.Name = "edSearch";
      this.edSearch.Size = new System.Drawing.Size(163, 20);
      this.edSearch.TabIndex = 0;
      this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
      // 
      // lbSearch
      // 
      this.lbSearch.AutoSize = true;
      this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbSearch.Location = new System.Drawing.Point(0, 1);
      this.lbSearch.Name = "lbSearch";
      this.lbSearch.Size = new System.Drawing.Size(47, 13);
      this.lbSearch.TabIndex = 0;
      this.lbSearch.Text = "Search";
      // 
      // timer1
      // 
      this.timer1.Interval = 300;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // userListView1
      // 
      this.userListView1.Conn = null;
      this.userListView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.userListView1.HideSelection = false;
      this.userListView1.Location = new System.Drawing.Point(0, 48);
      this.userListView1.Name = "userListView1";
      this.userListView1.ObjectsCache = null;
      this.userListView1.SelectedIndices = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("userListView1.SelectedIndices")));
      this.userListView1.SelectedUserIds = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("userListView1.SelectedUserIds")));
      this.userListView1.ShowGroups = false;
      this.userListView1.ShowHourglass = true;
      this.userListView1.Size = new System.Drawing.Size(330, 214);
      this.userListView1.TabIndex = 3;
      this.userListView1.UseCompatibleStateImageBehavior = false;
      this.userListView1.UsersCache = null;
      this.userListView1.View = System.Windows.Forms.View.Details;
      this.userListView1.VirtualMode = true;
      this.userListView1.DoubleClick += new System.EventHandler(this.userListView1_DoubleClick);
      // 
      // SelectUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.userListView1);
      this.Controls.Add(this.panel1);
      this.Name = "SelectUser";
      this.Size = new System.Drawing.Size(330, 262);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox edSearch;
    private System.Windows.Forms.Label lbSearch;
    private UserListView userListView1;
    private System.Windows.Forms.CheckBox ckGroups;
    private System.Windows.Forms.CheckBox ckUsers;
    private System.Windows.Forms.Timer timer1;

  }
}
