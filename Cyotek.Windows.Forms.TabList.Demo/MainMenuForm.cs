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

  internal partial class MainMenuForm : AboutDialog
  {
    #region Constructors

    public MainMenuForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      TabPage demoPage;

      base.OnLoad(e);

      demoPage = new TabPage
                 {
                   UseVisualStyleBackColor = true,
                   Padding = new Padding(9),
                   Text = "Demonstrations"
                 };

      demoGroupBox.Dock = DockStyle.Fill;
      demoPage.Controls.Add(demoGroupBox);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = this.ProductName + " for Windows Forms";
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      generalDemoButton.Focus();
    }

    private void generalDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<GeneralDemonstrationForm>();
    }

    private void ShowDemo<T>() where T : Form, new()
    {
      Cursor.Current = Cursors.WaitCursor;

      using (Form form = new T())
      {
        form.ShowDialog(this);
      }
    }

    private void tabControlDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<TabControlHostDemonstrationForm>();
    }

    private void themeDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<RendererDemonstrationForm>();
    }

    #endregion

    private void dynamicLoadingDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<DynamicLoadingDemonstrationForm>();
    }
  }
}
