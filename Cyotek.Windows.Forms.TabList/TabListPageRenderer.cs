using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public abstract class TabListPageRenderer : ITabListPageRenderer
  {
    #region Static Properties

    public static ITabListPageRenderer DefaultRenderer { get; set; }

    #endregion

    #region Methods

    public virtual Size GetPreferredSize(TabListPage page, Size proposedSize)
    {
      return proposedSize;
    }

    public virtual Point GetStartingPosition()
    {
      return Point.Empty;
    }

    public abstract void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    public virtual void RenderList(Graphics g, Rectangle bounds)
    {
      // empty implementation
    }

    #endregion

    #region ITabListPageRenderer Interface

    Size ITabListPageRenderer.GetPreferredSize(TabListPage page, Size proposedSize)
    {
      return this.GetPreferredSize(page, proposedSize);
    }

    Point ITabListPageRenderer.GetStartingPosition()
    {
      return this.GetStartingPosition();
    }

    void ITabListPageRenderer.RenderHeader(Graphics g, TabListPage page, TabListPageState state)
    {
      this.RenderHeader(g, page, state);
    }

    void ITabListPageRenderer.RenderList(Graphics g, Rectangle bounds)
    {
      this.RenderList(g, bounds);
    }

    #endregion
  }
}
