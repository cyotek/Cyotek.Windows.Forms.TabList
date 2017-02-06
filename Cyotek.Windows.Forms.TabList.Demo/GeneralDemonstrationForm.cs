using System;
using System.Media;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class GeneralDemonstrationForm : BaseForm
  {
    #region Fields

    private int _counter;

    #endregion

    #region Constructors

    public GeneralDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      _counter = tabList.TabListPageCount;

      pagePropertyGrid.SelectedObject = tabList.SelectedPage;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void addPageButton_Click(object sender, EventArgs e)
    {
      TabListPage page;

      _counter++;

      page = tabList.TabListPages.Add("New Page " + _counter);

      tabList.SelectedPage = page;
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void firstButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(0);
    }

    private void lastButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.TabListPageCount - 1);
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.SelectedIndex + 1);
    }

    private void previousButton_Click(object sender, EventArgs e)
    {
      this.SelectTab(tabList.SelectedIndex - 1);
    }

    private void removePageButton_Click(object sender, EventArgs e)
    {
      TabListPage page;

      page = tabList.SelectedPage;

      if (page != null && MessageBox.Show($"Are you sure you want to remove page '{page.Text}'?", "Remove Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        tabList.TabListPages.Remove(page);
      }
    }

    private void SelectTab(int index)
    {
      if (index >= 0 && index < tabList.TabListPageCount)
      {
        tabList.SelectedIndex = index;
      }
      else
      {
        SystemSounds.Beep.Play();
      }
    }

    private void tabList_SelectedIndexChanged(object sender, EventArgs e)
    {
      pagePropertyGrid.SelectedObject = tabList.SelectedPage;
    }

    #endregion
  }
}
