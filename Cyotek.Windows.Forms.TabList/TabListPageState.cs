using System;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  /// <summary>
  /// Specifies the state of an item that is being drawn.
  /// </summary>
  [Flags]
  public enum TabListPageState
  {
    /// <summary>
    /// The item currently has no state.
    /// </summary>
    None = 0,

    /// <summary>
    /// The item is being hot-tracked, that is, the item is highlighted as the mouse pointer passes over it.
    /// </summary>
    HotLight = 1,

    /// <summary>
    /// The item is selected.
    /// </summary>
    Selected = 2,

    /// <summary>
    /// The item has focus.
    /// </summary>
    Focused = 4
  }
}
