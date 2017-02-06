using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public class TabListPageDesigner : ScrollableControlDesigner
  {
    #region Properties

    public override SelectionRules SelectionRules
    {
      get { return SelectionRules.Locked; }
    }

    #endregion

    #region Methods

    public override bool CanBeParentedTo(IDesigner parentDesigner)
    {
      return parentDesigner?.Component is TabList;
    }

    protected override void OnPaintAdornments(PaintEventArgs pe)
    {
      base.OnPaintAdornments(pe);

      if (!(this.Control is Panel) || ((Panel)this.Control).BorderStyle == BorderStyle.None)
      {
        // outline the control at design time if we don't have any borders
        NativeMethods.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
      }
    }

    #endregion
  }
}
