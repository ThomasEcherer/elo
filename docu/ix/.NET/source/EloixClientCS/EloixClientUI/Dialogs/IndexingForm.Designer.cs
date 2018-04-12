using EloixClientUI.Controls;
namespace EloixClientUI.Dialogs
{
    partial class IndexingForm
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
            this.cmbOk = new System.Windows.Forms.Button();
            this.cmbCancel = new System.Windows.Forms.Button();
            this.grpBoxButtons = new System.Windows.Forms.GroupBox();
            this.pBoxStateIcon = new System.Windows.Forms.PictureBox();
            this.labelStateMsg = new System.Windows.Forms.Label();
            this.outlookIndexingUControl1 = new EloixClientUI.Controls.OutlookIndexingUControl();
            this.grpBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStateIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOk
            // 
            this.cmbOk.Location = new System.Drawing.Point(551, 17);
            this.cmbOk.Name = "cmbOk";
            this.cmbOk.Size = new System.Drawing.Size(100, 23);
            this.cmbOk.TabIndex = 1;
            this.cmbOk.Text = "Ok";
            this.cmbOk.UseVisualStyleBackColor = true;
            this.cmbOk.Click += new System.EventHandler(this.cmbOk_Click);
            // 
            // cmbCancel
            // 
            this.cmbCancel.Location = new System.Drawing.Point(657, 17);
            this.cmbCancel.Name = "cmbCancel";
            this.cmbCancel.Size = new System.Drawing.Size(100, 23);
            this.cmbCancel.TabIndex = 2;
            this.cmbCancel.Text = "Abbrechen";
            this.cmbCancel.UseVisualStyleBackColor = true;
            this.cmbCancel.Click += new System.EventHandler(this.cmbCancel_Click);
            // 
            // grpBoxButtons
            // 
            this.grpBoxButtons.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxButtons.Controls.Add(this.pBoxStateIcon);
            this.grpBoxButtons.Controls.Add(this.labelStateMsg);
            this.grpBoxButtons.Controls.Add(this.cmbOk);
            this.grpBoxButtons.Controls.Add(this.cmbCancel);
            this.grpBoxButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxButtons.Location = new System.Drawing.Point(0, 446);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Size = new System.Drawing.Size(763, 48);
            this.grpBoxButtons.TabIndex = 3;
            this.grpBoxButtons.TabStop = false;
            // 
            // pBoxStateIcon
            // 
            this.pBoxStateIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxStateIcon.Location = new System.Drawing.Point(10, 17);
            this.pBoxStateIcon.Name = "pBoxStateIcon";
            this.pBoxStateIcon.Size = new System.Drawing.Size(24, 21);
            this.pBoxStateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxStateIcon.TabIndex = 6;
            this.pBoxStateIcon.TabStop = false;
            // 
            // labelStateMsg
            // 
            this.labelStateMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStateMsg.Location = new System.Drawing.Point(41, 13);
            this.labelStateMsg.Name = "labelStateMsg";
            this.labelStateMsg.Size = new System.Drawing.Size(400, 26);
            this.labelStateMsg.TabIndex = 5;
            this.labelStateMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outlookIndexingUControl1
            // 
            this.outlookIndexingUControl1.AutoScroll = true;
            this.outlookIndexingUControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outlookIndexingUControl1.BackColor = System.Drawing.Color.Transparent;
            this.outlookIndexingUControl1.CanChangeDocMask = false;
            this.outlookIndexingUControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookIndexingUControl1.IxConnection = null;
            this.outlookIndexingUControl1.Location = new System.Drawing.Point(0, 3);
            this.outlookIndexingUControl1.Name = "outlookIndexingUControl1";
            this.outlookIndexingUControl1.ReadOnly = false;
            this.outlookIndexingUControl1.Size = new System.Drawing.Size(763, 443);
            this.outlookIndexingUControl1.TabIndex = 4;
            // 
            // IndexingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 494);
            this.Controls.Add(this.outlookIndexingUControl1);
            this.Controls.Add(this.grpBoxButtons);
            this.DoubleBuffered = true;
            this.Name = "IndexingForm";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verschlagwortung";
            this.grpBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStateIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmbOk;
        private System.Windows.Forms.Button cmbCancel;
        private System.Windows.Forms.GroupBox grpBoxButtons;
        private OutlookIndexingUControl outlookIndexingUControl1;
        private System.Windows.Forms.PictureBox pBoxStateIcon;
        private System.Windows.Forms.Label labelStateMsg;
    }
}