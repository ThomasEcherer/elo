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
    /// Sie �berpr�ft anhand des Regul�renausdrucks ob der eingegebene
    /// Inhalt richtig oder falsch ist. Ist der Inhalt falsch wird
    /// der Hintergrund mit Rot markiert, um dem Benutzer die Falsche
    /// Eingabe anzuzeigen.
    /// 
    ///  
    /// Letzte �nderung:
    /// ===================
    /// 11/05/2009
    /// 
    /// </summary>
    public partial class RegExTextBox : TextBox
    {

        /// <summary>
        /// Regul�rerausdruck anhand dem der Inhalt �berpr�ft werden soll
        /// </summary>
        private string regExpression;

        /// <summary>
        /// True wenn der eingegebene Inhalt richtig ist sonst false
        /// </summary>
        private bool isValid = true;

        /// <summary>
        /// Regul�rerausdruck anhand dem der Inhalt �berpr�ft werden soll
        /// </summary>
        private Regex regEx;

        /// <summary>
        /// Nachricht die fals die Eingabe nicht richtig ist ausgegeben
        /// werden soll �ber das Event Validated
        /// </summary>
        private string msg;

        /// <summary>
        /// Minimale und maximale L�nge des Textes
        /// -1 bedeutet es gibt keine Pr�fung f�r die L�nge der Eingabe
        /// </summary>
        private int minLength = -1;
        private int maxLength = -1;

        /// <event>
        /// Wird ausgel�t wenn der Inhalt des Controls �berpr�ft wurde
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
        /// �berpr�ft bei jedem eingegebenem Zeichen des Benutzer ob der bisherige Inhalt
        /// richtig ist
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            // �berpr�fen ob der Inhalt mit dem regul�rerenausdruck �bereinstimmt
            isValid = ValidateControl(regEx);

            if (isValid) e.Handled = true;
        }

        /// <summary>
        /// �berpr�ft ob die Eingabe richtig ist anhand des Regul�rerenausdrucks.
        /// Ist keiner vorhanden, gilt die Eingabe immer als richtig.
        /// </summary>
        /// <returns>
        /// True wenn die Eingabe mit dem Regul�rerenausdruck �bereinstimmt, sonst false
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

                // Wenn die Zeile Text enh�lt
                if (regEx.IsMatch(this.Text))
                {
                    BackColor = Color.FromArgb(160, 246, 164);

                    bool hasMinLength = true;
                    bool hasMaxLenght = true;
                    string msg = string.Empty;

                    // Pr�fen ob min oder max Zeichen eingegeben wurden
                    if (minLength != -1) if (this.Text.Length < minLength) hasMinLength = false;
                    if (maxLength != -1) if (this.Text.Length > maxLength) hasMaxLenght = false;

                    // Wenn die minimale L�nge nicht eingehalten wurde
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

                    // Nur wenn beide erf�llt sind
                    if (hasMinLength && hasMaxLenght)
                    {
                        BackColor = Color.White;
                        valid = true;
                    }

                    // Event ausl�scen
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
        /// Gibt die Nachricht zur�ck, die ausgegeben wird wenn die Eingabe kleiner ist
        /// als die mindest L�nge
        /// </summary>
        /// <param name="actTextLength">Momentane L�nge der Eingabe</param>
        /// <param name="minLength">Minimale L�nge der Eingabe</param>
        /// <returns>
        /// Fehlernachricht
        /// </returns>
        private string MinLengthFailureMsg(int actTextLength, int minLength)
        {
            return string.Format(Properties.Resources.Message_Indexing_Validation_MinLengthFailure, minLength, actTextLength);
        }

        /// <summary>
        /// Gibt die Fehlernachricht zur�ck, die ausgegeben wird wenn die Eingabe gr��er ist
        /// als die maximal m�gliche L�nge f�r die Eingabe
        /// </summary>
        /// <param name="actTextLength">Momentane L�nge der Eingabe</param>
        /// <param name="maxLength">Maximal m�gliche L�nge der Eingabe</param>
        /// <returns>
        /// Fehlernachricht
        /// </returns>
        private string MaxLengthFailureMsg(int actTextLength, int maxLength)
        {
            return string.Format(Properties.Resources.Message_Indexing_Validation_MaxLengthFailure, maxLength, actTextLength);
        }

        /// <summary>
        /// Minimale l�nge der Eingabe, f�r das Textfeld
        /// </summary>
        public int Min
        {
            get { return minLength; }
            set { minLength = value; }
        }

        /// <summary>
        /// Maximal zul�ssige L�nge f�r die Eingabe
        /// </summary>
        public int Max
        {
            get { return maxLength; }
            set { maxLength = value; }
        }

        /// <summary>
        /// Regul�rerausdruck anhand dem der Inhalt in der Textbox �berpr�ft werden
        /// sool. Wird kein Regul�rerausdruck �bergeben gilt der Inhalt immer als
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
        /// Setzt die Nachricht, die im Fehlerfall zur�ckgegeben werden soll
        /// </summary>
        public string Message
        {
            set { this.msg = value; }
        }

        /// <summary>
        /// Gibt zur�ck ob der Inhalt richtig oder falsch ist
        /// True wenn der Inhalt richtig ist sonst false
        /// </summary>
        public bool IsValid
        {
            get { return ValidateControl(regEx); }
        }
    }
}
