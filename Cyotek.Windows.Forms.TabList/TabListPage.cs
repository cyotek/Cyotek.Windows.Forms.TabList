using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms.Design;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2020 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  /// <summary>
  /// Represents a single tab page in a <see cref="TabList"/>.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Panel"/>
  [ToolboxItem(false)]
  [DesignTimeVisible(false)]
  [Designer(typeof(TabListPageDesigner))]
  [DefaultProperty(nameof(Text))]
  public class TabListPage : Panel
  {
    #region Events

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler AutoSizeChanged
    {
      add { base.AutoSizeChanged += value; }
      remove { base.AutoSizeChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler DockChanged
    {
      add { base.DockChanged += value; }
      remove { base.DockChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler LocationChanged
    {
      add { base.LocationChanged += value; }
      remove { base.LocationChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler TabIndexChanged
    {
      add { base.TabIndexChanged += value; }
      remove { base.TabIndexChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler TabStopChanged
    {
      add { base.TabStopChanged += value; }
      remove { base.TabStopChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Always)]
    [Browsable(true)]
    public new event EventHandler TextChanged
    {
      add { base.TextChanged += value; }
      remove { base.TextChanged -= value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler VisibleChanged
    {
      add { base.VisibleChanged += value; }
      remove { base.VisibleChanged -= value; }
    }

    #endregion

    #region Properties

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override AnchorStyles Anchor
    {
      get { return base.Anchor; }
      set { base.Anchor = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public override bool AutoSize
    {
      get { return base.AutoSize; }
      set { base.AutoSize = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Localizable(false)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override AutoSizeMode AutoSizeMode
    {
      get { return AutoSizeMode.GrowOnly; }
      set { }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new BorderStyle BorderStyle
    {
      get { return base.BorderStyle; }
      set { base.BorderStyle = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override DockStyle Dock
    {
      get { return DockStyle.None; }
      set { }
    }

    /// <summary>
    /// Gets the display area of the header item for this <see cref="TabListPage"/>.
    /// </summary>
    /// <value>
    /// A <see cref="Rectangle"/> that represents the header display area of the tab list.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Rectangle HeaderBounds { get; set; }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Point Location
    {
      get { return base.Location; }
      set { base.Location = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [DefaultValue(typeof(Size), "0, 0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MaximumSize
    {
      get { return base.MaximumSize; }
      set { base.MaximumSize = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MinimumSize
    {
      get { return base.MinimumSize; }
      set { base.MinimumSize = value; }
    }

    /// <summary>
    /// Gets the <see cref="TabList"/> control hosting this <see cref="TabListPage"/>.
    /// </summary>
    /// <value>
    /// The <see cref="TabList"/> control hosting this <see cref="TabListPage"/>.
    /// </value>
    [Browsable(false)]
    public TabList Owner
    {
      get { return this.Parent as TabList; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size PreferredSize
    {
      get { return base.PreferredSize; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new int TabIndex
    {
      get { return base.TabIndex; }
      set { base.TabIndex = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool TabStop
    {
      get { return base.TabStop; }
      set { base.TabStop = value; }
    }

    /// <summary>
    /// Gets or sets the text to display on the tab list.
    /// </summary>
    /// <value>
    /// The text to display on the tab list.
    /// </value>
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public override string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool Visible
    {
      get { return base.Visible; }
      set { base.Visible = value; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Convert this object into a string representation.
    /// </summary>
    /// <returns>
    /// A string that represents this object.
    /// </returns>
    public override string ToString()
    {
      return "TabListPage: {" + this.Text + "}";
    }

    /// <summary>
    /// Raises the <see cref="Control.FontChanged"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnFontChanged(EventArgs e)
    {
      base.OnFontChanged(e);
      this.UpdateParent();
    }

    /// <summary>
    /// Raises the <see cref="Control.FontChanged"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnTextChanged(EventArgs e)
    {
      base.OnTextChanged(e);
      this.UpdateParent();
    }

    private void UpdateParent()
    {
      this.Owner?.UpdatePage(this);
    }

    #endregion
  }
}
