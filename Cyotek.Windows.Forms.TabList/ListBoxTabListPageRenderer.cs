using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See tablist-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public class ListBoxTabListPageRenderer : TabListPageRenderer
  {
    #region Overridden Methods

    public override Size GetPreferredSize(TabListPage page, Size proposedSize)
    {
      return new Size(proposedSize.Width - 4, proposedSize.Height); // adjusted for border widths
    }

    public override Point GetStartingPosition()
    {
      return new Point(2, 2); // adjusted for border sizes
    }

    public override void RenderHeader(Graphics g, TabListPage page, TabListPageState state)
    {
      Color fillColor;
      Color textColor;
      Rectangle fillBounds;
      Rectangle textRectangle;
      TextFormatFlags flags;

      fillBounds = page.HeaderBounds;
      textRectangle = Rectangle.Inflate(fillBounds, -4, -4);

      // define the most appropriate colors
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        fillColor = SystemColors.Highlight;
        textColor = SystemColors.HighlightText;
      }
      else if ((state & TabListPageState.Hot) == TabListPageState.Hot)
      {
        fillColor = SystemColors.ControlLight;
        textColor = page.Owner.ForeColor;
      }
      else
      {
        fillColor = SystemColors.Window;
        textColor = page.Owner.ForeColor;
      }

      // fill the background
      using (Brush brush = new SolidBrush(fillColor))
      {
        g.FillRectangle(brush, fillBounds);
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

        ControlPaint.DrawFocusRectangle(g, new Rectangle(textRectangle.X, textRectangle.Y, (int)textSize.Width + offset, (int)textSize.Height + offset), textColor, fillColor);
      }
    }

    public override void RenderList(Graphics g, Rectangle bounds)
    {
      // TODO: Paint using themes

      g.FillRectangle(SystemBrushes.Window, new Rectangle(bounds.X, bounds.Y, bounds.Width + 1, bounds.Height + 1));

      ControlPaint.DrawBorder3D(g, bounds);
    }

    #endregion
  }
}
