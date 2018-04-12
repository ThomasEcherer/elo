namespace ExamplesFW
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.bnOK = new System.Windows.Forms.Button();
      this.bnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(17, 39);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(268, 20);
      this.textBox1.TabIndex = 0;
      // 
      // bnOK
      // 
      this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bnOK.Location = new System.Drawing.Point(66, 73);
      this.bnOK.Name = "bnOK";
      this.bnOK.Size = new System.Drawing.Size(75, 23);
      this.bnOK.TabIndex = 1;
      this.bnOK.Text = "OK";
      this.bnOK.UseVisualStyleBackColor = true;
      // 
      // bnCancel
      // 
      this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnCancel.Location = new System.Drawing.Point(156, 73);
      this.bnCancel.Name = "bnCancel";
      this.bnCancel.Size = new System.Drawing.Size(75, 23);
      this.bnCancel.TabIndex = 2;
      this.bnCancel.Text = "Cancel";
      this.bnCancel.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "label1";
      // 
      // InputBox
      // 
      this.AcceptButton = this.bnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.bnCancel;
      this.ClientSize = new System.Drawing.Size(292, 119);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bnCancel);
      this.Controls.Add(this.bnOK);
      this.Controls.Add(this.textBox1);
      this.Name = "InputBox";
      this.Text = "InputBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button bnOK;
    private System.Windows.Forms.Button bnCancel;
    private System.Windows.Forms.Label label1;
  }
}