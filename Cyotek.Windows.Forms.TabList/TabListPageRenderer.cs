using System.Drawing;

namespace Cyotek.Windows.Forms
{
  public abstract class TabListPageRenderer
    : ITabListPageRenderer
  {
    #region  Public Class Properties

    public static ITabListPageRenderer DefaultRenderer { get; set; }

    #endregion  Public Class Properties

    #region  Public Abstract Methods

    public abstract void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    #endregion  Public Abstract Methods
  }
}
