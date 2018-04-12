namespace EloixClientUI.Dialogs
{
  partial class InputBox
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.bnOk = new System.Windows.Forms.Button();
      this.bnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(15, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(206, 20);
      this.textBox1.TabIndex = 1;
      // 
      // bnOk
      // 
      this.bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bnOk.Location = new System.Drawing.Point(43, 57);
      this.bnOk.Name = "bnOk";
      this.bnOk.Size = new System.Drawing.Size(75, 23);
      this.bnOk.TabIndex = 2;
      this.bnOk.Text = "OK";
      this.bnOk.UseVisualStyleBackColor = true;
      // 
      // bnCancel
      // 
      this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnCancel.Location = new System.Drawing.Point(124, 58);
      this.bnCancel.Name = "bnCancel";
      this.bnCancel.Size = new System.Drawing.Size(75, 23);
      this.bnCancel.TabIndex = 3;
      this.bnCancel.Text = "Cancel";
      this.bnCancel.UseVisualStyleBackColor = true;
      // 
      // InputBox
      // 
      this.AcceptButton = this.bnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bnCancel;
      this.ClientSize = new System.Drawing.Size(236, 92);
      this.Controls.Add(this.bnCancel);
      this.Controls.Add(this.bnOk);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "InputBox";
      this.Text = "Input";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button bnOk;
    private System.Windows.Forms.Button bnCancel;
  }
}