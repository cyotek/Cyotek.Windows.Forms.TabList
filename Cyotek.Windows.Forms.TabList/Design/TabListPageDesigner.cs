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

  /// <summary>
  /// Extends the design mode behavior of a <see cref="TabListPage"/>.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Design.ScrollableControlDesigner"/>
  public class TabListPageDesigner : ScrollableControlDesigner
  {
    #region Properties

    /// <summary>
    /// Gets the selection rules that indicate the movement capabilities of a component.
    /// </summary>
    /// <value>
    /// A bitwise combination of <see cref="SelectionRules"/> values.
    /// </value>
    public override SelectionRules SelectionRules
    {
      get { return SelectionRules.Locked; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Indicates if this designer's control can be parented by the control of the specified designer.
    /// </summary>
    /// <param name="parentDesigner">The <see cref="IDesigner"/> that manages the control to check.</param>
    /// <returns>
    /// <c>true</c> if the control managed by the specified designer can parent the control managed by this designer; otherwise, <c>false</c>.
    /// </returns>
    public override bool CanBeParentedTo(IDesigner parentDesigner)
    {
      return parentDesigner?.Component is TabList;
    }

    /// <summary>
    /// Receives a call when the control that the designer is managing has painted its surface so the designer can paint any additional adornments on top of the control.
    /// </summary>
    /// <param name="pe">A <see cref="PaintEventArgs"/> the designer can use to draw on the control.</param>
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
