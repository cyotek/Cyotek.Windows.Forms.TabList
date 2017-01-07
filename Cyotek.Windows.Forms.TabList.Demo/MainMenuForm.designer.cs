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
      this.generalDemoButton = new System.Windows.Forms.Button();
      this.groupBox1 = new Cyotek.Windows.Forms.GroupBox();
      this.renderStylesDemoButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
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
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.renderStylesDemoButton);
      this.groupBox1.Controls.Add(this.generalDemoButton);
      this.groupBox1.Location = new System.Drawing.Point(31, 65);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(444, 332);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Available Demonstrations";
      // 
      // renderStylesDemoButton
      // 
      this.renderStylesDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.renderStylesDemoButton.Location = new System.Drawing.Point(6, 55);
      this.renderStylesDemoButton.Name = "renderStylesDemoButton";
      this.renderStylesDemoButton.Size = new System.Drawing.Size(432, 27);
      this.renderStylesDemoButton.TabIndex = 1;
      this.renderStylesDemoButton.Text = "&Render Styles Demonstration";
      this.renderStylesDemoButton.UseVisualStyleBackColor = true;
      this.renderStylesDemoButton.Click += new System.EventHandler(this.renderStylesDemoButton_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 495);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainMenuForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.Text = "Cyotek TabList Control for Windows Forms";
      this.Controls.SetChildIndex(this.groupBox1, 0);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button generalDemoButton;
    private GroupBox groupBox1;
    private System.Windows.Forms.Button renderStylesDemoButton;



  }
}

