using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See tablist-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  partial class TabList
  {
    #region Nested Types

    public class TabListControlCollection : ControlCollection
    {
      #region Public Constructors

      public TabListControlCollection(TabList owner)
        : base(owner)
      { }

      #endregion

      #region Overridden Methods

      public override void Add(Control value)
      {
        TabListPage page;

        if (!(value is TabListPage))
        {
          throw new ArgumentException("Only TabListPage controls can be hosted in this control.");
        }

        page = (TabListPage)value;
        page.Visible = false; // all pages should be hidden by default
        page.Bounds = this.Owner.DisplayRectangle;

        base.Add(page);

        this.Owner.AddPage(page);
      }

      public override void Remove(Control value)
      {
        base.Remove(value);

        if (value is TabListPage)
        {
          int index;

          index = this.Owner.TabListPages.IndexOf((TabListPage)value);

          if (index != -1)
          {
            this.Owner.RemovePageAt(index);
          }
        }
      }

      #endregion

      #region Protected Properties

      protected new TabList Owner
      {
        get { return (TabList)base.Owner; }
      }

      #endregion
    }

    #endregion
  }
}
