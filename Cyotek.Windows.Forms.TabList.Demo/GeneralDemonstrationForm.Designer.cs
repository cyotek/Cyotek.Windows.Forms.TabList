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
      this.tabList = new Cyotek.Windows.Forms.TabList();
      this.applicationTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.buildTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.builtEventsTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.debugTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.resourcesTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.servicesTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.securityTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.settingsTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.referencePathsTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.signingTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.publishTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.codeAnalysisTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pageTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.selectionPropertyGrid = new System.Windows.Forms.PropertyGrid();
      this.miscTabListPage = new Cyotek.Windows.Forms.TabListPage();
      this.lastButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.previousButton = new System.Windows.Forms.Button();
      this.firstButton = new System.Windows.Forms.Button();
      this.removePageButton = new System.Windows.Forms.Button();
      this.addPageButton = new System.Windows.Forms.Button();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.viewsTabList.SuspendLayout();
      this.controlTabListPage.SuspendLayout();
      this.tabList.SuspendLayout();
      this.applicationTabListPage.SuspendLayout();
      this.buildTabListPage.SuspendLayout();
      this.builtEventsTabListPage.SuspendLayout();
      this.debugTabListPage.SuspendLayout();
      this.resourcesTabListPage.SuspendLayout();
      this.servicesTabListPage.SuspendLayout();
      this.codeAnalysisTabListPage.SuspendLayout();
      this.pageTabListPage.SuspendLayout();
      this.miscTabListPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer.Location = new System.Drawing.Point(0, 0);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.viewsTabList);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.tabList);
      this.splitContainer.Size = new System.Drawing.Size(759, 518);
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
      this.viewsTabList.Size = new System.Drawing.Size(400, 518);
      this.viewsTabList.TabIndex = 0;
      // 
      // controlTabListPage
      // 
      this.controlTabListPage.Controls.Add(this.controlPropertyGrid);
      this.controlTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlTabListPage.Name = "controlTabListPage";
      this.controlTabListPage.Padding = new System.Windows.Forms.Padding(3);
      this.controlTabListPage.Size = new System.Drawing.Size(242, 510);
      this.controlTabListPage.TabIndex = 0;
      this.controlTabListPage.Text = "Control";
      // 
      // controlPropertyGrid
      // 
      this.controlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPropertyGrid.Location = new System.Drawing.Point(3, 3);
      this.controlPropertyGrid.Name = "controlPropertyGrid";
      this.controlPropertyGrid.SelectedObject = this.tabList;
      this.controlPropertyGrid.Size = new System.Drawing.Size(236, 504);
      this.controlPropertyGrid.TabIndex = 1;
      // 
      // tabList
      // 
      this.tabList.Controls.Add(this.applicationTabListPage);
      this.tabList.Controls.Add(this.buildTabListPage);
      this.tabList.Controls.Add(this.builtEventsTabListPage);
      this.tabList.Controls.Add(this.debugTabListPage);
      this.tabList.Controls.Add(this.resourcesTabListPage);
      this.tabList.Controls.Add(this.servicesTabListPage);
      this.tabList.Controls.Add(this.securityTabListPage);
      this.tabList.Controls.Add(this.settingsTabListPage);
      this.tabList.Controls.Add(this.referencePathsTabListPage);
      this.tabList.Controls.Add(this.signingTabListPage);
      this.tabList.Controls.Add(this.publishTabListPage);
      this.tabList.Controls.Add(this.codeAnalysisTabListPage);
      this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabList.Location = new System.Drawing.Point(0, 0);
      this.tabList.Name = "tabList";
      this.tabList.Size = new System.Drawing.Size(355, 518);
      this.tabList.TabIndex = 0;
      this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
      // 
      // applicationTabListPage
      // 
      this.applicationTabListPage.Controls.Add(this.textBox2);
      this.applicationTabListPage.Controls.Add(this.label2);
      this.applicationTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.applicationTabListPage.Name = "applicationTabListPage";
      this.applicationTabListPage.Size = new System.Drawing.Size(197, 510);
      this.applicationTabListPage.TabIndex = 0;
      this.applicationTabListPage.Text = "Application";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(6, 21);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 21);
      this.textBox2.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "label2";
      // 
      // buildTabListPage
      // 
      this.buildTabListPage.Controls.Add(this.checkBox1);
      this.buildTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buildTabListPage.Name = "buildTabListPage";
      this.buildTabListPage.Size = new System.Drawing.Size(42, 192);
      this.buildTabListPage.TabIndex = 1;
      this.buildTabListPage.Text = "Build";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(3, 8);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(77, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // builtEventsTabListPage
      // 
      this.builtEventsTabListPage.Controls.Add(this.checkedListBox1);
      this.builtEventsTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.builtEventsTabListPage.Name = "builtEventsTabListPage";
      this.builtEventsTabListPage.Size = new System.Drawing.Size(42, 192);
      this.builtEventsTabListPage.TabIndex = 2;
      this.builtEventsTabListPage.Text = "Build Events";
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(3, 8);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
      this.checkedListBox1.TabIndex = 0;
      // 
      // debugTabListPage
      // 
      this.debugTabListPage.Controls.Add(this.comboBox1);
      this.debugTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.debugTabListPage.Name = "debugTabListPage";
      this.debugTabListPage.Size = new System.Drawing.Size(42, 192);
      this.debugTabListPage.TabIndex = 3;
      this.debugTabListPage.Text = "Debug";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(3, 8);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 0;
      // 
      // resourcesTabListPage
      // 
      this.resourcesTabListPage.Controls.Add(this.dateTimePicker1);
      this.resourcesTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.resourcesTabListPage.Name = "resourcesTabListPage";
      this.resourcesTabListPage.Size = new System.Drawing.Size(42, 192);
      this.resourcesTabListPage.TabIndex = 4;
      this.resourcesTabListPage.Text = "Resources";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(3, 8);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(168, 21);
      this.dateTimePicker1.TabIndex = 0;
      // 
      // servicesTabListPage
      // 
      this.servicesTabListPage.Controls.Add(this.linkLabel1);
      this.servicesTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.servicesTabListPage.Name = "servicesTabListPage";
      this.servicesTabListPage.Size = new System.Drawing.Size(42, 192);
      this.servicesTabListPage.TabIndex = 5;
      this.servicesTabListPage.Text = "Services";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(93, 141);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(53, 13);
      this.linkLabel1.TabIndex = 0;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "linkLabel1";
      // 
      // securityTabListPage
      // 
      this.securityTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.securityTabListPage.Name = "securityTabListPage";
      this.securityTabListPage.Size = new System.Drawing.Size(42, 192);
      this.securityTabListPage.TabIndex = 9;
      this.securityTabListPage.Text = "Security";
      // 
      // settingsTabListPage
      // 
      this.settingsTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.settingsTabListPage.Name = "settingsTabListPage";
      this.settingsTabListPage.Size = new System.Drawing.Size(42, 192);
      this.settingsTabListPage.TabIndex = 6;
      this.settingsTabListPage.Text = "Settings";
      // 
      // referencePathsTabListPage
      // 
      this.referencePathsTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.referencePathsTabListPage.Name = "referencePathsTabListPage";
      this.referencePathsTabListPage.Size = new System.Drawing.Size(42, 192);
      this.referencePathsTabListPage.TabIndex = 7;
      this.referencePathsTabListPage.Text = "Reference Paths";
      // 
      // signingTabListPage
      // 
      this.signingTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.signingTabListPage.Name = "signingTabListPage";
      this.signingTabListPage.Size = new System.Drawing.Size(42, 192);
      this.signingTabListPage.TabIndex = 8;
      this.signingTabListPage.Text = "Signing";
      // 
      // publishTabListPage
      // 
      this.publishTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.publishTabListPage.Name = "publishTabListPage";
      this.publishTabListPage.Size = new System.Drawing.Size(42, 192);
      this.publishTabListPage.TabIndex = 10;
      this.publishTabListPage.Text = "Publish";
      // 
      // codeAnalysisTabListPage
      // 
      this.codeAnalysisTabListPage.Controls.Add(this.textBox1);
      this.codeAnalysisTabListPage.Controls.Add(this.label1);
      this.codeAnalysisTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.codeAnalysisTabListPage.Name = "codeAnalysisTabListPage";
      this.codeAnalysisTabListPage.Size = new System.Drawing.Size(42, 192);
      this.codeAnalysisTabListPage.TabIndex = 11;
      this.codeAnalysisTabListPage.Text = "Code Analysis";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 21);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(159, 21);
      this.textBox1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // pageTabListPage
      // 
      this.pageTabListPage.Controls.Add(this.selectionPropertyGrid);
      this.pageTabListPage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pageTabListPage.Name = "pageTabListPage";
      this.pageTabListPage.Padding = new System.Windows.Forms.Padding(3);
      this.pageTabListPage.Size = new System.Drawing.Size(42, 192);
      this.pageTabListPage.TabIndex = 1;
      this.pageTabListPage.Text = "Selected TabListPage";
      // 
      // selectionPropertyGrid
      // 
      this.selectionPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.selectionPropertyGrid.Location = new System.Drawing.Point(3, 3);
      this.selectionPropertyGrid.Name = "selectionPropertyGrid";
      this.selectionPropertyGrid.Size = new System.Drawing.Size(36, 186);
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
      this.miscTabListPage.Size = new System.Drawing.Size(42, 192);
      this.miscTabListPage.TabIndex = 2;
      this.miscTabListPage.Text = "Misc";
      // 
      // lastButton
      // 
      this.lastButton.Location = new System.Drawing.Point(8, 162);
      this.lastButton.Name = "lastButton";
      this.lastButton.Size = new System.Drawing.Size(132, 23);
      this.lastButton.TabIndex = 5;
      this.lastButton.Text = "Last";
      this.lastButton.UseVisualStyleBackColor = true;
      this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(8, 133);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(132, 23);
      this.nextButton.TabIndex = 4;
      this.nextButton.Text = "Next";
      this.nextButton.UseVisualStyleBackColor = true;
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // previousButton
      // 
      this.previousButton.Location = new System.Drawing.Point(8, 104);
      this.previousButton.Name = "previousButton";
      this.previousButton.Size = new System.Drawing.Size(132, 23);
      this.previousButton.TabIndex = 3;
      this.previousButton.Text = "Previous";
      this.previousButton.UseVisualStyleBackColor = true;
      this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
      // 
      // firstButton
      // 
      this.firstButton.Location = new System.Drawing.Point(8, 75);
      this.firstButton.Name = "firstButton";
      this.firstButton.Size = new System.Drawing.Size(132, 23);
      this.firstButton.TabIndex = 2;
      this.firstButton.Text = "First";
      this.firstButton.UseVisualStyleBackColor = true;
      this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
      // 
      // removePageButton
      // 
      this.removePageButton.Location = new System.Drawing.Point(8, 35);
      this.removePageButton.Name = "removePageButton";
      this.removePageButton.Size = new System.Drawing.Size(132, 23);
      this.removePageButton.TabIndex = 1;
      this.removePageButton.Text = "Remove Selected Page";
      this.removePageButton.UseVisualStyleBackColor = true;
      this.removePageButton.Click += new System.EventHandler(this.removePageButton_Click);
      // 
      // addPageButton
      // 
      this.addPageButton.Location = new System.Drawing.Point(8, 6);
      this.addPageButton.Name = "addPageButton";
      this.addPageButton.Size = new System.Drawing.Size(132, 23);
      this.addPageButton.TabIndex = 0;
      this.addPageButton.Text = "Add Page";
      this.addPageButton.UseVisualStyleBackColor = true;
      this.addPageButton.Click += new System.EventHandler(this.addPageButton_Click);
      // 
      // GeneralDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 518);
      this.Controls.Add(this.splitContainer);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "GeneralDemonstrationForm";
      this.Text = "Cyotek TabList Control Demonstration";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.viewsTabList.ResumeLayout(false);
      this.controlTabListPage.ResumeLayout(false);
      this.tabList.ResumeLayout(false);
      this.applicationTabListPage.ResumeLayout(false);
      this.applicationTabListPage.PerformLayout();
      this.buildTabListPage.ResumeLayout(false);
      this.buildTabListPage.PerformLayout();
      this.builtEventsTabListPage.ResumeLayout(false);
      this.debugTabListPage.ResumeLayout(false);
      this.resourcesTabListPage.ResumeLayout(false);
      this.servicesTabListPage.ResumeLayout(false);
      this.servicesTabListPage.PerformLayout();
      this.codeAnalysisTabListPage.ResumeLayout(false);
      this.codeAnalysisTabListPage.PerformLayout();
      this.pageTabListPage.ResumeLayout(false);
      this.miscTabListPage.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private TabList tabList;
    private System.Windows.Forms.SplitContainer splitContainer;
    private TabList viewsTabList;
    private TabListPage controlTabListPage;
    private System.Windows.Forms.PropertyGrid controlPropertyGrid;
    private TabListPage pageTabListPage;
    private System.Windows.Forms.PropertyGrid selectionPropertyGrid;
    private TabListPage miscTabListPage;
    private System.Windows.Forms.Button removePageButton;
    private System.Windows.Forms.Button addPageButton;
    private TabListPage applicationTabListPage;
    private TabListPage buildTabListPage;
    private TabListPage builtEventsTabListPage;
    private TabListPage debugTabListPage;
    private TabListPage resourcesTabListPage;
    private TabListPage servicesTabListPage;
    private TabListPage settingsTabListPage;
    private TabListPage referencePathsTabListPage;
    private TabListPage signingTabListPage;
    private TabListPage securityTabListPage;
    private TabListPage publishTabListPage;
    private TabListPage codeAnalysisTabListPage;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button firstButton;
    private System.Windows.Forms.Button lastButton;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button previousButton;



  }
}

