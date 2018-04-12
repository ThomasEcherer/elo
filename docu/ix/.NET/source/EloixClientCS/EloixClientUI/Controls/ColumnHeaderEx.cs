using System.ComponentModel;
using System.Windows.Forms;

namespace EloixClientUI.Controls
{
    public class ColumnHeaderEx : ColumnHeader, INotifyPropertyChanged
    {
        private int _oldWidth = 0;

        public bool Visible
        {
            get { return Width > 0; }
            set
            {
                if (value)
                {
                    if (_oldWidth <= 0)
                    {
                        Width = 60;
                    }
                    else
                    {
                        Width = _oldWidth;
                    }
                }
                else
                {
                    _oldWidth = Width;
                    Width = 0;
                }

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Width"));
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
