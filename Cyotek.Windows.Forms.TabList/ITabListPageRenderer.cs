using System.Drawing;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See tablist-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public interface ITabListPageRenderer
  {
    #region Members

    void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    #endregion
  }
}
