/// ********************************************************
/// Titel: 
/// =============
/// ImageTextComboBox
///  
///  
/// Author: 
/// ===============
/// Dario Ilicic
///  
/// 
/// Beschreibung:
/// =================
/// Die Klasse ImageTextComboBox stellt eine ComboBox dar die
/// in der Lage ist Items mit Bild und Text darzustellen.
/// Hierfür müssen die Items und die dazugehörifen Bilder
/// übergeben werden. Die Bilder müssen an die Property
/// ImageList übergeben werden. Jeder Item weiß über den
/// Index dem ihm zugeordnet wurde welches Bild er aus
/// der ImageList laden soll. Ist kein Bild für den Item
/// in der ImageList vorhanden, dann wird nur der Text
/// für den Item dargestellt.
/// 
/// 
/// 
///  
/// Letzte Änderung:
/// ===================
/// 20/10/2009
/// 
/// *********************************************************



using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using log4net;







namespace EloixClientUI.Controls.combobox
{

    /// <summary>
    /// Setllt eine Erweiterung der ComboBox dar.
    /// In dieser kann neben den Text auch ein Bild dargestellt werden.
    /// </summary>
	public class ImageTextComboBox : ComboBox
	{
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(ImageTextComboBox));

        /// <summary>
        /// Auflistung der Bilder, die in der ComboBox angezeigt werden sollen
        /// </summary>
		private ImageList imgs = new ImageList();








        #region Initialization
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ImageTextComboBox()
		{
			// set draw mode to owner draw
			this.DrawMode = DrawMode.OwnerDrawFixed;
        }
        #endregion









        /// <summary>
        /// Auflistung der Bilder, die in der Combobox angezeigt werden sollen
        /// </summary>
		public ImageList ImageList 
		{
			get { return imgs; }
			set { imgs = value; }
		}

		/// <summary>
		/// Zeichnet den Item der Combobox
		/// </summary>
		/// <param name="e"></param>
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			// Hintergrund zeichnen
			e.DrawBackground();
			e.DrawFocusRectangle();
            
			// Überprüfen ob der Item zu der Auflistung gehört
			if (e.Index < 0)
            {
                int imgSizeWidth = 0;
                if (imgs != null) imgSizeWidth = imgs.ImageSize.Width;

				e.Graphics.DrawString(this.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + imgSizeWidth, e.Bounds.Top);
            }
			else
			{
                if (this.Items != null)
                {
                    // Überprüfen sich bei dem Item um ein ImageTextComboItem handelt
                    if (this.Items[e.Index].GetType() == typeof(ImageTextComboItem))
                    {

                        // Item laden
                        ImageTextComboItem item = (ImageTextComboItem)this.Items[e.Index];

                        // Schrift und Farbe laden
                        Color forecolor = (item.ForeColor != Color.FromKnownColor(KnownColor.Transparent)) ? item.ForeColor : e.ForeColor;
                        Font font = item.Mark ? new Font(e.Font, FontStyle.Bold) : e.Font;

                        // -1: wenn der Item kein Bild enthält
                        if (item.ImageIndex != -1)
                        {
                            try
                            {
                                // Falls der Item ein Bild enthält, wird dieses aus der Imagelist geladen und neben dem Text gezeichnet
                                if (this.ImageList != null) this.ImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, item.ImageIndex);
                            }
                            catch
                            { }

                            e.Graphics.DrawString(item.Text, font, new SolidBrush(forecolor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);
                        }
                        else
                            // Falls kein Bild vorhanden ist, dann wird nur der Text gezeichnet
                            e.Graphics.DrawString(item.Text, font, new SolidBrush(forecolor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);

                    }
                    else

                        // Wenn es kein ImageTextComboItem ist dann wird nur Text dargestellt
                        e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);
                }
			}

			base.OnDrawItem (e);
		}

        /// <summary>
        /// Setzt den entsprechenden SordType mit der entsprechenden id
        /// als selektiert.
        /// </summary>
        /// <param name="sordTypeId">Id von dem SordType das selektiert werden soll in der ComboBox</param>
        public void SelectSordType(int sordTypeId)
        {
            try
            {
                if (DataSource != null && DataSource is List<ImageTextComboItem>)
                {
                    List<ImageTextComboItem> items = (List<ImageTextComboItem>)DataSource;

                    if (items != null)
                    {
                        foreach (ImageTextComboItem item in items)
                        {
                            if (item.SordType != null && item.SordType.id == sordTypeId)
                            {
                                this.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                logger.Error(Properties.Resources.Error_SelectSordType, ex);
            }
        }

	}
}