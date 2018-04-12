namespace Examples
{
    partial class EventBusWatchFolderEventsDlg
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
            this.edObjId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.hdrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrParam2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAnyWhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edObjId
            // 
            this.edObjId.Location = new System.Drawing.Point(20, 31);
            this.edObjId.Name = "edObjId";
            this.edObjId.Size = new System.Drawing.Size(489, 20);
            this.edObjId.TabIndex = 0;
            this.edObjId.Text = "1";
            this.edObjId.TextChanged += new System.EventHandler(this.edObjId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder-ID to be Watched";
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrType,
            this.hdrParam2,
            this.hdrAny,
            this.hdrAnyWhat});
            this.lvEvents.Location = new System.Drawing.Point(22, 68);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(487, 141);
            this.lvEvents.TabIndex = 2;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // hdrType
            // 
            this.hdrType.Text = "Type";
            // 
            // hdrParam2
            // 
            this.hdrParam2.Text = "Event.param2 (Folder-ID)";
            this.hdrParam2.Width = 150;
            // 
            // hdrAny
            // 
            this.hdrAny.Text = "Event.any[0] (Sord-Object)";
            this.hdrAny.Width = 150;
            // 
            // hdrAnyWhat
            // 
            this.hdrAnyWhat.Text = "What";
            this.hdrAnyWhat.Width = 87;
            // 
            // bnClose
            // 
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnClose.Location = new System.Drawing.Point(434, 227);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 23);
            this.bnClose.TabIndex = 3;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // EventBusWatchFolderEventsDlg
            // 
            this.AcceptButton = this.bnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edObjId);
            this.Name = "EventBusWatchFolderEventsDlg";
            this.Text = "EventBusWatchFolderEventsDlg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventBusWatchFolderEventsDlg_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edObjId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.ColumnHeader hdrType;
        private System.Windows.Forms.ColumnHeader hdrParam2;
        private System.Windows.Forms.ColumnHeader hdrAny;
        private System.Windows.Forms.ColumnHeader hdrAnyWhat;
    }
}