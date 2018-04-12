namespace EloixClientUI.Dialogs
{
  partial class FormSelectUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectUser));
      this.panel1 = new System.Windows.Forms.Panel();
      this.bnCancel = new System.Windows.Forms.Button();
      this.bnOK = new System.Windows.Forms.Button();
      this.selectUser1 = new EloixClientUI.Controls.SelectUser();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.bnCancel);
      this.panel1.Controls.Add(this.bnOK);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(322, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(31);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(124, 311);
      this.panel1.TabIndex = 2;
      // 
      // bnCancel
      // 
      this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnCancel.Location = new System.Drawing.Point(12, 41);
      this.bnCancel.Name = "bnCancel";
      this.bnCancel.Size = new System.Drawing.Size(100, 23);
      this.bnCancel.TabIndex = 1;
      this.bnCancel.Text = "Cancel";
      this.bnCancel.UseVisualStyleBackColor = true;
      // 
      // bnOK
      // 
      this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bnOK.Location = new System.Drawing.Point(12, 12);
      this.bnOK.Name = "bnOK";
      this.bnOK.Size = new System.Drawing.Size(100, 23);
      this.bnOK.TabIndex = 0;
      this.bnOK.Text = "OK";
      this.bnOK.UseVisualStyleBackColor = true;
      this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
      // 
      // selectUser1
      // 
      this.selectUser1.Conn = null;
      this.selectUser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.selectUser1.HiddenUserIds = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("selectUser1.HiddenUserIds")));
      this.selectUser1.Location = new System.Drawing.Point(0, 0);
      this.selectUser1.MultiSelect = true;
      this.selectUser1.Name = "selectUser1";
      this.selectUser1.Padding = new System.Windows.Forms.Padding(10);
      this.selectUser1.SelectedUserIds = ((System.Collections.Generic.IEnumerable<int>)(resources.GetObject("selectUser1.SelectedUserIds")));
      this.selectUser1.ShowGroups = true;
      this.selectUser1.ShowUsers = true;
      this.selectUser1.Size = new System.Drawing.Size(322, 311);
      this.selectUser1.TabIndex = 1;
      // 
      // FormSelectUser
      // 
      this.AcceptButton = this.bnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bnCancel;
      this.ClientSize = new System.Drawing.Size(446, 311);
      this.Controls.Add(this.selectUser1);
      this.Controls.Add(this.panel1);
      this.Name = "FormSelectUser";
      this.Text = "Select User";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button bnCancel;
    private System.Windows.Forms.Button bnOK;
    private EloixClientUI.Controls.SelectUser selectUser1;

  }
}