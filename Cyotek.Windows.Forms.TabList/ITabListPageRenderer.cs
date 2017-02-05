using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public interface ITabListPageRenderer
  {
    #region Methods

    Size GetPreferredSize(TabListPage page, Size proposedSize);

    Point GetStartingPosition();

    void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    void RenderList(Graphics g, Rectangle bounds);

    #endregion
  }
}
