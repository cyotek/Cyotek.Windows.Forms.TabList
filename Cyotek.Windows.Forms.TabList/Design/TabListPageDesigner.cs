using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
  public class TabListPageDesigner : ScrollableControlDesigner
  {
    #region  Overriden Properties

    public override SelectionRules SelectionRules
    { get { return SelectionRules.Locked; } }

    #endregion  Overriden Properties

    #region  Public Overridden Methods

    public override bool CanBeParentedTo(IDesigner parentDesigner)
    {
      return parentDesigner != null && parentDesigner.Component is TabList;
    }

    #endregion  Public Overridden Methods

    #region  Protected Overridden Methods

    protected override void OnPaintAdornments(PaintEventArgs pe)
    {
      base.OnPaintAdornments(pe);

      if (!(this.Control is Panel) || ((Panel)this.Control).BorderStyle == BorderStyle.None)
      {
        // outline the control at design time if we don't have any borders
        ControlPaint.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
      }
    }

    #endregion  Protected Overridden Methods
  }
}
