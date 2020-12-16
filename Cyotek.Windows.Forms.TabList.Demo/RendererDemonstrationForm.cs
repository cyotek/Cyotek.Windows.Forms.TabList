using System;
using System.Reflection;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek TabList
  // Copyright (c) 2012-2020 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class RendererDemonstrationForm : BaseForm
  {
    #region Public Constructors

    public RendererDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      Assembly[] assemblies;

      base.OnLoad(e);

      assemblies = AppDomain.CurrentDomain.GetAssemblies();

      // use reflection to find all types inheriting from ITabListPageRenderer that we can use
      for (int i = 0; i < assemblies.Length; i++)
      {
        Type[] types;

        types = assemblies[i].GetTypes();

        for (int j = 0; j < types.Length; j++)
        {
          Type type;

          type = types[j];

          if (this.CanUseType(type))
          {
            string text;
            int textWidth;

            text = type.Name;

            renderStyleToolStripComboBox.Items.Add(new TypeInfo
            {
              Name = text,
              FullName = type.AssemblyQualifiedName
            });

            // make sure the control is wide enough
            textWidth = TextRenderer.MeasureText(text, renderStyleToolStripComboBox.Font).Width + SystemInformation.VerticalScrollBarWidth + 6;
            if (textWidth > renderStyleToolStripComboBox.Width)
            {
              renderStyleToolStripComboBox.Width = textWidth;
            }
          }
        }
      }

      if (renderStyleToolStripComboBox.Items.Count != 0)
      {
        renderStyleToolStripComboBox.SelectedIndex = 0;
      }
    }

    #endregion Protected Methods

    #region Private Methods

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private bool CanUseType(Type type)
    {
      return type.IsClass
        && !type.IsAbstract
        && typeof(ITabListRenderer).IsAssignableFrom(type)
        && !type.IsObsolete();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void renderStyleToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ITabListRenderer renderer;
      TypeInfo info;

      info = (TypeInfo)renderStyleToolStripComboBox.SelectedItem;

      // create an instance of the rendered based on its full type name
      // as the renderers are likely to be in different assemblies, you must
      // specify a full name - e.g. namespace.name,assemblyname
      renderer = (ITabListRenderer)Activator.CreateInstance(Type.GetType(info.FullName));

      tabList.Renderer = renderer;
    }

    #endregion Private Methods
  }
}
