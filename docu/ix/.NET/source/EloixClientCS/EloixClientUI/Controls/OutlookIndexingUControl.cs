using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.MasterData;
using EloixClientUI.Common;
using EloixClientUI.Controls.combobox;
using EloixClientUI.Helpers;
using log4net;







namespace EloixClientUI.Controls
{
    /// <summary>
    /// Titel: 
    /// =============
    /// OutlookIndexingUControl
    ///  
    ///  
    /// Author: 
    /// ===============
    /// Dario Ilicic
    ///  
    /// 
    /// Beschreibung:
    /// =================
    /// Das UserControl OutlookIndexingUControl stellt ein Control
    /// zur Verschlagwortung in dem Outlook AddIn dar. Es listet
    /// verfügbaren Verschlagwortungsmasken auf. * 
    /// 
    ///  
    /// Letzte Änderung:
    /// ===================
    /// 11/05/2009
    /// 
    /// </summary>
    public partial class OutlookIndexingUControl : UserControl
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(OutlookIndexingUControl));
        private string test;
        /// <summary>
        /// Dieser Delegate wird benutzt um die Controls für die ausgewählte
        /// Verschlagwortungsmaske asynchron zu laden
        /// </summary>
        /// <param name="docMask">Verschlagwortungsmaske, für die Controls zur Eingabe angezeigt werden sollen</param>
        private delegate void SetDocMaskDelegate(DocMask docMask);

        /// <summary>
        /// Verbindung zum Indexserver
        /// </summary>
        private FWConnection ixConnection;

        /// <summary>
        /// Auflistung aller Controls, die Aufgrund der Auswahl eines Verschlagwortungsmaske
        /// in die Benutzeroberfläche eingefügt wurden
        /// </summary>
        private List<Control> maskLineControls;

        /// <summary>
        /// Momentan ausgewählte Verschlagwortungsmaske
        /// </summary>
        private DocMask actSelectedDocMask;

        /// <summary>
        /// Referenz auf die momentan ausgewählte Verschlagwortungsmaske
        /// </summary>
        private Button actSelectedMaskButton;

        /// <summary>
        /// True wenn die Daten in der Verschagwortungsmaske verändert werden dürfen, sonst false
        /// </summary>
        private bool readOnly = false;

        /// <summary>
        /// True wenn der Benutzer die Verschlagwortungsmaske ändern darf sonst false
        /// </summary>
        private bool canChangeDocMask = false;

        /// <summary>
        /// Auflistung aller Controls die zur Eingabe in der Verschlagwortungsmaske dienen
        /// </summary>
        private Dictionary<int, Control> indexFieldControls = new Dictionary<int, Control>();

        /// <summary>
        /// Auflistung aller Verschlagwortungsmasken
        /// </summary>
        private Dictionary<int, Button> docMaskCollection = new Dictionary<int, Button>();

        /// <summary>
        /// Referen auf das Sord objekt dessen Daten in dem Verschlagwortungscontrol angezeigt werden
        /// </summary>
        private FWSord actSelectedSord;

        /// <summary>
        /// Modus in dem das Dialog betrieben wird, dieses ist defaultmäßig auf Verschlagwortungsmodus gesetzt
        /// </summary>
        private IndexingDialogMode mode = IndexingDialogMode.IndexingMode;

        /// <summary>
        /// Referenz auf das Dialog, dass zur Auswahl des Benutzers für die Suchoption "Abgelegt von" angezeigt wird
        /// </summary>
        private Form userFormDialog;

        /// <summary>
        /// Wird zur Anzeige aller Benutzer verwendet
        /// </summary>
        private UserListView userLView;

        /// <summary>
        /// Temporäre speicherung der aktuellen Datumswerte
        /// </summary>
        private DateTime searchDocDateFrom;
        private DateTime searchDocDateUntil;
        private DateTime searchSavedDocDateFrom;
        private DateTime searchSavedDocDateUntil;
        private DateTime searchExpiredDateFrom;
        private DateTime searchExpiredDateUntil;

        /// <summary>
        /// Diese Sord objekt wird temporär Benutzt, um 
        /// darin die ObjKeys für die ausgewählte Verschlagwortungsmaske
        /// zu setzen und um auf diese zuzugreifen beim Erstellen des
        /// FindInfo objekts
        /// </summary>
        private Sord tempSordForSearch;


        /// <summary>
        /// Id des übergeordneten Ordners, in dem sich der Benutzer momentan
        /// im Archiv befindet
        /// </summary>
        private string parentId;

        private int _searchMaskId = 0;
        public int SearchMaskId
        {
            set { _searchMaskId = value; }
        }

        /// <event>
        /// Wird ausgelöt wenn der Inhalt eines Controls überprüft wurde
        /// </event>
        public event RegExEventHandler IndexFieldValidated;














        #region Initialization
        /// <summary>
        /// Konstruktor
        /// </summary>
        public OutlookIndexingUControl()
        {
            InitializeComponent();

            // Initialisierung der Collection
            maskLineControls = new List<Control>();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // Datumswerte tempärer speichern wird für die Überprüfung benötigt
            this.searchDocDateFrom = dTPsearchDocDateFrom.Value;
            this.searchDocDateUntil = dTPsearchDocDateUntil.Value;
            this.searchSavedDocDateFrom = dTPSearchDocSaveDateFrom.Value;
            this.searchSavedDocDateUntil = dTPSearchDocSaveDateUntil.Value;
            this.searchExpiredDateFrom = dTPSearchExpiredDateFrom.Value;
            this.searchExpiredDateUntil = dTPSearchExpiredDateUntil.Value;

            // Regulärerenausdruck für den Namen setzen
            txtBoxName.RegularExpression = RegularExpresionsDataBase.RegEx_Min1Char;
            txtBoxName.Message           = Properties.Resources.Error_Indexing_ShortDescription_BelowMinLength;
            txtBoxName.Validated        += new RegExEventHandler(indexField_Validated);

            chkAddToFulltext.Text = Properties.Resources.CheckBox_AddToFulltext_Text;
        }
        #endregion
        













        /// <summary>
        /// Lädt die Liste aller verfügbaren Verschlagwortungsmasken und zeigt diese
        /// an der Benutzeroberfläche an.
        /// </summary>
        /// <param name="ixConn">Verbindung zum Indexserver</param>
        /// <param name="tabLayoutPanel">Referenz auf das TableLayoutPanel, in dem die Verschlagwortungsmasken angezeigt werden sollen</param>
        /// <exception cref="ArgumentNullException">Wird geworfen wenn entweder die Verbindung zum Indexserver oder die Referenz auf TableLayoutPanel null ist</exception>
        /// <exception cref="Exception">Falls ein unerwarteter Fehler auftritt</exception>
        private void InitMaskList(FWConnection ixConn, TableLayoutPanel tabLayoutPanel, bool searchMask, bool folderMask, bool documentMask)
        {
            try
            {
                if (ixConn != null && tabLayoutPanel != null)
                {
                    if (ixConn.Content != null && ixConn.MasterData.DocMasks != null && ixConn.MasterData.DocMasks.MaskNames != null)
                    {
                        // Anzeige löschen
                        if (tabLayoutPanelMasks != null && tabLayoutPanelMasks.Controls != null) tabLayoutPanelMasks.Controls.Clear();
                        if (docMaskCollection != null) docMaskCollection.Clear();
                        
                        // Verschlagwortungsmasken auflisten
                        foreach (MaskName docMask in ixConn.MasterData.DocMasks.MaskNames)
                        {
                            if (searchMask && docMask.searchMask || folderMask && docMask.folderMask || documentMask && docMask.documentMask)
                            {
                                Button newDocMask = new Button();
                                newDocMask.Enabled = (docMask.access & AccessC.LUR_READ) > 0;
                                newDocMask.BackColor = Color.Transparent;
                                newDocMask.Font = new Font("Arial", 9f, FontStyle.Bold);
                                newDocMask.AutoSize = false;
                                newDocMask.Height = 20;
                                newDocMask.Text = docMask.name;
                                newDocMask.Margin = new Padding(0);
                                newDocMask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                                newDocMask.TextAlign = ContentAlignment.MiddleLeft;
                                //newDocMask.Tag = ixConn.MasterData.DocMaskCache.TryGetValue(docMask.id);
                                FWDocMask mask = null;
                                ixConn.MasterData.DocMasks.TryGetValue(docMask.id, out mask);
                                newDocMask.Tag = mask.Core;
                                newDocMask.MouseMove += new MouseEventHandler(newDocMask_MouseMove);
                                newDocMask.MouseLeave += new EventHandler(newDocMask_MouseLeave);
                                newDocMask.Click += new EventHandler(newDocMask_Click);
                                newDocMask.BackgroundImageLayout = ImageLayout.Stretch;
                                if (tabLayoutPanelMasks != null && tabLayoutPanelMasks.Controls != null) tabLayoutPanelMasks.Controls.Add(newDocMask);
                                if (docMaskCollection != null && !docMaskCollection.ContainsKey(docMask.id)) docMaskCollection.Add(docMask.id, newDocMask);
                            }
                        }
                    }
                }
                else
                {
                    logger.Error(Properties.Resources.Error_Indexing_DocMasks_NoConnection);
                    throw new ArgumentNullException(Properties.Resources.Exception_Indexing_NoConnectionOrPanelRef_Message);
                }
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Exception_Indexing_LoadDocMasks_Message, ex);

                // Anzeige löschen bei 
                if (tabLayoutPanel != null && tabLayoutPanel.Controls != null) tabLayoutPanel.Controls.Clear();
                if (docMaskCollection != null) docMaskCollection.Clear();
            }
        }

        /// <summary>
        /// Zeigt die Eingabefelder der neuen Verschlagwortungsmaske in der Benutzeroberfläche an
        /// </summary>
        /// <param name="docMask">Verschlagwortungsmaske, derren Eingabefelder in der Benutzeroberfläche angezeigt werden sollen</param>
        /// <exception cref="ArgumentNullException">Wird geworfen wenn docMask null ist</exception>
        /// <exception cref="Exception">Wird geworfen wenn ein unerwarteter Fehler auftritt</exception>
        private void SetNewDocMask(DocMask docMask)
        {
            try
            {
                if (docMask != null)
                {
                    if (docMask != actSelectedDocMask && docMask.lines != null && tabLayoutPanelBaseData != null)
                    {
                        // Auflistung der Controls löschen
                        if (indexFieldControls != null) indexFieldControls.Clear();

                        // Löschen der Controls in den entsprechenden Tabpages
                        if (mode == IndexingDialogMode.IndexingMode) ClearView(tabLayoutPanelBaseData, maskLineControls);
                        if (mode == IndexingDialogMode.SearchMode) ClearView(tabLayoutSearchBaseData, maskLineControls);

                        int line = (mode == IndexingDialogMode.IndexingMode ? 5 : 4);
                        // Eingabefelder der ausgewählten Verschlagwortungsmaske anzeigen
                        foreach (DocMaskLine docMaskLine in docMask.lines)
                        {
                            // Bezeichngung des Eingabefeldes
                            Label docMaskLineName = new Label();
                            docMaskLineName.BackColor = Color.Transparent;
                            docMaskLineName.Font = new Font("Arial", 8.25f);
                            docMaskLineName.Text = docMaskLine.name;
                            docMaskLineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                            docMaskLineName.Margin = new Padding(4);
                            docMaskLineName.AutoSize = true;
                            docMaskLineName.Visible = !docMaskLine.hidden;
                            docMaskLineName.Enabled = docMaskLine.canEdit && !docMaskLine.readOnly;

                            // Feld zum Eingeben des Indexwertes laden
                            Control indexFieldControl = GetIndexFieldControl(docMaskLine);

                            // Falls Indexfeld erzeugt wurde
                            if (indexFieldControl != null)
                            {
                                indexFieldControl.Tag = docMaskLine;
                                indexFieldControl.Font = new Font("Arial", 8.25f);
                                indexFieldControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                                indexFieldControl.Margin = new Padding(4);
                                indexFieldControl.Enabled = docMaskLine.canEdit && !docMaskLine.readOnly;
                                indexFieldControl.Visible = !docMaskLine.hidden;

                                // Hinzufügen der Indexcontrols
                                TableLayoutPanel tabLayoutControls = null;

                                if (mode == IndexingDialogMode.IndexingMode) tabLayoutControls = this.tabLayoutPanelBaseData;
                                if (mode == IndexingDialogMode.SearchMode) tabLayoutControls = this.tabLayoutSearchBaseData;

                                // Indexfeld in das Tablelayout setzen
                                if (tabLayoutControls != null && tabLayoutControls.Controls != null)
                                {
                                    // Name des Indexfeldes
                                    tabLayoutControls.Controls.Add(docMaskLineName, 0, line);
                                    // Control zur Eingabe des Indexwertes
                                    tabLayoutControls.Controls.Add(indexFieldControl, 1, line);
                                    tabLayoutControls.SetColumnSpan(indexFieldControl, 3);
                                    Refresh();
                                }

                                if (maskLineControls == null) maskLineControls = new List<Control>();

                                // Speichern der gesamten Indexzeile
                                if (maskLineControls != null)
                                {
                                    maskLineControls.Add(docMaskLineName);
                                    maskLineControls.Add(indexFieldControl);
                                }

                                // Speichern des Indexfeldes, das zur Eingabe dient
                                if (indexFieldControls != null) indexFieldControls.Add(docMaskLine.id, indexFieldControl);

                                // Zeilennummer erhöhen
                                line++;
                            }
                            else
                            {
                                MessageBox.Show(
                                    Properties.Resources.Error_Indexing_UnknownError_IndexingFields,
                                    Properties.Resources.InfoMessage_Title,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // die ausgewählte Verschlagwortungsmaske speichern
                        actSelectedDocMask = docMask;
                    }
                }
                else
                {
                    logger.Error(Properties.Resources.Error_Indexing_IndexingFields_DocMaskNull);
                    throw new ArgumentNullException(Properties.Resources.Exception_Indexing_SetNewDocMaskNullRef_Message);
                }
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_UnknownError_SetDocMask, ex);
                MessageBox.Show(
                    Properties.Resources.Error_Indexing_UnknownError_DocMaskView,
                    Properties.Resources.InfoMessage_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Verschlagwortungscontrols entfernen
                if (mode == IndexingDialogMode.IndexingMode) ClearView(tabLayoutPanelBaseData, maskLineControls);
                if (mode == IndexingDialogMode.SearchMode) ClearView(tabLayoutSearchBaseData, maskLineControls);

                // Alles auf default Zusand setzen
                if (indexFieldControls != null) indexFieldControls.Clear();
                this.Refresh();
            }
        }

        /// <summary>
        /// Entfernt alle Controls, die zu einer Verschlagwortungsmaske gehören aus der Ansicht.
        /// </summary>
        /// <param name="indexingControlsContainer">Container aus dem die Controls entfernt werden sollen</param>
        /// <param name="controlsToRemove">Controls, die gelöscht werden sollen</param>
        private void ClearView(TableLayoutPanel indexingControlsContainer, List<Control> controlsToRemove)
        {
            if (indexingControlsContainer != null && controlsToRemove != null && controlsToRemove.Count > 0)
            {
                try
                {
                    // Entferne alle alten indexzeilen
                    foreach (Control ctrl in controlsToRemove)
                    {
                        indexingControlsContainer.Controls.Remove(ctrl);
                    }

                    controlsToRemove.Clear();
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_ClearView_Message, ex);
                }
            }
        }

        /// <summary>
        /// Erstellt für eine Zeile der Verschlagwortungsmaske das entsprechenden Control
        /// </summary>
        /// <param name="docMaskLine">Zeile der Verschlagwortungsmaske</param>
        /// <returns>
        /// Das Control für die Zeile der Verschlagwortungsmaske oder null
        /// </returns>
        /// <exception cref="ArgumentNullException">Wird geworfen wenn für docMaskLine null übergeben wird</exception>
        /// <exception cref="Exception">Wird geworfen wenn ein unerwarteter Fehler auftritt</exception>
        private Control GetIndexFieldControl(DocMaskLine docMaskLine)
        {
            Control indexFieldControl = null;

            if (docMaskLine != null)
            {
                // Erstellen des Controls für die Verschlagwortungszeile
                switch (docMaskLine.type)
                {
                    case DocMaskLineC.TYPE_DATE:
                    case DocMaskLineC.TYPE_ISO_DATE:

                        DateTimePicker dateTimePicker = new DateTimePicker();
                        dateTimePicker.Format = DateTimePickerFormat.Custom;
                        dateTimePicker.CustomFormat = "dd.MM.yyyy";
                        indexFieldControl = dateTimePicker;
                        break;

                    //case DocMaskLineC.TYPE_ISO_DATE:
                    //    RegExTextBox regExTextBox = new RegExTextBox();
                    //    // d entspricht [0-9]
                    //    // D entspricht [^0-9]
                    //    //\d steht für ziffer {4}(jahr vierstellig) soll vier mal am anfang vorkommen
                    //    //\D? ein zeichen kann vorkommen muss nicht es handelt sich dabei aber um keine ziffer
                    //    //0[1-9]|1[0-2], wenn wir 0 haben dann kann als zweite Ziffer, eine zahl zwischen 1 und 9 vorkommen
                    //    // wenn die erste ziffer eine 1 ist dann kann die zweite Zahl zwischen 10 und 12 liegen (12 monate)
                    //    // der letzte abschnitt ist für die tage/ 
                    //    //regExTextBox.Regular_Expression = @"^(\d{4})\D?(0[1-9]|1[0-2])\D?([12]\d|0[1-9]|3[01])$";

                    //    // setzen der regular expression für iso datum
                    //    regExTextBox.Regular_Expression = @"^(\d{4})(0[1-9]|1[0-2])([12]\d|0[1-9]|3[01])$";
                    //    indexFieldControl = regExTextBox;
                    //    break;

                    case DocMaskLineC.TYPE_LIST:
                        indexFieldControl = CreateKeywordTextBox(docMaskLine, false);
                        break;

                    case DocMaskLineC.TYPE_TEXT:
                        indexFieldControl = CreateKeywordTextBox(docMaskLine, docMaskLine.onlyBuzzwords);
                        break;

                    case DocMaskLineC.TYPE_NUMBER_F0:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_IntNumber, Properties.Resources.Message_Indexing_Validation_IntegerField);
                        break;

                    case DocMaskLineC.TYPE_NUMBER:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_IntNumber, Properties.Resources.Message_Indexing_Validation_IntegerField);
                        break;

                    case DocMaskLineC.TYPE_NUMBER_F1:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_DoubleNumberWithFraction(1), Properties.Resources.Message_Indexing_Validation_DoubleF1Field);
                        break;

                    case DocMaskLineC.TYPE_NUMBER_F2:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_DoubleNumberWithFraction(2), string.Format(Properties.Resources.Message_Indexing_Validation_DoubleFxField, Properties.Resources.Numbers_Two));
                        break;

                    case DocMaskLineC.TYPE_NUMBER_F4:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_DoubleNumberWithFraction(4), string.Format(Properties.Resources.Message_Indexing_Validation_DoubleFxField, Properties.Resources.Numbers_Four));
                        break;

                    case DocMaskLineC.TYPE_NUMBER_F6:
                        indexFieldControl = CreateRegExTxtBox(docMaskLine, RegularExpresionsDataBase.RegEx_DoubleNumberWithFraction(6), string.Format(Properties.Resources.Message_Indexing_Validation_DoubleFxField, Properties.Resources.Numbers_Six));
                        break;

                    case DocMaskLineC.TYPE_USER:
                        indexFieldControl = CreateKeywordTextBox(docMaskLine, docMaskLine.onlyBuzzwords);
                        break;
                    default:
                        indexFieldControl = new TextBox();
                        break;
                }

                if (indexFieldControl != null)
                {
                    indexFieldControl.Enabled = (docMaskLine.canEdit && !docMaskLine.readOnly);
                    indexFieldControl.Visible = !docMaskLine.hidden;
                }
            }
            else
            {
                throw new ArgumentNullException(Properties.Resources.Exception_Indexing_GetIndexFieldControlNullRef_Message);
            }

            return indexFieldControl;
        }

        /// <summary>
        /// Erstellt für eine Indexzeile eine Textbox, die die Eingabe mit Hilfe von
        /// Reguläreren Ausdrücken überprüft.
        /// </summary>
        /// <param name="docMaskLine">Indexzeile für die das Control erstellt werden soll</param>
        /// <param name="regEx">Reulärerausdruck zum Überprüfen der Eingabe</param>
        /// <param name="errorMsg">Nachricht, die im Fehlerfall angezeigt werden soll</param>
        /// <returns>
        /// Control
        /// </returns>
        private Control CreateRegExTxtBox(DocMaskLine docMaskLine, string regEx, string errorMsg)
        {
            RegExTextBox regTxtBox = new RegExTextBox();
            if (docMaskLine != null)
            {
                regTxtBox.RegularExpression = regEx;
                regTxtBox.Min = docMaskLine.min;
                regTxtBox.Max = docMaskLine.max;
                if (errorMsg != null) regTxtBox.Message = errorMsg;
                regTxtBox.Validated += new RegExEventHandler(indexField_Validated);
            }
            return regTxtBox;
        }

        /// <summary>
        /// Initialisiert die Suchoptionen mit Daten
        /// </summary>
        private void InitSearchOptions()
        {
            // Suchtypen laden
            InitObjectList(ixConnection, comBoxSearchObjType, false, mode);

            // Notizentypen setzen
            InitNotesTypes(comBoxSearchNotesTypes);

            // Suchmodustypen laden
            InitSearchModeTypes(comBoxSearchModeType);
        }

        /// <summary>
        /// Gibt eine Referenz auf das FindInfo Objekt zurück mit dem
        /// dann die erweiterte Suche durchgeführt werden kann
        /// </summary>
        public FindInfo SearchFindInfo
        {
            get
            {
                FindInfo findInfo = new FindInfo();

                // Suche mit Hilfe der Indexwerte
                FindByIndex findByIndex = new FindByIndex();

                // Kurzbereichnung
                string name = rgTxtBoxSearchName.Text;
                if (name != null && !name.Equals(string.Empty)) findByIndex.name = name;

                // Zusatztext
                string desc = rTextBoxAdditionalText.Text;
                if (desc != null && !desc.Equals(string.Empty)) findByIndex.desc = desc;

                // Ablagemaske
                if (actSelectedDocMask != null) findByIndex.maskId = actSelectedDocMask.name;

                // Eingabefelder der Maske setzen
                findByIndex.objKeys = GetObjKeysDataForSearch(tempSordForSearch, indexFieldControls);

                // Dokumententendatum
                string date = GetDateRange(dTPsearchDocDateFrom, dTPsearchDocDateUntil);
                if (date != null && date != string.Empty) findByIndex.xDateIso = date;

                // Ablagedatum
                string savedDate = GetDateRange(dTPSearchDocSaveDateFrom, dTPSearchDocSaveDateUntil);
                if (savedDate != null && savedDate != string.Empty) findByIndex.iDateIso = savedDate;

                // Verfallsdatum
                string delDate = GetDateRange(dTPSearchExpiredDateFrom, dTPSearchExpiredDateUntil);
                if (delDate != null && delDate != string.Empty) findByIndex.delDateIso = delDate;

                // Besitzer
                string owner = regTxtBoxDocSavedByUser.Text;
                if (owner != null && !owner.Equals(string.Empty)) findByIndex.ownerId = owner;

                // Volltextsuche
                string fullTxt = regTxtBoxFullTxtSearch.Text;
                if (fullTxt != null && fullTxt != string.Empty)
                {
                    FindByFulltext findByFullTxt = new FindByFulltext();
                    findByFullTxt.term = fullTxt;
                    findInfo.findByFulltext = findByFullTxt;
                }

                // Datumsbereich trennzeichen
                FindOptions findOptions = new FindOptions();
                findOptions.rangeDelimiter = "...";

                // Suchmodus and oder or
                string searchType = (string)((ImageTextComboItem)comBoxSearchModeType.SelectedItem).Tag;
                if (searchType != null)
                {
                    string modeType = searchType.ToUpper();

                    // Suchoptionen werden mit or verknüpft
                    if (modeType.Equals("OR")) findOptions.searchMode = SearchModeC.OR;

                    // Suchoptionen werden mit and verknüpft
                    if (modeType.Equals("AND")) findOptions.searchMode = SearchModeC.AND;
                }

                // Suche nur im aktuellen Ordner durchführen
                if (chkSearchInActDir.Checked && parentId != null && parentId != string.Empty)
                {
                    FindChildren findChildren = new FindChildren();
                    findChildren.endLevel = -1;
                    findChildren.parentId = parentId;
                    findInfo.findChildren = findChildren;
                }

                findInfo.findOptions = findOptions;
                findInfo.findByIndex = findByIndex;
                findInfo.findByType = FindByType;
                findInfo.findByNotes = FindByNotes;

                return findInfo;
            }
        }

        /// <summary>
        /// Gibt den Typ der Objekte zurück nach denen gesucht werden soll
        /// </summary>
        private FindByType FindByType
        {
            get
            {
                if (comBoxSearchObjType != null)
                {
                    // Typ nach dem gesucht werden soll setzen
                    int type = comBoxSearchObjType.SelectedIndex;
                    FindByType findByType = new FindByType();

                    // Alle Typen
                    if (type == 0)
                    {
                        findByType = null;
                    }
                    // Nur Dokumente
                    else if (type == 1)
                    {
                        findByType.typeDocuments = true;
                    }
                    // Nur Ordner
                    else if (type == 2)
                    {
                        findByType.typeStructures = true;
                    }
                    else
                    {
                        if (comBoxSearchObjType.Text != null && comBoxSearchObjType.Text != string.Empty)
                        {
                            string typeName = comBoxSearchObjType.Text;
                            findByType.typeNames = new string[] { typeName };
                        }
                    }

                    return findByType;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Liefert den Typ der Notizen nach denen gesucht werden soll
        /// </summary>
        private FindByNotes FindByNotes
        {
            get
            {
                // Hat der Benutzer Sucheingabe für die Notizen gemacht
                string text = regTxtBoxSearchNotes.Text;
                // Falls der Benutzer nichts eingegeben hat wird null zurückgegeben und es
                // wird somit nicht nach Notizen gesucht
                if (text == null || text.Equals(string.Empty)) return null;

                // Falls der Benutzer Sucheingabe für Notizen eingegeben hat
                FindByNotes findByNotes = new FindByNotes();

                object type = null;
                if (comBoxSearchNotesTypes.SelectedItem != null) type = ((ImageTextComboItem)comBoxSearchNotesTypes.SelectedItem).Tag;

                if (type == null)
                {
                    // Suche nach allen Notiztypen (= -1)
                    findByNotes.type = -1;
                }
                else
                {
                    findByNotes.type = (int)type;
                }

                // Suchtexts
                findByNotes.term = text;

                return findByNotes;
            }
        }

        /// <summary>
        /// Liefert den Zeitbereich zwischen zwei Datums
        /// </summary>
        /// <param name="dTimePickerSearchDocDateFrom">Startdatum des Zeitbereichs</param>
        /// <param name="dTimePickerSearchDocDateUntil">Enddatum des Zeitbereichs</param>
        /// <returns>
        /// Zeitbereich in Form on String
        /// </returns>
        private string GetDateRange(DateTimePicker from, DateTimePicker until)
        {
            string dateRange = string.Empty;
            if (from != null || until != null)
            {
                try
                {
                    string startDate = string.Empty;
                    string endDate   = string.Empty;

                    if (from != null && from.Checked)   startDate = ixConnection.DateToIso(from.Value.Date);
                    if (until != null && until.Checked) endDate   = ixConnection.DateToIso(until.Value.Date);

                    dateRange = startDate;
                    if (endDate != null && endDate.Length > 0) dateRange += "..." + endDate;
                }
                catch (Exception ex)
                {
                    logger.Error("Beim Bestimmten des Datumbereichs für die Suche ist ein Fehler aufgetreten.", ex);
                    dateRange = string.Empty;
                }
            }
            return dateRange;
        }

        /// <summary>
        /// Lädt Modi in denen die Suche durchgeführt werden kann
        /// </summary>
        /// <param name="comBoxSearchModeType">Referenz auf die Combobox in der die Modi abgelegt werden sollen</param>
        private void InitSearchModeTypes(ComboBox comBoxSearchModeType)
        {
            if (comBoxSearchModeType != null && comBoxSearchModeType.Items != null)
            {
                try
                {
                    // Anzeige löschen
                    comBoxSearchModeType.Items.Clear();

                    // Auflistung aller Suchmodi
                    List<ImageTextComboItem> items = new List<ImageTextComboItem>();

                    ImageTextComboItem andMode = new ImageTextComboItem(Properties.Resources.SearchOption_ModeType_AND);
                    andMode.Tag = "AND";

                    ImageTextComboItem orMode = new ImageTextComboItem(Properties.Resources.SearchOption_ModeType_OR);
                    orMode.Tag = "OR";

                    items.Add(andMode);
                    items.Add(orMode);

                    comBoxSearchModeType.DataSource = items;
                    comBoxSearchModeType.DisplayMember = "Text";

                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_LoadingModeTypes_Message, ex);
                }
            }
        }

        /// <summary>
        /// Lädt alle Typen von Notizen nach denen gesucht werden kann.
        /// </summary>
        /// <param name="comBoxSearchNotesTypes">Referenz auf die ComboBox in der die Typen abgelegt werden sollen</param>
        private void InitNotesTypes(ComboBox comBoxSearchNotesTypes)
        {
            if (comBoxSearchNotesTypes != null && comBoxSearchNotesTypes.Items != null)
            {
                try
                {
                    // Anzeige löschen
                    comBoxSearchNotesTypes.Items.Clear();

                    // Auflistung aller Typen von Notizen nach denen gesucht werden kann
                    List<ImageTextComboItem> notesTypes = new List<ImageTextComboItem>();

                    ImageTextComboItem allNotes = new ImageTextComboItem(Properties.Resources.AllNotes);
                    allNotes.Tag = -1;

                    // weitere Notizentypen nach denen gesucht werden kann
                    ImageTextComboItem normalNotes = new ImageTextComboItem(GetNotesType(NoteC.TYPE_NORMAL));
                    normalNotes.Tag = NoteC.TYPE_NORMAL;

                    ImageTextComboItem personalNotes = new ImageTextComboItem(GetNotesType(NoteC.TYPE_PERSONAL));
                    personalNotes.Tag = NoteC.TYPE_PERSONAL;

                    ImageTextComboItem stampNotes = new ImageTextComboItem(GetNotesType(NoteC.TYPE_STAMP));
                    stampNotes.Tag = NoteC.TYPE_STAMP;

                    notesTypes.Add(allNotes);
                    notesTypes.Add(normalNotes);
                    notesTypes.Add(personalNotes);
                    notesTypes.Add(stampNotes);

                    comBoxSearchNotesTypes.DataSource = notesTypes;
                    comBoxSearchNotesTypes.DisplayMember = "Text";
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_LoadingNotesTypes_Message, ex);
                }
            }
        }

        /// <summary>
        /// Liefert den Namen des Notiztyps zu der entsprechenden Nummer des Notiztyps
        /// </summary>
        /// <param name="notesType">Konstante Nummer des Notiztyps</param>
        /// <returns>
        /// Name des Notiztyps zu der entsprechenden Nummer des Notiztyps
        /// </returns>
        private string GetNotesType(int notesType)
        {
            switch (notesType)
            {
                case NoteC.TYPE_NORMAL:
                    return Properties.Resources.GeneralNotes;
                case NoteC.TYPE_PERSONAL:
                    return Properties.Resources.PersonalNotes;
                case NoteC.TYPE_STAMP:
                    return Properties.Resources.Stamps;
                default:
                    return "";
            }
        }

        /// <summary>
        /// Zeigt im Fehlerfall die Nachricht von dem Indexfeld, das gearde auf Inhalt überprüft
        /// wurde. Falls der Inhalt des Indexfeldes richtig war, dann wird die Anzeige gelöscht.
        /// </summary>
        /// <param name="source">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void indexField_Validated(object source, RegExEventArgs e)
        {
            // Wenn der Inhalt des Indexfeldes falsch ist
            //if (!e.IsValid)
            //{
            //    labelStateMsg.Text = "";
            //    labelStateMsg.Text = e.Msg;
            //    pBoxStateIcon.Image = EloixClientUI.Properties.Resources.fctIconDelete;
            //}
            //else
            //{
            //    labelStateMsg.Text = "";
            //    pBoxStateIcon.Image = null;
            //}

            // Propagate the event to the form
            if (IndexFieldValidated != null)
                IndexFieldValidated(source, e);
        }

        /// <summary>
        /// Diese Methode erstellt eine KeywordTextBox in der die Schlüssel angezeigt werden.
        /// In der Methode wird aufgrund der id der DockMaskLine nach den entsprechenden
        /// Schlüsseln gesucht, die dann an die Keywordtextbox übergeben werden.
        /// </summary>
        /// <param name="line">Verschlagwortungszeige für die eine Keywordtextbox erstellt werden soll</param>
        /// <returns>
        /// Referenz auf die KeywordTextBox
        /// </returns>
        private Control CreateKeywordTextBox(DocMaskLine line, bool onlyKeywords)
        {
            OutlookKeywordTextBox keywordTxtBox = new OutlookKeywordTextBox();
            
            if (line != null && line.key != null)
            {
                try
                {
                    FWKeyword keywordList = null;
                    try
                    {
                        try
                        {
                            // Spezielle Schlüsselliste auswählen
                            if (ixConnection != null && ixConnection.MasterData != null && ixConnection.MasterData.Keywords != null)
                                keywordList = ixConnection.MasterData.Keywords[line.key];
                        }
                        catch
                        {
                            if (ixConnection != null && ixConnection.MasterData != null && ixConnection.MasterData.Keywords != null)
                                // Falls keine spezielle Liste vorhanden ist, die default liste setzen
                                keywordList = ixConnection.MasterData.Keywords[KeywordC.KWID_STANDARD_LIST];
                        }
                    }
                    catch { }

                    keywordTxtBox.KeywordList = keywordList;
                    keywordTxtBox.Editable    = !line.onlyBuzzwords;
                    keywordTxtBox.Validated  += new RegExEventHandler(indexField_Validated);

                    // setzen der minimalen und maximalen textlänge
                    keywordTxtBox.Min = line.min;
                    keywordTxtBox.Max = line.max;

                    if (!onlyKeywords)
                    {
                        keywordTxtBox.IsTextChangedHandlerActive = false;
                    }
                    else
                    {
                        keywordTxtBox.OnlyBuzzwordsAsInput = true;
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Exception_Indexing_CreateKeywordTextBox_Message, ex);
                }
            }

            return keywordTxtBox;
        }

        /// <summary>
        /// Erstellt eine Textbox in der nur Integerzahlen eingegeben werden können
        /// </summary>
        /// <param name="line">Verschlagwortungszeile für die eine Integertextbox erstellt werden soll</param>
        /// <returns>
        /// Referenz auf die IntegerTextBox
        /// </returns>
        private static Control CreateIntegerTextbox(DocMaskLine line)
        {
            NumericTextBox ntb = new NumericTextBox();
            if (line != null)
            {
                if (line.min > 0 && line.max > 0 && line.min <= line.max)
                {
                    ntb.MinLength = line.min;
                    ntb.MaxLength = line.max;
                }
            }
            ntb.Mode = NumericTextBox.NumericTextBoxMode.Integer;
            return ntb;
        }

        /// <summary>
        /// Erstellt eine Textbox in der nur dezimalzahlen eingegeben werden können.
        /// </summary>
        /// <param name="line">Verschlagwortungszeile für die eine Dezimaltextbox erstellt werde soll</param>
        /// <returns>
        /// Referenz auf die Dezimaltextbox
        /// </returns>
        private static Control CreateDecimalTextBox(DocMaskLine line)
        {
            NumericTextBox ntb = new NumericTextBox();
            if (line != null)
            {
                if (line.min > 0 && line.max > 0 && line.min <= line.max)
                {
                    ntb.MinLength = line.min;
                    ntb.MaxLength = line.max;
                }
            }
            ntb.Mode = NumericTextBox.NumericTextBoxMode.Integer;
            return ntb;
        }

        /// <summary>
        /// Zeigt die Verschlagwortungsmaske für das ausgewählte Dokuemnt/den ausgewählten Ordner an
        /// </summary>
        /// <param name="sord">Dokument/Ordner für den die Verschalgwortung angezeigt werden soll</param>
        /// <exception cref="ArgumentNullException">
        /// Wird geworfen, wenn die Referenz auf sord null ist
        /// oder keine Verbindung zum Indexserver übergeben wurde
        /// </exception>
        /// <exception cref="Exception">
        /// Wird geworfen, wenn keine Verbindung zum Indexserver übergeben wurde
        /// oder wenn ein unerwarteter Fehler auftritt
        /// </exception>
        public void SetSord(FWSord sord)
        {
            try
            {
                if (sord != null && ixConnection != null)
                {
                    if (mode == IndexingDialogMode.IndexingMode)
                    {
                        actSelectedSord = sord;

                        // Auflistung der Objekttypen initialisieren
                        InitObjectList(ixConnection, comBoxObjectType, actSelectedSord.IsDocument(), mode);

                        // Lade die Liste mit den Maskennamen
                        if (this.tabLayoutPanelMasks != null)
                        {
                            if (sord.IsDocument())
                            {
                                txtBoxDocVersion.Visible = true;
                                labActDocVersion.Visible = true;
                                // Nur Verschlagwortungsmasken für die Dokumente laden
                                InitMaskList(ixConnection, this.tabLayoutPanelMasks, false, false, true);
                            }
                            else
                            {
                                txtBoxDocVersion.Visible = false;
                                labActDocVersion.Visible = false;
                                // Nur Verschlagwortungsmasken für die Ordner laden
                                InitMaskList(ixConnection, this.tabLayoutPanelMasks, false, true, false);
                            }
                        }

                        FWDocMask sordDocMask = null;
                        try
                        {
                            //sordDocMask = ixConnection.MasterData.DocMaskCache.TryGetValue(sord.Core.mask);
                            ixConnection.MasterData.DocMasks.TryGetValue(sord.Core.mask, out sordDocMask);
                        }
                        catch (Exception ex)
                        {
                            logger.Error(Properties.Resources.Error_Indexing_GettingDocMaskFromCache_Message, ex);
                        }

                        if (sordDocMask != null)
                        {
                            // Den Button für die entsprechenden Verschlagwortung markieren
                            if (docMaskCollection != null && docMaskCollection.ContainsKey(sordDocMask.Id))
                            {
                                Button docMaskButton = docMaskCollection[sordDocMask.Id];
                                if (docMaskButton != null)
                                {
                                    docMaskButton.BackgroundImage = EloixClientUI.Properties.Resources.OutlookOrangeButton;
                                    actSelectedMaskButton = docMaskButton;
                                }
                                docMaskButton.Select();
                                docMaskButton.Show();
                            }

                            // Verschlagwortungsmakse anzeigen
                            SetNewDocMask(sordDocMask.Core);

                            // Verschlagwortungsmaske mit den Daten von Sord befüllen
                            SetSordData(actSelectedSord);
                        }
                    }
                    else
                    {
                        logger.Error(Properties.Resources.Error_Indexing_DocMaskView_SordNull);
                        MessageBox.Show(Properties.Resources.Message_Indexing_UnableToProcess_NoConnectionOrNoDoc,
                                        Properties.Resources.InfoMessage_Title,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_UnknownError_Process, ex);
                MessageBox.Show(string.Format(Properties.Resources.Message_ExceptionErrorMessage, ex.Message), Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Speichert die für in den Verschlagwortungszeilen eingebenenen Daten in dem
        /// Sord objekt und gibt dieses zurück.
        /// </summary>
        /// <returns>
        /// Referen auf das FWSord objekt oder null
        /// </returns>
        public FWSord GetSord()
        {
            try
            {
                return GetSordData(actSelectedSord);
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_TransferDocMaskChanges, ex);
                MessageBox.Show(
                    Properties.Resources.Message_Indexing_TransferDocMaskChangesError,
                    Properties.Resources.InfoMessage_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Befüllen der Verschlagwortungsmaske mit Daten
        /// </summary>
        /// <param name="sord">Ordner/Dokuemnt dessen Daten für das Befüllen benutzt werden sollen</param>
        private void SetSordData(FWSord sord)
        {
            if (sord != null && sord.Core != null)
            {
                // Kurzbezeichnung setzen
                if (sord.Core.name != null) txtBoxName.Text = sord.Core.name;

                // Dokumentendatum setzen
                if (sord.Core.IDateIso != null && sord.Core.IDateIso != string.Empty) dateTimePickerDocCheckInDate.Value = ixConnection.IsoToDate(sord.Core.IDateIso);

                // Ablagedatum setzen
                if (sord.Core.XDateIso != null && sord.Core.XDateIso != string.Empty) dateTimePickerDocDate.Value = ixConnection.IsoToDate(sord.Core.XDateIso);

                if (sord.IsDocument())
                {
                    txtBoxDocVersion.Visible = true;
                    labActDocVersion.Visible = true;

                    // Version setzen
                    if (sord.Core.docVersion != null) txtBoxDocVersion.Text = sord.Core.docVersion.version;
                }
                else
                {
                    txtBoxDocVersion.Visible = false;
                    labActDocVersion.Visible = false;
                }

                // In den Volltext aufnehmen?
                chkAddToFulltext.Checked = sord.Core.details.fulltext;

                // Benutzer setzen
                txtBoxUser.Text = sord.Core.ownerName;

                // Zusatztext setzen
                rTextBoxAdditionalText.Text = sord.Desc;

                try
                {
                    if (comBoxObjectType.Items != null && comBoxObjectType.Items.Count > 0) comBoxObjectType.SelectSordType(sord.Core.type);
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_SetObjectType, ex);
                }

                // Füllen der Verschlagwortungszeilen mit Daten
                if (indexFieldControls != null && sord.Core.objKeys != null)
                {
                    foreach (ObjKey objKey in sord.Core.objKeys)
                    {
                        if (objKey != null)
                        {
                            string data = string.Empty;

                            if (objKey.data != null)
                            {
                                if (objKey.data.Length > 1)
                                {
                                    StringBuilder stringBuilder = new StringBuilder();
                                    stringBuilder.Append("¶");

                                    for (int i = 0; i < objKey.data.Length; i++)
                                    {
                                        if (objKey.data[i] != null) stringBuilder.AppendFormat("¶{0}", objKey.data[i]);
                                    }
                                    data = stringBuilder.ToString();
                                }
                                else
                                {
                                    if (objKey.data.Length == 1 && objKey.data[0] != null) data = objKey.data[0];
                                }
                            }

                            try
                            {
                                if (indexFieldControls != null && indexFieldControls.ContainsKey(objKey.id) && indexFieldControls[objKey.id] is Control)
                                {
                                    // Zuweisen des Wertes zu dem Control
                                    Control indexFieldControl = indexFieldControls[objKey.id];
                                    DocMaskLine docMaskLine = (DocMaskLine)indexFieldControl.Tag;
                                    indexFieldControl.Tag = objKey;

                                    // Textchanged handler ausschalten
                                    if (indexFieldControl is OutlookKeywordTextBox) ((OutlookKeywordTextBox)indexFieldControl).IsTextChangedHandlerActive = false;

                                    // ISO Datum setzen
                                    if (indexFieldControl is DateTimePicker)
                                    {
                                        if (data != null && data != string.Empty)
                                        {
                                            if (docMaskLine.type == DocMaskLineC.TYPE_ISO_DATE)
                                            {
                                                try
                                                {
                                                    Regex expression = new Regex(@"^(\d{4})(0[1-9]|1[0-2])([12]\d|0[1-9]|3[01])$");
                                                    if (expression.IsMatch(data)) ((DateTimePicker)indexFieldControl).Value = ixConnection.IsoToDate(data);
                                                }
                                                catch (Exception ex)
                                                {
                                                    logger.Error(Properties.Resources.Error_Indexing_SetISODate, ex);
                                                }
                                            }
                                            else
                                            {
                                                ((DateTimePicker)indexFieldControl).Value = DateTime.Parse(data);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        indexFieldControl.Text = data;
                                    }

                                    if (indexFieldControl is OutlookKeywordTextBox) ((OutlookKeywordTextBox)indexFieldControl).IsTextChangedHandlerActive = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                logger.Error(Properties.Resources.Error_Indexing_SetDocMaskValues, ex);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Übernimmt die eingegebenen Daten aus dem Verschlagwortungsdialog
        /// und speichert diese in dem Sord objekt.
        /// </summary>
        /// <param name="sord">Sord objekt in dem die Verschlagwortungsdaten abegelegt werden</param>
        /// <returns>
        /// Referenz auf sord objekt oder null
        /// </returns>
        private FWSord GetSordData(FWSord sord)
        {
            if (sord != null && sord.Core != null)
            {
                // Kurzbezeichnung setzen
                sord.Core.name = txtBoxName.Text;

                // Dokumentendatum setzen
                if (ixConnection != null) sord.Core.IDateIso = ixConnection.DateToIso(dateTimePickerDocCheckInDate.Value);

                // Ablagedatum setzen
                if (ixConnection != null) sord.Core.XDateIso = ixConnection.DateToIso(dateTimePickerDocDate.Value);

                // Version setzen
                if (sord.Core.docVersion != null && sord.IsDocument()) sord.Core.docVersion.version = txtBoxDocVersion.Text;

                // Benutzer setzen
                sord.Core.ownerName = txtBoxUser.Text;

                // Zusatztext setzen
                sord.Core.desc = rTextBoxAdditionalText.Text;

                // Objekttyp setzen
                if (comBoxObjectType.SelectedItem != null && comBoxObjectType.SelectedItem is ImageTextComboItem && ((ImageTextComboItem)comBoxObjectType.SelectedItem).SordType != null)
                    sord.Core.type = ((ImageTextComboItem)comBoxObjectType.SelectedItem).SordType.id;

                // In den Volltext aufnehmen?
                sord.Core.details.fulltext = chkAddToFulltext.Checked;

                if (indexFieldControls != null && indexFieldControls.Keys != null && indexFieldControls.Keys.Count > 0)
                {
                    int i = 0;
                    foreach (int key in indexFieldControls.Keys)
                    {
                        Control tb = null;
                        if (indexFieldControls.ContainsKey(key)) tb = indexFieldControls[key] as Control;

                        if (tb != null)
                        {
                            //ObjKey objKey = (ObjKey)tb.Tag;

                            if (tb.Text.StartsWith("¶¶"))
                            {
                                actSelectedSord.Core.objKeys[i].data = tb.Text.Substring(2).Split('¶');
                            }
                            else
                            {
                                actSelectedSord.Core.objKeys[i].data = new string[] { tb.Text };
                            }
                        }
                        i++;
                    }
                }
            }
            return sord;
        }

        /// <summary>
        /// Zeigt die Eingabefelder der ausgewählten Verschlagwortungsmaske in der
        /// Benutzeroberfläche
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void newDocMask_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender != null && sender is Button)
                {
                    Button cmb = (Button)sender;

                    if (cmb != null && cmb.Tag != null && cmb.Tag is DocMask)
                    {
                        // Verschlagwortungsmaske laden
                        DocMask docMask = (DocMask)cmb.Tag;

                        if (mode == IndexingDialogMode.IndexingMode)
                        {
                            if (canChangeDocMask)
                            {
                                if (actSelectedMaskButton != null) actSelectedMaskButton.BackgroundImage = null;
                                actSelectedMaskButton = cmb;
                                cmb.BackgroundImage = EloixClientUI.Properties.Resources.OutlookOrangeButton;

                                // Indexzeilen mit Daten befüllen
                                if (actSelectedSord != null && ixConnection != null)
                                {
                                    // Verschlagwortungsmaske ermitteln 
                                    FWDocMask sordDocMask = null;
                                    try
                                    {
                                        //sordDocMask = ixConnection.MasterData.DocMaskCache.TryGetValue(actSelectedSord.Core.mask);
                                        ixConnection.MasterData.DocMasks.TryGetValue(actSelectedSord.Core.mask, out sordDocMask);
                                    }
                                    catch (Exception ex)
                                    {
                                        logger.Error(Properties.Resources.Error_Indexing_GettingDocMaskFromCache_Message, ex);
                                    }

                                    if (sordDocMask != null && docMask != null && sordDocMask.Id == docMask.id)
                                    {
                                        // Neue Verschlagwortungsmaske anzeigen
                                        SetNewDocMask(docMask);
                                        SetSordData(actSelectedSord);
                                    }
                                    else
                                    {
                                        DialogResult result = MessageBox.Show(
                                            Properties.Resources.Message_Indexing_ChangeDocMask,
                                            Properties.Resources.InfoMessage_Title,
                                            MessageBoxButtons.OKCancel);
                                        if (result == DialogResult.OK)
                                        {
                                            EditInfo newEditInfo = ixConnection.Ix.changeSordMask(actSelectedSord.Core, docMask.name, EditInfoC.mbSord);

                                            if (newEditInfo != null)
                                            {
                                                if (newEditInfo.sord.id == 1 || newEditInfo.sord.type < SordC.LBT_DOCUMENT)
                                                {
                                                    actSelectedSord = ixConnection.Content.ClassFactory.NewFolder(newEditInfo.sord);
                                                }
                                                else
                                                {
                                                    actSelectedSord = ixConnection.Content.ClassFactory.NewDocument(newEditInfo.sord);
                                                }
                                            }
                                            else
                                            {
                                                logger.Error(Properties.Resources.Error_Indexing_ChangeDocMask_EditInfoNull);
                                            }

                                            // Neue Verschlagwortungsmaske anzeigen
                                            BeginInvoke(new SetDocMaskDelegate(SetNewDocMask), new object[] { docMask });

                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    Properties.Resources.Message_Indexing_ChangeDocMask_InsufficentRights,
                                    Properties.Resources.InfoMessage_Title,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        // Im Suchmodus
                        if (mode == IndexingDialogMode.SearchMode)
                        {
                            // Hintergrundfarbe der selektierten Verschlagwortungsmaske anpassen
                            if (actSelectedMaskButton != null) actSelectedMaskButton.BackgroundImage = null;
                            actSelectedMaskButton = cmb;
                            cmb.BackgroundImage = EloixClientUI.Properties.Resources.OutlookOrangeButton;

                            // Neue Verschlagwortungsmaske anzeigen
                            BeginInvoke(new SetDocMaskDelegate(SetNewDocMask), new object[] { docMask });

                            // Eingabefelder der Verschlagwortungsmaske im Sord objekt setzen
                            tempSordForSearch = SetDocMaskInSord(docMask);
                        }
                    }
                }
                /*
                else
                {
                    if (mode == IndexingDialogMode.IndexingMode)
                        MessageBox.Show(
                            Properties.Resources.Message_Indexing_ChangeDocMask_InsufficentRights,
                            Properties.Resources.InfoMessage_Title,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 */

            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_SelectDocMask, ex);
            }
        }

        /// <summary>
        /// Wenn der Mousezeiger den Button zur Auswahl der Verschlagwortungsmaske
        /// verlässt, dann wird das ursprüngliche Hintergrundbild in dem Button
        /// gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void newDocMask_MouseLeave(object sender, EventArgs e)
        {
            if (sender != null && sender is Button)
            {
                Button cmb = (Button)sender;
                if (cmb != null && cmb != actSelectedMaskButton)
                {
                    cmb.BackgroundImage = null;
                    cmb.Refresh();
                }
            }
        }

        /// <summary>
        /// Wenn der Mousezeiger über dem Button zur Auswahl der Verschlagwortungsmaske
        /// bewegt wird, dann wird das Hintergrundbild des Buttons verändert.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void newDocMask_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender != null && sender is Button)
            {
                Button cmb = (Button)sender;
                if (cmb != null)
                {
                    //cmb.BackgroundImage = EloixClientUI.Properties.Resources.OutlookOrangeButton;
                    cmb.BackgroundImageLayout = ImageLayout.Stretch;
                    cmb.Refresh();
                }
            }
        }

        /// <summary>
        /// Lädt die Liste der verfügbaren Objekttypen in die Combobox.
        /// </summary>
        /// <param name="ixConn"></param>
        /// <param name="comBox"></param>
        private void InitObjectList(FWConnection ixConn, ImageTextComboBox comBox, bool isDocument, IndexingDialogMode mode)
        {
            if (ixConn != null && comBox != null && comBox.Items != null)
            {
                // Anzeige löschen
                comBox.Items.Clear();

                // Sordtypen laden
                SordType[] types = ixConn.Ix.checkoutSordTypes(null, SordTypeC.mbAllJPG, LockC.NO);
           
                if (types != null)
                {
                    // Alle erstellten ComboBoxItems für die vorhandenen Objekttypen
                    List<ImageTextComboItem> items = new List<ImageTextComboItem>();

                    // Liste der Bilder zu den objekttypen
                    ImageList images = new ImageList();

                    // Für die Suche werden noch ein paar allgemeine Typen zu den standard Objektypen hinzugefügt
                    if (mode == IndexingDialogMode.SearchMode)
                    {
                        items.Add(new ImageTextComboItem(Properties.Resources.AllTypes, -1));
                        items.Add(new ImageTextComboItem(Properties.Resources.AllDocuments, -1));
                        items.Add(new ImageTextComboItem(Properties.Resources.AllStructures, -1));
                    }

                    int index = 0;

                    foreach (SordType sordType in types)
                    {
                        // Für Suchmodus alle Objektypen laden
                        if (mode == IndexingDialogMode.SearchMode)
                        {
                            ImageTextComboItem item = CreateItemForSordType(sordType, index, images);
                            if (item != null)
                            {
                                // Falls nur ein Bild für das Item geladen werden konnte, den Index
                                // erhöhen um somit auf das nächste Bild zu referenzieren in der Auflistung images
                                if (item.ImageIndex != -1) index++;
                                items.Add(item);
                            }
                        }

                        // Im Verschlagwortungsmodus nur bestimmte SordTypen laden
                        if (mode == IndexingDialogMode.IndexingMode)
                        {
                            if (isDocument)
                            {
                                // Nur Sordtypen für die Dokumente laden
                                if (sordType.id >= SordC.LBT_DOCUMENT && sordType.id != SordC.LBT_ARCHIVE)
                                {
                                    ImageTextComboItem item = CreateItemForSordType(sordType, index, images);
                                    if (item != null)
                                    {
                                        if (item.ImageIndex != -1) index++;
                                        items.Add(item);
                                    }
                                }
                            }
                            else
                            {
                                // Nur Sordtypen für die Ordner laden
                                if (sordType.id < SordC.LBT_DOCUMENT || sordType.id == SordC.LBT_ARCHIVE)
                                {
                                    ImageTextComboItem item = CreateItemForSordType(sordType, index, images);
                                    if (item != null)
                                    {
                                        if (item.ImageIndex != -1) index++;
                                        items.Add(item);
                                    }
                                }
                            }
                        }
                    }

                    comBox.DataSource = items;
                    comBox.ImageList = images;
                }
            }
        }

        /// <summary>
        /// Sets the ObjectType in the options page.
        /// Only takes effect if in search mode.
        /// </summary>
        public SordType ObjectType
        {
            set { comBoxSearchObjType.SelectSordType(value.id); }
        }

        /// <summary>
        /// Die Methode überprüft von ob es sich bei dem SordTyp um ein Typ für Dokument
        /// oder Ordner handelt. Dementsprechend werden die Items für den SordTyp erstellt.
        /// </summary>
        /// <param name="isDocument">
        /// True wenn nur SordTypes für das Doument erzeugt werden sollen
        /// False wenn nur SordTypes für den Ordner erzeugt werden soll
        /// </param>
        /// <param name="sordType">
        /// SordType für den das Item erzeugt werden soll
        /// </param>
        /// <returns>
        /// Refeerenz auf das ImageTextComboItem oder null abhängig davon ob SordType
        /// sich auf Dokumente oder Ordner bezieht
        /// </returns>
        private ImageTextComboItem CreateItemForSordType(SordType sordType, int itemIndex, ImageList images)
        {
            // Neuer Item für den SordTyp
            ImageTextComboItem item = null;

            if (sordType != null && itemIndex >= 0)
            {
                try
                {
                    item = new ImageTextComboItem(sordType.name, itemIndex);
                    item.SordType = sordType;

                    // Bild für den Sordtyp laden
                    Image img = LoadSordTypeImg(sordType.icon.data);

                    if (img == null || images == null)
                    {
                        // Falls kein Bild geladen werden konnten ImageIndex = -1 (d.h. kein Bild) setzen
                        item.ImageIndex = -1;
                    }
                    else
                    {
                        if (images.Images != null) images.Images.Add(img);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_CreatingItemForSordType_Message, ex);
                    item = null;
                }
            }

            return item;
        }

        /// <summary>
        /// Lädt für einen Sordtyp aus den übergebenen bytedata das
        /// entsprechenden Image und gibt es zurück.
        /// </summary>
        /// <param name="imgData">Image des Sordtypes in Form von byte Daten</param>
        /// <returns>
        /// Referenz auf das geladen Image oder null falls das Bild nicht geladen werden konnte
        /// </returns>
        /// <remarks>
        /// Die Daten für das Bild des Sordtyps müssen als Jpg vorliegen da sonst Fehler auftreten
        /// </remarks>
        private Image LoadSordTypeImg(byte[] imgData)
        {
            Image sordTypeImg = null;
            System.IO.Stream strm = null;

            try
            {
                if (imgData != null)
                {
                    strm = new System.IO.MemoryStream(imgData);
                    if (strm != null) sordTypeImg = Image.FromStream(strm);
                }
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_LoadImageForObjectType, ex);
                sordTypeImg = null;
            }
            finally
            {
                if (strm != null) strm.Close();
            }

            return sordTypeImg;
        }

        /// <summary>
        /// Erzeugt für alle Indexzeilen der Verschlagwortungsmaske objkeys objekte und setzt diese
        /// in dem neu erzeugten Sord objekt, das dann zurückgegeben wird.
        /// </summary>
        /// <param name="docMask">Verschlagwortungsmaske, dessen Indexzeilen in Form von ObjKeys im Sordobjekt gesetzt werden sollen</param>
        /// <returns>
        /// Sord objekt mit ObjKey für jede Indexzeile der Verschlagwortungsmaske oder
        /// null, falls keine Verschlagwortungsmaske übergeben wurde
        /// </returns>
        private Sord SetDocMaskInSord(DocMask docMask)
        {
            Sord newSord = null;

            if (docMask != null)
            {
                try
                {
                    // neues sordobjekt erzeugen
                    newSord = new Sord();
                    SordDetails sordDetails = new SordDetails();
                    newSord.details = sordDetails;

                    // Indexfeld mit dem Dateinamen hat die id 51
                    bool isFileNameIndexLineFound = false;

                    List<ObjKey> objKeys = new List<ObjKey>();

                    // für jede indexzeile ein objkey erzeugen
                    foreach (DocMaskLine docMaskLine in docMask.lines)
                    {
                        ObjKey newObjKey = new ObjKey();
                        newObjKey.id = docMaskLine.id;
                        newObjKey.name = docMaskLine.key;

                        objKeys.Add(newObjKey);

                        // prüfen ob es sich bei den Indexzeile um das Feld für den Dateinamen handelt
                        if (newObjKey.id == DocMaskLineC.ID_FILENAME) isFileNameIndexLineFound = true;
                    }

                    // Zusätzliche objkeys mit der id > 49 übernehmen
                    ObjKey[] oldObjKeys = newSord.objKeys;
                    if (oldObjKeys != null)
                    {
                        for (int i = 0; i < oldObjKeys.Length; i++)
                        {
                            if (isFileNameIndexLineFound && (oldObjKeys[i].id == DocMaskLineC.ID_FILENAME)) continue;

                            ObjKey newObjKey = new ObjKey();
                            newObjKey.id = oldObjKeys[i].id;
                            newObjKey.name = oldObjKeys[i].name;
                            newObjKey.data = oldObjKeys[i].data;

                            objKeys.Add(newObjKey);
                        }
                    }

                    newSord.objKeys = objKeys.ToArray();
                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_SettingDocMaskInSord_Message, ex);
                }
            }

            return newSord;
        }

        /// <summary>
        /// Füllt die Objkeys der Sord mit den Daten, die der Benutzer eingeben hat
        /// und gibt diese als Array zurück.
        /// </summary>
        /// <param name="searchSord">Sord dessen objkeys mit Daten befüllt und als Array zurückgegeben werden sollen</param>
        /// <returns>
        /// Objkeys zusammen mit den eingegebenen Daten des Benutzers oder null
        /// </returns>
        private ObjKey[] GetObjKeysDataForSearch(Sord searchSord, Dictionary<int, Control> indexFieldControls)
        {
            ObjKey[] objKeys = null;

            if (indexFieldControls != null && indexFieldControls.Keys.Count > 0)
            {
                try
                {
                    // Ist die Indexzeile mit dem Dateinamen gefunden
                    bool isFileNameIndexLineFound = false;
                    List<ObjKey> filledObjKeys = new List<ObjKey>();

                    if (searchSord == null || searchSord.objKeys == null)
                    {
                        objKeys = new ObjKey[0];
                    }
                    else
                    {
                        foreach (ObjKey objKey in searchSord.objKeys)
                        {
                            string[] data = new string[1];
                            string value = string.Empty;

                            // Wenn die Indexzeile für den Dateinamen gefunden wurde
                            // dann wird dieser zusätzlich zu den weiteren ObjKeys dazu genommen
                            if (objKey.id == DocMaskLineC.ID_FILENAME)
                            {
                                isFileNameIndexLineFound = true;
                                // Dateiname auslesen
                                value = regTxtBoxSearchFileName.Text;
                            }
                            else
                            {
                                // Control für die entsprechende Indexzeile laden
                                Control ctrl = null;
                                if (indexFieldControls.ContainsKey(objKey.id)) ctrl = indexFieldControls[objKey.id];

                                // wert auslesen
                                if (ctrl != null) value = ctrl.Text;
                            }

                            if (value != null)
                            {
                                if (value.IndexOf('¶') > -1)
                                {
                                    if (value.Length >= 2)
                                    {
                                        //string firstChar = value.Substring(0, 1);
                                        //string secondChar = value.Substring(1, 1);

                                        //if (firstChar.Equals("¶") && secondChar.Equals("¶"))
                                        //{
                                        //    value = value.Substring(2);
                                        //}
                                        string first2Chars = value.Substring(0, 2);
                                        if (first2Chars.Equals("¶¶"))
                                            value = value.Substring(2);
                                    }
                                    data = value.Split(new char[] { '¶' });
                                }
                                else if (value.Length > 0)
                                {
                                    data = new string[1];
                                    data[0] = value;
                                }
                                else
                                {
                                    data = new string[0];
                                }

                            }

                            if (data != null) objKey.data = data;

                            // Nur wenn für ObjKey Daten eingegeben wurden
                            if (data != null && data.Length > 0 && !data.Equals(string.Empty)) filledObjKeys.Add(objKey);
                        }
                    }

                    // Falls die Indexzeile für Dateiname nicht gefunden wurde
                    if (!isFileNameIndexLineFound)
                    {
                        // Wert aus der Indexzeile für den Dateinamen laden
                        string value = regTxtBoxSearchFileName.Text;

                        if (value != null && value.Length > 0)
                        {
                            ObjKey fileNameObjKey = new ObjKey();
                            fileNameObjKey.id = DocMaskLineC.ID_FILENAME;
                            fileNameObjKey.name = DocMaskLineC.NAME_FILENAME;
                            string[] data = new string[1];
                            data[0] = value;
                            fileNameObjKey.data = data;
                            filledObjKeys.Add(fileNameObjKey);
                        }
                    }

                    if (filledObjKeys != null) objKeys = filledObjKeys.ToArray();

                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_LoadingObjKeyData_Message, ex);
                    objKeys = new ObjKey[0];
                }
            }
            else
            {
                objKeys = new ObjKey[0];
            }

            return objKeys;
        }

        /// <summary>
        /// Zeichnet die Benutzeroberfläche neu
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void splitContainer_Panel1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        /// <summary>
        /// Zeichnet die Benutzeroberfläche neu
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void splitContainer_Panel2_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        /// <summary>
        /// Zeigt die eine Auflistung aller Anwender die für die für
        /// die Suchoption Abgelegt von ausgewählt werden können.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void cmbSelectUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Dialog zur Benutzerauswahl anzeigen
                userFormDialog = new Form();
                userFormDialog.AutoSize = true;
                userFormDialog.Text = Properties.Resources.SavedBy;

                // Auflistung aller Benutzer anzeigen
                userLView = new UserListView();
                userLView.Conn = ixConnection;
                userLView.ObjectsCache = ixConnection.MasterData.UserNames.ResultCache;

                userFormDialog.Controls.Add(userLView);
                userLView.Dock = DockStyle.Fill;

                // Button zum Auswählen des Benutzers hinzufügen
                Button cmbSelect = new Button();
                cmbSelect.Text = "Ok";
                cmbSelect.Click += new EventHandler(cmbSelect_Click);
                userFormDialog.Controls.Add(cmbSelect);
                cmbSelect.Dock = DockStyle.Bottom;

                // Dialog öffnen
                userFormDialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_SelectingUser_Message, ex);
            }
        }

        /// <summary>
        /// Speichert den ausgewählten Benutzer unter der Suchoption "Abgelegt von"
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Erreigniss</param>
        private void cmbSelect_Click(object sender, EventArgs e)
        {

            if (userLView != null && userLView.SelectedUsers != null)
            {
                foreach (UserName uName in userLView.SelectedUsers)
                {
                    regTxtBoxDocSavedByUser.Text = uName.name;
                    regTxtBoxDocSavedByUser.Tag = uName;
                }
            }

            // Dialog schließen
            if (userFormDialog != null) userFormDialog.Close();
        }

        /// <summary>
        /// Setzt oder gibt zurück die Referenz auf die Verbindung zum Indexserver
        /// </summary>
        public FWConnection IxConnection
        {
            get { return ixConnection; }
            set
            {
                ixConnection = value;

                // Default Suchmaske setzen
                if (mode == IndexingDialogMode.SearchMode && ixConnection != null) InitDockMaskForSearchMode(ixConnection);
            }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob die Daten in den Eingabefeldern der Verschlagwortungsmaske verändert werden dürfen
        /// </summary>
        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                tabLayoutPanelBaseData.Enabled = !readOnly;
                tabLayoutPanelMasks.Enabled = !readOnly;
            }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob die Verschagwortungsmaske ausgewählt werden darf durch den Benutzer
        /// </summary>
        public bool CanChangeDocMask
        {
            get { return canChangeDocMask; }
            set
            {
                canChangeDocMask = value;

                if (!canChangeDocMask)
                {
                    tabLayoutPanelMasks.Enabled = false;
                }
                else
                {
                    tabLayoutPanelMasks.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Gibt die Referenz auf das Sord objekt, das verschlagwortet wird
        /// </summary>
        public FWSord Sord
        {
            get { return actSelectedSord; }
        }

        /// <summary>
        /// Setzt den Modus des Dialogs
        /// </summary>
        public IndexingDialogMode Mode
        {
            set
            {
                this.mode = value;

                // Das Tabcontrol anpassen
                if (this.mode == IndexingDialogMode.IndexingMode)
                {
                    tabControlOptions.TabPages.Remove(tabPageSearchBaseData);
                    tabControlOptions.TabPages.Remove(tabPageOptions);
                }

                if (this.mode == IndexingDialogMode.SearchMode)
                {
                    // Entfernt die Tabpage zur Eingabe der Verschlagwortungsdaten
                    tabControlOptions.TabPages.Remove(tabPageDocMaskInput2);

                    // Alle Suchmasken laden
                    InitMaskList(ixConnection, this.tabLayoutPanelMasks, true, false, false);

                    // Suchoptionen laden
                    InitSearchOptions();

                    // Lädt die Default DocMask für die Suche und passt gleichzeitig
                    // in dem temporären Sord objekt die Docmask an
                    InitDockMaskForSearchMode(ixConnection);
                }
            }
        }

        /// <summary>
        /// Setzt die default Docmask für die Suche und setzt diese
        /// in dem tempäreren Sord objekt. Als default Verschlagwortungsmaske
        /// wird Frei Eingabe gesetzt.
        /// </summary>
        /// <param name="ixConnection">Verbindung zum Indexserver</param>
        private void InitDockMaskForSearchMode(FWConnection ixConnection)
        {
            // Default Suchmaske setzen
            if (ixConnection != null && ixConnection.Content != null && ixConnection.Ix != null)
            {
                try
                {
                    // Suchmaske anhand der ID (_searchMaskId) setzen.
                    FWDocMask docMask = null;
                    try
                    {
                        if (ixConnection.MasterData.DocMasks != null) docMask = ixConnection.MasterData.DocMasks[_searchMaskId];
                    }
                    catch (Exception ex)
                    {
                        logger.Error(Properties.Resources.Error_Indexing_GettingDocMaskFromCache_Message, ex);
                    }

                    if (actSelectedMaskButton != null) actSelectedMaskButton.BackgroundImage = null;

                    // Den Button für die entsprechenden Verschlagwortung markieren
                    if (docMaskCollection != null && docMaskCollection.ContainsKey(_searchMaskId))
                    {
                        Button docMaskButton = docMaskCollection[_searchMaskId];
                        if (docMaskButton != null)
                        {
                            docMaskButton.BackgroundImage = EloixClientUI.Properties.Resources.OutlookOrangeButton;
                            actSelectedMaskButton = docMaskButton;
                        }
                        docMaskButton.Select();
                        docMaskButton.Show();
                    }

                    // Neue Verschlagwortungsmaske anzeigen
                    SetNewDocMask(docMask.Core);

                    // Verschlagwortungsmaske im temporären Sordobjekt setzen
                    tempSordForSearch = SetDocMaskInSord(docMask.Core);

                }
                catch (Exception ex)
                {
                    logger.Error(Properties.Resources.Error_Indexing_SettingDefaultDocMaskForSearch_Message, ex);
                }
            }
        }

        /// <summary>
        /// Setzt für die erweiterte Suche die id des Übergeordneten
        /// Ordners, in dem sich der Benutzer momentan befindet
        /// </summary>
        public string ParentId
        {
            set { parentId = value; }
        }

        /// <summary>
        /// Prüft ob die Indexzeilen richtig ausgefüllt sind, wenn
        /// nicht werden diese mit roter Farbe markiert
        /// </summary>
        /// <returns></returns>
        internal bool ProoveIndexFieldsContent()
        {
            bool valid = true;

            if (mode == IndexingDialogMode.IndexingMode)
            {
                // Kurzbezeichnung
                valid = valid && txtBoxName.IsValid;

                // Andere Datenfelder
                if (maskLineControls != null)
                {
                    foreach (Control ctrl in maskLineControls)
                    {
                        if (ctrl is RegExTextBox)
                        {
                            valid = valid && ((RegExTextBox)ctrl).IsValid;
                        }

                        if (ctrl is OutlookKeywordTextBox)
                        {
                            valid = valid && ((OutlookKeywordTextBox)ctrl).IsValid;
                        }
                    }
                }
            }

            return valid;
        }

        /// <summary>
        /// Der Datum von darf nicht größer sein als Datum bis. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void dTimePickerSearchDocDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPsearchDocDateUntil.Checked || dTPsearchDocDateFrom.Value <= dTPsearchDocDateUntil.Value)
            {
                this.searchDocDateFrom = dTPsearchDocDateFrom.Value;
            }
            else
            {
                dTPsearchDocDateFrom.Value = this.searchDocDateFrom;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateFromGreaterDateUntil_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Der Datum bis darf nicht kleiner sein als Datum von. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void dTimePickerSearchDocDateUntil_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPsearchDocDateFrom.Checked || dTPsearchDocDateUntil.Value >= dTPsearchDocDateFrom.Value)
            {
                this.searchDocDateUntil = dTPsearchDocDateUntil.Value;
            }
            else
            {
                dTPsearchDocDateUntil.Value = this.searchDocDateUntil;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateUntilGreaterDateFrom_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Der Datum von darf nicht größer sein als Datum bis. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void dTimePickerSearchDocSaveDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPSearchDocSaveDateUntil.Checked || dTPSearchDocSaveDateFrom.Value <= dTPSearchDocSaveDateUntil.Value)
            {
                this.searchSavedDocDateFrom = dTPSearchDocSaveDateFrom.Value;
            }
            else
            {
                dTPSearchDocSaveDateFrom.Value = this.searchSavedDocDateFrom;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateFromGreaterDateUntil_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Der Datum bis darf nicht kleiner sein als Datum von. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void dTimePickerSearchDocSaveDateUntil_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPSearchDocSaveDateFrom.Checked || dTPSearchDocSaveDateUntil.Value >= dTPSearchDocSaveDateFrom.Value)
            {
                this.searchSavedDocDateUntil = dTPSearchDocSaveDateUntil.Value;
            }
            else
            {
                dTPSearchDocSaveDateUntil.Value = this.searchSavedDocDateUntil;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateUntilGreaterDateFrom_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Der Datum von darf nicht größer sein als Datum bis. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void datTimePSearchExpiredDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPSearchExpiredDateUntil.Checked || dTPSearchExpiredDateFrom.Value <= dTPSearchExpiredDateUntil.Value)
            {
                this.searchExpiredDateFrom = dTPSearchExpiredDateFrom.Value;
            }
            else
            {
                dTPSearchExpiredDateFrom.Value = this.searchExpiredDateFrom;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateFromGreaterDateUntil_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Der Datum bis darf nicht kleiner sein als Datum von. Dies wird in dieser
        /// Methode überprüft. Falls die Bedingung nicht eingehalten wird dann wird das 
        /// Datum auf den ursprünglischen Wert gesetzt.
        /// </summary>
        /// <param name="sender">Quelle, die das Erreigniss ausgelöst hat</param>
        /// <param name="e">Zusätzliche Informationen zu dem Event</param>
        private void datTimePSearchExpiredDateUntil_ValueChanged(object sender, EventArgs e)
        {
            if (!dTPSearchExpiredDateFrom.Checked || dTPSearchExpiredDateUntil.Value >= dTPSearchExpiredDateFrom.Value)
            {
                this.searchExpiredDateUntil = dTPSearchExpiredDateUntil.Value;
            }
            else
            {
                dTPSearchExpiredDateUntil.Value = this.searchExpiredDateUntil;
                //MessageBox.Show(this, Properties.Resources.Exception_Search_DateUntilGreaterDateFrom_Message, Properties.Resources.InfoMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comBoxSearchNotesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comBoxSearchModeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
