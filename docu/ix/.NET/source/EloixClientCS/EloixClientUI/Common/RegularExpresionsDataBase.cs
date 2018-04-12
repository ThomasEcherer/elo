/// ********************************************************
/// Titel: 
/// =============
/// RegularExpresionsDataBase
///  
///  
/// Author: 
/// ===============
/// Dario Ilicic
///  
/// 
/// Beschreibung:
/// =================
/// Die Klasse RegularExpresionsDataBase stellt eine Datenbank mit Regulärerenausdrücken
/// dar. Sie werden dazu benutzt um die Eingabe in der RegExTextBox auf Richtigkeit zu
/// überprüfen.
/// 
///  
/// Letzte Änderung:
/// ===================
/// 20/10/2009
/// 
/// *********************************************************




using System;




namespace EloixClientUI.Common
{
    /// <summary>
    /// Die Klasse RegularExpresionsDataBase stellt eine Datenbank mit Regulärerenausdrücken
    /// dar. Sie werden dazu benutzt um die Eingabe in der RegExTextBox auf Richtigkeit zu
    /// überprüfen.
    /// </summary>
    public class RegularExpresionsDataBase
    {

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob die Eingabe aus mindestens einem Zeichen besteht
        /// </summary>
        public static string RegEx_Min1Char = @"^[^\s\.]{1,}"/*"^[a-zA-Z0-9]{1}"*/;

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob die Eingabe aus mindesten bis maximal n zeichen
        /// besteht
        /// </summary>
        /// <param name="minCharLength">Minimale Anzahl der Zeichen</param>
        /// <param name="maxCharLength">Maximale Anzahl der Zeichen</param>
        /// <returns>
        /// Regularerausruck 
        /// </returns>
        /// <exception cref="ArgumentException">Wird geworfen wenn der Benutzer für minCharLenght/maxCharLength werte kleiner 0
        /// oder maxCharLenght kleiner minCharLenght setzt
        /// </exception>
        public static string RegEx_MinMaxChar(int minCharLength, int maxCharLength)
        {
            if (minCharLength < 0 || maxCharLength < 0 || minCharLength > maxCharLength)
                throw new ArgumentException(Properties.Resources.Exception_Indexing_RegEx_MinMaxChar_Message);
            return @"^[^\s\.][a-z0-9A-Z]{" + minCharLength.ToString() + "," + maxCharLength.ToString() + "}";

        }

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob es sich um eine Integer Zahl handelt beliebiger länge
        /// </summary>
        public static string RegEx_IntNumber = "^[+-]?[0-9]*$";

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob die Integerzahl über eine bestimmte Länge verfügt
        /// </summary>
        /// <param name="minLength">Minimale Länge</param>
        /// <param name="maxLength">Maximale Länge</param>
        /// <returns>
        /// Regulärerausruck 
        /// </returns>
        /// <exception cref="ArgumentException">Wird geworfen wenn der Benutzer für minCharLenght/maxCharLength werte kleiner 0
        /// oder maxCharLenght kleiner minCharLenght setzt
        /// </exception>
        public static string RegEx_MinMaxLenghtIntNumber(int minLength, int maxLength)
        {
            if (minLength < 0 || maxLength < 0 || minLength > maxLength)
                throw new ArgumentException(Properties.Resources.Exception_Indexing_RegEx_MinMaxChar_Message);

            return "^[+-]?[0-9]{" + minLength.ToString() + "," + maxLength.ToString() + "}$";
        }

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob es sich um eine Decimalzahl handelt
        /// </summary>
        public static string RegEx_DoubleNumber = @"^[+-]?[0-9]*(\.|\,)[0-9]*$";

        /// <summary>
        /// Regulärerausdruck zum Überprüfen ob es sich um eine Dezimalzahl mit 1 bis n Nachkommastellen handelt
        /// </summary>
        /// <param name="digitsAfterPoint">Anzahl der Nachkommastellen</param>
        /// <returns>
        /// Regulärer Ausdruck
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Wird geworfen wenn für Nachkommastellen eine Zahl kleiner 1 übergeben wird
        /// </exception>
        public static string RegEx_DoubleNumberWithFraction(int digitsAfterPoint)
        {
            if (digitsAfterPoint < 1) throw new ArgumentException(Properties.Resources.Exception_Indexing_RegEx_Fraction);

            return @"^[+-]?[0-9]*(\.|\,)[0-9]{" + digitsAfterPoint.ToString() + "}$";
        }
    }
}
