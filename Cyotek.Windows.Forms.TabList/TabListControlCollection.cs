using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  partial class TabList
  {
    #region  Nested Classes


    public class TabListControlCollection
      : Control.ControlCollection
    {
      #region  Public Constructors

      public TabListControlCollection(TabList owner)
        : base(owner)
      {

      }

      #endregion  Public Constructors

      #region  Public Overridden Methods

      public override void Add(Control value)
      {
        TabListPage page;

        if (!(value is TabListPage))
          throw new ArgumentException("Only TabListPage controls can be hosted in this control.");

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
            this.Owner.RemovePageAt(index);
        }
      }

      #endregion  Public Overridden Methods

      #region  Protected Properties

      protected new TabList Owner
      { get { return (TabList)base.Owner; } }

      #endregion  Protected Properties
    }
    #endregion  Nested Classes
  }
}
