using System;
using System.Drawing;
using System.Runtime.InteropServices;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable InconsistentNaming

namespace Cyotek.Windows.Forms
{
  internal static class NativeMethods
  {
    #region Externals

    [DllImport(_user32DllName)]
    public static extern bool DrawFocusRect(IntPtr hDC, [In] ref RECT lprc);

    #endregion

    #region Constants

    public const int WM_CONTEXTMENU = 0x007B;

    private const string _user32DllName = "user32.dll";

    #endregion

    #region Static Methods

    public static void DrawFocusRectangle(Graphics g, Rectangle rectangle)
    {
      DrawFocusRectangle(g, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
    }

    public static void DrawFocusRectangle(Graphics g, int x, int y, int w, int h)
    {
      RECT rect;
      IntPtr hDC;

      rect = new RECT(x, y, x + w, y + h);

      hDC = g.GetHdc();
      try
      {
        DrawFocusRect(hDC, ref rect);
      }
      finally
      {
        g.ReleaseHdc(hDC);
      }
    }

    #endregion

    #region Nested type: RECT

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
      public int left;

      public int top;

      public int right;

      public int bottom;

      public RECT(int left, int top, int right, int bottom)
      {
        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
      }
    }

    #endregion
  }
}
