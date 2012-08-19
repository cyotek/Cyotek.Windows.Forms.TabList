using System;

namespace Cyotek.Windows.Forms
{
  [Flags]
  public enum TabListPageState
  {
    Normal = 0,
    Hot = 1,
    Selected = 2,
    Focused = 4
  }
}
