using EloixClientUI.Controls.combobox;
namespace EloixClientUI.Controls
{
    partial class OutlookIndexingUControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string text;
        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpBoxDocMasks = new EloixClientUI.Controls.BorderlessGroupBox();
            this.panelMasks = new System.Windows.Forms.Panel();
            this.tabLayoutPanelMasks = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxDataInput = new EloixClientUI.Controls.BorderlessGroupBox();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageDocMaskInput2 = new System.Windows.Forms.TabPage();
            this.tabLayoutPanelBaseData = new System.Windows.Forms.TableLayoutPanel();
            this.labDocumentDate = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.labCheckInDocDate = new System.Windows.Forms.Label();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.labActDocVersion = new System.Windows.Forms.Label();
            this.txtBoxDocVersion = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.dateTimePickerDocCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDocDate = new System.Windows.Forms.DateTimePicker();
            this.labShortDescription = new System.Windows.Forms.Label();
            this.txtBoxName = new EloixClientUI.Controls.RegExTextBox();
            this.chkAddToFulltext = new System.Windows.Forms.CheckBox();
            this.comBoxObjectType = new EloixClientUI.Controls.combobox.ImageTextComboBox();
            this.tabPageSearchBaseData = new System.Windows.Forms.TabPage();
            this.tabLayoutSearchBaseData = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.regTxtBoxFullTxtSearch = new EloixClientUI.Controls.RegExTextBox();
            this.dTPSearchDocSaveDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labSearchCheckDateUntil = new System.Windows.Forms.Label();
            this.dTPSearchDocSaveDateUntil = new System.Windows.Forms.DateTimePicker();
            this.dTPsearchDocDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labSearchDocDataUntil = new System.Windows.Forms.Label();
            this.dTPsearchDocDateUntil = new System.Windows.Forms.DateTimePicker();
            this.rgTxtBoxSearchName = new EloixClientUI.Controls.RegExTextBox();
            this.labSearchCheckDataFrom = new System.Windows.Forms.Label();
            this.labSearchDocDateFrom = new System.Windows.Forms.Label();
            this.labSearchShordDesc = new System.Windows.Forms.Label();
            this.tabPageAdditionalText = new System.Windows.Forms.TabPage();
            this.rTextBoxAdditionalText = new System.Windows.Forms.RichTextBox();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.tabLayoutSearchOptions = new System.Windows.Forms.TableLayoutPanel();
            this.labSearchObjType = new System.Windows.Forms.Label();
            this.dTPSearchExpiredDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labExpiredDateUntil = new System.Windows.Forms.Label();
            this.dTPSearchExpiredDateUntil = new System.Windows.Forms.DateTimePicker();
            this.regTxtBoxDocSavedByUser = new EloixClientUI.Controls.RegExTextBox();
            this.labSearchFileName = new System.Windows.Forms.Label();
            this.labExpiredDateFrom = new System.Windows.Forms.Label();
            this.labDocSavedByUser = new System.Windows.Forms.Label();
            this.cmbSelectUser = new System.Windows.Forms.Button();
            this.regTxtBoxSearchFileName = new EloixClientUI.Controls.RegExTextBox();
            this.labSearchNotes = new System.Windows.Forms.Label();
            this.regTxtBoxSearchNotes = new EloixClientUI.Controls.RegExTextBox();
            this.comBoxSearchNotesTypes = new System.Windows.Forms.ComboBox();
            this.labSearchMode = new System.Windows.Forms.Label();
            this.comBoxSearchModeType = new System.Windows.Forms.ComboBox();
            this.chkSearchInActDir = new System.Windows.Forms.CheckBox();
            this.comBoxSearchObjType = new EloixClientUI.Controls.combobox.ImageTextComboBox();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpBoxDocMasks.SuspendLayout();
            this.panelMasks.SuspendLayout();
            this.grpBoxDataInput.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPageDocMaskInput2.SuspendLayout();
            this.tabLayoutPanelBaseData.SuspendLayout();
            this.tabPageSearchBaseData.SuspendLayout();
            this.tabLayoutSearchBaseData.SuspendLayout();
            this.tabPageAdditionalText.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.tabLayoutSearchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpBoxDocMasks);
            this.splitContainer.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpBoxDataInput);
            this.splitContainer.Panel2.Resize += new System.EventHandler(this.splitContainer_Panel2_Resize);
            this.splitContainer.Panel2MinSize = 50;
            this.splitContainer.Size = new System.Drawing.Size(751, 442);
            this.splitContainer.SplitterDistance = 183;
            this.splitContainer.TabIndex = 0;
            // 
            // grpBoxDocMasks
            // 
            this.grpBoxDocMasks.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxDocMasks.Controls.Add(this.panelMasks);
            this.grpBoxDocMasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDocMasks.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDocMasks.Location = new System.Drawing.Point(0, 0);
            this.grpBoxDocMasks.Name = "grpBoxDocMasks";
            this.grpBoxDocMasks.Size = new System.Drawing.Size(183, 442);
            this.grpBoxDocMasks.TabIndex = 1;
            this.grpBoxDocMasks.TabStop = false;
            this.grpBoxDocMasks.Text = "Verschlagwortungsmasken";
            // 
            // panelMasks
            // 
            this.panelMasks.AutoScroll = true;
            this.panelMasks.Controls.Add(this.tabLayoutPanelMasks);
            this.panelMasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMasks.Location = new System.Drawing.Point(3, 16);
            this.panelMasks.Name = "panelMasks";
            this.panelMasks.Size = new System.Drawing.Size(177, 423);
            this.panelMasks.TabIndex = 1;
            // 
            // tabLayoutPanelMasks
            // 
            this.tabLayoutPanelMasks.AutoScroll = true;
            this.tabLayoutPanelMasks.AutoSize = true;
            this.tabLayoutPanelMasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabLayoutPanelMasks.BackColor = System.Drawing.Color.Transparent;
            this.tabLayoutPanelMasks.ColumnCount = 1;
            this.tabLayoutPanelMasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutPanelMasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabLayoutPanelMasks.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutPanelMasks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tabLayoutPanelMasks.Name = "tabLayoutPanelMasks";
            this.tabLayoutPanelMasks.RowCount = 1;
            this.tabLayoutPanelMasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelMasks.Size = new System.Drawing.Size(177, 0);
            this.tabLayoutPanelMasks.TabIndex = 0;
            // 
            // grpBoxDataInput
            // 
            this.grpBoxDataInput.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxDataInput.Controls.Add(this.tabControlOptions);
            this.grpBoxDataInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDataInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataInput.Location = new System.Drawing.Point(0, 0);
            this.grpBoxDataInput.Name = "grpBoxDataInput";
            this.grpBoxDataInput.Size = new System.Drawing.Size(564, 442);
            this.grpBoxDataInput.TabIndex = 1;
            this.grpBoxDataInput.TabStop = false;
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageDocMaskInput2);
            this.tabControlOptions.Controls.Add(this.tabPageSearchBaseData);
            this.tabControlOptions.Controls.Add(this.tabPageAdditionalText);
            this.tabControlOptions.Controls.Add(this.tabPageOptions);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOptions.Location = new System.Drawing.Point(3, 16);
            this.tabControlOptions.Multiline = true;
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(558, 423);
            this.tabControlOptions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabPageDocMaskInput2
            // 
            this.tabPageDocMaskInput2.AutoScroll = true;
            this.tabPageDocMaskInput2.BackColor = System.Drawing.Color.White;
            this.tabPageDocMaskInput2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageDocMaskInput2.Controls.Add(this.tabLayoutPanelBaseData);
            this.tabPageDocMaskInput2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDocMaskInput2.Location = new System.Drawing.Point(4, 23);
            this.tabPageDocMaskInput2.Name = "tabPageDocMaskInput2";
            this.tabPageDocMaskInput2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocMaskInput2.Size = new System.Drawing.Size(550, 396);
            this.tabPageDocMaskInput2.TabIndex = 0;
            this.tabPageDocMaskInput2.Text = "Basis";
            this.tabPageDocMaskInput2.UseVisualStyleBackColor = true;
            // 
            // tabLayoutPanelBaseData
            // 
            this.tabLayoutPanelBaseData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutPanelBaseData.AutoSize = true;
            this.tabLayoutPanelBaseData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabLayoutPanelBaseData.ColumnCount = 4;
            this.tabLayoutPanelBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutPanelBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutPanelBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutPanelBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutPanelBaseData.Controls.Add(this.labDocumentDate, 0, 1);
            this.tabLayoutPanelBaseData.Controls.Add(this.txtBoxUser, 3, 2);
            this.tabLayoutPanelBaseData.Controls.Add(this.labCheckInDocDate, 0, 2);
            this.tabLayoutPanelBaseData.Controls.Add(this.lblObjectType, 0, 3);
            this.tabLayoutPanelBaseData.Controls.Add(this.labActDocVersion, 2, 1);
            this.tabLayoutPanelBaseData.Controls.Add(this.txtBoxDocVersion, 3, 1);
            this.tabLayoutPanelBaseData.Controls.Add(this.labUser, 2, 2);
            this.tabLayoutPanelBaseData.Controls.Add(this.dateTimePickerDocCheckInDate, 1, 2);
            this.tabLayoutPanelBaseData.Controls.Add(this.dateTimePickerDocDate, 1, 1);
            this.tabLayoutPanelBaseData.Controls.Add(this.labShortDescription, 0, 0);
            this.tabLayoutPanelBaseData.Controls.Add(this.txtBoxName, 1, 0);
            this.tabLayoutPanelBaseData.Controls.Add(this.chkAddToFulltext, 1, 4);
            this.tabLayoutPanelBaseData.Controls.Add(this.comBoxObjectType, 1, 3);
            this.tabLayoutPanelBaseData.Location = new System.Drawing.Point(6, 6);
            this.tabLayoutPanelBaseData.Name = "tabLayoutPanelBaseData";
            this.tabLayoutPanelBaseData.RowCount = 6;
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanelBaseData.Size = new System.Drawing.Size(526, 133);
            this.tabLayoutPanelBaseData.TabIndex = 12;
            // 
            // labDocumentDate
            // 
            this.labDocumentDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDocumentDate.AutoSize = true;
            this.labDocumentDate.Location = new System.Drawing.Point(3, 33);
            this.labDocumentDate.Name = "labDocumentDate";
            this.labDocumentDate.Size = new System.Drawing.Size(37, 14);
            this.labDocumentDate.TabIndex = 2;
            this.labDocumentDate.Text = "Datum";
            this.labDocumentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUser.Enabled = false;
            this.txtBoxUser.Location = new System.Drawing.Point(413, 58);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(109, 20);
            this.txtBoxUser.TabIndex = 9;
            // 
            // labCheckInDocDate
            // 
            this.labCheckInDocDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCheckInDocDate.AutoSize = true;
            this.labCheckInDocDate.Location = new System.Drawing.Point(3, 61);
            this.labCheckInDocDate.Name = "labCheckInDocDate";
            this.labCheckInDocDate.Size = new System.Drawing.Size(70, 14);
            this.labCheckInDocDate.TabIndex = 3;
            this.labCheckInDocDate.Text = "Ablagedatum";
            this.labCheckInDocDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObjectType
            // 
            this.lblObjectType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(3, 88);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(52, 14);
            this.lblObjectType.TabIndex = 4;
            this.lblObjectType.Text = "Objekttyp";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labActDocVersion
            // 
            this.labActDocVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labActDocVersion.AutoSize = true;
            this.labActDocVersion.Location = new System.Drawing.Point(320, 33);
            this.labActDocVersion.Name = "labActDocVersion";
            this.labActDocVersion.Size = new System.Drawing.Size(86, 14);
            this.labActDocVersion.TabIndex = 9;
            this.labActDocVersion.Text = "Aktuelle Version";
            this.labActDocVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxDocVersion
            // 
            this.txtBoxDocVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDocVersion.Enabled = false;
            this.txtBoxDocVersion.Location = new System.Drawing.Point(413, 30);
            this.txtBoxDocVersion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDocVersion.Name = "txtBoxDocVersion";
            this.txtBoxDocVersion.Size = new System.Drawing.Size(109, 20);
            this.txtBoxDocVersion.TabIndex = 5;
            // 
            // labUser
            // 
            this.labUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(320, 61);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(57, 14);
            this.labUser.TabIndex = 10;
            this.labUser.Text = "Bearbeiter";
            this.labUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDocCheckInDate
            // 
            this.dateTimePickerDocCheckInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDocCheckInDate.CustomFormat = "dd.MM.yyyy hh:mm";
            this.dateTimePickerDocCheckInDate.Enabled = false;
            this.dateTimePickerDocCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDocCheckInDate.Location = new System.Drawing.Point(102, 58);
            this.dateTimePickerDocCheckInDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDocCheckInDate.Name = "dateTimePickerDocCheckInDate";
            this.dateTimePickerDocCheckInDate.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerDocCheckInDate.TabIndex = 7;
            // 
            // dateTimePickerDocDate
            // 
            this.dateTimePickerDocDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDocDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDocDate.Location = new System.Drawing.Point(102, 30);
            this.dateTimePickerDocDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDocDate.Name = "dateTimePickerDocDate";
            this.dateTimePickerDocDate.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerDocDate.TabIndex = 3;
            // 
            // labShortDescription
            // 
            this.labShortDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labShortDescription.AutoSize = true;
            this.labShortDescription.Location = new System.Drawing.Point(3, 6);
            this.labShortDescription.Name = "labShortDescription";
            this.labShortDescription.Size = new System.Drawing.Size(92, 14);
            this.labShortDescription.TabIndex = 0;
            this.labShortDescription.Text = "Kurzbezeichnung";
            this.labShortDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutPanelBaseData.SetColumnSpan(this.txtBoxName, 3);
            this.txtBoxName.Location = new System.Drawing.Point(101, 3);
            this.txtBoxName.Max = -1;
            this.txtBoxName.Min = -1;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.RegularExpression = null;
            this.txtBoxName.Size = new System.Drawing.Size(422, 20);
            this.txtBoxName.TabIndex = 14;
            // 
            // chkAddToFulltext
            // 
            this.chkAddToFulltext.AutoSize = true;
            this.chkAddToFulltext.Location = new System.Drawing.Point(101, 112);
            this.chkAddToFulltext.Name = "chkAddToFulltext";
            this.chkAddToFulltext.Size = new System.Drawing.Size(151, 18);
            this.chkAddToFulltext.TabIndex = 22;
            this.chkAddToFulltext.Text = "In den Volltext aufnehmen";
            this.chkAddToFulltext.UseVisualStyleBackColor = true;
            // 
            // comBoxObjectType
            // 
            this.tabLayoutPanelBaseData.SetColumnSpan(this.comBoxObjectType, 2);
            this.comBoxObjectType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxObjectType.FormattingEnabled = true;
            this.comBoxObjectType.Location = new System.Drawing.Point(101, 85);
            this.comBoxObjectType.Name = "comBoxObjectType";
            this.comBoxObjectType.Size = new System.Drawing.Size(212, 21);
            this.comBoxObjectType.TabIndex = 23;
            // 
            // tabPageSearchBaseData
            // 
            this.tabPageSearchBaseData.AutoScroll = true;
            this.tabPageSearchBaseData.Controls.Add(this.tabLayoutSearchBaseData);
            this.tabPageSearchBaseData.Location = new System.Drawing.Point(4, 23);
            this.tabPageSearchBaseData.Name = "tabPageSearchBaseData";
            this.tabPageSearchBaseData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchBaseData.Size = new System.Drawing.Size(550, 396);
            this.tabPageSearchBaseData.TabIndex = 2;
            this.tabPageSearchBaseData.Text = "Suche";
            this.tabPageSearchBaseData.UseVisualStyleBackColor = true;
            // 
            // tabLayoutSearchBaseData
            // 
            this.tabLayoutSearchBaseData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchBaseData.AutoSize = true;
            this.tabLayoutSearchBaseData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabLayoutSearchBaseData.ColumnCount = 4;
            this.tabLayoutSearchBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchBaseData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutSearchBaseData.Controls.Add(this.label1, 0, 0);
            this.tabLayoutSearchBaseData.Controls.Add(this.regTxtBoxFullTxtSearch, 1, 0);
            this.tabLayoutSearchBaseData.Controls.Add(this.dTPSearchDocSaveDateFrom, 1, 3);
            this.tabLayoutSearchBaseData.Controls.Add(this.labSearchCheckDateUntil, 2, 3);
            this.tabLayoutSearchBaseData.Controls.Add(this.dTPSearchDocSaveDateUntil, 3, 3);
            this.tabLayoutSearchBaseData.Controls.Add(this.dTPsearchDocDateFrom, 1, 2);
            this.tabLayoutSearchBaseData.Controls.Add(this.labSearchDocDataUntil, 2, 2);
            this.tabLayoutSearchBaseData.Controls.Add(this.dTPsearchDocDateUntil, 3, 2);
            this.tabLayoutSearchBaseData.Controls.Add(this.rgTxtBoxSearchName, 1, 1);
            this.tabLayoutSearchBaseData.Controls.Add(this.labSearchCheckDataFrom, 0, 3);
            this.tabLayoutSearchBaseData.Controls.Add(this.labSearchDocDateFrom, 0, 2);
            this.tabLayoutSearchBaseData.Controls.Add(this.labSearchShordDesc, 0, 1);
            this.tabLayoutSearchBaseData.Location = new System.Drawing.Point(6, 6);
            this.tabLayoutSearchBaseData.Name = "tabLayoutSearchBaseData";
            this.tabLayoutSearchBaseData.RowCount = 6;
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchBaseData.Size = new System.Drawing.Size(526, 108);
            this.tabLayoutSearchBaseData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Volltextsuche";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regTxtBoxFullTxtSearch
            // 
            this.regTxtBoxFullTxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchBaseData.SetColumnSpan(this.regTxtBoxFullTxtSearch, 3);
            this.regTxtBoxFullTxtSearch.Location = new System.Drawing.Point(101, 3);
            this.regTxtBoxFullTxtSearch.Max = -1;
            this.regTxtBoxFullTxtSearch.Min = -1;
            this.regTxtBoxFullTxtSearch.Name = "regTxtBoxFullTxtSearch";
            this.regTxtBoxFullTxtSearch.RegularExpression = null;
            this.regTxtBoxFullTxtSearch.Size = new System.Drawing.Size(422, 20);
            this.regTxtBoxFullTxtSearch.TabIndex = 19;
            // 
            // dTPSearchDocSaveDateFrom
            // 
            this.dTPSearchDocSaveDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPSearchDocSaveDateFrom.Checked = false;
            this.dTPSearchDocSaveDateFrom.CustomFormat = "dd.MM.yyyy";
            this.dTPSearchDocSaveDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSearchDocSaveDateFrom.Location = new System.Drawing.Point(102, 84);
            this.dTPSearchDocSaveDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dTPSearchDocSaveDateFrom.Name = "dTPSearchDocSaveDateFrom";
            this.dTPSearchDocSaveDateFrom.ShowCheckBox = true;
            this.dTPSearchDocSaveDateFrom.Size = new System.Drawing.Size(211, 20);
            this.dTPSearchDocSaveDateFrom.TabIndex = 7;
            this.dTPSearchDocSaveDateFrom.ValueChanged += new System.EventHandler(this.dTimePickerSearchDocSaveDateFrom_ValueChanged);
            // 
            // labSearchCheckDateUntil
            // 
            this.labSearchCheckDateUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSearchCheckDateUntil.AutoSize = true;
            this.labSearchCheckDateUntil.Location = new System.Drawing.Point(320, 87);
            this.labSearchCheckDateUntil.Name = "labSearchCheckDateUntil";
            this.labSearchCheckDateUntil.Size = new System.Drawing.Size(21, 14);
            this.labSearchCheckDateUntil.TabIndex = 16;
            this.labSearchCheckDateUntil.Text = "bis";
            // 
            // dTPSearchDocSaveDateUntil
            // 
            this.dTPSearchDocSaveDateUntil.Checked = false;
            this.dTPSearchDocSaveDateUntil.CustomFormat = "dd.MM.yyyy";
            this.dTPSearchDocSaveDateUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSearchDocSaveDateUntil.Location = new System.Drawing.Point(347, 83);
            this.dTPSearchDocSaveDateUntil.Name = "dTPSearchDocSaveDateUntil";
            this.dTPSearchDocSaveDateUntil.ShowCheckBox = true;
            this.dTPSearchDocSaveDateUntil.Size = new System.Drawing.Size(176, 20);
            this.dTPSearchDocSaveDateUntil.TabIndex = 18;
            this.dTPSearchDocSaveDateUntil.ValueChanged += new System.EventHandler(this.dTimePickerSearchDocSaveDateUntil_ValueChanged);
            // 
            // dTPsearchDocDateFrom
            // 
            this.dTPsearchDocDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPsearchDocDateFrom.Checked = false;
            this.dTPsearchDocDateFrom.CustomFormat = "dd.MM.yyyy";
            this.dTPsearchDocDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPsearchDocDateFrom.Location = new System.Drawing.Point(102, 56);
            this.dTPsearchDocDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dTPsearchDocDateFrom.Name = "dTPsearchDocDateFrom";
            this.dTPsearchDocDateFrom.ShowCheckBox = true;
            this.dTPsearchDocDateFrom.Size = new System.Drawing.Size(211, 20);
            this.dTPsearchDocDateFrom.TabIndex = 3;
            this.dTPsearchDocDateFrom.ValueChanged += new System.EventHandler(this.dTimePickerSearchDocDateFrom_ValueChanged);
            // 
            // labSearchDocDataUntil
            // 
            this.labSearchDocDataUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSearchDocDataUntil.AutoSize = true;
            this.labSearchDocDataUntil.Location = new System.Drawing.Point(320, 59);
            this.labSearchDocDataUntil.Name = "labSearchDocDataUntil";
            this.labSearchDocDataUntil.Size = new System.Drawing.Size(21, 14);
            this.labSearchDocDataUntil.TabIndex = 15;
            this.labSearchDocDataUntil.Text = "bis";
            // 
            // dTPsearchDocDateUntil
            // 
            this.dTPsearchDocDateUntil.Checked = false;
            this.dTPsearchDocDateUntil.CustomFormat = "dd.MM.yyyy";
            this.dTPsearchDocDateUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPsearchDocDateUntil.Location = new System.Drawing.Point(347, 55);
            this.dTPsearchDocDateUntil.Name = "dTPsearchDocDateUntil";
            this.dTPsearchDocDateUntil.ShowCheckBox = true;
            this.dTPsearchDocDateUntil.Size = new System.Drawing.Size(176, 20);
            this.dTPsearchDocDateUntil.TabIndex = 17;
            this.dTPsearchDocDateUntil.ValueChanged += new System.EventHandler(this.dTimePickerSearchDocDateUntil_ValueChanged);
            // 
            // rgTxtBoxSearchName
            // 
            this.rgTxtBoxSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchBaseData.SetColumnSpan(this.rgTxtBoxSearchName, 3);
            this.rgTxtBoxSearchName.Location = new System.Drawing.Point(101, 29);
            this.rgTxtBoxSearchName.Max = -1;
            this.rgTxtBoxSearchName.Min = -1;
            this.rgTxtBoxSearchName.Name = "rgTxtBoxSearchName";
            this.rgTxtBoxSearchName.RegularExpression = null;
            this.rgTxtBoxSearchName.Size = new System.Drawing.Size(422, 20);
            this.rgTxtBoxSearchName.TabIndex = 14;
            // 
            // labSearchCheckDataFrom
            // 
            this.labSearchCheckDataFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchCheckDataFrom.AutoSize = true;
            this.labSearchCheckDataFrom.Location = new System.Drawing.Point(3, 87);
            this.labSearchCheckDataFrom.Name = "labSearchCheckDataFrom";
            this.labSearchCheckDataFrom.Size = new System.Drawing.Size(70, 14);
            this.labSearchCheckDataFrom.TabIndex = 3;
            this.labSearchCheckDataFrom.Text = "Ablagedatum";
            this.labSearchCheckDataFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSearchDocDateFrom
            // 
            this.labSearchDocDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchDocDateFrom.AutoSize = true;
            this.labSearchDocDateFrom.Location = new System.Drawing.Point(3, 59);
            this.labSearchDocDateFrom.Name = "labSearchDocDateFrom";
            this.labSearchDocDateFrom.Size = new System.Drawing.Size(37, 14);
            this.labSearchDocDateFrom.TabIndex = 2;
            this.labSearchDocDateFrom.Text = "Datum";
            this.labSearchDocDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSearchShordDesc
            // 
            this.labSearchShordDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchShordDesc.AutoSize = true;
            this.labSearchShordDesc.Location = new System.Drawing.Point(3, 32);
            this.labSearchShordDesc.Name = "labSearchShordDesc";
            this.labSearchShordDesc.Size = new System.Drawing.Size(92, 14);
            this.labSearchShordDesc.TabIndex = 0;
            this.labSearchShordDesc.Text = "Kurzbezeichnung";
            this.labSearchShordDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageAdditionalText
            // 
            this.tabPageAdditionalText.AutoScroll = true;
            this.tabPageAdditionalText.BackColor = System.Drawing.Color.White;
            this.tabPageAdditionalText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAdditionalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAdditionalText.Controls.Add(this.rTextBoxAdditionalText);
            this.tabPageAdditionalText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdditionalText.Location = new System.Drawing.Point(4, 23);
            this.tabPageAdditionalText.Name = "tabPageAdditionalText";
            this.tabPageAdditionalText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdditionalText.Size = new System.Drawing.Size(550, 396);
            this.tabPageAdditionalText.TabIndex = 1;
            this.tabPageAdditionalText.Text = "Zusatztext";
            this.tabPageAdditionalText.UseVisualStyleBackColor = true;
            // 
            // rTextBoxAdditionalText
            // 
            this.rTextBoxAdditionalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTextBoxAdditionalText.Location = new System.Drawing.Point(3, 3);
            this.rTextBoxAdditionalText.Name = "rTextBoxAdditionalText";
            this.rTextBoxAdditionalText.Size = new System.Drawing.Size(542, 388);
            this.rTextBoxAdditionalText.TabIndex = 0;
            this.rTextBoxAdditionalText.Text = "";
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.AutoScroll = true;
            this.tabPageOptions.Controls.Add(this.tabLayoutSearchOptions);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 23);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(550, 396);
            this.tabPageOptions.TabIndex = 3;
            this.tabPageOptions.Text = "Optionen";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // tabLayoutSearchOptions
            // 
            this.tabLayoutSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.AutoSize = true;
            this.tabLayoutSearchOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabLayoutSearchOptions.ColumnCount = 4;
            this.tabLayoutSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutSearchOptions.Controls.Add(this.labSearchObjType, 0, 0);
            this.tabLayoutSearchOptions.Controls.Add(this.dTPSearchExpiredDateFrom, 1, 2);
            this.tabLayoutSearchOptions.Controls.Add(this.labExpiredDateUntil, 2, 2);
            this.tabLayoutSearchOptions.Controls.Add(this.dTPSearchExpiredDateUntil, 3, 2);
            this.tabLayoutSearchOptions.Controls.Add(this.regTxtBoxDocSavedByUser, 1, 1);
            this.tabLayoutSearchOptions.Controls.Add(this.labSearchFileName, 0, 3);
            this.tabLayoutSearchOptions.Controls.Add(this.labExpiredDateFrom, 0, 2);
            this.tabLayoutSearchOptions.Controls.Add(this.labDocSavedByUser, 0, 1);
            this.tabLayoutSearchOptions.Controls.Add(this.cmbSelectUser, 3, 1);
            this.tabLayoutSearchOptions.Controls.Add(this.regTxtBoxSearchFileName, 1, 3);
            this.tabLayoutSearchOptions.Controls.Add(this.labSearchNotes, 0, 6);
            this.tabLayoutSearchOptions.Controls.Add(this.regTxtBoxSearchNotes, 1, 6);
            this.tabLayoutSearchOptions.Controls.Add(this.comBoxSearchNotesTypes, 1, 7);
            this.tabLayoutSearchOptions.Controls.Add(this.labSearchMode, 0, 10);
            this.tabLayoutSearchOptions.Controls.Add(this.comBoxSearchModeType, 1, 10);
            this.tabLayoutSearchOptions.Controls.Add(this.chkSearchInActDir, 1, 9);
            this.tabLayoutSearchOptions.Controls.Add(this.comBoxSearchObjType, 1, 0);
            this.tabLayoutSearchOptions.Location = new System.Drawing.Point(6, 6);
            this.tabLayoutSearchOptions.Name = "tabLayoutSearchOptions";
            this.tabLayoutSearchOptions.RowCount = 11;
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutSearchOptions.Size = new System.Drawing.Size(526, 216);
            this.tabLayoutSearchOptions.TabIndex = 14;
            // 
            // labSearchObjType
            // 
            this.labSearchObjType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchObjType.AutoSize = true;
            this.labSearchObjType.Location = new System.Drawing.Point(3, 6);
            this.labSearchObjType.Name = "labSearchObjType";
            this.labSearchObjType.Size = new System.Drawing.Size(52, 14);
            this.labSearchObjType.TabIndex = 20;
            this.labSearchObjType.Text = "Objekttyp";
            this.labSearchObjType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTPSearchExpiredDateFrom
            // 
            this.dTPSearchExpiredDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPSearchExpiredDateFrom.Checked = false;
            this.dTPSearchExpiredDateFrom.CustomFormat = "dd.MM.yyyy";
            this.dTPSearchExpiredDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSearchExpiredDateFrom.Location = new System.Drawing.Point(84, 60);
            this.dTPSearchExpiredDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dTPSearchExpiredDateFrom.Name = "dTPSearchExpiredDateFrom";
            this.dTPSearchExpiredDateFrom.ShowCheckBox = true;
            this.dTPSearchExpiredDateFrom.Size = new System.Drawing.Size(211, 20);
            this.dTPSearchExpiredDateFrom.TabIndex = 3;
            this.dTPSearchExpiredDateFrom.ValueChanged += new System.EventHandler(this.datTimePSearchExpiredDateFrom_ValueChanged);
            // 
            // labExpiredDateUntil
            // 
            this.labExpiredDateUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labExpiredDateUntil.AutoSize = true;
            this.labExpiredDateUntil.Location = new System.Drawing.Point(302, 63);
            this.labExpiredDateUntil.Name = "labExpiredDateUntil";
            this.labExpiredDateUntil.Size = new System.Drawing.Size(21, 14);
            this.labExpiredDateUntil.TabIndex = 15;
            this.labExpiredDateUntil.Text = "bis";
            // 
            // dTPSearchExpiredDateUntil
            // 
            this.dTPSearchExpiredDateUntil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPSearchExpiredDateUntil.Checked = false;
            this.dTPSearchExpiredDateUntil.CustomFormat = "dd.MM.yyyy";
            this.dTPSearchExpiredDateUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPSearchExpiredDateUntil.Location = new System.Drawing.Point(329, 60);
            this.dTPSearchExpiredDateUntil.Name = "dTPSearchExpiredDateUntil";
            this.dTPSearchExpiredDateUntil.ShowCheckBox = true;
            this.dTPSearchExpiredDateUntil.Size = new System.Drawing.Size(194, 20);
            this.dTPSearchExpiredDateUntil.TabIndex = 17;
            this.dTPSearchExpiredDateUntil.ValueChanged += new System.EventHandler(this.datTimePSearchExpiredDateUntil_ValueChanged);
            // 
            // regTxtBoxDocSavedByUser
            // 
            this.regTxtBoxDocSavedByUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.SetColumnSpan(this.regTxtBoxDocSavedByUser, 2);
            this.regTxtBoxDocSavedByUser.Location = new System.Drawing.Point(83, 31);
            this.regTxtBoxDocSavedByUser.Max = -1;
            this.regTxtBoxDocSavedByUser.Min = -1;
            this.regTxtBoxDocSavedByUser.Name = "regTxtBoxDocSavedByUser";
            this.regTxtBoxDocSavedByUser.RegularExpression = null;
            this.regTxtBoxDocSavedByUser.Size = new System.Drawing.Size(240, 20);
            this.regTxtBoxDocSavedByUser.TabIndex = 14;
            // 
            // labSearchFileName
            // 
            this.labSearchFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchFileName.AutoSize = true;
            this.labSearchFileName.Location = new System.Drawing.Point(3, 90);
            this.labSearchFileName.Name = "labSearchFileName";
            this.labSearchFileName.Size = new System.Drawing.Size(57, 14);
            this.labSearchFileName.TabIndex = 3;
            this.labSearchFileName.Text = "Dateiname";
            this.labSearchFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labExpiredDateFrom
            // 
            this.labExpiredDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExpiredDateFrom.AutoSize = true;
            this.labExpiredDateFrom.Location = new System.Drawing.Point(3, 63);
            this.labExpiredDateFrom.Name = "labExpiredDateFrom";
            this.labExpiredDateFrom.Size = new System.Drawing.Size(74, 14);
            this.labExpiredDateFrom.TabIndex = 2;
            this.labExpiredDateFrom.Text = "Verfallsdatum";
            this.labExpiredDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDocSavedByUser
            // 
            this.labDocSavedByUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDocSavedByUser.AutoSize = true;
            this.labDocSavedByUser.Location = new System.Drawing.Point(3, 34);
            this.labDocSavedByUser.Name = "labDocSavedByUser";
            this.labDocSavedByUser.Size = new System.Drawing.Size(71, 14);
            this.labDocSavedByUser.TabIndex = 0;
            this.labDocSavedByUser.Text = "Abgelegt von";
            this.labDocSavedByUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSelectUser
            // 
            this.cmbSelectUser.Location = new System.Drawing.Point(329, 30);
            this.cmbSelectUser.Name = "cmbSelectUser";
            this.cmbSelectUser.Size = new System.Drawing.Size(194, 23);
            this.cmbSelectUser.TabIndex = 22;
            this.cmbSelectUser.Text = "Anwender auswählen";
            this.cmbSelectUser.UseVisualStyleBackColor = true;
            this.cmbSelectUser.Click += new System.EventHandler(this.cmbSelectUser_Click);
            // 
            // regTxtBoxSearchFileName
            // 
            this.regTxtBoxSearchFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.SetColumnSpan(this.regTxtBoxSearchFileName, 3);
            this.regTxtBoxSearchFileName.Location = new System.Drawing.Point(83, 87);
            this.regTxtBoxSearchFileName.Max = -1;
            this.regTxtBoxSearchFileName.Min = -1;
            this.regTxtBoxSearchFileName.Name = "regTxtBoxSearchFileName";
            this.regTxtBoxSearchFileName.RegularExpression = null;
            this.regTxtBoxSearchFileName.Size = new System.Drawing.Size(440, 20);
            this.regTxtBoxSearchFileName.TabIndex = 23;
            // 
            // labSearchNotes
            // 
            this.labSearchNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchNotes.AutoSize = true;
            this.labSearchNotes.Location = new System.Drawing.Point(3, 116);
            this.labSearchNotes.Name = "labSearchNotes";
            this.labSearchNotes.Size = new System.Drawing.Size(43, 14);
            this.labSearchNotes.TabIndex = 24;
            this.labSearchNotes.Text = "Notizen";
            this.labSearchNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regTxtBoxSearchNotes
            // 
            this.regTxtBoxSearchNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.SetColumnSpan(this.regTxtBoxSearchNotes, 3);
            this.regTxtBoxSearchNotes.Location = new System.Drawing.Point(83, 113);
            this.regTxtBoxSearchNotes.Max = -1;
            this.regTxtBoxSearchNotes.Min = -1;
            this.regTxtBoxSearchNotes.Name = "regTxtBoxSearchNotes";
            this.regTxtBoxSearchNotes.RegularExpression = null;
            this.regTxtBoxSearchNotes.Size = new System.Drawing.Size(440, 20);
            this.regTxtBoxSearchNotes.TabIndex = 25;
            // 
            // comBoxSearchNotesTypes
            // 
            this.comBoxSearchNotesTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.SetColumnSpan(this.comBoxSearchNotesTypes, 2);
            this.comBoxSearchNotesTypes.FormattingEnabled = true;
            this.comBoxSearchNotesTypes.Location = new System.Drawing.Point(83, 139);
            this.comBoxSearchNotesTypes.Name = "comBoxSearchNotesTypes";
            this.comBoxSearchNotesTypes.Size = new System.Drawing.Size(240, 22);
            this.comBoxSearchNotesTypes.TabIndex = 26;
            this.comBoxSearchNotesTypes.SelectedIndexChanged += new System.EventHandler(this.comBoxSearchNotesTypes_SelectedIndexChanged);
            // 
            // labSearchMode
            // 
            this.labSearchMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSearchMode.AutoSize = true;
            this.labSearchMode.Location = new System.Drawing.Point(3, 195);
            this.labSearchMode.Name = "labSearchMode";
            this.labSearchMode.Size = new System.Drawing.Size(64, 14);
            this.labSearchMode.TabIndex = 25;
            this.labSearchMode.Text = "Suchmodus";
            this.labSearchMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comBoxSearchModeType
            // 
            this.comBoxSearchModeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutSearchOptions.SetColumnSpan(this.comBoxSearchModeType, 3);
            this.comBoxSearchModeType.FormattingEnabled = true;
            this.comBoxSearchModeType.Location = new System.Drawing.Point(83, 191);
            this.comBoxSearchModeType.Name = "comBoxSearchModeType";
            this.comBoxSearchModeType.Size = new System.Drawing.Size(440, 22);
            this.comBoxSearchModeType.TabIndex = 27;
            this.comBoxSearchModeType.SelectedIndexChanged += new System.EventHandler(this.comBoxSearchModeType_SelectedIndexChanged);
            // 
            // chkSearchInActDir
            // 
            this.chkSearchInActDir.AutoSize = true;
            this.chkSearchInActDir.Location = new System.Drawing.Point(83, 167);
            this.chkSearchInActDir.Name = "chkSearchInActDir";
            this.chkSearchInActDir.Size = new System.Drawing.Size(192, 18);
            this.chkSearchInActDir.TabIndex = 28;
            this.chkSearchInActDir.Text = "Nur aktuellen Ordner durchsuchen";
            this.chkSearchInActDir.UseVisualStyleBackColor = true;
            // 
            // comBoxSearchObjType
            // 
            this.tabLayoutSearchOptions.SetColumnSpan(this.comBoxSearchObjType, 2);
            this.comBoxSearchObjType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxSearchObjType.FormattingEnabled = true;
            this.comBoxSearchObjType.Location = new System.Drawing.Point(83, 3);
            this.comBoxSearchObjType.Name = "comBoxSearchObjType";
            this.comBoxSearchObjType.Size = new System.Drawing.Size(240, 21);
            this.comBoxSearchObjType.TabIndex = 29;
            // 
            // OutlookIndexingUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Name = "OutlookIndexingUControl";
            this.Size = new System.Drawing.Size(754, 449);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.grpBoxDocMasks.ResumeLayout(false);
            this.panelMasks.ResumeLayout(false);
            this.panelMasks.PerformLayout();
            this.grpBoxDataInput.ResumeLayout(false);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageDocMaskInput2.ResumeLayout(false);
            this.tabPageDocMaskInput2.PerformLayout();
            this.tabLayoutPanelBaseData.ResumeLayout(false);
            this.tabLayoutPanelBaseData.PerformLayout();
            this.tabPageSearchBaseData.ResumeLayout(false);
            this.tabPageSearchBaseData.PerformLayout();
            this.tabLayoutSearchBaseData.ResumeLayout(false);
            this.tabLayoutSearchBaseData.PerformLayout();
            this.tabPageAdditionalText.ResumeLayout(false);
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.tabLayoutSearchOptions.ResumeLayout(false);
            this.tabLayoutSearchOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tabLayoutPanelMasks;
        private BorderlessGroupBox grpBoxDocMasks;
        private System.Windows.Forms.Panel panelMasks;
        private BorderlessGroupBox grpBoxDataInput;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageDocMaskInput2;
        private System.Windows.Forms.TableLayoutPanel tabLayoutPanelBaseData;
        private ImageTextComboBox comBoxObjectType;
        private System.Windows.Forms.Label labDocumentDate;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label labCheckInDocDate;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.Label labActDocVersion;
        private System.Windows.Forms.TextBox txtBoxDocVersion;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerDocCheckInDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDocDate;
        private System.Windows.Forms.Label labShortDescription;
        private RegExTextBox txtBoxName;
        private System.Windows.Forms.TabPage tabPageSearchBaseData;
        private System.Windows.Forms.TableLayoutPanel tabLayoutSearchBaseData;
        private System.Windows.Forms.Label label1;
        private RegExTextBox regTxtBoxFullTxtSearch;
        private System.Windows.Forms.DateTimePicker dTPSearchDocSaveDateFrom;
        private System.Windows.Forms.Label labSearchCheckDateUntil;
        private System.Windows.Forms.DateTimePicker dTPSearchDocSaveDateUntil;
        private System.Windows.Forms.DateTimePicker dTPsearchDocDateFrom;
        private System.Windows.Forms.Label labSearchDocDataUntil;
        private System.Windows.Forms.DateTimePicker dTPsearchDocDateUntil;
        private RegExTextBox rgTxtBoxSearchName;
        private System.Windows.Forms.Label labSearchCheckDataFrom;
        private System.Windows.Forms.Label labSearchDocDateFrom;
        private System.Windows.Forms.Label labSearchShordDesc;
        private System.Windows.Forms.TabPage tabPageAdditionalText;
        private System.Windows.Forms.RichTextBox rTextBoxAdditionalText;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TableLayoutPanel tabLayoutSearchOptions;
        private System.Windows.Forms.Label labSearchObjType;
        private System.Windows.Forms.DateTimePicker dTPSearchExpiredDateFrom;
        private System.Windows.Forms.Label labExpiredDateUntil;
        private System.Windows.Forms.DateTimePicker dTPSearchExpiredDateUntil;
        private RegExTextBox regTxtBoxDocSavedByUser;
        private System.Windows.Forms.Label labSearchFileName;
        private System.Windows.Forms.Label labExpiredDateFrom;
        private System.Windows.Forms.Label labDocSavedByUser;
        private ImageTextComboBox comBoxSearchObjType;
        private System.Windows.Forms.Button cmbSelectUser;
        private RegExTextBox regTxtBoxSearchFileName;
        private System.Windows.Forms.Label labSearchNotes;
        private RegExTextBox regTxtBoxSearchNotes;
        private System.Windows.Forms.ComboBox comBoxSearchNotesTypes;
        private System.Windows.Forms.Label labSearchMode;
        private System.Windows.Forms.ComboBox comBoxSearchModeType;
        private System.Windows.Forms.CheckBox chkSearchInActDir;
        private System.Windows.Forms.CheckBox chkAddToFulltext;
    }
}
