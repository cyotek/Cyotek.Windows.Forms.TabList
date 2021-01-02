using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2021 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  /// <summary>
  /// Visual Studio 2012 renderer for a <see cref="TabList"/> control.
  /// </summary>
  /// <seealso cref="T:Cyotek.Windows.Forms.TabListPageRenderer"/>
  public class VisualStudioTabListRenderer : TabListRenderer
  {
    #region Public Fields

    /// <summary> A default instance of <see cref="VisualStudioTabListRenderer"/>. </summary>
    public static ITabListRenderer Default = new VisualStudioTabListRenderer();

    #endregion Public Fields

    #region Public Methods

    /// <summary>
    /// Renders the header for the given <see cref="TabListPage"/>.
    /// </summary>
    /// <param name="g">The <see cref="Graphics"/> to draw on.</param>
    /// <param name="page">The <see cref="TabListPage"/> to be processed.</param>
    /// <param name="state">One of the <see cref="TabListPageState"/> values that specifies the state
    /// of the <see cref="TabListPage"/> to render.</param>
    /// <seealso cref="M:Cyotek.Windows.Forms.TabListPageRenderer.RenderHeader(Graphics,TabListPage,TabListPageState)"/>
    public override void RenderHeader(Graphics g, TabListPage page, TabListPageState state)
    {
      int arrowSize;
      Rectangle fillBounds;
      Rectangle textBounds;

      arrowSize = 6;
      fillBounds = page.HeaderBounds;
      fillBounds.Width -= arrowSize;
      textBounds = Rectangle.Inflate(fillBounds, -4, -4);

      RenderSupport.DefineColors(page, state, out Color fillColor, out Color textColor, SystemColors.ControlLightLight);
      RenderSupport.DrawBackground(g, fillBounds, fillColor);
      RenderSupport.DrawText(g, page, textBounds, textColor, fillColor);
      RenderSupport.DrawFocus(g, page, state, textBounds, fitToText: true);

      // draw the selection arrow
      if ((state & TabListPageState.Selected) == TabListPageState.Selected)
      {
        int y;
        int x;
        Point point1;
        Point point2;
        Point point3;

        y = fillBounds.Top + ((fillBounds.Height - (arrowSize * 2)) / 2);
        x = fillBounds.Right;

        point1 = new Point(x, y);
        point2 = new Point(x + arrowSize, y + arrowSize);
        point3 = new Point(x, y + (arrowSize * 2));

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
    }

    #endregion Public Methods
  }
}
