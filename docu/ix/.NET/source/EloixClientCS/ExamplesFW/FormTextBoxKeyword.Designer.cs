namespace ExamplesFW
{
  partial class FormTextBoxKeyword
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
      this.keywordTextBox3 = new EloixClientUI.Controls.KeywordTextBox();
      this.keywordTextBox2 = new EloixClientUI.Controls.KeywordTextBox();
      this.keywordTextBox1 = new EloixClientUI.Controls.KeywordTextBox();
      this.SuspendLayout();
      // 
      // keywordTextBox3
      // 
      this.keywordTextBox3.FormattingEnabled = true;
      this.keywordTextBox3.KeywordList = null;
      this.keywordTextBox3.Location = new System.Drawing.Point(12, 66);
      this.keywordTextBox3.Name = "keywordTextBox3";
      this.keywordTextBox3.Size = new System.Drawing.Size(222, 21);
      this.keywordTextBox3.TabIndex = 2;
      // 
      // keywordTextBox2
      // 
      this.keywordTextBox2.KeywordList = null;
      this.keywordTextBox2.Location = new System.Drawing.Point(12, 39);
      this.keywordTextBox2.Name = "keywordTextBox2";
      this.keywordTextBox2.Size = new System.Drawing.Size(222, 21);
      this.keywordTextBox2.TabIndex = 1;
      // 
      // keywordTextBox1
      // 
      this.keywordTextBox1.KeywordList = null;
      this.keywordTextBox1.Location = new System.Drawing.Point(12, 12);
      this.keywordTextBox1.Name = "keywordTextBox1";
      this.keywordTextBox1.Size = new System.Drawing.Size(222, 21);
      this.keywordTextBox1.TabIndex = 0;
      this.keywordTextBox1.TextChanged += new System.EventHandler(this.keywordTextBox1_TextChanged);
      // 
      // FormTextBoxKeyword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 273);
      this.Controls.Add(this.keywordTextBox3);
      this.Controls.Add(this.keywordTextBox2);
      this.Controls.Add(this.keywordTextBox1);
      this.Name = "FormTextBoxKeyword";
      this.ShowInTaskbar = false;
      this.Text = "FormTextBoxKeyword";
      this.Load += new System.EventHandler(this.FormTextBoxKeyword_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private EloixClientUI.Controls.KeywordTextBox keywordTextBox1;
    private EloixClientUI.Controls.KeywordTextBox keywordTextBox2;
    private EloixClientUI.Controls.KeywordTextBox keywordTextBox3;

  }
}