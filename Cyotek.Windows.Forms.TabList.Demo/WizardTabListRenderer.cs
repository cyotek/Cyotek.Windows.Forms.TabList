using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal class WizardTabListRenderer : TabListRenderer
  {
    #region Methods

    public override void RenderHeader(Graphics g, TabListPage page, TabListPageState state)
    {
      Color fillColor;
      Color textColor;
      Rectangle fillBounds;
      Rectangle textRectangle;
      TextFormatFlags flags;

      fillBounds = new Rectangle(page.HeaderBounds.Left + 10, page.HeaderBounds.Top, page.HeaderBounds.Width - 10, page.HeaderBounds.Height);
      textRectangle = Rectangle.Inflate(fillBounds, -4, -4);

      // define the most appropriate colors
      fillColor = page.Owner.BackColor;
      textColor = page.Owner.ForeColor;

      // fill the background
      using (Brush brush = new SolidBrush(fillColor))
        g.FillRectangle(brush, fillBounds);

      // draw a chevron
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        using (Font font = new Font(page.Font.FontFamily, page.Font.Size + 2, FontStyle.Bold))
          TextRenderer.DrawText(g, "»", font, page.HeaderBounds.Location, page.ForeColor);
      }

      // draw the text
      flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.WordEllipsis;

      using (Font font = new Font(page.Font, (state & TabListPageState.Selected) == TabListPageState.Selected ? FontStyle.Bold : FontStyle.Regular))
        TextRenderer.DrawText(g, page.Text, font, textRectangle, textColor, fillColor, flags);
    }

    #endregion
  }
}
