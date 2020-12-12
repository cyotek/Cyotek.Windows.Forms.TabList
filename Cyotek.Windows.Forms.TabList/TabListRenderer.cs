using System;
using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  /// <summary>
  /// Base class for theme rendering.
  /// </summary>
  /// <seealso cref="T:Cyotek.Windows.Forms.ITabListPageRenderer"/>
  public abstract class TabListRenderer : ITabListRenderer
  {
    #region Static Properties

    /// <summary>
    /// Gets or sets the default renderer .
    /// </summary>
    /// <value>
    /// The default renderer.
    /// </value>
    /// <remarks>All <see cref="TabList"/> controls will use the default renderer unless explicit assigned a dedicated renderer.</remarks>
    [Obsolete("This property is obsolete and will be removed in a future update. Use TabListManager.Renderer.")]
    public static ITabListRenderer DefaultRenderer
    {
      get => TabListManager.Renderer;
      set => TabListManager.Renderer = value;
    }

    #endregion

    #region ITabListRenderer Interface

    /// <summary>
    /// Retrieves the size of a rectangular area into which the header area of a
    /// <see cref="TabListPage"/> can be fitted.
    /// </summary>
    /// <param name="page">The <see cref="TabListPage"/> to be processed.</param>
    /// <param name="proposedSize">The proposed size for the header.</param>
    /// <returns>
    /// An ordered pair of type <see cref="Size"/> representing the width and height of a rectangle.
    /// </returns>
    /// <seealso cref="M:Cyotek.Windows.Forms.ITabListPageRenderer.GetPreferredSize(TabListPage,Size)"/>
    public virtual Size GetPreferredSize(TabListPage page, Size proposedSize)
    {
      return proposedSize;
    }

    /// <summary>
    /// Retrieves the location where the tab list should be located.
    /// </summary>
    /// <returns>
    /// The location of the tab list.
    /// </returns>
    /// <seealso cref="M:Cyotek.Windows.Forms.ITabListPageRenderer.GetStartingPosition()"/>
    public virtual Point GetStartingPosition()
    {
      return Point.Empty;
    }

    /// <summary>
    /// Renders the header for the given <see cref="TabListPage"/>.
    /// </summary>
    /// <param name="g">The <see cref="Graphics"/> to draw on.</param>
    /// <param name="page">The <see cref="TabListPage"/> to be processed.</param>
    /// <param name="state">One of the <see cref="TabListPageState"/> values that specifies the state
    /// of the <see cref="TabListPage"/> to render.</param>
    /// <seealso cref="M:Cyotek.Windows.Forms.ITabListPageRenderer.RenderHeader(Graphics,TabListPage,TabListPageState)"/>
    public abstract void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    /// <summary>
    /// Renders the background of the tab list.
    /// </summary>
    /// <param name="g">The <see cref="Graphics"/> to draw on.</param>
    /// <param name="bounds">The <see cref="Rectangle"/> that represents the dimensions of the tab
    /// list.</param>
    /// <seealso cref="M:Cyotek.Windows.Forms.ITabListPageRenderer.RenderList(Graphics,Rectangle)"/>
    public virtual void RenderList(Graphics g, Rectangle bounds)
    {
      // empty implementation
    }

    #endregion
  }
}
