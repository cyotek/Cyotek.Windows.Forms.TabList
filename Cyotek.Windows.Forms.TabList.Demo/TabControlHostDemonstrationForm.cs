using System;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class TabControlHostDemonstrationForm : BaseForm
  {
    #region Constructors

    public TabControlHostDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion
  }
}
