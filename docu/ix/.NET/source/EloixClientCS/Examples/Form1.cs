using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using EloixClient.IndexServer;



namespace Examples
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button bnClose;
		private System.Windows.Forms.Button bnRun;
		private System.Windows.Forms.TreeView tvExamples;
		private System.Windows.Forms.Label lbURL;
		private System.Windows.Forms.TextBox txURL;
		private System.Windows.Forms.Button bnRunAll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txUserPwd;
		private System.Windows.Forms.RichTextBox rtxLog;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
            //

            Logger.instance().init(rtxLog);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Standard login");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Single-sign-on login");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lock archive with key");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Login/Logout", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Create Sord");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Checkin/-out Sord");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Change Keywording form");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Move Sord");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Create logical reference to Sord");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Delete Sord");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Checkout and unlock");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Checkout by index attribute");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Checkout by archive path");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Sord performance");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Access Control Lists");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("View + Edit Sord");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Link Sords");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sord types (lables, icons, file extensions)");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Indexing Information", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Checkin new document");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Checkin one document version");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Checkin many document versions");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Checkin document + signature");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Checkin attachment");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Document performance");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Small document performance");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Document performance with CheckinDocsEnd");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Checkin new encrypted");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Checkin/-out documents", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Notes on vertical bar");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Annotations");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Note Templates");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Checkin sticky notes", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Find all (#-search)");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Find-first, find-next");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Find children (browse archive tree)");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Find by index values");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Find by index range");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Find iSearch");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Find", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Create/Delete user/group");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("List user names");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("List user rights");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Create/Delete keys");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Users/Keys", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Create, checkin, checkout, delete storage mask");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Storage masks", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("List basic data");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Basic data", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Checkin/-out report options");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Find report entries");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("List workflows");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("List WF nodes");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Start AdHoc Workflow");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Workflow", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Select Keyword");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Checkin/out, cook Keywords");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Keyword", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Send-Receive");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Watch Folder");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Event Bus", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Query Languages");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Recognize file sync");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Recognize file async");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("OCR", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64,
            treeNode65});
            this.bnRun = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.tvExamples = new System.Windows.Forms.TreeView();
            this.lbURL = new System.Windows.Forms.Label();
            this.txURL = new System.Windows.Forms.TextBox();
            this.bnRunAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txUserPwd = new System.Windows.Forms.TextBox();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bnRun
            // 
            this.bnRun.Location = new System.Drawing.Point(8, 8);
            this.bnRun.Name = "bnRun";
            this.bnRun.Size = new System.Drawing.Size(56, 23);
            this.bnRun.TabIndex = 1;
            this.bnRun.Text = "Run";
            this.bnRun.Click += new System.EventHandler(this.bnRun_Click);
            // 
            // bnClose
            // 
            this.bnClose.Location = new System.Drawing.Point(568, 8);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(56, 23);
            this.bnClose.TabIndex = 2;
            this.bnClose.Text = "Close";
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // tvExamples
            // 
            this.tvExamples.HideSelection = false;
            this.tvExamples.Location = new System.Drawing.Point(8, 48);
            this.tvExamples.Name = "tvExamples";
            treeNode1.Name = "";
            treeNode1.Text = "Standard login";
            treeNode2.Name = "";
            treeNode2.Text = "Single-sign-on login";
            treeNode3.Name = "";
            treeNode3.Text = "Lock archive with key";
            treeNode4.Name = "";
            treeNode4.Text = "Login/Logout";
            treeNode5.Name = "";
            treeNode5.Text = "Create Sord";
            treeNode6.Name = "";
            treeNode6.Text = "Checkin/-out Sord";
            treeNode7.Name = "";
            treeNode7.Text = "Change Keywording form";
            treeNode8.Name = "";
            treeNode8.Text = "Move Sord";
            treeNode9.Name = "";
            treeNode9.Text = "Create logical reference to Sord";
            treeNode10.Name = "";
            treeNode10.Text = "Delete Sord";
            treeNode11.Name = "";
            treeNode11.Text = "Checkout and unlock";
            treeNode12.Name = "";
            treeNode12.Text = "Checkout by index attribute";
            treeNode13.Name = "";
            treeNode13.Text = "Checkout by archive path";
            treeNode14.Name = "";
            treeNode14.Text = "Sord performance";
            treeNode15.Name = "";
            treeNode15.Text = "Access Control Lists";
            treeNode16.Name = "";
            treeNode16.Text = "View + Edit Sord";
            treeNode17.Name = "";
            treeNode17.Text = "Link Sords";
            treeNode18.Name = "";
            treeNode18.Text = "Sord types (lables, icons, file extensions)";
            treeNode19.Name = "";
            treeNode19.Text = "Indexing Information";
            treeNode20.Name = "";
            treeNode20.Text = "Checkin new document";
            treeNode21.Name = "";
            treeNode21.Text = "Checkin one document version";
            treeNode22.Name = "";
            treeNode22.Text = "Checkin many document versions";
            treeNode23.Name = "";
            treeNode23.Text = "Checkin document + signature";
            treeNode24.Name = "";
            treeNode24.Text = "Checkin attachment";
            treeNode25.Name = "";
            treeNode25.Text = "Document performance";
            treeNode26.Name = "";
            treeNode26.Text = "Small document performance";
            treeNode27.Name = "";
            treeNode27.Text = "Document performance with CheckinDocsEnd";
            treeNode28.Name = "Knoten0";
            treeNode28.Text = "Checkin new encrypted";
            treeNode29.Name = "";
            treeNode29.Text = "Checkin/-out documents";
            treeNode30.Name = "";
            treeNode30.Text = "Notes on vertical bar";
            treeNode31.Name = "";
            treeNode31.Text = "Annotations";
            treeNode32.Name = "";
            treeNode32.Text = "Note Templates";
            treeNode33.Name = "";
            treeNode33.Text = "Checkin sticky notes";
            treeNode34.Name = "";
            treeNode34.Text = "Find all (#-search)";
            treeNode35.Name = "";
            treeNode35.Text = "Find-first, find-next";
            treeNode36.Name = "";
            treeNode36.Text = "Find children (browse archive tree)";
            treeNode37.Name = "";
            treeNode37.Text = "Find by index values";
            treeNode38.Name = "";
            treeNode38.Text = "Find by index range";
            treeNode39.Name = "FindISearch";
            treeNode39.Text = "Find iSearch";
            treeNode40.Name = "";
            treeNode40.Text = "Find";
            treeNode41.Name = "";
            treeNode41.Text = "Create/Delete user/group";
            treeNode42.Name = "";
            treeNode42.Text = "List user names";
            treeNode43.Name = "";
            treeNode43.Text = "List user rights";
            treeNode44.Name = "";
            treeNode44.Text = "Create/Delete keys";
            treeNode45.Name = "";
            treeNode45.Text = "Users/Keys";
            treeNode46.Name = "";
            treeNode46.Text = "Create, checkin, checkout, delete storage mask";
            treeNode47.Name = "";
            treeNode47.Text = "Storage masks";
            treeNode48.Name = "";
            treeNode48.Text = "List basic data";
            treeNode49.Name = "";
            treeNode49.Text = "Basic data";
            treeNode50.Name = "";
            treeNode50.Text = "Checkin/-out report options";
            treeNode51.Name = "";
            treeNode51.Text = "Find report entries";
            treeNode52.Name = "";
            treeNode52.Text = "Report";
            treeNode53.Name = "";
            treeNode53.Text = "List workflows";
            treeNode54.Name = "";
            treeNode54.Text = "List WF nodes";
            treeNode55.Name = "";
            treeNode55.Text = "Start AdHoc Workflow";
            treeNode56.Name = "";
            treeNode56.Text = "Workflow";
            treeNode57.Name = "";
            treeNode57.Text = "Select Keyword";
            treeNode58.Name = "";
            treeNode58.Text = "Checkin/out, cook Keywords";
            treeNode59.Name = "";
            treeNode59.Text = "Keyword";
            treeNode60.Name = "EventBusSendReceive";
            treeNode60.Text = "Send-Receive";
            treeNode61.Name = "EventBusWatchFolder";
            treeNode61.Text = "Watch Folder";
            treeNode62.Name = "EventBusExample";
            treeNode62.Text = "Event Bus";
            treeNode63.Name = "OCRQueryLangs";
            treeNode63.Text = "Query Languages";
            treeNode64.Name = "OCRRecognizeFile";
            treeNode64.Text = "Recognize file sync";
            treeNode65.Name = "OCRRecognizeFileAsync";
            treeNode65.Text = "Recognize file async";
            treeNode66.Name = "OCRExample";
            treeNode66.Text = "OCR";
            this.tvExamples.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode19,
            treeNode29,
            treeNode33,
            treeNode40,
            treeNode45,
            treeNode47,
            treeNode49,
            treeNode52,
            treeNode56,
            treeNode59,
            treeNode62,
            treeNode66});
            this.tvExamples.Size = new System.Drawing.Size(264, 216);
            this.tvExamples.TabIndex = 4;
            this.tvExamples.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExamples_AfterSelect);
            // 
            // lbURL
            // 
            this.lbURL.Location = new System.Drawing.Point(8, 280);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(40, 23);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL";
            // 
            // txURL
            // 
            this.txURL.Location = new System.Drawing.Point(56, 280);
            this.txURL.Name = "txURL";
            this.txURL.Size = new System.Drawing.Size(216, 20);
            this.txURL.TabIndex = 6;
            this.txURL.Text = "http://localhost:8084/ix-elo90/ix";
            // 
            // bnRunAll
            // 
            this.bnRunAll.Location = new System.Drawing.Point(80, 8);
            this.bnRunAll.Name = "bnRunAll";
            this.bnRunAll.Size = new System.Drawing.Size(56, 23);
            this.bnRunAll.TabIndex = 7;
            this.bnRunAll.Text = "Run all";
            this.bnRunAll.Click += new System.EventHandler(this.bnRunAll_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(120, 320);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(152, 20);
            this.txUserName.TabIndex = 9;
            this.txUserName.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txUserPwd
            // 
            this.txUserPwd.Location = new System.Drawing.Point(120, 360);
            this.txUserPwd.Name = "txUserPwd";
            this.txUserPwd.Size = new System.Drawing.Size(152, 20);
            this.txUserPwd.TabIndex = 11;
            this.txUserPwd.Text = "elo";
            // 
            // rtxLog
            // 
            this.rtxLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxLog.Location = new System.Drawing.Point(288, 48);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxLog.Size = new System.Drawing.Size(336, 400);
            this.rtxLog.TabIndex = 13;
            this.rtxLog.Text = "";
            this.rtxLog.WordWrap = false;
            this.rtxLog.TextChanged += new System.EventHandler(this.rtxLog_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.rtxLog);
            this.Controls.Add(this.txUserPwd);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.txURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnRunAll);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.tvExamples);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.bnRun);
            this.Name = "Form1";
            this.Text = "Run examples";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void bnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tvExamples_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		}

		public void assertTrue(String msg, bool failIfFalse) 
		{
			if (!failIfFalse)
			{
				fail(msg, null);
			}
		}

		public void fail(String msg, Exception ex) 
		{
			throw new InvalidOperationException(msg, ex);
		}

		private void dispatchCommand(String cmd) 
		{
			Logger.instance().log("---- begin " + cmd);
      if (cmd.IndexOf("Standard login") >= 0) 
      {
        Logger.instance().log("**** refer to StandardLogin.cs");
        StandardLogin example = new StandardLogin();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      } 
      else if (cmd.IndexOf("Single-sign-on login") >= 0) 
      {
        Logger.instance().log("**** refer to SingleSignOnLogin.cs");
        SingleSignOnLogin example = new SingleSignOnLogin();
        example.url = txURL.Text;
        example.run();
      }
      else if (cmd.IndexOf("Lock archive with key") >= 0) 
      {
        Logger.instance().log("**** refer to LockArchive.cs");
        LockArchive example = new LockArchive();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.lockKey = "0";
        example.run();
      }
      else if (cmd.IndexOf("Create Sord") >= 0) 
      {
        Logger.instance().log("**** refer to CreateSord.cs");
        CreateSord example = new CreateSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin/-out Sord") >= 0) 
      {
        Logger.instance().log("**** refer to CheckinOutSord.cs");
        CheckinOutSord example = new CheckinOutSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Change Keywording form") >= 0) 
      {
        Logger.instance().log("**** refer to ChangeSordMask.cs");
        ChangeSordMask example = new ChangeSordMask();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Move Sord") >= 0) 
      {
        Logger.instance().log("**** refer to MoveSord.cs");
        MoveSord example = new MoveSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Create logical reference to Sord") >= 0)
      {
        Logger.instance().log("**** refer to CopySord.cs");
        CopySord example = new CopySord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Delete Sord") >= 0) 
      {
        Logger.instance().log("**** refer to DeleteSord.cs");
        DeleteSord example = new DeleteSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkout and unlock") >= 0)
      {
        Logger.instance().log("**** refer to CheckoutAndUnlock.cs");
        CheckoutAndUnlock example = new CheckoutAndUnlock();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkout by index attribute") >= 0)
      {
        Logger.instance().log("**** refer to CheckoutByIndex.cs");
        CheckoutByIndex example = new CheckoutByIndex();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkout by archive path") >= 0)
      {
        Logger.instance().log("**** refer to CheckoutByArcPath.cs");
        CheckoutByArcPath example = new CheckoutByArcPath();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Access Control Lists") >= 0)
      {
        Logger.instance().log("**** refer to SordACL.cs");
        SordACL example = new SordACL();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Sord performance") >= 0)
      {
        Logger.instance().log("**** refer to SordPerformance.cs");
        SordPerformance example = new SordPerformance();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("View + Edit Sord") >= 0)
      {
        Logger.instance().log("**** refer to ViewAndEditSord.cs");
        ViewAndEditSord example = new ViewAndEditSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Link Sords") >= 0)
      {
        Logger.instance().log("**** refer to LinkSord.cs");
        LinkSord example = new LinkSord();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin new document") >= 0)
      {
        Logger.instance().log("**** refer to CheckinNewDocument.cs");
        CheckinNewDocument example = new CheckinNewDocument();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin new encrypted") >= 0)
      {
        Logger.instance().log("**** refer to CheckinOutDocEncrypted.cs");
        CheckinOutDocEncrypted example = new CheckinOutDocEncrypted();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin one document version") >= 0)
      {
        Logger.instance().log("**** refer to CheckinNewDocVersion.cs");
        CheckinNewDocVersion example = new CheckinNewDocVersion();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin many document versions") >= 0)
      {
        Logger.instance().log("**** refer to CheckinManyDocVersions.cs");
        CheckinManyDocVersions example = new CheckinManyDocVersions();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin document + signature") >= 0)
      {
        Logger.instance().log("**** refer to CheckinNewDocAndSig.cs");
        CheckinNewDocAndSig example = new CheckinNewDocAndSig();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Checkin attachment") >= 0)
      {
        Logger.instance().log("**** refer to CheckinAttachment.cs");
        CheckinAttachment example = new CheckinAttachment();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Document performance") >= 0)
      {
        Logger.instance().log("**** refer to DocPerformance.cs");
        DocPerformance example = new DocPerformance();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Document performance with CheckinDocsEnd") >= 0)
      {
        Logger.instance().log("**** refer to DocPerformance2.cs");
        DocPerformance2 example = new DocPerformance2();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Small document performance") >= 0)
      {
        Logger.instance().log("**** refer to DocPerformanceSmall.cs");
        DocPerformanceSmall example = new DocPerformanceSmall();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Notes on vertical bar") >= 0)
      {
        Logger.instance().log("**** refer to CheckinNoteOnVerticalBar.cs");
        CheckinNoteOnVerticalBar example = new CheckinNoteOnVerticalBar();
        example.url = txURL.Text;
        example.userName = txUserName.Text;
        example.userPwd = txUserPwd.Text;
        example.run();
      }
      else if (cmd.IndexOf("Annotations") >= 0)
      {
          Logger.instance().log("**** refer to CheckinAnnotations.cs");
          CheckinAnnotations example = new CheckinAnnotations();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Note Templates") >= 0)
      {
          Logger.instance().log("**** refer to CheckinNoteStampByTemplate.cs");
          CheckinNoteStampByTemplate example = new CheckinNoteStampByTemplate();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find all (#-search)") >= 0)
      {
          Logger.instance().log("**** refer to FindAll.cs");
          FindAll example = new FindAll();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find-first, find-next") >= 0)
      {
          Logger.instance().log("**** refer to FindFirstFindNext.cs");
          FindFirstFindNext example = new FindFirstFindNext();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find children (browse archive tree)") >= 0)
      {
          Logger.instance().log("**** refer to FindChildren.cs");
          FindChildren example = new FindChildren();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find by index values") >= 0)
      {
          Logger.instance().log("**** refer to FindByIndexValues.cs");
          FindByIndexValues example = new FindByIndexValues();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find by index range") >= 0)
      {
          Logger.instance().log("**** refer to FindByIndexRange.cs");
          FindByIndexRange example = new FindByIndexRange();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("List user names") >= 0)
      {
          Logger.instance().log("**** refer to ListUserNames.cs");
          ListUserNames example = new ListUserNames();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("List user rights") >= 0)
      {
          Logger.instance().log("**** refer to ViewUserRights.cs");
          ViewUserRights example = new ViewUserRights();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Create/Delete user/group") >= 0)
      {
          Logger.instance().log("**** refer to CreateDeleteUser.cs");
          CreateDeleteUser example = new CreateDeleteUser();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Create/Delete keys") >= 0)
      {
          Logger.instance().log("**** refer to CreateDeleteKeys.cs");
          CreateDeleteKeys example = new CreateDeleteKeys();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Create, checkin, checkout, delete storage mask") >= 0)
      {
          Logger.instance().log("**** refer to CreateStorageMask.cs");
          CreateStorageMask example = new CreateStorageMask();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("List basic data") >= 0)
      {
          Logger.instance().log("**** refer to ListBasicData.cs");
          ListBasicData example = new ListBasicData();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Checkin/-out report options") >= 0)
      {
          Logger.instance().log("**** refer to ReportOptions.cs");
          ReportOptions example = new ReportOptions();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find report") >= 0)
      {
          Logger.instance().log("**** refer to FindReport.cs");
          FindReport example = new FindReport();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("List workflows") >= 0)
      {
          Logger.instance().log("**** refer to ListWorkFlows.cs");
          ListWorkFlows example = new ListWorkFlows();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("List WF nodes") >= 0)
      {
          Logger.instance().log("**** refer to ListWorkFlowNodes.cs");
          ListWorkFlowNodes example = new ListWorkFlowNodes();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Start AdHoc Workflow") >= 0)
      {
          Logger.instance().log("**** refer to StartAdhocWorkFlow.cs");
          StartAdhocWorkFlow example = new StartAdhocWorkFlow();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Select Keyword") >= 0)
      {
          Logger.instance().log("**** refer to SelectKeyword.cs");
          SelectKeyword example = new SelectKeyword();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Checkin/out, cook Keywords") >= 0)
      {
          Logger.instance().log("**** refer to CheckinKeywords.cs");
          CheckinKeywords example = new CheckinKeywords();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Sord types (lables, icons, file extensions)") >= 0)
      {
          Logger.instance().log("**** refer to CheckinSordTypes.cs");
          CheckinSordTypes example = new CheckinSordTypes();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Send-Receive") >= 0)
      {
          Logger.instance().log("**** refer to EventBusSendReceive.cs");
          EventBusSendReceive example = new EventBusSendReceive();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Watch Folder") >= 0)
      {
          Logger.instance().log("**** refer to EventBusWatchFolder.cs");
          EventBusWatchFolder example = new EventBusWatchFolder();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Query Languages") >= 0)
      {
          Logger.instance().log("**** refer to QueryLanguages.cs");
          QueryLanguages example = new QueryLanguages();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Recognize file sync") >= 0)
      {
          Logger.instance().log("**** refer to OcrRecognize.cs");
          OcrRecognize example = new OcrRecognize();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Recognize file async") >= 0)
      {
          Logger.instance().log("**** refer to OcrRecognizeAsync.cs");
          OcrRecognizeAsync example = new OcrRecognizeAsync();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }
      else if (cmd.IndexOf("Find iSearch") >= 0)
      {
          Logger.instance().log("**** refer to FindISearch.cs");
          FindISearch example = new FindISearch();
          example.url = txURL.Text;
          example.userName = txUserName.Text;
          example.userPwd = txUserPwd.Text;
          example.run();
      }

      Logger.instance().log("---- end " + cmd);

			
		}

		private void bnRun_Click(object sender, System.EventArgs e)
		{
			rtxLog.Clear();

			try 
			{
				if (tvExamples.SelectedNode == null) return;
				
				String cmd = tvExamples.SelectedNode.Text;
				dispatchCommand(cmd);
			} 
			catch (Exception ex) 
			{
				System.Windows.Forms.MessageBox.Show(ex.ToString(), "Exception");
			}
			finally 
			{
			}
		}

		private void bnRunAll_Click(object sender, System.EventArgs e)
		{
			rtxLog.Clear();

			try 
			{
				foreach (TreeNode i in tvExamples.Nodes) 
				{
					foreach (TreeNode j in i.Nodes) 
					{
						dispatchCommand(j.Text);
					}
				}
			} 
			finally 
			{
			}
		}

		private void rtxLog_TextChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
