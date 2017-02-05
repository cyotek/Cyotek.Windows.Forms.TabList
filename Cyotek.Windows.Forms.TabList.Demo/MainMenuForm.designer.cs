namespace Cyotek.Windows.Forms.Demo
{
  partial class MainMenuForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
      this.generalDemoButton = new System.Windows.Forms.Button();
      this.themeDemoButton = new System.Windows.Forms.Button();
      this.demoGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.demoGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // generalDemoButton
      // 
      this.generalDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.generalDemoButton.Location = new System.Drawing.Point(6, 22);
      this.generalDemoButton.Name = "generalDemoButton";
      this.generalDemoButton.Size = new System.Drawing.Size(432, 27);
      this.generalDemoButton.TabIndex = 0;
      this.generalDemoButton.Text = "&General Demonstration";
      this.generalDemoButton.UseVisualStyleBackColor = true;
      this.generalDemoButton.Click += new System.EventHandler(this.generalDemoButton_Click);
      // 
      // themeDemoButton
      // 
      this.themeDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.themeDemoButton.Location = new System.Drawing.Point(6, 56);
      this.themeDemoButton.Name = "themeDemoButton";
      this.themeDemoButton.Size = new System.Drawing.Size(432, 27);
      this.themeDemoButton.TabIndex = 1;
      this.themeDemoButton.Text = "&Pixel Grid Demonstration";
      this.themeDemoButton.UseVisualStyleBackColor = true;
      this.themeDemoButton.Click += new System.EventHandler(this.themeDemoButton_Click);
      // 
      // demoGroupBox
      // 
      this.demoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.demoGroupBox.Controls.Add(this.generalDemoButton);
      this.demoGroupBox.Controls.Add(this.themeDemoButton);
      this.demoGroupBox.Location = new System.Drawing.Point(31, 65);
      this.demoGroupBox.Name = "demoGroupBox";
      this.demoGroupBox.Size = new System.Drawing.Size(444, 360);
      this.demoGroupBox.TabIndex = 0;
      this.demoGroupBox.TabStop = false;
      this.demoGroupBox.Text = "Available Demonstrations";
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 552);
      this.Controls.Add(this.demoGroupBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainMenuForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.Text = "Cyotek ImageBox Control for Windows Forms";
      this.Controls.SetChildIndex(this.demoGroupBox, 0);
      this.demoGroupBox.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button generalDemoButton;
    private System.Windows.Forms.Button themeDemoButton;
    private GroupBox demoGroupBox;



  }
}

