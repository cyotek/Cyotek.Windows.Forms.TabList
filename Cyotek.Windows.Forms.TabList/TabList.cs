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

  /// <summary>
  /// Manages a related set of tab pages.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Control"/>
  [ToolboxItem(true)]
  [Designer(typeof(TabListDesigner))]
  [DefaultProperty("TabListPages")]
  [DefaultEvent("SelectedIndexChanged")]
  public partial class TabList : Control
  {
    #region Constants

    private static readonly object _eventAllowTabSelectionChanged = new object();

    private static readonly object _eventDeselected = new object();

    private static readonly object _eventDeselecting = new object();

    private static readonly object _eventHeaderSizeChanged = new object();

    private static readonly object _eventRendererChanged = new object();

    private static readonly object _eventSelected = new object();

    private static readonly object _eventSelectedIndexChanged = new object();

    private static readonly object _eventSelecting = new object();

    private static readonly object _eventShowTabListChanged = new object();

    #endregion

    #region Fields

    private bool _allowTabSelection;

    private Rectangle _displayRectangle;

    private Size _headerSize;

    private int _hotIndex;

    private TabListPage[] _pages;

    private ITabListRenderer _renderer;

    private int _selectedIndex;

    private bool _showTabList;

    private Rectangle _tabListBounds;

    private int _tabListPageCount;

    private TabListPageCollection _tabListPages;

    #endregion

    #region Static Constructors

    /// <summary>
    /// Static constructor.
    /// </summary>
    static TabList()
    {
      TabListRenderer.DefaultRenderer = new VisualStudioTabListRenderer();
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor.
    /// </summary>
    public TabList()
    {
      _tabListPages = new TabListPageCollection(this);
      _selectedIndex = -1;
      _hotIndex = -1;
      _headerSize = new Size(150, 25);
      _showTabList = true;
      _allowTabSelection = true;

      this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor, true);
      this.UpdateFocusStyle();

      this.Size = new Size(200, 200); // the default size is tiny!
      this.Padding = new Padding(3);
    }

    #endregion

    #region Events

    /// <summary>
    /// Occurs when the value of the <see cref="AllowTabSelection"/> property changes.
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler AllowTabSelectionChanged
    {
      add { this.Events.AddHandler(_eventAllowTabSelectionChanged, value); }
      remove { this.Events.RemoveHandler(_eventAllowTabSelectionChanged, value); }
    }

    /// <summary>
    ///
    ///    Occurs when a tab is deselected.
    /// </summary>
    [Category("Action")]
    public event EventHandler<TabListEventArgs> Deselected
    {
      add { this.Events.AddHandler(_eventDeselected, value); }
      remove { this.Events.RemoveHandler(_eventDeselected, value); }
    }

    /// <summary>
    /// Occurs before a tab is deselected, enabling a handler to cancel the tab change.
    /// </summary>
    [Category("Action")]
    public event EventHandler<TabListCancelEventArgs> Deselecting
    {
      add { this.Events.AddHandler(_eventDeselecting, value); }
      remove { this.Events.RemoveHandler(_eventDeselecting, value); }
    }

    /// <summary>
    /// Occurs when the value of the <see cref="HeaderSize"/> property changes.
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler HeaderSizeChanged
    {
      add { this.Events.AddHandler(_eventHeaderSizeChanged, value); }
      remove { this.Events.RemoveHandler(_eventHeaderSizeChanged, value); }
    }

    /// <summary>
    /// Occurs when the value of the <see cref="Renderer"/> property changes.
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler RendererChanged
    {
      add { this.Events.AddHandler(_eventRendererChanged, value); }
      remove { this.Events.RemoveHandler(_eventRendererChanged, value); }
    }

    /// <summary>
    /// Occurs when a tab is selected.
    /// </summary>
    [Category("Action")]
    public event EventHandler<TabListEventArgs> Selected
    {
      add { this.Events.AddHandler(_eventSelected, value); }
      remove { this.Events.RemoveHandler(_eventSelected, value); }
    }

    /// <summary>
    /// Occurs when the value of the <see cref="SelectedIndex"/> property changes.
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler SelectedIndexChanged
    {
      add { this.Events.AddHandler(_eventSelectedIndexChanged, value); }
      remove { this.Events.RemoveHandler(_eventSelectedIndexChanged, value); }
    }

    /// <summary>
    /// Occurs before a tab is selected, enabling a handler to cancel the tab change.
    /// </summary>
    [Category("Action")]
    public event EventHandler<TabListCancelEventArgs> Selecting
    {
      add { this.Events.AddHandler(_eventSelecting, value); }
      remove { this.Events.RemoveHandler(_eventSelecting, value); }
    }

    /// <summary>
    /// Occurs when the value of the <see cref="ShowTabList"/> property changes.
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler ShowTabListChanged
    {
      add { this.Events.AddHandler(_eventShowTabListChanged, value); }
      remove { this.Events.RemoveHandler(_eventShowTabListChanged, value); }
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a value indicating whether the selected tab can be changed via the user interface.
    /// </summary>
    /// <value>
    /// <c>true</c> if the selected tab can be changed via the user interface, otherwise <c>false</c>.
    /// </value>
    [Category("Behavior")]
    [DefaultValue(true)]
    public bool AllowTabSelection
    {
      get { return _allowTabSelection; }
      set
      {
        if (this.AllowTabSelection != value)
        {
          _allowTabSelection = value;

          this.OnAllowTabSelectionChanged(EventArgs.Empty);
        }
      }
    }

    /// <summary>
    /// Gets the display area of the control's tab pages.
    /// </summary>
    /// <value>
    /// A <see cref="Rectangle"/> that represents the display area of the tab pages.
    /// </value>
    public override Rectangle DisplayRectangle
    {
      get
      {
        if (_displayRectangle.IsEmpty)
        {
          _displayRectangle = this.GetDisplayRectangle();
        }

        return _displayRectangle;
      }
    }

    /// <summary>
    /// Gets or sets the default size of tab list headers
    /// </summary>
    /// <value>
    /// A <see cref="Size"/> that represents the default size of tab list headers.
    /// </value>
    [Category("Appearance")]
    [DefaultValue(typeof(Size), "150, 25")]
    public Size HeaderSize
    {
      get { return _headerSize; }
      set
      {
        if (this.HeaderSize != value)
        {
          _headerSize = value;

          this.OnHeaderSizeChanged(EventArgs.Empty);
        }
      }
    }

    /// <summary>
    /// Gets or sets the amount of space around each item on the control's tab pages.
    /// </summary>
    /// <value>
    /// A <see cref="Padding"/> that specifies the amount of space around each item.
    /// </value>
    [DefaultValue(typeof(Padding), "3, 3, 3, 3")]
    public new Padding Padding
    {
      get { return base.Padding; }
      set { base.Padding = value; }
    }

    /// <summary>
    /// Gets or sets a customer renderer for the <see cref="TabList"/>
    /// </summary>
    /// <value>
    /// The customer renderer for painting the control
    /// </value>
    /// <remarks>If this property is <c>null</c> (default), the value of the <see cref="TabListRenderer.DefaultRenderer"/> property will be used instead.</remarks>
    [Category("Appearance")]
    [DefaultValue(null)]
    public ITabListRenderer Renderer
    {
      get { return _renderer; }
      set
      {
        if (_renderer != value)
        {
          _renderer = value;

          this.OnRendererChanged(EventArgs.Empty);
        }
      }
    }

    /// <summary>
    /// Gets or sets the index of the currently selected tab page.
    /// </summary>
    /// <value>
    /// The zero-based index of the currently selected tab page. The default is -1, which is also the value if no tab page is selected.
    /// </value>
    [Browsable(false)]
    [DefaultValue(-1)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex
    {
      get { return _selectedIndex; }
      set
      {
        if (_selectedIndex != value)
        {
          _selectedIndex = value;

          this.OnSelectedIndexChanged(EventArgs.Empty);
        }
      }
    }

    /// <summary>
    /// Gets or sets the currently selected tab page.
    /// </summary>
    /// <value>
    /// A <see cref="TabListPage"/> that represents the selected tab page. If no tab page is selected, the value is <c>null</c>.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public TabListPage SelectedPage
    {
      get { return _selectedIndex != -1 ? _tabListPages[_selectedIndex] : null; }
      set { this.SelectedIndex = _tabListPages.IndexOf(value); }
    }

    /// <summary>
    /// Gets or sets a value indicating whether the tab list is shown.
    /// </summary>
    /// <value>
    /// <c>true</c> if the tab list should be shown; otherwise <c>false</c>.
    /// </value>
    [Category("Appearance")]
    [DefaultValue(true)]
    public bool ShowTabList
    {
      get { return _showTabList; }
      set
      {
        if (_showTabList != value)
        {
          _showTabList = value;

          this.OnShowTabListChanged(EventArgs.Empty);
        }
      }
    }

    /// <summary>
    /// Gets the display area of the control's tab list.
    /// </summary>
    /// <value>
    /// A <see cref="Rectangle"/> that represents the display area of the tab list.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Rectangle TabListDisplayRectangle
    {
      get
      {
        if (_tabListBounds.IsEmpty && _showTabList)
        {
          Padding padding;

          padding = this.Padding;

          _tabListBounds = new Rectangle(padding.Left, padding.Top, this.DisplayRectangle.Left - (padding.Left + 1), this.ClientRectangle.Height - padding.Vertical);
        }

        return _tabListBounds;
      }
    }

    /// <summary>
    /// Gets the number of tabs in the tab list.
    /// </summary>
    /// <value>
    /// The number of tabs in the tab list.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int TabListPageCount
    {
      get { return _tabListPageCount; }
      protected set { _tabListPageCount = value; }
    }

    /// <summary>
    /// Gets the collection of tab pages in this tab control.
    /// </summary>
    /// <value>
    /// A <see cref="TabListPageCollection"/> that contains the <see cref="TabListPage"/> objects in this <see cref="TabList"/>.
    /// </value>
    [Category("Behavior")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public TabListPageCollection TabListPages
    {
      get { return _tabListPages; }
      protected set { _tabListPages = value; }
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    /// <value>
    /// The text associated with this control.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    private int HotIndex
    {
      get { return _hotIndex; }
      set
      {
        if (_hotIndex != value)
        {
          _hotIndex = value;
          this.Invalidate();
        }
      }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Retrieves the page that is at the specified co-ordinates.
    /// </summary>
    /// <param name="x">The x-coordinate at which to retrieve page information.</param>
    /// <param name="y">The y coordinate at which to retrieve page information.</param>
    /// <returns>
    /// The <see cref="TabListPage"/> at the specified point, in client coordinates, or <c>null</c> if there is no page at that location.
    /// </returns>
    public int GetPageAt(int x, int y)
    {
      int result;

      result = -1;

      for (int i = 0; i < _tabListPageCount; i++)
      {
        if (_tabListPages[i].HeaderBounds.Contains(x, y))
        {
          result = i;
          break;
        }
      }

      return result;
    }

    /// <summary>
    /// Retrieves the page that is at the specified point.
    /// </summary>
    /// <param name="point">The <see cref="Point"/> at which to retrieve page information.</param>
    /// <returns>
    /// The <see cref="TabListPage"/> at the specified point, in client coordinates, or <c>null</c> if
    /// there is no page at that location.
    /// </returns>
    public int GetPageAt(Point point)
    {
      return this.GetPageAt(point.X, point.Y);
    }

    /// <summary>
    /// Provides page information, given a point.
    /// </summary>
    /// <param name="point">The <see cref="Point"/> at which to retrieve page information.</param>
    /// <returns>
    /// A list of.
    /// </returns>
    public TabListPage HitTest(Point point)
    {
      return this.HitTest(point.X, point.Y);
    }

    /// <summary>
    /// Provides page information, given x- and y-coordinates.
    /// </summary>
    /// <param name="x">The x-coordinate at which to retrieve page information.</param>
    /// <param name="y">The y coordinate at which to retrieve page information.</param>
    /// <returns>
    /// The page information.
    /// </returns>
    public TabListPage HitTest(int x, int y)
    {
      int index;

      index = this.GetPageAt(x, y);

      return index != -1 ? _tabListPages[index] : null;
    }

    /// <summary>
    /// Creates a new instance of the control collection for the control.
    /// </summary>
    /// <returns>
    /// A new instance of <see cref="Control.ControlCollection"/> assigned to the control.
    /// </returns>
    protected override ControlCollection CreateControlsInstance()
    {
      return new TabListControlCollection(this);
    }

    /// <summary>
    /// Gets a <see cref="ITabListRenderer"/> used to paint the control.
    /// </summary>
    /// <returns>
    /// A <see cref="ITabListRenderer"/> used to paint the control.
    /// </returns>
    protected virtual ITabListRenderer GetRenderer()
    {
      return _renderer ?? TabListRenderer.DefaultRenderer ?? new VisualStudioTabListRenderer();
    }

    /// <summary>
    /// <p>This API supports the product infrastructure and is not intended to be used directly from your code.</p>
    /// <p>This member is not meaningful for this control.</p>
    /// </summary>
    /// <param name="keyData">One of the <see cref="Keys"/> values.</param>
    /// <returns>
    /// <c>true</c> if the specified key is a regular input key; otherwise, <c>false</c>.
    /// </returns>
    protected override bool IsInputKey(Keys keyData)
    {
      bool result;

      switch (keyData)
      {
        case Keys.Up:
        case Keys.Down:
          result = true;
          break;
        default:
          result = base.IsInputKey(keyData);
          break;
      }

      return result;
    }

    /// <summary>
    /// Raises the <see cref="AllowTabSelectionChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnAllowTabSelectionChanged(EventArgs e)
    {
      EventHandler handler;

      this.UpdateFocusStyle();

      handler = (EventHandler)this.Events[_eventAllowTabSelectionChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Deselected" /> event.
    /// </summary>
    /// <param name="e">The <see cref="TabListEventArgs" /> instance containing the event data.</param>
    protected virtual void OnDeselected(TabListEventArgs e)
    {
      EventHandler<TabListEventArgs> handler;

      handler = (EventHandler<TabListEventArgs>)this.Events[_eventDeselected];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Deselecting" /> event.
    /// </summary>
    /// <param name="e">The <see cref="TabListCancelEventArgs" /> instance containing the event data.</param>
    protected virtual void OnDeselecting(TabListCancelEventArgs e)
    {
      EventHandler<TabListCancelEventArgs> handler;

      handler = (EventHandler<TabListCancelEventArgs>)this.Events[_eventDeselecting];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Control.GotFocus"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);

      this.Invalidate();
    }

    /// <summary>
    /// Raises the <see cref="HeaderSizeChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnHeaderSizeChanged(EventArgs e)
    {
      EventHandler handler;

      this.ResetSelectedPage();

      handler = (EventHandler)this.Events[_eventHeaderSizeChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Control.KeyDown"/> event.
    /// </summary>
    /// <param name="e">A <see cref="KeyEventArgs"/> that contains the event data.</param>
    protected override void OnKeyDown(KeyEventArgs e)
    {
      base.OnKeyDown(e);

      if (_showTabList)
      {
        // allow keyboard navigation, if any tabs are present
        if (_tabListPageCount != 0)
        {
          switch (e.KeyCode)
          {
            case Keys.Down:
              this.CycleSelectedTab(1);
              break;
            case Keys.Up:
              this.CycleSelectedTab(-1);
              break;
            case Keys.PageDown:
              this.CycleSelectedTab(3);
              break;
            case Keys.PageUp:
              this.CycleSelectedTab(-3);
              break;
            case Keys.Home:
              this.ProcessTabChange(0);
              break;
            case Keys.End:
              this.ProcessTabChange(_tabListPageCount - 1);
              break;
          }
        }
      }
    }

    /// <summary>
    /// Raises the <see cref="Control.LostFocus"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);

      this.Invalidate();
    }

    /// <summary>
    /// Raises the <see cref="Control.MouseClick"/> event.
    /// </summary>
    /// <param name="e">An <see cref="MouseEventArgs"/> that contains the event data.</param>
    protected override void OnMouseClick(MouseEventArgs e)
    {
      base.OnMouseClick(e);

      if (e.Button == MouseButtons.Left && this.DesignMode | this.AllowTabSelection)
      {
        int index;

        index = this.GetPageAt(e.Location);

        if (index != -1)
        {
          this.ProcessTabChange(index);
        }
      }
    }

    /// <summary>
    /// Raises the <see cref="Control.MouseLeave"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnMouseLeave(EventArgs e)
    {
      base.OnMouseLeave(e);

      this.HotIndex = -1;
    }

    /// <summary>
    /// Raises the <see cref="Control.MouseMove"/> event.
    /// </summary>
    /// <param name="e">An <see cref="MouseEventArgs"/> that contains the event data.</param>
    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);

      if (this.AllowTabSelection)
      {
        this.HotIndex = this.GetPageAt(e.Location);
      }
    }

    /// <summary>
    /// Raises the <see cref="Control.PaddingChanged"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnPaddingChanged(EventArgs e)
    {
      base.OnPaddingChanged(e);

      this.ResetSelectedPage();
    }

    /// <summary>
    /// Raises the <see cref="Control.Paint"/> event.
    /// </summary>
    /// <param name="e">An <see cref="PaintEventArgs"/> that contains the event data.</param>
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      if (_showTabList)
      {
        ITabListRenderer renderer;

        renderer = this.GetRenderer();

        // paint the sidebar
        renderer.RenderList(e.Graphics, this.TabListDisplayRectangle);

        // paint the pages
        for (int i = 0; i < _tabListPageCount; i++)
        {
          TabListPageState state;

          if (i == _selectedIndex)
          {
            state = TabListPageState.Selected;
            if (this.Focused)
            {
              state |= TabListPageState.Focused;
            }
          }
          else if (i == this.HotIndex)
          {
            state = TabListPageState.HotLight;
          }
          else
          {
            state = TabListPageState.None;
          }

          renderer.RenderHeader(e.Graphics, _tabListPages[i], state);
        }
      }
    }

    /// <summary>
    /// Raises the <see cref="RendererChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnRendererChanged(EventArgs e)
    {
      EventHandler handler;

      this.UpdatePages();
      this.Invalidate();

      handler = (EventHandler)this.Events[_eventRendererChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Control.Resize"/> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      this.ResetSelectedPage();
    }

    /// <summary>
    /// Raises the <see cref="Selected" /> event.
    /// </summary>
    /// <param name="e">The <see cref="TabListEventArgs" /> instance containing the event data.</param>
    protected virtual void OnSelected(TabListEventArgs e)
    {
      EventHandler<TabListEventArgs> handler;

      handler = (EventHandler<TabListEventArgs>)this.Events[_eventSelected];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="SelectedIndexChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnSelectedIndexChanged(EventArgs e)
    {
      EventHandler handler;

      this.UpdateSelectedPage();

      handler = (EventHandler)this.Events[_eventSelectedIndexChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="Selecting" /> event.
    /// </summary>
    /// <param name="e">The <see cref="TabListCancelEventArgs" /> instance containing the event data.</param>
    protected virtual void OnSelecting(TabListCancelEventArgs e)
    {
      EventHandler<TabListCancelEventArgs> handler;

      handler = (EventHandler<TabListCancelEventArgs>)this.Events[_eventSelecting];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="ShowTabListChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnShowTabListChanged(EventArgs e)
    {
      EventHandler handler;

      this.ResetSelectedPage();

      handler = (EventHandler)this.Events[_eventShowTabListChanged];

      handler?.Invoke(this, e);
    }

    internal int AddPage(TabListPage page)
    {
      int index;

      index = this.InsertPage(_tabListPageCount, page);

      if (_selectedIndex == -1)
      {
        this.SelectedIndex = index;
      }

      return index;
    }

    internal void ClearAllPages()
    {
      this.Controls.Clear();
      _pages = null;
      _tabListPageCount = 0;
    }

    internal TabListPage[] GetTabListPages()
    {
      TabListPage[] copy;

      copy = new TabListPage[_tabListPageCount];

      if (_tabListPageCount > 0)
      {
        Array.Copy(_pages, copy, _tabListPageCount);
      }

      return copy;
    }

    internal int InsertPage(int index, TabListPage page)
    {
      if (_pages == null)
      {
        _pages = new TabListPage[1];
      }
      else if (_pages.Length == _tabListPageCount)
      {
        // no room left, so resize the array
        TabListPage[] copy;

        copy = new TabListPage[_pages.Length + 1];
        Array.Copy(_pages, copy, _pages.Length);
        _pages = copy;
      }

      // if this is an insert rather than append, move the array around
      if (index < _tabListPageCount)
      {
        Array.Copy(_pages, index, _pages, index + 1, _pages.Length - index);
      }

      // update the array and page count
      _pages[index] = page;
      _tabListPageCount++;
      this.UpdatePages();
      this.UpdateSelectedPage();

      // finally trigger a redraw of the control
      this.Invalidate();

      return index;
    }

    internal void RemovePageAt(int index)
    {
      int selectedIndex;

      if (index < 0 || index >= _tabListPageCount)
      {
        throw new ArgumentOutOfRangeException(nameof(index));
      }

      _tabListPageCount--;

      if (index < _tabListPageCount)
      {
        Array.Copy(_pages, index + 1, _pages, index, _tabListPageCount - index);
      }

      _pages[_tabListPageCount] = null;

      selectedIndex = _selectedIndex;

      if (_tabListPageCount == 0)
      {
        this.SelectedIndex = -1;
      }
      else if (index == selectedIndex || selectedIndex >= _tabListPageCount)
      {
        this.SelectedIndex = 0;
      }

      this.UpdatePages();
      this.UpdateSelectedPage();

      this.Invalidate();
    }

    // ReSharper disable once UnusedParameter.Global
    internal void UpdatePage(TabListPage page)
    {
      this.Invalidate();
    }

    private void CycleSelectedTab(int increment)
    {
      if (_tabListPageCount != 0)
      {
        int index;

        index = _selectedIndex + increment;

        if (index < 0 && increment == -1 || index >= _tabListPageCount && increment != 1)
        {
          index = _tabListPageCount - 1;
        }
        else if (index < 0 && increment != -1 || index >= _tabListPageCount && increment == 1)
        {
          index = 0;
        }

        this.ProcessTabChange(index);
      }
    }

    private Rectangle GetDisplayRectangle()
    {
      Size size;
      Padding padding;
      int leftMargin;
      int topMargin;
      int rightMargin;
      int bottomMargin;

      size = this.ClientSize;
      padding = this.Padding;

      // to avoid calculating every time, calculate it only when it's need it and cache it like any normal property
      if (_showTabList)
      {
        leftMargin = this.HeaderSize.Width + padding.Left + 1;
      }
      else
      {
        leftMargin = padding.Left + 1;
      }
      topMargin = padding.Top + 1;
      rightMargin = padding.Right + 1;
      bottomMargin = padding.Bottom + 1;

      return new Rectangle(leftMargin, topMargin, size.Width - (leftMargin + rightMargin), size.Height - (topMargin + bottomMargin));
    }

    private void ProcessTabChange(int index)
    {
      if (index != _selectedIndex)
      {
        TabListCancelEventArgs cancelEventArgs;
        TabListPage newPage;
        newPage = _pages[index];

        // first raise the Selecting event to allow the UI choice to be cancelled
        cancelEventArgs = new TabListCancelEventArgs(newPage, index, TabListAction.Selecting);
        this.OnSelecting(cancelEventArgs);

        if (!cancelEventArgs.Cancel)
        {
          TabListPage currentPage;

          currentPage = this.SelectedPage;

          // next, raise the Deselect event (if appropriate), and again check for cancellation
          if (currentPage != null)
          {
            cancelEventArgs = new TabListCancelEventArgs(currentPage, _selectedIndex, TabListAction.Deselecting);
            this.OnDeselecting(cancelEventArgs);
          }

          if (!cancelEventArgs.Cancel)
          {
            this.SelectedIndex = index;

            this.OnSelected(new TabListEventArgs(newPage, index, TabListAction.Selected));

            if (currentPage != null)
            {
              this.OnDeselected(new TabListEventArgs(currentPage, _selectedIndex, TabListAction.Deselected));
            }
          }
        }
      }
    }

    private void ResetSelectedPage()
    {
      _displayRectangle = Rectangle.Empty; // force the display rectangle to be recalculated
      _tabListBounds = Rectangle.Empty;
      this.UpdateSelectedPage();
    }

    private void UpdateFocusStyle()
    {
      this.SetStyle(ControlStyles.Selectable, _allowTabSelection);
    }

    private void UpdatePages()
    {
      int y;
      int x;
      Point defaultPosition;
      ITabListRenderer renderer;
      Padding padding;

      renderer = this.GetRenderer();
      padding = this.Padding;

      defaultPosition = renderer.GetStartingPosition();
      y = defaultPosition.X + padding.Top;
      x = defaultPosition.Y + padding.Left;

      foreach (TabListPage page in _tabListPages)
      {
        Size headerSize;

        headerSize = renderer.GetPreferredSize(page, this.HeaderSize);
        page.HeaderBounds = new Rectangle(new Point(x, y), headerSize);
        y += headerSize.Height;
      }
    }

    private void UpdateSelectedPage()
    {
      if (_selectedIndex != -1)
      {
        this.SelectedPage.Bounds = this.DisplayRectangle;

        for (int i = 0; i < _tabListPageCount; i++)
        {
          TabListPage page;

          page = _pages[i];

          if (i == _selectedIndex)
          {
            page.Bounds = this.DisplayRectangle;
            page.Visible = true;
          }
          else
          {
            page.Visible = false;
          }
        }
      }

      this.Invalidate();
    }

    #endregion
  }
}
