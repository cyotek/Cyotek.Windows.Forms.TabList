using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public class DefaultTabListPageRenderer : TabListPageRenderer
  {
    #region Methods

    public override void RenderHeader(Graphics g, TabListPage page, TabListPageState state)
    {
      Color fillColor;
      Color textColor;
      Rectangle fillBounds;
      Rectangle textRectangle;
      TextFormatFlags flags;
      int arrowSize;

      arrowSize = 6;
      fillBounds = page.HeaderBounds;
      fillBounds.Width -= arrowSize;
      textRectangle = Rectangle.Inflate(fillBounds, -4, -4);

      // define the most appropriate colors
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        fillColor = SystemColors.Highlight;
        textColor = SystemColors.HighlightText;
      }
      else if ((state & TabListPageState.Hot) == TabListPageState.Hot)
      {
        fillColor = SystemColors.ControlLightLight;
        textColor = page.Owner.ForeColor;
      }
      else
      {
        fillColor = page.Owner.BackColor;
        textColor = page.Owner.ForeColor;
      }

      // fill the background
      using (Brush brush = new SolidBrush(fillColor))
      {
        g.FillRectangle(brush, fillBounds);
      }

      // draw the selection arrow
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        int y;
        int x;
        Point point1;
        Point point2;
        Point point3;

        y = fillBounds.Top + (fillBounds.Height - arrowSize * 2) / 2;
        x = fillBounds.Right;

        point1 = new Point(x, y);
        point2 = new Point(x + arrowSize, y + arrowSize);
        point3 = new Point(x, y + arrowSize * 2);

        using (Brush brush = new SolidBrush(fillColor))
        {
          g.FillPolygon(brush, new[]
                               {
                                 point1,
                                 point2,
                                 point3
                               });
        }
      }

      // draw the text
      flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.WordEllipsis;
      TextRenderer.DrawText(g, page.Text, page.Font, textRectangle, textColor, fillColor, flags);

      // focus
      if ((state & TabListPageState.Focused) == TabListPageState.Focused)
      {
        SizeF textSize;
        int offset;

        textSize = TextRenderer.MeasureText(g, page.Text, page.Font, textRectangle.Size, flags);
        offset = 2;

        NativeMethods.DrawFocusRectangle(g, textRectangle.X, textRectangle.Y, (int)textSize.Width + offset, (int)textSize.Height + offset);
      }
    }

    #endregion
  }
}
