using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für ViewAndEditSord.
	/// </summary>
	public class ViewAndEditSordDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lbMasks;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbIDate;
		private System.Windows.Forms.Label lbIndex1;
		private System.Windows.Forms.Label lbIndex2;
		private System.Windows.Forms.TextBox txIndex1;
		private System.Windows.Forms.TextBox txIndex2;
		private System.Windows.Forms.TextBox txIndex3;
		private System.Windows.Forms.Label lbIndex3;
		private System.Windows.Forms.RichTextBox rtDesc;
		private System.Windows.Forms.Button bnOK;
		private System.Windows.Forms.Button bnCancel;
    private System.ComponentModel.IContainer components;

		IXConnection ix;
		IXServicePortC CONST;
		private System.Windows.Forms.DateTimePicker dtXDate;
		private System.Windows.Forms.DateTimePicker dtIDate;
		EditInfo ed;
    private System.Windows.Forms.ImageList imageListSordTypes;
    private System.Windows.Forms.ComboBox cbSordType;
    private System.Windows.Forms.PictureBox pbSordType;

		private bool lockChangeMaskIndex;

		public ViewAndEditSordDlg()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//

		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
	
		public void init(IXConnection ix, EditInfo ed) 
		{
			this.ix = ix;
			this.ed = ed;
			this.CONST = ix.CONST;

          for (int i = 0; i < ed.sordTypes.Length; i++) 
          {
            bool hasValidIcon = false;
            if (ed.sordTypes[i].icon != null)
            {
              try
              {
                System.IO.Stream strm = new System.IO.MemoryStream(ed.sordTypes[i].icon.data);
                System.Drawing.Image img = Image.FromStream(strm);
                imageListSordTypes.Images.Add(img);
                hasValidIcon = true;
              }
              catch (Exception)
              {
              }
            }
        
            if (!hasValidIcon)
            {
              System.Drawing.Image img = Image.FromFile("..\\..\\App.ico");
              imageListSordTypes.Images.Add(img);
            }
            cbSordType.Items.Add(ed.sordTypes[i].name);
      }
    }

		public Sord getSord() 
		{
			return ed.sord;
		}

		/// <summary>
		/// Convert ISO date into DateTime
		/// </summary>
		/// <param name="isoDate">ISO date</param>
		/// <returns>DateTime object</returns>
		private DateTime isoToDateTime(String isoDate)
		{
          int y = Convert.ToInt32(isoDate.Substring(0, 4));
          int m = Convert.ToInt32(isoDate.Substring(4, 2));
          int d = Convert.ToInt32(isoDate.Substring(6, 2));
          int h = Convert.ToInt32(isoDate.Substring(8, 2));
          int i = Convert.ToInt32(isoDate.Substring(10, 2));
          int s = Convert.ToInt32(isoDate.Substring(12, 2));
          DateTime dt = new DateTime(y, m, d, h, i, s);
          return dt;
		}

		private String dateTimeToIso(DateTime dt) 
		{
			String s = dt.ToString("yyyyMMddHHmmss");
			return s;
		}

		/// <summary>
		/// Reads EditInfo values into dialog elements
		/// </summary>
		private void load()
		{
			// list storage masks
			lockChangeMaskIndex = true;
			lbMasks.Items.Clear();
			for (int i = 0; i < ed.maskNames.Length; i++) 
			{
				lbMasks.Items.Add(ed.maskNames[i].name);
			}
			lockChangeMaskIndex = false;

			loadIndexingInfo();
		}

		/// <summary>
		/// Reads Sord values into dialog elements
		/// </summary>
		private void loadIndexingInfo()
		{
			// set name, description and dates
			txName.Text = ed.sord.name;
			rtDesc.Text = ed.sord.desc;
      
      // archiving date
      if (ed.sord.IDateIso != null && ed.sord.IDateIso.Length != 0)
      {
        dtIDate.Value = isoToDateTime(ed.sord.IDateIso);
      }
      
      // user defined date
      dtXDate.Checked = ed.sord.XDateIso != null && ed.sord.XDateIso.Length != 0;
      if (dtXDate.Checked)
      {
        dtXDate.Value = isoToDateTime(ed.sord.XDateIso);
      }
      
			// select mask
			lockChangeMaskIndex = true;
			lbMasks.SelectedItem = ed.mask.name;
			lockChangeMaskIndex = false;
				
			// handle index lines

			DocMask dm = ed.mask;
			Label[] labels = new Label[] {lbIndex1, lbIndex2, lbIndex3};
			TextBox[] textBoxes = new TextBox[] {txIndex1, txIndex2, txIndex3};

			for (int i = 0; i < labels.Length; i++) 
			{
				// visible?
				bool visible = (i < dm.lines.Length && i < ed.sord.objKeys.Length);
				labels[i].Visible = visible;
				textBoxes[i].Visible = visible;

				if (visible)
				{
					// label text from storage mask
					labels[i].Text = dm.lines[i].name;

					// enabled ?
					textBoxes[i].Enabled = dm.lines[i].canEdit;

					// hidden?
					labels[i].Visible = !dm.lines[i].hidden;
					textBoxes[i].Visible = !dm.lines[i].hidden;

					// index line data
					String data = "";
					if (ed.sord.objKeys[i].data.Length > 1)
					{
						// more then one value: ¶¶val1¶val2¶val3...
						data = "¶";
						for (int c = 0; c < ed.sord.objKeys[i].data.Length; c++) 
						{
							data += "¶" + ed.sord.objKeys[i].data[c];
						}
					} 
					else if (ed.sord.objKeys[i].data.Length == 1)
					{	
						// one value
						data = ed.sord.objKeys[i].data[0];
					}
					textBoxes[i].Text = data;
				}
			}
		}

		/// <summary>
		/// Stores dialog values into EditInfo values
		/// </summary>
		private void saveIndexingInfo() 
		{
			// name, desc, dates
			ed.sord.name = txName.Text;
			ed.sord.desc = rtDesc.Text;
			ed.sord.IDateIso = dateTimeToIso(dtIDate.Value);
			ed.sord.XDateIso = dateTimeToIso(dtXDate.Value);
			
			// index lines
			TextBox[] textBoxes = new TextBox[] {txIndex1, txIndex2, txIndex3};
			for (int i = 0; i < textBoxes.Length && textBoxes[i].Visible; i++) 
			{
				// write back only enabled index lines 
				if (!textBoxes[i].Enabled) continue;
				String data = textBoxes[i].Text;
				if (data.StartsWith("¶¶")) 
				{
					// many data values: ¶¶abc¶def¶ghi...
					// crack ¶-separated list into String array
					ArrayList arrData = new ArrayList();
					int p, p1 = 2;
					do 
					{
						p = data.IndexOf("¶", p1); 
						if (p < 0) p = data.Length;
						String item = data.Substring(p1, p-p1);
						arrData.Add(item);
						p1 = p+1;
					} while (p < data.Length);

					// copy dynamic array object to ObjKey[] array
					ed.sord.objKeys[i].data = new String[arrData.Count];
					int j = 0;
					System.Collections.IEnumerator en = arrData.GetEnumerator();
					while ( en.MoveNext() )
					{
						ed.sord.objKeys[i].data[j++] = (String)en.Current;
					}
				}
				else
				{
					// one value
					ed.sord.objKeys[i].data = new String[] {data};
				}
			}
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.lbMasks = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtXDate = new System.Windows.Forms.DateTimePicker();
            this.lbIDate = new System.Windows.Forms.Label();
            this.dtIDate = new System.Windows.Forms.DateTimePicker();
            this.lbIndex1 = new System.Windows.Forms.Label();
            this.txIndex1 = new System.Windows.Forms.TextBox();
            this.txIndex2 = new System.Windows.Forms.TextBox();
            this.lbIndex2 = new System.Windows.Forms.Label();
            this.txIndex3 = new System.Windows.Forms.TextBox();
            this.lbIndex3 = new System.Windows.Forms.Label();
            this.rtDesc = new System.Windows.Forms.RichTextBox();
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.cbSordType = new System.Windows.Forms.ComboBox();
            this.imageListSordTypes = new System.Windows.Forms.ImageList(this.components);
            this.pbSordType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSordType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMasks
            // 
            this.lbMasks.Location = new System.Drawing.Point(8, 8);
            this.lbMasks.Name = "lbMasks";
            this.lbMasks.Size = new System.Drawing.Size(120, 381);
            this.lbMasks.TabIndex = 0;
            this.lbMasks.SelectedIndexChanged += new System.EventHandler(this.lbMasks_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(136, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Short description";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(240, 8);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(200, 20);
            this.txName.TabIndex = 2;
            this.txName.Text = "txName";
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(136, 48);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(100, 23);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // dtXDate
            // 
            this.dtXDate.Checked = false;
            this.dtXDate.Location = new System.Drawing.Point(240, 48);
            this.dtXDate.Name = "dtXDate";
            this.dtXDate.ShowCheckBox = true;
            this.dtXDate.Size = new System.Drawing.Size(200, 20);
            this.dtXDate.TabIndex = 4;
            this.dtXDate.Value = new System.DateTime(2004, 10, 13, 16, 30, 34, 985);
            // 
            // lbIDate
            // 
            this.lbIDate.Location = new System.Drawing.Point(136, 88);
            this.lbIDate.Name = "lbIDate";
            this.lbIDate.Size = new System.Drawing.Size(100, 23);
            this.lbIDate.TabIndex = 5;
            this.lbIDate.Text = "Archiving date";
            // 
            // dtIDate
            // 
            this.dtIDate.Location = new System.Drawing.Point(240, 88);
            this.dtIDate.Name = "dtIDate";
            this.dtIDate.Size = new System.Drawing.Size(200, 20);
            this.dtIDate.TabIndex = 6;
            this.dtIDate.Value = new System.DateTime(2004, 10, 13, 16, 30, 34, 985);
            // 
            // lbIndex1
            // 
            this.lbIndex1.Location = new System.Drawing.Point(136, 160);
            this.lbIndex1.Name = "lbIndex1";
            this.lbIndex1.Size = new System.Drawing.Size(100, 23);
            this.lbIndex1.TabIndex = 7;
            this.lbIndex1.Text = "lbIndex1";
            // 
            // txIndex1
            // 
            this.txIndex1.Location = new System.Drawing.Point(240, 160);
            this.txIndex1.Name = "txIndex1";
            this.txIndex1.Size = new System.Drawing.Size(200, 20);
            this.txIndex1.TabIndex = 8;
            this.txIndex1.Text = "txIndex1";
            // 
            // txIndex2
            // 
            this.txIndex2.Location = new System.Drawing.Point(240, 192);
            this.txIndex2.Name = "txIndex2";
            this.txIndex2.Size = new System.Drawing.Size(200, 20);
            this.txIndex2.TabIndex = 10;
            this.txIndex2.Text = "txIndex2";
            // 
            // lbIndex2
            // 
            this.lbIndex2.Location = new System.Drawing.Point(136, 192);
            this.lbIndex2.Name = "lbIndex2";
            this.lbIndex2.Size = new System.Drawing.Size(100, 23);
            this.lbIndex2.TabIndex = 9;
            this.lbIndex2.Text = "lbIndex2";
            // 
            // txIndex3
            // 
            this.txIndex3.Location = new System.Drawing.Point(240, 224);
            this.txIndex3.Name = "txIndex3";
            this.txIndex3.Size = new System.Drawing.Size(200, 20);
            this.txIndex3.TabIndex = 12;
            this.txIndex3.Text = "txIndex3";
            // 
            // lbIndex3
            // 
            this.lbIndex3.Location = new System.Drawing.Point(136, 224);
            this.lbIndex3.Name = "lbIndex3";
            this.lbIndex3.Size = new System.Drawing.Size(100, 23);
            this.lbIndex3.TabIndex = 11;
            this.lbIndex3.Text = "lbIndex3";
            // 
            // rtDesc
            // 
            this.rtDesc.Location = new System.Drawing.Point(144, 256);
            this.rtDesc.Name = "rtDesc";
            this.rtDesc.Size = new System.Drawing.Size(296, 136);
            this.rtDesc.TabIndex = 13;
            this.rtDesc.Text = "rtDesc";
            // 
            // bnOK
            // 
            this.bnOK.Location = new System.Drawing.Point(456, 8);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(88, 23);
            this.bnOK.TabIndex = 14;
            this.bnOK.Text = "OK";
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(456, 40);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(88, 24);
            this.bnCancel.TabIndex = 15;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // cbSordType
            // 
            this.cbSordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSordType.Location = new System.Drawing.Point(240, 120);
            this.cbSordType.Name = "cbSordType";
            this.cbSordType.Size = new System.Drawing.Size(200, 21);
            this.cbSordType.TabIndex = 16;
            this.cbSordType.SelectedIndexChanged += new System.EventHandler(this.cbSordType_SelectedIndexChanged);
            // 
            // imageListSordTypes
            // 
            this.imageListSordTypes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSordTypes.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSordTypes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbSordType
            // 
            this.pbSordType.Location = new System.Drawing.Point(472, 120);
            this.pbSordType.Name = "pbSordType";
            this.pbSordType.Size = new System.Drawing.Size(32, 32);
            this.pbSordType.TabIndex = 17;
            this.pbSordType.TabStop = false;
            // 
            // ViewAndEditSordDlg
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.pbSordType);
            this.Controls.Add(this.cbSordType);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.rtDesc);
            this.Controls.Add(this.txIndex3);
            this.Controls.Add(this.lbIndex3);
            this.Controls.Add(this.txIndex2);
            this.Controls.Add(this.lbIndex2);
            this.Controls.Add(this.txIndex1);
            this.Controls.Add(this.lbIndex1);
            this.Controls.Add(this.dtIDate);
            this.Controls.Add(this.lbIDate);
            this.Controls.Add(this.dtXDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMasks);
            this.Name = "ViewAndEditSordDlg";
            this.Text = "ViewAndEditSord";
            this.Load += new System.EventHandler(this.ViewAndEditSord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSordType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
		#endregion

		private void ViewAndEditSord_Load(object sender, System.EventArgs e)
		{
			load();
		}

		private void bnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void bnOK_Click(object sender, System.EventArgs e)
		{
			saveIndexingInfo();
			this.Close();
		}

		private void lbMasks_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lockChangeMaskIndex) return;

			saveIndexingInfo();		

			String maskName = lbMasks.Items[lbMasks.SelectedIndex].ToString();

			ed = ix.Ix.changeSordMask(ed.sord, maskName, EditInfoC.mbAll);

			loadIndexingInfo();
		}

        private void cbSordType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
          pbSordType.Image = imageListSordTypes.Images[cbSordType.SelectedIndex];
        }
	}
}
