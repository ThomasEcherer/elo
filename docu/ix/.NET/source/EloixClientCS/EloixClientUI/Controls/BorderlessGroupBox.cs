using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EloixClientUI.Controls
{
    public partial class BorderlessGroupBox : GroupBox
    {
        public BorderlessGroupBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (DesignMode)
                base.OnPaint(pe);
            else
            {
                GroupBoxState state = base.Enabled ? GroupBoxState.Normal : GroupBoxState.Disabled;
                TextFormatFlags flags = TextFormatFlags.PreserveGraphicsTranslateTransform | TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak;

                if (!this.ShowKeyboardCues)
                {
                    flags |= TextFormatFlags.HidePrefix;
                }
                if (this.RightToLeft == RightToLeft.Yes)
                {
                    flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                }

                else
                {
                    Rectangle bounds = new Rectangle(0, 0, base.Width, base.Height);
                    Rectangle rectangle = bounds;
                    rectangle.Width -= 8;
                    Size size = TextRenderer.MeasureText(pe.Graphics, this.Text, this.Font, new Size(rectangle.Width, rectangle.Height), flags);
                    rectangle.Width = size.Width;
                    rectangle.Height = size.Height;
                    if ((flags & TextFormatFlags.Right) == TextFormatFlags.Right)
                    {
                        rectangle.X = (bounds.Right - rectangle.Width) - 8;
                    }
                    else
                    {
                        rectangle.X += 8;
                    }
                    TextRenderer.DrawText(pe.Graphics, this.Text, this.Font, rectangle, this.ForeColor, flags);
                    if (rectangle.Width > 0)
                    {
                        rectangle.Inflate(2, 0);
                    }
                }
            }
        }
    }
}
