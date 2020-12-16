using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  internal static class RenderSupport
  {
    #region Public Methods

    public static void DrawText(Graphics g, TabListPage page, Rectangle bounds, Color textColor, Color fillColor)
    {
      TextRenderer.DrawText(g, page.Text, page.Font, bounds, textColor, fillColor, _textFlags);
    }

    private const TextFormatFlags _textFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.WordEllipsis;

    public static void DefineColors(TabListPage page, TabListPageState state, out Color fillColor, out Color textColor, Color hotBackground)
    {
      bool enabled;

      enabled = page.Owner.Enabled && page.Enabled;

      // define the most appropriate colors
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        if (enabled)
        {
          fillColor = SystemColors.Highlight;
          textColor = SystemColors.HighlightText;
        }
        else
        {
          fillColor = SystemColors.GrayText;
          textColor = SystemColors.Control;
        }
      }
      else if ((state & TabListPageState.HotLight) == TabListPageState.HotLight)
      {
        fillColor = hotBackground;
        textColor = page.Owner.ForeColor;
      }
      else
      {
        fillColor = Color.Transparent;
        textColor = enabled
          ? page.Owner.ForeColor
          : SystemColors.GrayText;
      }
    }

    public static void DrawBackground(Graphics g, Rectangle bounds, Color fillColor)
    {
      // fill the background
      if (fillColor.A > 0)
      {
        using (Brush brush = new SolidBrush(fillColor))
        {
          g.FillRectangle(brush, bounds);
        }
      }
    }

    public static void DrawFocus(Graphics g, TabListPage page, TabListPageState state, Rectangle bounds, bool fitToText)
    {
      if ((state & TabListPageState.Focused) == TabListPageState.Focused)
      {
        if (fitToText)
        {
          SizeF textSize;
          int offset;

          textSize = TextRenderer.MeasureText(g, page.Text, page.Font, bounds.Size, _textFlags);
          offset = 2;

          NativeMethods.DrawFocusRectangle(g, bounds.X, bounds.Y, (int)textSize.Width + offset, (int)textSize.Height + offset);
        }
        else
        {
          NativeMethods.DrawFocusRectangle(g, bounds);
        }
      }
    }

    #endregion Public Methods
  }
}
