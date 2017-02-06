using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public abstract class TabListPageRenderer : ITabListPageRenderer
  {
    #region Static Properties

    public static ITabListPageRenderer DefaultRenderer { get; set; }

    #endregion

    #region ITabListPageRenderer Interface

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
  }
}
