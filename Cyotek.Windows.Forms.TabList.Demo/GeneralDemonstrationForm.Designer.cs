namespace Cyotek.Windows.Forms.Demo
{
  partial class GeneralDemonstrationForm
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
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.viewsTabList = new Cyotek.Windows.Forms.TabList();
      this.controlTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.controlPropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.pageTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.selectionPropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.miscTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.lastButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.previousButton = new System.Windows.Forms.Button();
      this.firstButton = new System.Windows.Forms.Button();
      this.removePageButton = new System.Windows.Forms.Button();
      this.addPageButton = new System.Windows.Forms.Button();
      this.tabList = new Cyotek.Windows.Forms.TabList();
      this.tabListPage1 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage11 = new Cyotek.Windows.Forms.Demo.FakeOptionPage1();
      this.tabListPage2 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage21 = new Cyotek.Windows.Forms.Demo.FakeOptionPage2();
      this.tabListPage3 = new Cyotek.Windows.Forms.TabListPage();
      this.fakeOptionPage31 = new Cyotek.Windows.Forms.Demo.FakeOptionPage3();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.viewsTabList.SuspendLayout();
      this.controlTabListPage.SuspendLayout();
      this.pageTabListPage.SuspendLayout();
      this.miscTabListPage.SuspendLayout();
      this.tabList.SuspendLayout();
      this.tabListPage1.SuspendLayout();
      this.tabListPage2.SuspendLayout();
      this.tabListPage3.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer.Location = new System.Drawing.Point(0, 24);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.viewsTabList);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.tabList);
      this.splitContainer.Size = new System.Drawing.Size(759, 472);
      this.splitContainer.SplitterDistance = 400;
      this.splitContainer.TabIndex = 1;
      // 
      // viewsTabList
      // 
      this.viewsTabList.Controls.Add(this.controlTabListPage);
      this.viewsTabList.Controls.Add(this.pageTabListPage);
      this.viewsTabList.Controls.Add(this.miscTabListPage);
      this.viewsTabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewsTabList.Location = new System.Drawing.Point(0, 0);
      this.viewsTabList.Name = "viewsTabList";
      this.viewsTabList.Size = new System.Drawing.Size(400, 472);
      this.viewsTabList.TabIndex = 0;
      // 
      // controlTabListPage
      // 
      this.controlTabListPage.Controls.Add(this.controlPropertyGrid);
      this.controlTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlTabListPage.Name = "controlTabListPage";
      this.controlTabListPage.Padding = new System.Windows.Forms.Padding(3);
      this.controlTabListPage.Size = new System.Drawing.Size(242, 464);
      this.controlTabListPage.TabIndex = 0;
      this.controlTabListPage.Text = "Control";
      // 
      // controlPropertyGrid
      // 
      this.controlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPropertyGrid.Location = new System.Drawing.Point(3, 3);
      this.controlPropertyGrid.Name = "controlPropertyGrid";
      this.controlPropertyGrid.SelectedObject = this.tabList;
      this.controlPropertyGrid.Size = new System.Drawing.Size(236, 458);
      this.controlPropertyGrid.TabIndex = 1;
      // 
      // pageTabListPage
      // 
      this.pageTabListPage.Controls.Add(this.selectionPropertyGrid);
      this.pageTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pageTabListPage.Name = "pageTabListPage";
      this.pageTabListPage.Padding = new System.Windows.Forms.Padding(3);
      this.pageTabListPage.Size = new System.Drawing.Size(49, 222);
      this.pageTabListPage.TabIndex = 1;
      this.pageTabListPage.Text = "Selected TabListPage";
      // 
      // selectionPropertyGrid
      // 
      this.selectionPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.selectionPropertyGrid.Location = new System.Drawing.Point(3, 3);
      this.selectionPropertyGrid.Name = "selectionPropertyGrid";
      this.selectionPropertyGrid.Size = new System.Drawing.Size(43, 216);
      this.selectionPropertyGrid.TabIndex = 1;
      // 
      // miscTabListPage
      // 
      this.miscTabListPage.Controls.Add(this.lastButton);
      this.miscTabListPage.Controls.Add(this.nextButton);
      this.miscTabListPage.Controls.Add(this.previousButton);
      this.miscTabListPage.Controls.Add(this.firstButton);
      this.miscTabListPage.Controls.Add(this.removePageButton);
      this.miscTabListPage.Controls.Add(this.addPageButton);
      this.miscTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.miscTabListPage.Name = "miscTabListPage";
      this.miscTabListPage.Padding = new System.Windows.Forms.Padding(3);
      this.miscTabListPage.Size = new System.Drawing.Size(49, 222);
      this.miscTabListPage.TabIndex = 2;
      this.miscTabListPage.Text = "Misc";
      // 
      // lastButton
      // 
      this.lastButton.Location = new System.Drawing.Point(12, 249);
      this.lastButton.Name = "lastButton";
      this.lastButton.Size = new System.Drawing.Size(210, 36);
      this.lastButton.TabIndex = 5;
      this.lastButton.Text = "Last";
      this.lastButton.UseVisualStyleBackColor = true;
      this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(12, 204);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(210, 36);
      this.nextButton.TabIndex = 4;
      this.nextButton.Text = "Next";
      this.nextButton.UseVisualStyleBackColor = true;
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // previousButton
      // 
      this.previousButton.Location = new System.Drawing.Point(12, 159);
      this.previousButton.Name = "previousButton";
      this.previousButton.Size = new System.Drawing.Size(210, 36);
      this.previousButton.TabIndex = 3;
      this.previousButton.Text = "Previous";
      this.previousButton.UseVisualStyleBackColor = true;
      this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
      // 
      // firstButton
      // 
      this.firstButton.Location = new System.Drawing.Point(12, 115);
      this.firstButton.Name = "firstButton";
      this.firstButton.Size = new System.Drawing.Size(210, 36);
      this.firstButton.TabIndex = 2;
      this.firstButton.Text = "First";
      this.firstButton.UseVisualStyleBackColor = true;
      this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
      // 
      // removePageButton
      // 
      this.removePageButton.Location = new System.Drawing.Point(12, 53);
      this.removePageButton.Name = "removePageButton";
      this.removePageButton.Size = new System.Drawing.Size(210, 36);
      this.removePageButton.TabIndex = 1;
      this.removePageButton.Text = "Remove Selected Page";
      this.removePageButton.UseVisualStyleBackColor = true;
      this.removePageButton.Click += new System.EventHandler(this.removePageButton_Click);
      // 
      // addPageButton
      // 
      this.addPageButton.Location = new System.Drawing.Point(12, 9);
      this.addPageButton.Name = "addPageButton";
      this.addPageButton.Size = new System.Drawing.Size(210, 36);
      this.addPageButton.TabIndex = 0;
      this.addPageButton.Text = "Add Page";
      this.addPageButton.UseVisualStyleBackColor = true;
      this.addPageButton.Click += new System.EventHandler(this.addPageButton_Click);
      // 
      // tabList
      // 
      this.tabList.Controls.Add(this.tabListPage1);
      this.tabList.Controls.Add(this.tabListPage2);
      this.tabList.Controls.Add(this.tabListPage3);
      this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabList.Location = new System.Drawing.Point(0, 0);
      this.tabList.Name = "tabList";
      this.tabList.Size = new System.Drawing.Size(355, 472);
      this.tabList.TabIndex = 2;
      // 
      // tabListPage1
      // 
      this.tabListPage1.Controls.Add(this.fakeOptionPage11);
      this.tabListPage1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage1.Name = "tabListPage1";
      this.tabListPage1.Size = new System.Drawing.Size(197, 464);
      this.tabListPage1.TabIndex = 0;
      this.tabListPage1.Text = "Options";
      // 
      // fakeOptionPage11
      // 
      this.fakeOptionPage11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage11.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage11.Name = "fakeOptionPage11";
      this.fakeOptionPage11.Size = new System.Drawing.Size(197, 464);
      this.fakeOptionPage11.TabIndex = 0;
      // 
      // tabListPage2
      // 
      this.tabListPage2.Controls.Add(this.fakeOptionPage21);
      this.tabListPage2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage2.Name = "tabListPage2";
      this.tabListPage2.Size = new System.Drawing.Size(49, 222);
      this.tabListPage2.TabIndex = 1;
      this.tabListPage2.Text = "More Options";
      // 
      // fakeOptionPage21
      // 
      this.fakeOptionPage21.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage21.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage21.Name = "fakeOptionPage21";
      this.fakeOptionPage21.Size = new System.Drawing.Size(49, 222);
      this.fakeOptionPage21.TabIndex = 0;
      // 
      // tabListPage3
      // 
      this.tabListPage3.Controls.Add(this.fakeOptionPage31);
      this.tabListPage3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage3.Name = "tabListPage3";
      this.tabListPage3.Size = new System.Drawing.Size(49, 222);
      this.tabListPage3.TabIndex = 2;
      this.tabListPage3.Text = "Advanced Options";
      // 
      // fakeOptionPage31
      // 
      this.fakeOptionPage31.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage31.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage31.Name = "fakeOptionPage31";
      this.fakeOptionPage31.Size = new System.Drawing.Size(49, 222);
      this.fakeOptionPage31.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(759, 24);
      this.menuStrip1.TabIndex = 2;
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
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 496);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(759, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // GeneralDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 518);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "GeneralDemonstrationForm";
      this.Text = "Cyotek TabList Control Demonstration";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.viewsTabList.ResumeLayout(false);
      this.controlTabListPage.ResumeLayout(false);
      this.pageTabListPage.ResumeLayout(false);
      this.miscTabListPage.ResumeLayout(false);
      this.tabList.ResumeLayout(false);
      this.tabListPage1.ResumeLayout(false);
      this.tabListPage2.ResumeLayout(false);
      this.tabListPage3.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private TabList viewsTabList;
    private TabListPage controlTabListPage;
    private System.Windows.Forms.PropertyGrid controlPropertyGrid;
    private TabListPage pageTabListPage;
    private System.Windows.Forms.PropertyGrid selectionPropertyGrid;
    private TabListPage miscTabListPage;
    private System.Windows.Forms.Button removePageButton;
    private System.Windows.Forms.Button addPageButton;
    private System.Windows.Forms.Button firstButton;
    private System.Windows.Forms.Button lastButton;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button previousButton;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private TabList tabList;
    private TabListPage tabListPage1;
    private FakeOptionPage1 fakeOptionPage11;
    private TabListPage tabListPage2;
    private FakeOptionPage2 fakeOptionPage21;
    private TabListPage tabListPage3;
    private FakeOptionPage3 fakeOptionPage31;



  }
}

