/// *************************************************************
/// Titel: 
/// =============
/// RegExEventArgs
///  
///  
/// Author: 
/// ===============
/// Dario Ilicic
///  
/// 
/// Beschreibung:
/// =================
/// Die Klasse RegExEventArgs stellt zusätzliche Informationen
/// bereit bei den Events, die von dem Control RegExTextBox
/// ausgelöt werden.
/// 
///  
/// Letzte Änderung:
/// ===================
/// 20/10/2009
/// 
/// ***************************************************************



using System;





namespace EloixClientUI.Common
{
    /// <summary>
    /// Die Klasse RegExEventArgs stellt zusätzliche Informationen
    /// zu den Events, die von dem Control RegExTextBox ausgelöst werden.
    /// </summary>
    public class RegExEventArgs : EventArgs
    {
        /// <summary>
        /// True wenn die Eingabe richtig ist sonst false
        /// </summary>
        private bool isValid;


        /// <summary>
        /// Nachricht die mitgeteilt wird, wenn Eingabe nicht richtig ist
        /// </summary>
        private string msg;






        #region Initialization
        /// <summary>
        /// Konsturktor
        /// </summary>
        /// <param name="isValid">True wenn die Eingabe richtig ist, sonst false</param>
        /// <param name="msg">Nachricht, die angezeigt werden soll, wenn die Eingabe nicht richtig ist</param>
        public RegExEventArgs(bool isValid, string msg)
        {
            this.isValid = isValid;
            this.msg = msg;
        }
        #endregion







        public bool IsValid
        {
            get { return isValid; }
            set { isValid = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

    }
}
