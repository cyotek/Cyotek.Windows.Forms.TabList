namespace Cyotek.Windows.Forms.Demo
{
  partial class TabControlHostDemonstrationForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPage = new System.Windows.Forms.TabPage();
      this.tabList = new Cyotek.Windows.Forms.TabList();
      this.tabListPage1 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage11 = new Cyotek.Windows.Forms.Demo.FakeOptionPage1();
      this.tabListPage2 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage21 = new Cyotek.Windows.Forms.Demo.FakeOptionPage2();
      this.tabListPage3 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage31 = new Cyotek.Windows.Forms.Demo.FakeOptionPage3();
      this.menuStrip1.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPage.SuspendLayout();
      this.tabList.SuspendLayout();
      this.tabListPage1.SuspendLayout();
      this.tabListPage2.SuspendLayout();
      this.tabListPage3.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 483);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(773, 22);
      this.statusStrip1.TabIndex = 7;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(773, 24);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.closeToolStripMenuItem.Text = "&Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPage);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 24);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(773, 459);
      this.tabControl.TabIndex = 8;
      // 
      // tabPage
      // 
      this.tabPage.Controls.Add(this.tabList);
      this.tabPage.Location = new System.Drawing.Point(4, 22);
      this.tabPage.Name = "tabPage";
      this.tabPage.Padding = new System.Windows.Forms.Padding(12);
      this.tabPage.Size = new System.Drawing.Size(765, 433);
      this.tabPage.TabIndex = 0;
      this.tabPage.Text = "Options";
      this.tabPage.UseVisualStyleBackColor = true;
      // 
      // tabList
      // 
      this.tabList.Controls.Add(this.tabListPage1);
      this.tabList.Controls.Add(this.tabListPage2);
      this.tabList.Controls.Add(this.tabListPage3);
      this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabList.Location = new System.Drawing.Point(12, 12);
      this.tabList.Name = "tabList";
      this.tabList.Size = new System.Drawing.Size(741, 409);
      this.tabList.TabIndex = 2;
      // 
      // tabListPage1
      // 
      this.tabListPage1.Controls.Add(this.fakeOptionPage11);
      this.tabListPage1.Name = "tabListPage1";
      this.tabListPage1.Size = new System.Drawing.Size(583, 401);
      this.tabListPage1.Text = "Options";
      // 
      // fakeOptionPage11
      // 
      this.fakeOptionPage11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage11.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage11.Name = "fakeOptionPage11";
      this.fakeOptionPage11.Size = new System.Drawing.Size(583, 401);
      this.fakeOptionPage11.TabIndex = 0;
      // 
      // tabListPage2
      // 
      this.tabListPage2.Controls.Add(this.fakeOptionPage21);
      this.tabListPage2.Name = "tabListPage2";
      this.tabListPage2.Size = new System.Drawing.Size(42, 192);
      this.tabListPage2.Text = "More Options";
      // 
      // fakeOptionPage21
      // 
      this.fakeOptionPage21.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage21.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage21.Name = "fakeOptionPage21";
      this.fakeOptionPage21.Size = new System.Drawing.Size(42, 192);
      this.fakeOptionPage21.TabIndex = 0;
      // 
      // tabListPage3
      // 
      this.tabListPage3.Controls.Add(this.fakeOptionPage31);
      this.tabListPage3.Name = "tabListPage3";
      this.tabListPage3.Size = new System.Drawing.Size(42, 192);
      this.tabListPage3.Text = "Advanced Options";
      // 
      // fakeOptionPage31
      // 
      this.fakeOptionPage31.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage31.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage31.Name = "fakeOptionPage31";
      this.fakeOptionPage31.Size = new System.Drawing.Size(42, 192);
      this.fakeOptionPage31.TabIndex = 0;
      // 
      // TabControlHostDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(773, 505);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "TabControlHostDemonstrationForm";
      this.Text = "TabControl Host Demonstration";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl.ResumeLayout(false);
      this.tabPage.ResumeLayout(false);
      this.tabList.ResumeLayout(false);
      this.tabListPage1.ResumeLayout(false);
      this.tabListPage2.ResumeLayout(false);
      this.tabListPage3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPage;
    private TabList tabList;
    private TabListPage tabListPage1;
    private FakeOptionPage1 fakeOptionPage11;
    private TabListPage tabListPage2;
    private FakeOptionPage2 fakeOptionPage21;
    private TabListPage tabListPage3;
    private FakeOptionPage3 fakeOptionPage31;
  }
}