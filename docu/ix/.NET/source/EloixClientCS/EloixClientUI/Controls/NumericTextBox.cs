using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace EloixClientUI.Controls
{
    public class NumericTextBox : TextBox, INotifyPropertyChanged
    {
        public enum NumericTextBoxMode
        {
            Integer,
            Decimal
        }

        #region private fields

        private static Dictionary<Control, ErrorProvider> errorProviders = new Dictionary<Control, ErrorProvider>();

        bool allowSpace = false;
        NumericTextBoxMode _mode = NumericTextBoxMode.Decimal;
        int _minLength = 0;
        bool _isValid;
        bool _autoError = true;
        //string _tooShortErrorMessage = "ZuKurz";
        //string _tooLongErrorMessage = "ZuLang";
        //string _tooShortErrorMessageResourceKey = "TooShort";
        //string _tooLongErrorMessageResourceKey = "TooLong";

        #endregion

        #region ctor

        public NumericTextBox()
        {
            this.Validated += NumericTextBox_Validated;
            this.Validating += NumericTextBox_Validated;
        }

        void NumericTextBox_Validated(object sender, EventArgs e)
        {
            UpdateValidity();
        }

        #endregion

        #region methods

        // Restricts the entry of characters to digits (including hex), the negative sign,
        // the decimal point, and editing keystrokes (backspace).
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if ((keyInput.Equals(decimalSeparator) && _mode == NumericTextBoxMode.Decimal) || keyInput.Equals(groupSeparator) ||
             keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            //    {
            //     // Let the edit control handle control and alt key combinations
            //    }
            else if (this.allowSpace && e.KeyChar == ' ')
            {
            }
            else
            {
                // Consume this invalid key and beep
                e.Handled = true;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            UpdateValidity();
        }

        private void UpdateValidity()
        {
            if (MinLength > 0 && MaxLength > 0 && MinLength <= MaxLength)
            {
                if (Text.Length < MinLength && Text.Length > 0)
                {
                    if (AutoError)
                        ErrorProvider.SetError(this, string.Format(Properties.Resources.Error_MinLength, MinLength));
                    Valid = false;
                }
                else if (Text.Length > MaxLength)
                {
                    if (AutoError)
                        ErrorProvider.SetError(this, string.Format(Properties.Resources.Error_MaxLength, MaxLength));
                    Valid = false;
                }
                else
                {
                    if (AutoError)
                        ErrorProvider.SetError(this, "");
                    Valid = true;
                }
            }
            else
            {
                if (AutoError)
                    ErrorProvider.SetError(this, "");
                Valid = true;
            }
        }

        #endregion

        #region properties

        public decimal Value
        {
            get { return (_mode == NumericTextBoxMode.Decimal) ? DecimalValue : IntValue; }
        }

        private int IntValue
        {
            get { return Int32.Parse(this.Text); }
        }

        private decimal DecimalValue
        {
            get { return Decimal.Parse(this.Text); }
        }

        public bool AllowSpace
        {
            set { this.allowSpace = value; }
            get { return this.allowSpace; }
        }

        public NumericTextBoxMode Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public override int MaxLength
        {
            get { return base.MaxLength; }
            set
            {
                base.MaxLength = value;
                if (MinLength == 0 || MaxLength == 0 || MinLength > MaxLength) Valid = true;
            }
        }

        [DefaultValue(0)]
        public int MinLength
        {
            get { return _minLength; }
            set
            {
                _minLength = value;
                if (MinLength == 0 || MaxLength == 0 || MinLength > MaxLength) Valid = true;
            }
        }

        public bool Valid
        {
            get { return _isValid; }
            private set
            {
                if (value != _isValid)
                {
                    _isValid = value;
                    OnPropertyChanged("Valid");
                }
            }
        }

        [DefaultValue(true)]
        public bool AutoError
        {
            get { return _autoError; }
            set { _autoError = value; }
        }

        private ErrorProvider ErrorProvider
        {
            get
            {
                if (!errorProviders.ContainsKey(this.Parent) || errorProviders[this.Parent] == null)
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider.ContainerControl = this.Parent as ContainerControl;
                    errorProviders.Add(this.Parent, errorProvider);
                }
                return errorProviders[this.Parent];
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
