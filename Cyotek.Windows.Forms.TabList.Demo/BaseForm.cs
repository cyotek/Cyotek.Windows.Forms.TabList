using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class BaseForm : Form
  {
    #region Constructors

    public BaseForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected void FillTabList(TabList control)
    {
      control.TabListPages.Clear();
      control.TabListPages.Add(this.CreateDemoTabPage1());
      control.TabListPages.Add(this.CreateDemoTabPage2());
      control.TabListPages.Add(this.CreateDemoTabPage3());
    }

    protected string FormatPoint(Point point)
    {
      return $"X:{point.X}, Y:{point.Y}";
    }

    protected string FormatRectangle(RectangleF rect)
    {
      return $"X:{(int)rect.X}, Y:{(int)rect.Y}, W:{(int)rect.Width}, H:{(int)rect.Height}";
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        this.Font = SystemFonts.MessageBoxFont;
      }
    }

    private TabListPage CreateDemoTabPage1()
    {
      TabListPage page;

      page = new TabListPage
             {
               Text = "Options 1"
             };

      return page;
    }

    private TabListPage CreateDemoTabPage2()
    {
      TabListPage page;

      page = new TabListPage
             {
               Text = "Options 2"
             };

      return page;
    }

    private TabListPage CreateDemoTabPage3()
    {
      TabListPage page;

      page = new TabListPage
             {
               Text = "Advanced"
             };

      return page;
    }

    #endregion
  }
}
