using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
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

  public class TabListDesigner : ParentControlDesigner
  {
    #region Instance Fields

    private DesignerVerb _addVerb;

    private DesignerVerb _removeVerb;

    private DesignerVerbCollection _verbs;

    #endregion

    #region Overridden Properties

    /// <summary>
    /// Gets a value indicating whether the <see cref="T:System.Windows.Forms.Design.ControlDesigner" /> will allow snapline alignment during a drag operation.
    /// </summary>
    /// <value><c>true</c> if the ControlDesigner will allow snapline alignment during a drag operation when the primary drag control is over this designer; otherwise, <c>false</c>.</value>
    /// <returns>true if the <see cref="T:System.Windows.Forms.Design.ControlDesigner" /> will allow snapline alignment during a drag operation when the primary drag control is over this designer; otherwise, false.</returns>
    public override bool ParticipatesWithSnapLines
    {
      get
      {
        bool result;
        TabListPageDesigner designer;

        designer = this.GetSelectedTabListPageDesigner();

        if (designer != null)
          result = designer.ParticipatesWithSnapLines;
        else
          result = true;

        return result;
      }
    }

    /// <summary>
    /// Gets the design-time verbs supported by the component that is associated with the designer.
    /// </summary>
    /// <value>A collection that contains the verbs that are available to the designer.</value>
    /// <returns>A <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> of <see cref="T:System.ComponentModel.Design.DesignerVerb" /> objects, or null if no designer verbs are available. This default implementation always returns null.</returns>
    public override DesignerVerbCollection Verbs
    {
      get
      {
        if (_verbs == null)
        {
          _verbs = new DesignerVerbCollection();

          _addVerb = new DesignerVerb("Add TabListPage", this.AddVerbHandler)
          {
            Description = "Add a new TabListPage to the parent control."
          };
          _removeVerb = new DesignerVerb("Remove TabListPage", this.RemoveVerbHandler)
          {
            Description = "Remove the currently selected TabListPage from the parent control."
          };

          _verbs.Add(_addVerb);
          _verbs.Add(_removeVerb);
        }

        return _verbs;
      }
    }

    #endregion

    #region Overridden Members

    /// <summary>
    /// Indicates whether the control managed by the specified designer can be a child of the control managed by this designer.
    /// </summary>
    /// <param name="control">The control to test.</param>
    /// <returns>true if the control managed by the specified designer can be a child of the control managed by this designer; otherwise, false.</returns>
    public override bool CanParent(Control control)
    {
      return control is TabList && !this.Control.Contains(control);
    }

    /// <summary>
    /// Initializes the designer with the specified component.
    /// </summary>
    /// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to associate with the designer.</param>
    public override void Initialize(IComponent component)
    {
      TabList control;
      ISelectionService selectionService;
      IComponentChangeService changeService;

      base.Initialize(component);

      // attach an event so we can be notified when the selected components in the host change
      selectionService = (ISelectionService)this.GetService(typeof(ISelectionService));
      if (selectionService != null)
        selectionService.SelectionChanged += this.OnSelectionChanged;

      // attach an event to notify us of when a component has been modified
      changeService = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
      if (changeService != null)
        changeService.ComponentChanged += this.OnComponentChanged;

      // attach an event so we can tell when the SelectedIndex of the TabList control changes
      control = component as TabList;
      if (control != null)
        control.SelectedIndexChanged += this.OnSelectedIndexChanged;
    }

    /// <summary>
    /// Initializes the new component.
    /// </summary>
    /// <param name="defaultValues">A name/value dictionary of default values to apply to properties. May be null if no default values are specified.</param>
    public override void InitializeNewComponent(IDictionary defaultValues)
    {
      base.InitializeNewComponent(defaultValues);

      // add two default pages to each new control and reset the selected index
      this.AddTabListPage();
      this.AddTabListPage();
      this.TabListControl.SelectedIndex = 0;
    }

    /// <summary>
    /// Provides core functionality for all the <see cref="M:System.Windows.Forms.Design.ParentControlDesigner.CreateTool(System.Drawing.Design.ToolboxItem)" /> methods.
    /// </summary>
    /// <param name="tool">The <see cref="T:System.Drawing.Design.ToolboxItem" /> to create a component from.</param>
    /// <param name="x">The horizontal position, in design-time view coordinates, of the location of the left edge of the tool, if a size is specified; the horizontal position of the center of the tool, if no size is specified.</param>
    /// <param name="y">The vertical position, in design-time view coordinates, of the location of the top edge of the tool, if a size is specified; the vertical position of the center of the tool, if no size is specified.</param>
    /// <param name="width">The width of the tool. This parameter is ignored if the <paramref name="hasSize" /> parameter is set to false.</param>
    /// <param name="height">The height of the tool. This parameter is ignored if the <paramref name="hasSize" /> parameter is set to false.</param>
    /// <param name="hasLocation">true if a location for the component is specified; false if the component is to be positioned in the center of the currently selected control.</param>
    /// <param name="hasSize">true if a size for the component is specified; false if the default height and width values for the component are to be used.</param>
    /// <returns>An array of components created from the tool.</returns>
    /// <exception cref="System.ArgumentException"></exception>
    protected override IComponent[] CreateToolCore(ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize)
    {
      TabList control;
      IDesignerHost host;

      control = this.TabListControl;

      // prevent controls from being created directly on the TabList
      if (control.SelectedPage == null)
        throw new ArgumentException(string.Format("Cannot add control '{0}', no page is selected.", tool.DisplayName));

      host = (IDesignerHost)this.GetService(typeof(IDesignerHost));
      if (host != null)
      {
        ParentControlDesigner childDesigner;

        childDesigner = (ParentControlDesigner)host.GetDesigner(control.SelectedPage);

        // add controls onto the TabListPage control instead of the TabList
        InvokeCreateTool(childDesigner, tool);
      }

      return null;
    }

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Design.ParentControlDesigner" />, and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        ISelectionService selectionService;
        IComponentChangeService changeService;
        TabList control;

        // deatch all the events we hooked into earlier

        selectionService = (ISelectionService)this.GetService(typeof(ISelectionService));
        if (selectionService != null)
          selectionService.SelectionChanged -= this.OnSelectionChanged;

        changeService = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
        if (changeService != null)
          changeService.ComponentChanged -= this.OnComponentChanged;

        control = this.TabListControl;
        if (control != null)
          control.SelectedIndexChanged -= this.OnSelectedIndexChanged;
      }

      base.Dispose(disposing);
    }

    /// <summary>
    /// Indicates whether a mouse click at the specified point should be handled by the control.
    /// </summary>
    /// <param name="point">A <see cref="T:System.Drawing.Point" /> indicating the position at which the mouse was clicked, in screen coordinates.</param>
    /// <returns>true if a click at the specified point is to be handled by the control; otherwise, false.</returns>
    protected override bool GetHitTest(Point point)
    {
      TabList control;
      bool result;
      Point location;

      // return true if the mouse is located over a TabListPage header
      // this allows you to switch pages at design time with the mouse
      // rather than just selecting the control as it would otherwise

      control = this.TabListControl;
      location = control.PointToClient(point);
      result = control.HitTest(location) != null;

      return result;
    }

    /// <summary>
    /// Called when the control that the designer is managing has painted its surface so the designer can paint any additional adornments on top of the control.
    /// </summary>
    /// <param name="pe">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that provides data for the event.</param>
    protected override void OnPaintAdornments(PaintEventArgs pe)
    {
      base.OnPaintAdornments(pe);

      // outline the control at design time as we don't have any borders
      ControlPaint.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
    }

    /// <summary>
    /// Processes Windows messages and optionally routes them to the control.
    /// </summary>
    /// <param name="m">The <see cref="T:System.Windows.Forms.Message" /> to process.</param>
    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case 0x7b: // WM_CONTEXTMENU
          Point position;

          // For some reason the context menu is no longer displayed when right clicking the control
          // By hooking into the WM_CONTEXTMENU context message we can display the menu ourselves

          position = Cursor.Position;

          this.OnContextMenu(position.X, position.Y);
          break;
        default:
          base.WndProc(ref m);
          break;
      }
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the TabList control currently being designed
    /// </summary>
    /// <value>The TabList control being designed.</value>
    protected TabList TabListControl
    {
      get { return this.Control as TabList; }
    }

    #endregion

    #region Members

    /// <summary>
    /// Adds a new TabListPage to the control
    /// </summary>
    protected virtual void AddTabListPage()
    {
      TabList control;
      IDesignerHost host;

      control = this.TabListControl;
      host = (IDesignerHost)this.GetService(typeof(IDesignerHost));

      if (host != null)
      {
        using (DesignerTransaction transaction = host.CreateTransaction(string.Format("Add TabListPage to '{0}'", control.Name)))
        {
          try
          {
            TabListPage page;
            MemberDescriptor controlsProperty;

            page = (TabListPage)host.CreateComponent(typeof(TabListPage));
            controlsProperty = TypeDescriptor.GetProperties(control)["Controls"];

            // tell the designer we're about to start making changes
            this.RaiseComponentChanging(controlsProperty);

            // set the text to match the name
            page.Text = page.Name;

            // add the new control to the parent, and set it to be the active page
            control.Controls.Add(page);
            control.SelectedIndex = control.TabListPageCount - 1;

            // inform the designer we're finished making changes
            this.RaiseComponentChanged(controlsProperty, null, null);

            // commit the transaction
            transaction.Commit();
          }
          catch
          {
            transaction.Cancel();
            throw;
          }
        }
      }
    }

    /// <summary>
    /// Removes the selected TabListPage from the control
    /// </summary>
    protected virtual void RemoveSelectedTabListPage()
    {
      TabList control;

      control = this.TabListControl;

      if (control != null && control.TabListPageCount != 0)
      {
        IDesignerHost host;

        host = (IDesignerHost)this.GetService(typeof(IDesignerHost));

        if (host != null)
        {
          using (DesignerTransaction transaction = host.CreateTransaction(string.Format("Remove TabListPage from '{0}'", control.Name)))
          {
            try
            {
              MemberDescriptor controlsProperty;

              controlsProperty = TypeDescriptor.GetProperties(control)["Controls"];

              // inform the designer we're about to make changes
              this.RaiseComponentChanging(controlsProperty);

              // remove the tab page
              host.DestroyComponent(control.SelectedPage);

              // tell the designer w're finished making changes
              this.RaiseComponentChanged(controlsProperty, null, null);

              // commit the transaction
              transaction.Commit();
            }
            catch
            {
              transaction.Cancel();
              throw;
            }
          }
        }
      }
    }

    /// <summary>
    /// Called when the Add TabListPage verb is executed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void AddVerbHandler(object sender, EventArgs e)
    {
      this.AddTabListPage();
    }

    /// <summary>
    /// Gets the TabListPage that contains the specified component
    /// </summary>
    /// <param name="component">The component.</param>
    /// <returns>The TabListPage that hosts the specified component, otherwise null</returns>
    private TabListPage GetComponentOwner(object component)
    {
      TabListPage result;

      if (component is Control)
      {
        Control parent;

        parent = (Control)component;
        while (parent != null && !(parent is TabListPage))
          parent = parent.Parent;

        result = (TabListPage)parent;
      }
      else
        result = null;

      return result;
    }

    /// <summary>
    /// Gets the designer for the selected TabListPage
    /// </summary>
    /// <returns></returns>
    private TabListPageDesigner GetSelectedTabListPageDesigner()
    {
      TabListPageDesigner designer;
      TabListPage selectedPage;

      selectedPage = this.TabListControl.SelectedPage;
      designer = null;

      if (selectedPage != null)
      {
        IDesignerHost host;

        host = (IDesignerHost)this.GetService(typeof(IDesignerHost));
        if (host != null)
          designer = host.GetDesigner(selectedPage) as TabListPageDesigner;
      }

      return designer;
    }

    /// <summary>
    /// Called when the Remove TabListPage verb is executed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void RemoveVerbHandler(object sender, EventArgs e)
    {
      this.RemoveSelectedTabListPage();
    }

    #endregion

    #region Event Handlers

    /// <summary>
    /// Called when the component attached to this designer has changed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="ComponentChangedEventArgs" /> instance containing the event data.</param>
    private void OnComponentChanged(object sender, ComponentChangedEventArgs e)
    {
      // disable the Remove command if we dont' have anything we can actually remove
      if (_removeVerb != null)
        _removeVerb.Enabled = this.TabListControl.TabListPageCount > 0;
    }

    /// <summary>
    /// Called when the SelectedIndex property of the TabList control being designed has changed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void OnSelectedIndexChanged(object sender, EventArgs e)
    {
      ISelectionService service;

      service = (ISelectionService)this.GetService(typeof(ISelectionService));
      if (service != null)
      {
        // set the TabList control as the selected object. We need to do this as if the control is selected as a result
        // of GetHitTest returning true, normal designer actions don't seem to take place
        // Alternatively, we could select the selected TabListPage instead but might as well stick with the standard behaviour
        service.SetSelectedComponents(new object[]
        {
          this.Control
        });
      }
    }

    /// <summary>
    /// Called when the selected components have changed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void OnSelectionChanged(object sender, EventArgs e)
    {
      ISelectionService service;

      service = (ISelectionService)this.GetService(typeof(ISelectionService));
      if (service != null)
      {
        TabList control;

        control = this.TabListControl;
        foreach (object component in service.GetSelectedComponents())
        {
          TabListPage ownedPage;

          // check to see if one of the selected controls is hosted on a TabListPage. If it is, 
          // activate the page. This means, if for example, you select a control via the
          // IDE's properties window, the relavent TabListPage will be activated

          ownedPage = this.GetComponentOwner(component);
          if (ownedPage != null && ownedPage.Parent == control)
          {
            control.SelectedPage = ownedPage;
            break;
          }
        }
      }
    }

    #endregion
  }
}
