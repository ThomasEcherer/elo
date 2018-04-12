/* Titel: 
 * =======
 * IndexingForm 
 * 
 * Author:
 * ========
 * Dario Ilicic
 * 
 * Beschreibung:
 * ================
 * Die Klasse IndexingForm stellt das Verschlagwortungsdialog dar.
 * Es beinhaltet die Verschlagwortung als UserControl.
 * 
 * 
 * Letzte Änderung: 
 * ================
 * 11/05/2009
 */



using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Common;
using log4net;







namespace EloixClientUI.Dialogs
{
    /// <summary>
    /// Die Klasse IndexingForm stellt ein Dialog zur Verschlagwortung dar.
    /// </summary>
    public partial class IndexingForm : Form
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(IndexingForm));

        /// <summary>
        /// Verbindung zum Indexserver
        /// </summary>
        private FWConnection ixConnection;

        /// <summary>
        /// Hintergrundfarbe
        /// </summary>
        private LinearGradientBrush Styleblue;

        /// <summary>
        /// Der Brush, der verwendet wird, um den Hintergrund zu zeichnen, fals UseCustomBackgroundBrush true.
        /// Der Standardwert ist StyleBlue.
        /// </summary>
        private Brush backgroundBrush;

        /// <summary>
        /// Referenz auf den mometan zu bearbeitenden Ordner/Dokument
        /// </summary>
        private FWSord actSelectedSord;

        /// <summary>
        /// True wenn der Benutzer nur lesend auf die Verschlagwortung
        /// zugreifen kann sonst false
        /// </summary>
        private bool isReadOnly;

        /// <summary>
        /// True wenn der Benutzer selber die Hintergrundfarbe auswählen kann, sonst false
        /// Bei false und customBackgroundBrush false wird StyleBlue als default Hintergrundfarbe verwendet.
        /// </summary>
        private bool customBackgroundColor = false;

        /// <summary>
        /// True wenn der Benutzer selber den Hintergrundbrush auswählen kann, sonst false
        /// Bei false und customBackgroundColor false wird StyleBlue als default Hintergrundfarbe verwendet.
        /// Falls backgroundBrush nicht gesetzt wird, wird StyleBlue verwendet.
        /// </summary>
        private bool customBackgroundBrush = false;

        /// <summary>
        /// Modus in dem das Verschlagwortungsdialog verwendet wird
        /// </summary>
        private IndexingDialogMode mode = IndexingDialogMode.IndexingMode;

        /// <summary>
        /// Referenz auf das Findinfo objekt für die Erweitertesuche
        /// </summary>
        private FindInfo searchFindInfo;

        /// <summary>
        /// Id des übergeordneten Ordners, in dem sich der Benutzer momentan
        /// im Archiv befindet
        /// </summary>
        private string parentId;

        private ColorBlend backGroundColor;










        #region Initialization
        /// <summary>
        /// Konstruktor
        /// </summary>
        public IndexingForm()
        {
            InitializeComponent();

            Icon = Properties.Resources.MainIcon;

            backGroundColor = new ColorBlend(3);
            backGroundColor.Colors = new Color[] { Color.FromArgb(194, 216, 240), Color.White, Color.FromArgb(194, 216, 240) };
            backGroundColor.Positions = new float[] { 0.0f, 0.5f, 1.0f };

            // Hintergrundfarbe des Verschlagwortungsdialogs
            Styleblue = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(194, 216, 240), Color.FromArgb(194, 217, 240), (float)90, false);
            Styleblue.InterpolationColors = backGroundColor;

            backgroundBrush = Styleblue;

            outlookIndexingUControl1.IndexFieldValidated += new EloixClientUI.Helpers.RegExEventHandler(outlookIndexingUControl1_IndexFieldValidated);
        }

        void outlookIndexingUControl1_IndexFieldValidated(object source, RegExEventArgs e)
        {
            // Wenn der Inhalt des Indexfeldes falsch ist
            if (!e.IsValid)
            {
                labelStateMsg.Text = "";
                labelStateMsg.Text = e.Msg;
                pBoxStateIcon.Image = EloixClientUI.Properties.Resources.fctIconDelete;
            }
            else
            {
                labelStateMsg.Text = "";
                pBoxStateIcon.Image = null;
            }
        }
        #endregion













        /// <summary>
        /// Speichert die Änderungen die in der Verschlagwortungsmaske vorgenommen wurden.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void cmbOk_Click(object sender, EventArgs e)
        {
            // prüfen ob alle Felder in Ordnung sind
            bool isValid = this.outlookIndexingUControl1.ProoveIndexFieldsContent();

            if (isValid)
            {
                if (mode == IndexingDialogMode.IndexingMode) actSelectedSord = this.outlookIndexingUControl1.GetSord();
                if (mode == IndexingDialogMode.SearchMode) searchFindInfo = outlookIndexingUControl1.SearchFindInfo;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (mode == IndexingDialogMode.IndexingMode) 
                    MessageBox.Show(this, Properties.Resources.Message_InvalidIndexingFields_Text, 
                                      Properties.Resources.InfoMessage_Title, 
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(mode == IndexingDialogMode.SearchMode)
                    MessageBox.Show(this, Properties.Resources.Message_Search_InputInvalid,
                                      Properties.Resources.InfoMessage_Title,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Beendet die Verschlagwortung ohne die Änderungen zu speichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCancel_Click(object sender, EventArgs e)
        {
            actSelectedSord = outlookIndexingUControl1.Sord;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Paints a background of a dialog
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!customBackgroundColor && !customBackgroundBrush)
            {
                Rectangle rect = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
                e.Graphics.FillRectangle(Styleblue, this.RectangleToClient(rect));
            }
            //else if (customBackgroundBrush)
            //{
            //    Rectangle rect = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //    LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Blue, Color.Wheat, 50);
            //    e.Graphics.FillRectangle(backgroundBrush, this.RectangleToClient(rect));
            //}

            
        }

        /// <summary>
        /// Setzt oder gibt zurück die Verbindung zum Indexserver
        /// </summary>
        public FWConnection IxConnection
        {
            get { return ixConnection; }
            set
            {
                ixConnection = value;
                outlookIndexingUControl1.IxConnection = ixConnection;
            }
        }

        /// <summary>
        /// Setzt oder gibt zurück das Dokument/den Ordner für den die Verschlagwortung
        /// durchgeführt werden soll
        /// </summary>
        public FWSord Sord
        {
            get { return actSelectedSord; }
            set
            {
                if (value != null && ixConnection != null)
                {
                    try
                    {
                        actSelectedSord = value;

                        // Feststellen ob der Benutzer die Verschlagwortungsmaske ändern darf
                        bool canChangeDockMask = ((actSelectedSord.Core.access & AccessC.LUR_WRITE) > 0);
                        outlookIndexingUControl1.CanChangeDocMask = canChangeDockMask;

                        outlookIndexingUControl1.ReadOnly = isReadOnly;
                        //outlookIndexingUControl1.ReadOnly = !canChangeDockMask;

                        // Falls der Benutzer die Verschlagwortungsmaske nicht ändern darf wird der Ok Button gesperrt
                        //cmbOk.Enabled = canChangeDockMask;
                        //cmbOk.Enabled = isReadOnly;

                        // Dialog anzeigen
                        outlookIndexingUControl1.SetSord(actSelectedSord);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(Properties.Resources.Error_Indexing_View, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Setzt den Modus der Verschlagwortungsmaske
        /// </summary>
        public IndexingDialogMode Mode
        {
            set
            {
                mode = value;
                if (mode == IndexingDialogMode.SearchMode) this.Text = Properties.Resources.Search;
                if (outlookIndexingUControl1 != null) outlookIndexingUControl1.Mode = value;
            }
        }

        /// <summary>
        /// Gibt die Referenz auf das FindInfo objekt zurück für die
        /// erweiterte Suche
        /// </summary>
        public FindInfo SearchFindInfo
        {
            get { return searchFindInfo; }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob der Benutzer die Verschlagwortungsmaske ändern darf
        /// </summary>
        public bool CanChangeDocMask
        {
            get { return outlookIndexingUControl1.CanChangeDocMask; }
            set { outlookIndexingUControl1.CanChangeDocMask = value; }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob der Benutzer lesend oder schreibend auf die
        /// Verschlagwortung zugreifen kann.
        /// True wenn der Benutzer nur lesen auf die Verschlagwortung zugreifen kann
        /// </summary>
        public bool IsReadOnly
        {
            set
            {
                this.isReadOnly = value;
                this.cmbOk.Enabled = !isReadOnly;
            }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob der Benutzer die Hintergrundfarbe auswählen kann.
        /// True wenn der Benutzer selber die Hintergrundfarbe auswählen kann, sonst false
        /// Bei false StyleBlue als default Hintergrundfarbe verwendet.
        /// </summary>
        public bool UseCustomBackgroundColor
        {
            get { return customBackgroundColor; }
            set { customBackgroundColor = value; }
        }

        /// <summary>
        /// True wenn der Benutzer selber den Hintergrundbrush auswählen kann, sonst false
        /// Bei false und customBackgroundColor false wird StyleBlue als default Hintergrundfarbe verwendet.
        /// Falls BackgroundBrush nicht gesetzt wird, wird StyleBlue verwendet.
        /// </summary>
        public bool UseCustomBackgroundBrush
        {
            get { return customBackgroundBrush; }
            set { customBackgroundBrush = value; }
        }

        /// <summary>
        /// Der Brush, der verwendet wird, um den Hintergrund zu zeichnen, fals UseCustomBackgroundBrush true.
        /// Der Standardwert ist StyleBlue.
        /// </summary>
        public Brush BackgroundBrush
        {
            get { return backgroundBrush; }
            set { backgroundBrush = value; }
        }

        /// <summary>
        /// Setzt für die erweiterte Suche die id des Übergeordneten
        /// Ordners, in dem sich der Benutzer momentan befindet
        /// </summary>
        public string ParentId
        {
            set 
            { 
                parentId = value;
                if (outlookIndexingUControl1 != null) outlookIndexingUControl1.ParentId = value;
            }
        }

        /// Sets the ObjectType in the options page.
        /// Only takes effect if in search mode.
        public SordType ObjectType
        {
            set
            {
                if (outlookIndexingUControl1 != null)
                {
                    outlookIndexingUControl1.ObjectType = value;
                }
            }
        }

        public int SearchMaskId
        {
            set
            {
                if (null != outlookIndexingUControl1)
                    outlookIndexingUControl1.SearchMaskId = value;
            }
        }

        /// <summary>
        /// Schließt der Benutzer das Fenster über das Kreuz oben rechts, dann
        /// wird dies als Cancel angenommen und dem entsprechend wird auch der
        /// Cancelbutton hier geklickt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void IndexingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) cmbCancel_Click(this, null);
        }

    }
}
