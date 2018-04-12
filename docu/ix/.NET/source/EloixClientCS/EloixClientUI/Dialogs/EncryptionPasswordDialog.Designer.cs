namespace EloixClientUI.Dialogs
{
    partial class EncryptionPasswordDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPw1 = new System.Windows.Forms.Label();
            this.lblPw2 = new System.Windows.Forms.Label();
            this.pw1 = new System.Windows.Forms.TextBox();
            this.pw2 = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblEncryptedDocumentInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(278, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPw1
            // 
            this.lblPw1.AutoSize = true;
            this.lblPw1.Location = new System.Drawing.Point(12, 64);
            this.lblPw1.Name = "lblPw1";
            this.lblPw1.Size = new System.Drawing.Size(50, 13);
            this.lblPw1.TabIndex = 2;
            this.lblPw1.Text = "Passwort";
            // 
            // lblPw2
            // 
            this.lblPw2.AutoSize = true;
            this.lblPw2.Location = new System.Drawing.Point(11, 90);
            this.lblPw2.Name = "lblPw2";
            this.lblPw2.Size = new System.Drawing.Size(125, 13);
            this.lblPw2.TabIndex = 3;
            this.lblPw2.Text = "Passwort (Wiederholung)";
            this.lblPw2.Visible = false;
            // 
            // pw1
            // 
            this.pw1.Location = new System.Drawing.Point(137, 57);
            this.pw1.Name = "pw1";
            this.pw1.Size = new System.Drawing.Size(325, 20);
            this.pw1.TabIndex = 4;
            this.pw1.UseSystemPasswordChar = true;
            this.pw1.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // pw2
            // 
            this.pw2.Location = new System.Drawing.Point(137, 87);
            this.pw2.Name = "pw2";
            this.pw2.Size = new System.Drawing.Size(325, 20);
            this.pw2.TabIndex = 5;
            this.pw2.UseSystemPasswordChar = true;
            this.pw2.Visible = false;
            this.pw2.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(11, 120);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(223, 13);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Text = "Die Passwörter stimmen nicht überein!";
            this.lblErrorMessage.Visible = false;
            // 
            // lblEncryptedDocumentInstruction
            // 
            this.lblEncryptedDocumentInstruction.AutoSize = true;
            this.lblEncryptedDocumentInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedDocumentInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblEncryptedDocumentInstruction.Name = "lblEncryptedDocumentInstruction";
            this.lblEncryptedDocumentInstruction.Size = new System.Drawing.Size(327, 26);
            this.lblEncryptedDocumentInstruction.TabIndex = 7;
            this.lblEncryptedDocumentInstruction.Text = "Das Dokument ist verschlüsselt.\r\nBitte geben Sie das Passwort für den Schlüsselkr" +
                "eis ein.";
            // 
            // EncryptionPasswordDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(475, 174);
            this.Controls.Add(this.lblEncryptedDocumentInstruction);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.pw2);
            this.Controls.Add(this.pw1);
            this.Controls.Add(this.lblPw2);
            this.Controls.Add(this.lblPw1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EncryptionPasswordDialog";
            this.Text = "Verschlüsselungspasswort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPw1;
        private System.Windows.Forms.Label lblPw2;
        private System.Windows.Forms.TextBox pw1;
        private System.Windows.Forms.TextBox pw2;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblEncryptedDocumentInstruction;
    }
}