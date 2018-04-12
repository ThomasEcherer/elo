using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EloixClientUI.Common;
using EloixClientUI.Helpers;





namespace EloixClientUI.Controls
{
    /// <summary>
    /// Titel: 
    /// =============
    /// RegExTextBox
    ///  
    ///  
    /// Author: 
    /// ===============
    /// Dario Ilicic
    ///  
    /// 
    /// Beschreibung:
    /// =================
    /// Die Klasse RegExTextBox stellt eine Erweiterung der TextBox dar.
    /// Sie überprüft anhand des Regulärenausdrucks ob der eingegebene
    /// Inhalt richtig oder falsch ist. Ist der Inhalt falsch wird
    /// der Hintergrund mit Rot markiert, um dem Benutzer die Falsche
    /// Eingabe anzuzeigen.
    /// 
    ///  
    /// Letzte Änderung:
    /// ===================
    /// 11/05/2009
    /// 
    /// </summary>
    public partial class RegExTextBox : TextBox
    {

        /// <summary>
        /// Regulärerausdruck anhand dem der Inhalt überprüft werden soll
        /// </summary>
        private string regExpression;

        /// <summary>
        /// True wenn der eingegebene Inhalt richtig ist sonst false
        /// </summary>
        private bool isValid = true;

        /// <summary>
        /// Regulärerausdruck anhand dem der Inhalt überprüft werden soll
        /// </summary>
        private Regex regEx;

        /// <summary>
        /// Nachricht die fals die Eingabe nicht richtig ist ausgegeben
        /// werden soll über das Event Validated
        /// </summary>
        private string msg;

        /// <summary>
        /// Minimale und maximale Länge des Textes
        /// -1 bedeutet es gibt keine Prüfung für die Länge der Eingabe
        /// </summary>
        private int minLength = -1;
        private int maxLength = -1;

        /// <event>
        /// Wird ausgelöt wenn der Inhalt des Controls überprüft wurde
        /// </event>
        public event RegExEventHandler Validated;










        #region Initialization
        /// <summary>
        /// Konstruktor
        /// </summary>
        public RegExTextBox()
        {
            InitializeComponent();
        }
        #endregion









        

        /// <summary>
        /// Überprüft bei jedem eingegebenem Zeichen des Benutzer ob der bisherige Inhalt
        /// richtig ist
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            // Überprüfen ob der Inhalt mit dem regulärerenausdruck übereinstimmt
            isValid = ValidateControl(regEx);

            if (isValid) e.Handled = true;
        }

        /// <summary>
        /// Überprüft ob die Eingabe richtig ist anhand des Regulärerenausdrucks.
        /// Ist keiner vorhanden, gilt die Eingabe immer als richtig.
        /// </summary>
        /// <returns>
        /// True wenn die Eingabe mit dem Regulärerenausdruck übereinstimmt, sonst false
        /// </returns>
        public bool ValidateControl(Regex regex)
        {
            // True wenn der eingegebene Ausdruck richtig ist
            bool valid = false;

            // Nachricht, die im Fehlerfall ausgegeben wird
            string failureMsg = string.Empty;

            if (regex != null)
            {
                // Wenn kein Text eingegeben wurde
                if (this.Text.Length == 0)
                {
                    if (regEx.IsMatch(this.Text))
                    {
                        BackColor = Color.White;
                        valid = true;
                        failureMsg = string.Empty;
                    }
                    else
                    {
                        BackColor = Color.FromArgb(255, 175, 175);
                        failureMsg = msg;
                        valid = false;
                    }

                    if (Validated != null) Validated(this, new RegExEventArgs(valid, failureMsg));
                    return valid;
                }

                // Wenn die Zeile Text enhält
                if (regEx.IsMatch(this.Text))
                {
                    BackColor = Color.FromArgb(160, 246, 164);

                    bool hasMinLength = true;
                    bool hasMaxLenght = true;
                    string msg = string.Empty;

                    // Prüfen ob min oder max Zeichen eingegeben wurden
                    if (minLength != -1) if (this.Text.Length < minLength) hasMinLength = false;
                    if (maxLength != -1) if (this.Text.Length > maxLength) hasMaxLenght = false;

                    // Wenn die minimale Länge nicht eingehalten wurde
                    if (!hasMinLength)
                    {
                        BackColor = Color.FromArgb(255, 175, 175);
                        msg = MinLengthFailureMsg(this.Text.Length, minLength);
                    }

                    // Wenn die Eingabe zu lang ist
                    if (!hasMaxLenght)
                    {
                        BackColor = Color.FromArgb(255, 175, 175);
                        msg = MaxLengthFailureMsg(this.Text.Length, maxLength);
                    }

                    // Nur wenn beide erfüllt sind
                    if (hasMinLength && hasMaxLenght)
                    {
                        BackColor = Color.White;
                        valid = true;
                    }

                    // Event auslöscen
                    if (Validated != null) Validated(this, new RegExEventArgs(valid, msg));
                }
                else
                {
                    valid = false;
                    BackColor = Color.FromArgb(255, 175, 175);
                    if (Validated != null) Validated(this, new RegExEventArgs(false, msg));
                }
            }
            else
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Gibt die Nachricht zurück, die ausgegeben wird wenn die Eingabe kleiner ist
        /// als die mindest Länge
        /// </summary>
        /// <param name="actTextLength">Momentane Länge der Eingabe</param>
        /// <param name="minLength">Minimale Länge der Eingabe</param>
        /// <returns>
        /// Fehlernachricht
        /// </returns>
        private string MinLengthFailureMsg(int actTextLength, int minLength)
        {
            return string.Format(Properties.Resources.Message_Indexing_Validation_MinLengthFailure, minLength, actTextLength);
        }

        /// <summary>
        /// Gibt die Fehlernachricht zurück, die ausgegeben wird wenn die Eingabe größer ist
        /// als die maximal mögliche Länge für die Eingabe
        /// </summary>
        /// <param name="actTextLength">Momentane Länge der Eingabe</param>
        /// <param name="maxLength">Maximal mögliche Länge der Eingabe</param>
        /// <returns>
        /// Fehlernachricht
        /// </returns>
        private string MaxLengthFailureMsg(int actTextLength, int maxLength)
        {
            return string.Format(Properties.Resources.Message_Indexing_Validation_MaxLengthFailure, maxLength, actTextLength);
        }

        /// <summary>
        /// Minimale länge der Eingabe, für das Textfeld
        /// </summary>
        public int Min
        {
            get { return minLength; }
            set { minLength = value; }
        }

        /// <summary>
        /// Maximal zulässige Länge für die Eingabe
        /// </summary>
        public int Max
        {
            get { return maxLength; }
            set { maxLength = value; }
        }

        /// <summary>
        /// Regulärerausdruck anhand dem der Inhalt in der Textbox überprüft werden
        /// sool. Wird kein Regulärerausdruck übergeben gilt der Inhalt immer als
        /// richtig.
        /// </summary>
        public string RegularExpression
        {
            get
            {
                return regExpression;
            }
            set
            {
                regExpression = value;
                if (regExpression != null && regExpression != string.Empty) regEx = new Regex(regExpression);
            }
        }

        /// <summary>
        /// Setzt die Nachricht, die im Fehlerfall zurückgegeben werden soll
        /// </summary>
        public string Message
        {
            set { this.msg = value; }
        }

        /// <summary>
        /// Gibt zurück ob der Inhalt richtig oder falsch ist
        /// True wenn der Inhalt richtig ist sonst false
        /// </summary>
        public bool IsValid
        {
            get { return ValidateControl(regEx); }
        }
    }
}
