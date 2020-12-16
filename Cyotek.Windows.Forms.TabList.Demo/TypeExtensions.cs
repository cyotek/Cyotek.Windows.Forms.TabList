using System;

namespace Cyotek.Windows.Forms.Demo
{
  internal static class TypeExtensions
  {
    #region Public Methods

    public static bool IsObsolete(this Type type)
    {
      object[] attributes;
      bool result;

      attributes = type.GetCustomAttributes(false);
      result = false;

      for (int i = 0; i < attributes.Length; i++)
      {
        if (attributes[i] is ObsoleteAttribute)
        {
          result = true;
          break;
        }
      }

      return result;
    }

    #endregion Public Methods
  }
}
