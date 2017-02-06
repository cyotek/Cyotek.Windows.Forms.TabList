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
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1 = new Cyotek.Windows.Forms.GroupBox();
      this.firstButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.lastButton = new System.Windows.Forms.Button();
      this.previousButton = new System.Windows.Forms.Button();
      this.tabPagesGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.addPageButton = new System.Windows.Forms.Button();
      this.removePageButton = new System.Windows.Forms.Button();
      this.pageGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.pagePropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.controlPropertiesGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.controlPropertyGrid = new System.Windows.Forms.PropertyGrid();
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
      this.tableLayoutPanel.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabPagesGroupBox.SuspendLayout();
      this.pageGroupBox.SuspendLayout();
      this.controlPropertiesGroupBox.SuspendLayout();
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
      this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.tabList);
      this.splitContainer.Size = new System.Drawing.Size(784, 515);
      this.splitContainer.SplitterDistance = 300;
      this.splitContainer.TabIndex = 1;
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 1;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.tableLayoutPanel.Controls.Add(this.panel1, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.pageGroupBox, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.controlPropertiesGroupBox, 0, 0);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 3;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(300, 515);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Controls.Add(this.tabPagesGroupBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 345);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(294, 167);
      this.panel1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.firstButton);
      this.groupBox1.Controls.Add(this.nextButton);
      this.groupBox1.Controls.Add(this.lastButton);
      this.groupBox1.Controls.Add(this.previousButton);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 57);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(294, 88);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "SelectedPage";
      // 
      // firstButton
      // 
      this.firstButton.Location = new System.Drawing.Point(10, 23);
      this.firstButton.Name = "firstButton";
      this.firstButton.Size = new System.Drawing.Size(75, 23);
      this.firstButton.TabIndex = 0;
      this.firstButton.Text = "First";
      this.firstButton.UseVisualStyleBackColor = true;
      this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(9, 52);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(75, 23);
      this.nextButton.TabIndex = 2;
      this.nextButton.Text = "Next";
      this.nextButton.UseVisualStyleBackColor = true;
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // lastButton
      // 
      this.lastButton.Location = new System.Drawing.Point(91, 23);
      this.lastButton.Name = "lastButton";
      this.lastButton.Size = new System.Drawing.Size(75, 23);
      this.lastButton.TabIndex = 1;
      this.lastButton.Text = "Last";
      this.lastButton.UseVisualStyleBackColor = true;
      this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
      // 
      // previousButton
      // 
      this.previousButton.Location = new System.Drawing.Point(90, 52);
      this.previousButton.Name = "previousButton";
      this.previousButton.Size = new System.Drawing.Size(75, 23);
      this.previousButton.TabIndex = 3;
      this.previousButton.Text = "Previous";
      this.previousButton.UseVisualStyleBackColor = true;
      this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
      // 
      // tabPagesGroupBox
      // 
      this.tabPagesGroupBox.Controls.Add(this.addPageButton);
      this.tabPagesGroupBox.Controls.Add(this.removePageButton);
      this.tabPagesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.tabPagesGroupBox.Location = new System.Drawing.Point(0, 0);
      this.tabPagesGroupBox.Name = "tabPagesGroupBox";
      this.tabPagesGroupBox.Size = new System.Drawing.Size(294, 57);
      this.tabPagesGroupBox.TabIndex = 0;
      this.tabPagesGroupBox.TabStop = false;
      this.tabPagesGroupBox.Text = "TabPages Collection";
      // 
      // addPageButton
      // 
      this.addPageButton.Location = new System.Drawing.Point(10, 23);
      this.addPageButton.Name = "addPageButton";
      this.addPageButton.Size = new System.Drawing.Size(75, 23);
      this.addPageButton.TabIndex = 0;
      this.addPageButton.Text = "&Add";
      this.addPageButton.UseVisualStyleBackColor = true;
      this.addPageButton.Click += new System.EventHandler(this.addPageButton_Click);
      // 
      // removePageButton
      // 
      this.removePageButton.Location = new System.Drawing.Point(91, 23);
      this.removePageButton.Name = "removePageButton";
      this.removePageButton.Size = new System.Drawing.Size(75, 23);
      this.removePageButton.TabIndex = 1;
      this.removePageButton.Text = "&Remove";
      this.removePageButton.UseVisualStyleBackColor = true;
      this.removePageButton.Click += new System.EventHandler(this.removePageButton_Click);
      // 
      // pageGroupBox
      // 
      this.pageGroupBox.Controls.Add(this.pagePropertyGrid);
      this.pageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pageGroupBox.Location = new System.Drawing.Point(3, 174);
      this.pageGroupBox.Name = "pageGroupBox";
      this.pageGroupBox.Size = new System.Drawing.Size(294, 165);
      this.pageGroupBox.TabIndex = 1;
      this.pageGroupBox.TabStop = false;
      this.pageGroupBox.Text = "TabListPage Properties";
      // 
      // pagePropertyGrid
      // 
      this.pagePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pagePropertyGrid.HelpVisible = false;
      this.pagePropertyGrid.Location = new System.Drawing.Point(3, 17);
      this.pagePropertyGrid.Name = "pagePropertyGrid";
      this.pagePropertyGrid.Size = new System.Drawing.Size(288, 145);
      this.pagePropertyGrid.TabIndex = 0;
      this.pagePropertyGrid.ToolbarVisible = false;
      // 
      // controlPropertiesGroupBox
      // 
      this.controlPropertiesGroupBox.Controls.Add(this.controlPropertyGrid);
      this.controlPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPropertiesGroupBox.Location = new System.Drawing.Point(3, 3);
      this.controlPropertiesGroupBox.Name = "controlPropertiesGroupBox";
      this.controlPropertiesGroupBox.Size = new System.Drawing.Size(294, 165);
      this.controlPropertiesGroupBox.TabIndex = 0;
      this.controlPropertiesGroupBox.TabStop = false;
      this.controlPropertiesGroupBox.Text = "TabList Properties";
      // 
      // controlPropertyGrid
      // 
      this.controlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPropertyGrid.HelpVisible = false;
      this.controlPropertyGrid.Location = new System.Drawing.Point(3, 17);
      this.controlPropertyGrid.Name = "controlPropertyGrid";
      this.controlPropertyGrid.SelectedObject = this.tabList;
      this.controlPropertyGrid.Size = new System.Drawing.Size(288, 145);
      this.controlPropertyGrid.TabIndex = 0;
      this.controlPropertyGrid.ToolbarVisible = false;
      // 
      // tabList
      // 
      this.tabList.Controls.Add(this.tabListPage1);
      this.tabList.Controls.Add(this.tabListPage2);
      this.tabList.Controls.Add(this.tabListPage3);
      this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabList.Location = new System.Drawing.Point(0, 0);
      this.tabList.Name = "tabList";
      this.tabList.Size = new System.Drawing.Size(480, 515);
      this.tabList.TabIndex = 0;
      this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
      // 
      // tabListPage1
      // 
      this.tabListPage1.Controls.Add(this.fakeOptionPage11);
      this.tabListPage1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage1.Name = "tabListPage1";
      this.tabListPage1.Size = new System.Drawing.Size(322, 507);
      this.tabListPage1.TabIndex = 0;
      this.tabListPage1.Text = "Options";
      // 
      // fakeOptionPage11
      // 
      this.fakeOptionPage11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage11.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage11.Name = "fakeOptionPage11";
      this.fakeOptionPage11.Size = new System.Drawing.Size(322, 507);
      this.fakeOptionPage11.TabIndex = 0;
      // 
      // tabListPage2
      // 
      this.tabListPage2.Controls.Add(this.fakeOptionPage21);
      this.tabListPage2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage2.Name = "tabListPage2";
      this.tabListPage2.Size = new System.Drawing.Size(322, 507);
      this.tabListPage2.TabIndex = 1;
      this.tabListPage2.Text = "More Options";
      // 
      // fakeOptionPage21
      // 
      this.fakeOptionPage21.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage21.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage21.Name = "fakeOptionPage21";
      this.fakeOptionPage21.Size = new System.Drawing.Size(322, 507);
      this.fakeOptionPage21.TabIndex = 0;
      // 
      // tabListPage3
      // 
      this.tabListPage3.Controls.Add(this.fakeOptionPage31);
      this.tabListPage3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListPage3.Name = "tabListPage3";
      this.tabListPage3.Size = new System.Drawing.Size(322, 507);
      this.tabListPage3.TabIndex = 2;
      this.tabListPage3.Text = "Advanced Options";
      // 
      // fakeOptionPage31
      // 
      this.fakeOptionPage31.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fakeOptionPage31.Location = new System.Drawing.Point(0, 0);
      this.fakeOptionPage31.Name = "fakeOptionPage31";
      this.fakeOptionPage31.Size = new System.Drawing.Size(322, 507);
      this.fakeOptionPage31.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(784, 24);
      this.menuStrip1.TabIndex = 0;
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
      this.statusStrip1.Location = new System.Drawing.Point(0, 539);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(784, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // GeneralDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "GeneralDemonstrationForm";
      this.Text = "General Demonstration";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.tableLayoutPanel.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.tabPagesGroupBox.ResumeLayout(false);
      this.pageGroupBox.ResumeLayout(false);
      this.controlPropertiesGroupBox.ResumeLayout(false);
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
    private System.Windows.Forms.PropertyGrid controlPropertyGrid;
    private System.Windows.Forms.PropertyGrid pagePropertyGrid;
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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Panel panel1;
    private GroupBox pageGroupBox;
    private GroupBox controlPropertiesGroupBox;
    private GroupBox groupBox1;
    private GroupBox tabPagesGroupBox;
  }
}

