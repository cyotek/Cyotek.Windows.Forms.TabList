using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  partial class TabList
  {
    #region Nested type: TabListControlCollection

    public sealed class TabListControlCollection : ControlCollection
    {
      #region Constructors

      internal TabListControlCollection(Control owner)
        : base(owner)
      { }

      #endregion

      #region Properties

      private TabList TabList
      {
        get { return (TabList)this.Owner; }
      }

      #endregion

      #region Methods

      public override void Add(Control value)
      {
        TabListPage page;

        page = value as TabListPage;

        if (page == null)
        {
          throw new ArgumentException("Only TabListPage controls can be hosted in this control.");
        }

        page.Visible = false; // all pages should be hidden by default

        base.Add(page);

        this.TabList.AddPage(page);
      }

      public override void Remove(Control value)
      {
        TabListPage page;

        page = value as TabListPage;

        base.Remove(value);

        if (page != null)
        {
          TabList owner;
          int index;

          owner = this.TabList;
          index = owner.TabListPages.IndexOf(page);

          if (index != -1)
          {
            owner.RemovePageAt(index);
          }
        }
      }

      #endregion
    }

    #endregion
  }
}
