using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2020 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  /// <summary>
  /// Renderer that draws the tab list as a list box.
  /// </summary>
  /// <seealso cref="T:Cyotek.Windows.Forms.TabListPageRenderer"/>
  public class ListBoxTabListRenderer : TabListRenderer
  {
    #region Methods

    /// <summary>
    /// Retrieves the size of a rectangular area into which the header area of a
    /// <see cref="TabListPage"/> can be fitted.
    /// </summary>
    /// <param name="page">The <see cref="TabListPage"/> to be processed.</param>
    /// <param name="proposedSize">The proposed size for the header.</param>
    /// <returns>
    /// An ordered pair of type <see cref="Size"/> representing the width and height of a rectangle.
    /// </returns>
    /// <seealso cref="M:Cyotek.Windows.Forms.TabListPageRenderer.GetPreferredSize(TabListPage,Size)"/>
    public override Size GetPreferredSize(TabListPage page, Size proposedSize)
    {
      return new Size(proposedSize.Width - 4, proposedSize.Height); // adjusted for border widths
    }

    /// <summary>
    /// Retrieves the location where the tab list should be located.
    /// </summary>
    /// <returns>
    /// The location of the tab list.
    /// </returns>
    /// <seealso cref="M:Cyotek.Windows.Forms.TabListPageRenderer.GetStartingPosition()"/>
    public override Point GetStartingPosition()
    {
      return new Point(2, 2); // adjusted for border sizes
    }

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
      Rectangle fillBounds;
      Rectangle textBounds;

      fillBounds = page.HeaderBounds;
      textBounds = Rectangle.Inflate(fillBounds, -4, -4);

      RenderSupport.DefineColors(page, state, out Color fillColor, out Color textColor, SystemColors.ControlLight);
      RenderSupport.DrawBackground(g, fillBounds, fillColor);
      RenderSupport.DrawText(g, page, textBounds, textColor, fillColor);
      RenderSupport.DrawFocus(g, page, state, fillBounds, fitToText: false);
    }

    /// <summary>
    /// Renders the background of the tab list.
    /// </summary>
    /// <param name="g">The <see cref="Graphics"/> to draw on.</param>
    /// <param name="bounds">The <see cref="Rectangle"/> that represents the dimensions of the tab
    /// list.</param>
    /// <seealso cref="M:Cyotek.Windows.Forms.TabListPageRenderer.RenderList(Graphics,Rectangle)"/>
    public override void RenderList(Graphics g, Rectangle bounds)
    {
      // TODO: Paint using themes

      g.FillRectangle(SystemBrushes.Window, new Rectangle(bounds.X, bounds.Y, bounds.Width + 1, bounds.Height + 1));

      ControlPaint.DrawBorder3D(g, bounds);
    }

    #endregion
  }
}
