namespace Cyotek.Windows.Forms.Demo
{
  partial class DynamicLoadingDemonstrationForm
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
      this.tabList = new Cyotek.Windows.Forms.TabList();
      this.tabListPage1 = new Cyotek.Windows.Forms.TabListPage();
      this.tabListPage2 = new Cyotek.Windows.Forms.TabListPage();
      this.tabListPage3 = new Cyotek.Windows.Forms.TabListPage();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.eventsSplitContainer = new System.Windows.Forms.SplitContainer();
      this.eventsListBox = new Cyotek.Windows.Forms.Demo.EventsListBox();
      this.tabList.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.eventsSplitContainer.Panel1.SuspendLayout();
      this.eventsSplitContainer.Panel2.SuspendLayout();
      this.eventsSplitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabList
      // 
      this.tabList.Controls.Add(this.tabListPage1);
      this.tabList.Controls.Add(this.tabListPage2);
      this.tabList.Controls.Add(this.tabListPage3);
      this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabList.Location = new System.Drawing.Point(0, 0);
      this.tabList.Name = "tabList";
      this.tabList.Size = new System.Drawing.Size(784, 415);
      this.tabList.TabIndex = 0;
      this.tabList.Deselected += new System.EventHandler<Cyotek.Windows.Forms.TabListEventArgs>(this.tabList_Deselected);
      this.tabList.Deselecting += new System.EventHandler<Cyotek.Windows.Forms.TabListCancelEventArgs>(this.tabList_Deselecting);
      this.tabList.Selected += new System.EventHandler<Cyotek.Windows.Forms.TabListEventArgs>(this.tabList_Selected);
      this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
      this.tabList.Selecting += new System.EventHandler<Cyotek.Windows.Forms.TabListCancelEventArgs>(this.tabList_Selecting);
      // 
      // tabListPage1
      // 
      this.tabListPage1.Name = "tabListPage1";
      this.tabListPage1.Size = new System.Drawing.Size(626, 407);
      this.tabListPage1.Text = "Options";
      // 
      // tabListPage2
      // 
      this.tabListPage2.Name = "tabListPage2";
      this.tabListPage2.Size = new System.Drawing.Size(626, 407);
      this.tabListPage2.Text = "More Options";
      // 
      // tabListPage3
      // 
      this.tabListPage3.Name = "tabListPage3";
      this.tabListPage3.Size = new System.Drawing.Size(626, 407);
      this.tabListPage3.Text = "Advanced Options";
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
      // eventsSplitContainer
      // 
      this.eventsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.eventsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.eventsSplitContainer.Location = new System.Drawing.Point(0, 24);
      this.eventsSplitContainer.Name = "eventsSplitContainer";
      this.eventsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // eventsSplitContainer.Panel1
      // 
      this.eventsSplitContainer.Panel1.Controls.Add(this.tabList);
      // 
      // eventsSplitContainer.Panel2
      // 
      this.eventsSplitContainer.Panel2.Controls.Add(this.eventsListBox);
      this.eventsSplitContainer.Size = new System.Drawing.Size(784, 515);
      this.eventsSplitContainer.SplitterDistance = 415;
      this.eventsSplitContainer.TabIndex = 3;
      // 
      // eventsListBox
      // 
      this.eventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.eventsListBox.FormattingEnabled = true;
      this.eventsListBox.Location = new System.Drawing.Point(0, 0);
      this.eventsListBox.Name = "eventsListBox";
      this.eventsListBox.Size = new System.Drawing.Size(784, 96);
      this.eventsListBox.TabIndex = 0;
      // 
      // DynamicLoadingDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.eventsSplitContainer);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "DynamicLoadingDemonstrationForm";
      this.Text = "General Demonstration";
      this.tabList.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.eventsSplitContainer.Panel1.ResumeLayout(false);
      this.eventsSplitContainer.Panel2.ResumeLayout(false);
      this.eventsSplitContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private TabList tabList;
    private TabListPage tabListPage1;
    private TabListPage tabListPage2;
    private TabListPage tabListPage3;
    private System.Windows.Forms.SplitContainer eventsSplitContainer;
    private EventsListBox eventsListBox;
  }
}

