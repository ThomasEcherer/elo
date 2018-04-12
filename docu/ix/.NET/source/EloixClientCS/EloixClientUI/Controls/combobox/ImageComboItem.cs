/// ********************************************************
/// Titel: 
/// =============
/// ImageTextComboItem
///  
///  
/// Author: 
/// ===============
/// Dario Ilicic
///  
/// 
/// Beschreibung:
/// =================
/// Die Klasse ImageTextComboItem stellt eine Item dar in dem
/// Text und Bild nebeneinander angezeigt werden. Ist das Bild
/// nicht vorhanden, dann wird nur der Text dargestellt.
/// ImageIndex = -1 bedeutet für den Item ist kein Bild vorhanden
/// somit wird nur der Text dargestellt. Außerdem gibts die
/// Möglichkeit den Item einem Sordtyp zuzuordnen. Diese Option
/// wird bei der Verschlagwortung verwendet.
/// 
///  
/// Letzte Änderung:
/// ===================
/// 20/10/2009
/// 
/// *********************************************************





using System.Drawing;




using EloixClient.IndexServer;





namespace EloixClientUI.Controls.combobox
{
    /// <summary>
    /// Die Klasse ImageTextComboItem ist ein Item, das zu dem
    /// Text auch ein Bild darstellen kann..
    /// </summary>
	public class ImageTextComboItem : object
	{
		private Color forecolor = Color.FromKnownColor(KnownColor.Transparent);
		private bool mark = false;

        /// <summary>
        /// Index des Bildes das in dem Item angezeigt werden soll
        /// </summary>
		private int imageindex = -1;

        /// <summary>
        /// Dient zum Speichern eines Objekts
        /// </summary>
		private object tag = null;

        /// <summary>
        /// Text das im Item angezeigt wird
        /// </summary>
		private string text = null;

        /// <summary>
        /// Sordtype 
        /// </summary>
        private SordType sordType;











        #region Initialization
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ImageTextComboItem()
		{
		}

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Text">Text das in Item angezeigt werden soll</param>
		public ImageTextComboItem(string Text) 
		{
			text = Text;	
		}

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Text">Text, das angezeigt werden soll</param>
        /// <param name="ImageIndex">Index des Bildes das zusammen mit dem Text angezeigt werden soll</param>
		public ImageTextComboItem(string Text, int ImageIndex)
		{
			text = Text;
			imageindex = ImageIndex;
		}

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Text">Text, das angezeigt werden soll</param>
        /// <param name="ImageIndex">Index des Bildes das zusammen mit dem Text angezeigt werden soll</param>
        /// <param name="Mark"></param>
		public ImageTextComboItem(string Text, int ImageIndex, bool Mark)
		{
			text = Text;
			imageindex = ImageIndex;
			mark = Mark;
		}

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Text">Text, das angezeigt werden soll</param>
        /// <param name="ImageIndex">Index des Bildes das zusammen mit dem Text angezeigt werden soll</param>
        /// <param name="Mark"></param>
        /// <param name="ForeColor">Vordergrundfarbe der Schrift</param>
		public ImageTextComboItem(string Text, int ImageIndex, bool Mark, Color ForeColor)
		{
			text = Text;
			imageindex = ImageIndex;
			mark = Mark;
			forecolor = ForeColor;
		}

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Text">Text, das angezeigt werden soll</param>
        /// <param name="ImageIndex">Index des Bildes das zusammen mit dem Text angezeigt werden soll</param>
        /// <param name="Mark"></param>
        /// <param name="ForeColor">Vordergrundfarbe der Schrift</param>
        /// <param name="Tag">Object das im Tag des Items abgelegt werden soll</param>
        public ImageTextComboItem(string Text, int ImageIndex, bool Mark, Color ForeColor, object Tag)
		{
			text = Text;
			imageindex = ImageIndex;
			mark = Mark;
			forecolor = ForeColor;
			tag = Tag;
        }
        #endregion











        /// <summary>
        /// Sordtype den dieser Item representiert
        /// </summary>
        public SordType SordType
        {
            get { return sordType; }
            set { sordType = value; }
        }
        
        /// <summary>
		/// Vordergrundfarbe der Schrift
		/// </summary>
		public Color ForeColor 
		{
			get 
			{
				return forecolor;
			}
			set
			{
				forecolor = value;
			}
		}

		/// <summary>
		/// Index des Bildes das im Item zusammen mit Text angezeigt werden soll
		/// </summary>
		public int ImageIndex 
		{
			get	{ return imageindex; }
			set { imageindex = value; }
		}

		public bool Mark
		{
			get { return mark; }
			set	{ mark = value;	}
		}

		/// <summary>
		/// Objekt das im Tag des Items abgelegt werden soll
		/// </summary>
		public object Tag
		{
			get { return tag; }
			set	{ tag = value; }
		}

        /// <summary>
        /// Text das im Item angezeigt werden soll
        /// </summary>
		public string Text 
		{
			get { return text; }
            set { text = value; }
		}

		/// <summary>
		/// Gibt den Text des Items aus
		/// </summary>
		/// <returns></returns>
		public override string ToString() 
		{
			return text;
		}
	}
}
