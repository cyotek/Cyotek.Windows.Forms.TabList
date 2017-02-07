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

    private int _hoverIndex;

    private TabListPage[] _pages;

    private ITabListPageRenderer _renderer;

    private int _selectedIndex;

    private bool _showTabList;

    private Rectangle _tabListBounds;

    private int _tabListPageCount;

    private TabListPageCollection _tabListPages;

    #endregion

    #region Static Constructors

    static TabList()
    {
      TabListPageRenderer.DefaultRenderer = new DefaultTabListPageRenderer();
    }

    #endregion

    #region Constructors

    public TabList()
    {
      _tabListPages = new TabListPageCollection(this);
      _selectedIndex = -1;
      _hoverIndex = -1;
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

    [Category("Property Changed")]
    public event EventHandler AllowTabSelectionChanged
    {
      add { this.Events.AddHandler(_eventAllowTabSelectionChanged, value); }
      remove { this.Events.RemoveHandler(_eventAllowTabSelectionChanged, value); }
    }

    [Category("Action")]
    public event EventHandler<TabListEventArgs> Deselected
    {
      add { this.Events.AddHandler(_eventDeselected, value); }
      remove { this.Events.RemoveHandler(_eventDeselected, value); }
    }

    [Category("Action")]
    public event EventHandler<TabListCancelEventArgs> Deselecting
    {
      add { this.Events.AddHandler(_eventDeselecting, value); }
      remove { this.Events.RemoveHandler(_eventDeselecting, value); }
    }

    [Category("Property Changed")]
    public event EventHandler HeaderSizeChanged
    {
      add { this.Events.AddHandler(_eventHeaderSizeChanged, value); }
      remove { this.Events.RemoveHandler(_eventHeaderSizeChanged, value); }
    }

    [Category("Property Changed")]
    public event EventHandler RendererChanged
    {
      add { this.Events.AddHandler(_eventRendererChanged, value); }
      remove { this.Events.RemoveHandler(_eventRendererChanged, value); }
    }

    [Category("Action")]
    public event EventHandler<TabListEventArgs> Selected
    {
      add { this.Events.AddHandler(_eventSelected, value); }
      remove { this.Events.RemoveHandler(_eventSelected, value); }
    }

    [Category("Property Changed")]
    public event EventHandler SelectedIndexChanged
    {
      add { this.Events.AddHandler(_eventSelectedIndexChanged, value); }
      remove { this.Events.RemoveHandler(_eventSelectedIndexChanged, value); }
    }

    [Category("Action")]
    public event EventHandler<TabListCancelEventArgs> Selecting
    {
      add { this.Events.AddHandler(_eventSelecting, value); }
      remove { this.Events.RemoveHandler(_eventSelecting, value); }
    }

    [Category("Property Changed")]
    public event EventHandler ShowTabListChanged
    {
      add { this.Events.AddHandler(_eventShowTabListChanged, value); }
      remove { this.Events.RemoveHandler(_eventShowTabListChanged, value); }
    }

    #endregion

    #region Properties

    [Category("Behavior")]
    [DefaultValue(true)]
    public virtual bool AllowTabSelection
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

    public override Rectangle DisplayRectangle
    {
      get
      {
        if (_displayRectangle.IsEmpty)
        {
          int leftMargin;
          int topMargin;
          int rightMargin;
          int bottomMargin;

          // to avoid calculating every time, calculate it only when it's need it and cache it like any normal property
          if (this.ShowTabList)
          {
            leftMargin = this.HeaderSize.Width + this.Padding.Left + 1;
          }
          else
          {
            leftMargin = this.Padding.Left + 1;
          }
          topMargin = this.Padding.Top + 1;
          rightMargin = this.Padding.Right + 1;
          bottomMargin = this.Padding.Bottom + 1;

          _displayRectangle = new Rectangle(leftMargin, topMargin, this.ClientSize.Width - (leftMargin + rightMargin), this.ClientSize.Height - (topMargin + bottomMargin));
        }

        return _displayRectangle;
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Size), "150, 25")]
    public virtual Size HeaderSize
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

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int HoverIndex
    {
      get { return _hoverIndex; }
      set
      {
        if (_hoverIndex != value)
        {
          _hoverIndex = value;
          this.Invalidate();
        }
      }
    }

    [DefaultValue(typeof(Padding), "3, 3, 3, 3")]
    public new Padding Padding
    {
      get { return base.Padding; }
      set { base.Padding = value; }
    }

    [Category("Appearance")]
    [DefaultValue(null)]
    public virtual ITabListPageRenderer Renderer
    {
      get { return _renderer; }
      set
      {
        if (this.Renderer != value)
        {
          _renderer = value;

          this.OnRendererChanged(EventArgs.Empty);
        }
      }
    }

    [Browsable(false)]
    [DefaultValue(-1)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int SelectedIndex
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

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual TabListPage SelectedPage
    {
      get { return _selectedIndex != -1 ? _tabListPages[_selectedIndex] : null; }
      set { this.SelectedIndex = _tabListPages.IndexOf(value); }
    }

    [Category("Appearance")]
    [DefaultValue(true)]
    public virtual bool ShowTabList
    {
      get { return _showTabList; }
      set
      {
        if (this.ShowTabList != value)
        {
          _showTabList = value;

          this.OnShowTabListChanged(EventArgs.Empty);
        }
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Rectangle TabListBounds
    {
      get
      {
        if (_tabListBounds.IsEmpty && this.ShowTabList)
        {
          _tabListBounds = new Rectangle(this.Padding.Left, this.Padding.Top, this.DisplayRectangle.Left - (this.Padding.Left + 1), this.ClientRectangle.Height - this.Padding.Vertical);
        }

        return _tabListBounds;
      }
    }

    [Browsable(false)]
    public int TabListPageCount
    {
      get { return _tabListPageCount; }
      protected set { _tabListPageCount = value; }
    }

    [Category("Behavior")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual TabListPageCollection TabListPages
    {
      get { return _tabListPages; }
      protected set { _tabListPages = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    #endregion

    #region Methods

    public virtual TabListPage HitTest(Point point)
    {
      int index;

      index = this.GetItemAtPoint(point);

      return index != -1 ? _tabListPages[index] : null;
    }

    protected override ControlCollection CreateControlsInstance()
    {
      return new TabListControlCollection(this);
    }

    protected virtual void CycleSelectedTab(int increment)
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

    protected virtual int GetItemAtPoint(Point point)
    {
      int result;

      result = -1;

      for (int i = 0; i < _tabListPageCount; i++)
      {
        if (_tabListPages[i].HeaderBounds.Contains(point))
        {
          result = i;
          break;
        }
      }

      return result;
    }

    protected virtual ITabListPageRenderer GetRenderer()
    {
      return this.Renderer ?? TabListPageRenderer.DefaultRenderer ?? new DefaultTabListPageRenderer();
    }

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

    protected override void OnKeyDown(KeyEventArgs e)
    {
      base.OnKeyDown(e);

      if (this.ShowTabList)
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

    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);

      this.Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
      base.OnMouseClick(e);

      if (e.Button == MouseButtons.Left && this.DesignMode | this.AllowTabSelection)
      {
        int index;

        index = this.GetItemAtPoint(e.Location);

        if (index != -1)
        {
          this.ProcessTabChange(index);
        }
      }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      base.OnMouseLeave(e);

      this.HoverIndex = -1;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);

      if (this.AllowTabSelection)
      {
        this.HoverIndex = this.GetItemAtPoint(e.Location);
      }
    }

    protected override void OnPaddingChanged(EventArgs e)
    {
      base.OnPaddingChanged(e);

      this.ResetSelectedPage();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      if (this.ShowTabList)
      {
        ITabListPageRenderer renderer;

        renderer = this.GetRenderer();

        // paint the sidebar
        renderer.RenderList(e.Graphics, this.TabListBounds);

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
          else if (i == this.HoverIndex)
          {
            state = TabListPageState.Hot;
          }
          else
          {
            state = TabListPageState.Normal;
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

    protected virtual void ResetSelectedPage()
    {
      _displayRectangle = Rectangle.Empty; // force the display rectangle to be recalculated
      _tabListBounds = Rectangle.Empty;
      this.UpdateSelectedPage();
    }

    protected virtual void UpdatePages()
    {
      int y;
      int x;
      Point defaultPosition;
      ITabListPageRenderer renderer;

      renderer = this.GetRenderer();
      defaultPosition = renderer.GetStartingPosition();
      y = defaultPosition.X + this.Padding.Top;
      x = defaultPosition.Y + this.Padding.Left;

      foreach (TabListPage page in _tabListPages)
      {
        Size headerSize;

        headerSize = renderer.GetPreferredSize(page, this.HeaderSize);
        page.HeaderBounds = new Rectangle(new Point(x, y), headerSize);
        y += headerSize.Height;
      }
    }

    protected virtual void UpdateSelectedPage()
    {
      if (_selectedIndex != -1)
      {
        this.SelectedPage.Bounds = this.DisplayRectangle;

        for (int i = 0; i < _tabListPageCount; i++)
        {
          _pages[i].Visible = i == _selectedIndex;
        }
      }

      this.Invalidate();
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

    internal void UpdatePage(TabListPage page)
    {
      this.Invalidate();
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

    private void UpdateFocusStyle()
    {
      this.SetStyle(ControlStyles.Selectable, _allowTabSelection);
    }

    #endregion
  }
}
