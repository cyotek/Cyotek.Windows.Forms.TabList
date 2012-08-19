using System.Drawing;

namespace Cyotek.Windows.Forms
{
  public interface ITabListPageRenderer
  {
    #region  Private Methods

    void RenderHeader(Graphics g, TabListPage page, TabListPageState state);

    #endregion  Private Methods
  }
}
