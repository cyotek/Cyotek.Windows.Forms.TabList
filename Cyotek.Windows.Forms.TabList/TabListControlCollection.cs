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

    /// <summary>
    /// Contains a collection of <see cref="Control"/> objects.
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Control.ControlCollection"/>
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

      /// <summary>
      /// Adds a <see cref="Control"/> to the collection.
      /// </summary>
      /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
      /// illegal values.</exception>
      /// <param name="value">The <see cref="Control"/> to add.</param>
      public override void Add(Control value)
      {
        TabListPage page;

        page = value as TabListPage;

        if (page == null)
        {
          throw new ArgumentException("Only TabListPage controls can be hosted in this control.", nameof(value));
        }

        page.Visible = false; // all pages should be hidden by default

        base.Add(page);

        this.TabList.AddPage(page);
      }

      /// <summary>
      /// Removes a <see cref="Control"/> from the collection.
      /// </summary>
      /// <param name="value">The <see cref="Control"/> to remove.</param>
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
