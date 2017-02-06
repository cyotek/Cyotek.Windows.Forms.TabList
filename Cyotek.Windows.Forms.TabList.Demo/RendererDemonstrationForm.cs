using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class RendererDemonstrationForm : BaseForm
  {
    #region Constructors

    public RendererDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      Type matchType;

      base.OnLoad(e);

      matchType = typeof(ITabListPageRenderer);

      // use reflection to find all types inheriting from ITabListPageRenderer that we can use
      foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        foreach (Type type in assembly.GetTypes().Where(t => matchType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract))
        {
          int textWidth;
          string text;

          text = type.Name;

          renderStyleToolStripComboBox.Items.Add(new TypeInfo
                                                 {
                                                   Name = text,
                                                   FullName = type.AssemblyQualifiedName
                                                 });

          // make sure the control is wide enough
          textWidth = TextRenderer.MeasureText(text, renderStyleToolStripComboBox.Font).Width + SystemInformation.VerticalScrollBarWidth + 6;
          if (textWidth > renderStyleToolStripComboBox.Width)
            renderStyleToolStripComboBox.Width = textWidth;
        }
      }

      if (renderStyleToolStripComboBox.Items.Count != 0)
        renderStyleToolStripComboBox.SelectedIndex = 0;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void renderStyleToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ITabListPageRenderer renderer;
      TypeInfo info;

      info = (TypeInfo)renderStyleToolStripComboBox.SelectedItem;

      // create an instance of the rendered based on its full type name
      // as the renderers are likely to be in different assemblies, you must
      // specify a full name - e.g. namespace.name,assemblyname
      renderer = (ITabListPageRenderer)Activator.CreateInstance(Type.GetType(info.FullName));

      tabList.Renderer = renderer;
    }

    #endregion
  }
}
