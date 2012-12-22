using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  public partial class MainForm : Form
  {
    #region  Public Constructors

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion  Public Constructors

    #region  Protected Overridden Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      selectionPropertyGrid.SelectedObject = tabList.SelectedPage;
      viewsTabList.SelectedPage = pageTabListPage;
    }

    #endregion  Protected Overridden Methods

    #region  Event Handlers

    private void addPageButton_Click(object sender, EventArgs e)
    {
      TabListPage page;

      page = tabList.TabListPages.Add("test");
    }

    private void removePageButton_Click(object sender, EventArgs e)
    {
      TabListPage page;

      page = tabList.SelectedPage;

      if (page != null)
        tabList.TabListPages.Remove(page);
    }

    private void tabList_SelectedIndexChanged(object sender, EventArgs e)
    {
      selectionPropertyGrid.SelectedObject = tabList.SelectedPage;
    }

    #endregion  Event Handlers

    private void firstButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(0);
    }

    private void lastButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.TabListPageCount - 1);
    }

    private void previousButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.SelectedIndex - 1);
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.SelectedIndex + 1);
    }

    private void SelectTab(int index)
    {
      if (index < 0)
        index = 0;
      else if (index > tabList.TabListPageCount - 1)
        index = tabList.TabListPageCount - 1;

      tabList.SelectedIndex = index;
    }
  }
}
