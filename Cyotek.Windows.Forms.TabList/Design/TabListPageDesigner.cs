using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See tablist-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  public class TabListPageDesigner : ScrollableControlDesigner
  {
    #region Overridden Properties

    public override SelectionRules SelectionRules
    {
      get { return SelectionRules.Locked; }
    }

    #endregion

    #region Overridden Members

    public override bool CanBeParentedTo(IDesigner parentDesigner)
    {
      return parentDesigner != null && parentDesigner.Component is TabList;
    }

    protected override void OnPaintAdornments(PaintEventArgs pe)
    {
      base.OnPaintAdornments(pe);

      if (!(this.Control is Panel) || ((Panel)this.Control).BorderStyle == BorderStyle.None)
      {
        // outline the control at design time if we don't have any borders
        ControlPaint.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
      }
    }

    #endregion
  }
}
