using System;
using System.Drawing;
using System.Windows.Forms;
using EloixClientUI.Common;
using EloixClientUI.Helpers;
using log4net;



namespace EloixClientUI.Controls
{
    /// <summary>
    /// Titel: 
    /// =============
    /// OutlookKeywordTextBox
    ///  
    ///  
    /// Author: 
    /// ===============
    /// Dario Ilicic
    ///  
    /// 
    /// Beschreibung:
    /// =================
    /// Die Klasse OutlookKeywordTextBox stellt eine Erweiterung des
    /// Controls KeywordTextBox dar. Sie es ermöglichen Text eingeben
    /// zu können ohne das sich die Schlüsselliste öffnet. Hierzu
    /// wird über die Eigenschaft IsTextChangedHandlerActive gesteuert
    /// ob das Control auf das Erreigniss TextChanged reagieren soll
    /// oder nicht.
    /// 
    ///  
    /// Letzte Änderung:
    /// ===================
    /// 11/05/2009
    /// 
    /// </summary>
    public class OutlookKeywordTextBox : KeywordTextBox
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(OutlookKeywordTextBox));

        /// <summary>
        /// True wenn die KeywordTextBox das Event TextChanged
        /// behandeln soll sonst false
        /// </summary>
        private bool isTextChangedHandlerActive = true;

        /// <summary>
        /// True wenn nur Schlüsselwörter als Eingabe akzeptiert werden, sonst false
        /// </summary>
        private bool onlyBuzzwordsAsInput = false;

        /// <summary>
        /// True wenn die Eingabe durch den Benutzer richtig ist, sonst false
        /// </summary>
        private bool isValid = false;

        /// <summary>
        /// Minimale und maximale Länge des Textes
        /// -1 bedeutet es gibt keine Überprüfung der Länge der Eingabe
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
        public OutlookKeywordTextBox()
        {
        }
        #endregion













        // Restricts the entry of characters to digits (including hex), the negative sign,
        // the decimal point, and editing keystrokes (backspace).
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Falls nur Schlüsselworte zugelassen sind, dann soll
            // beim Versuch etwas einzugeben gleich das Dialog mit
            // den Schlüsselwörtern angezeigt werden
            if (onlyBuzzwordsAsInput)
            {
                OnTextChanged(null);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Überprüft ob der Handler für das TextChanged aktiviert ist, falls
        /// ja, dann wird das Fenster mit den Schlüsselwörtern angezeigt.
        /// Dies soll die Möglichkeit bieten eine KeywordTextBox zu haben, ohne
        /// auf Texteingaben in dieser zu reagieren.
        /// </summary>
        /// <param name="e">Zusätzliche Informationen zu dem Event TextChanged</param>
        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                // Überprüft ob der Event TextChanged behandelt werden soll oder nicht
                if (!isTextChangedHandlerActive) return;

                base.OnTextChanged(e);

                // Überprüfen ob die Eingabe richtig ist
                isValid = ValidateControl();
            }
            catch (Exception ex)
            {
                logger.Error(Properties.Resources.Error_Indexing_TextChanged, ex);
                MessageBox.Show(
                    Properties.Resources.Message_Indexing_KeySelectionError, 
                    Properties.Resources.InfoMessage_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Überprüft ob die Eingabe richtig ist anhand des Regulärerenausdrucks.
        /// Ist keiner vorhanden, gilt die Eingabe immer als richtig.
        /// </summary>
        /// <returns>
        /// True wenn die Eingabe mit dem Regulärerenausdruck übereinstimmt, sonst false
        /// </returns>
        public bool ValidateControl()
        {
            bool valid        = false;
            bool hasMinLength = true;
            bool hasMaxLength = true;
            string msg        = string.Empty;

            // Überprüfen der Länge der Eingabe
            if (minLength != -1) if (this.Text.Length < minLength) hasMinLength = false;
            if (maxLength != -1) if (this.Text.Length > maxLength) hasMaxLength = false;
            
            if (!hasMinLength)
            {
                BackColor = Color.FromArgb(255, 175, 175);
                msg       = MinLengthFailureMsg(this.Text.Length, minLength);
            }

            if (!hasMaxLength)
            {
                BackColor = Color.FromArgb(255, 175, 175);
                msg       = MaxLengthFailureMsg(this.Text.Length, maxLength);
            }

            if (hasMinLength && hasMaxLength)
            {
                BackColor = Color.White;
                valid     = true;
            }

            if (Validated != null) Validated(this, new RegExEventArgs(valid, msg));

            return valid;
        }

        /// <summary>
        /// Minimal erforderliche Länge für die Eingabe
        /// </summary>
        public int Min
        {
            get { return minLength; }
            set { minLength = value; }
        }

        /// <summary>
        /// Maximal mögliche Länge für die Eingabe
        /// </summary>
        public int Max
        {
            get { return maxLength; }
            set { maxLength = value; }
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
        /// Setzt oder gibt zurück ob die KeywordTextBox auf das TextChanged Erreigniss
        /// reagieren soll
        /// True wenn das Event verarbeitet werden soll, sonst false
        /// </summary>
        public bool IsTextChangedHandlerActive
        {
            get { return isTextChangedHandlerActive; }
            set
            {
                isTextChangedHandlerActive = value;

                if (isTextChangedHandlerActive)
                {
                    // Überprüfen ob die Eingabe richtig ist
                    isValid = ValidateControl();
                    if (!isValid)
                    {
                        this.BackColor = Color.FromArgb(255, 175, 175);
                    }
                    else
                    {
                        this.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Setzt oder gibt zurück ob nur Schlüsselwörter als Eingabe akzeptiert werden sollen
        /// True wenn nur Schlüsselwörter als Eingabe angenommen werden sollen, sonst false
        /// </summary>
        public bool OnlyBuzzwordsAsInput
        {
            get { return onlyBuzzwordsAsInput; }
            set { onlyBuzzwordsAsInput = value; }
        }

        /// <summary>
        /// Gibt zurück ob der Ausdruck den der Benutzer eingegeben hat richtig ist oder falsch
        /// True wenn der Ausdruck richtig ist, sonst false
        /// </summary>
        public bool IsValid
        {
            get { return ValidateControl(); }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OutlookKeywordTextBox
            // 
            this.ResumeLayout(false);

        }

    }
}
