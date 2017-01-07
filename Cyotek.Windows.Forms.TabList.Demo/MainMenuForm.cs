using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See tablist-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class MainMenuForm : AboutDialog
  {
    #region Constructors

    public MainMenuForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Overridden Members

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

      groupBox1.Dock = DockStyle.Fill;
      demoPage.Controls.Add(groupBox1);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = "Cyotek TabList Control for Windows Forms";
    }

    #endregion

    #region Members

    private void ShowDemo<T>() where T : Form
    {
      using (Form dialog = Activator.CreateInstance<T>())
        dialog.ShowDialog(this);
    }

    #endregion

    #region Event Handlers

    private void generalDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<GeneralDemonstrationForm>();
    }

    private void renderStylesDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<RendererDemonstrationForm>();
    }

    #endregion
  }
}
