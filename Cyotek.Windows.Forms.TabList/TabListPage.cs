using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms.Design;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  [ToolboxItem(false)]
  [DesignTimeVisible(false)]
  [Designer(typeof(TabListPageDesigner))]
  [DefaultProperty("Text")]
  public class TabListPage : Panel
  {
    #region Events

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler AutoSizeChanged
    {
      add { base.AutoSizeChanged += value; }
      remove { base.AutoSizeChanged -= value; }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler DockChanged
    {
      add { base.DockChanged += value; }
      remove { base.DockChanged -= value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler EnabledChanged
    {
      add { base.EnabledChanged += value; }
      remove { base.EnabledChanged -= value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler LocationChanged
    {
      add { base.LocationChanged += value; }
      remove { base.LocationChanged -= value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler TabIndexChanged
    {
      add { base.TabIndexChanged += value; }
      remove { base.TabIndexChanged -= value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler TabStopChanged
    {
      add { base.TabStopChanged += value; }
      remove { base.TabStopChanged -= value; }
    }

    [EditorBrowsable(EditorBrowsableState.Always)]
    [Browsable(true)]
    public new event EventHandler TextChanged
    {
      add { base.TextChanged += value; }
      remove { base.TextChanged -= value; }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler VisibleChanged
    {
      add { base.VisibleChanged += value; }
      remove { base.VisibleChanged -= value; }
    }

    #endregion

    #region Properties

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override AnchorStyles Anchor
    {
      get { return base.Anchor; }
      set { base.Anchor = value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public override bool AutoSize
    {
      get { return base.AutoSize; }
      set { base.AutoSize = value; }
    }

    [Localizable(false)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override AutoSizeMode AutoSizeMode
    {
      get { return AutoSizeMode.GrowOnly; }
      set { }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new BorderStyle BorderStyle
    {
      get { return base.BorderStyle; }
      set { base.BorderStyle = value; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override DockStyle Dock
    {
      get { return DockStyle.None; }
      set { }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool Enabled
    {
      get { return base.Enabled; }
      set { base.Enabled = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual Rectangle HeaderBounds { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Point Location
    {
      get { return base.Location; }
      set { base.Location = value; }
    }

    [Browsable(false)]
    [DefaultValue(typeof(Size), "0, 0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MaximumSize
    {
      get { return base.MaximumSize; }
      set { base.MaximumSize = value; }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MinimumSize
    {
      get { return base.MinimumSize; }
      set { base.MinimumSize = value; }
    }

    [Browsable(false)]
    public TabList Owner
    {
      get { return this.Parent as TabList; }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size PreferredSize
    {
      get { return base.PreferredSize; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new int TabIndex
    {
      get { return base.TabIndex; }
      set { base.TabIndex = value; }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool TabStop
    {
      get { return base.TabStop; }
      set { base.TabStop = value; }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public override string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

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

    protected override void OnFontChanged(EventArgs e)
    {
      base.OnFontChanged(e);
      this.UpdateParent();
    }

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
