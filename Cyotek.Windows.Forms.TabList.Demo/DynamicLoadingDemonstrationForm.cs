using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class DynamicLoadingDemonstrationForm : BaseForm
  {
    #region Private Fields

    private bool[] _viewInitialized;

    #endregion Private Fields

    #region Public Constructors

    public DynamicLoadingDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      _viewInitialized = new bool[tabList.TabListPageCount];
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      // The Selecting event is raised
      this.InitializeView(tabList.SelectedIndex);
    }

    #endregion Protected Methods

    #region Private Methods

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InitializeView(int index)
    {
      if (!_viewInitialized[index])
      {
        Control host;

        _viewInitialized[index] = true;

        switch (index)
        {
          case 0:
            host = new FakeOptionPage1();
            break;

          case 1:
            host = new FakeOptionPage2();
            break;

          case 2:
            host = new FakeOptionPage3();
            break;

          default:
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        host.Dock = DockStyle.Fill;

        tabList.TabListPages[index].Controls.Add(host);
      }
    }

    private void tabList_Deselected(object sender, TabListEventArgs e)
    {
      eventsListBox.AddEvent(tabList, "Deselected", e);
    }

    private void tabList_Deselecting(object sender, TabListCancelEventArgs e)
    {
      eventsListBox.AddEvent(tabList, "Deselecting", e);
    }

    private void tabList_Selected(object sender, TabListEventArgs e)
    {
      eventsListBox.AddEvent(tabList, "Selected", e);
    }

    private void tabList_SelectedIndexChanged(object sender, EventArgs e)
    {
      eventsListBox.AddEvent(tabList, "SelectedIndexChanged", e);
    }

    private void tabList_Selecting(object sender, TabListCancelEventArgs e)
    {
      eventsListBox.AddEvent(tabList, "Selecting", e);

      this.InitializeView(e.TabPageIndex);
    }

    #endregion Private Methods
  }
}
