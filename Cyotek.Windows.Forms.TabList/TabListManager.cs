using System;

// Code mostly adapted from ToolStripManager

namespace Cyotek.Windows.Forms
{
  public static class TabListManager
  {
    #region Private Fields

    private const int _staticEventCount = 1;

    private const int _staticEventDefaultRendererChanged = 0;

    private static ITabListRenderer _defaultRenderer;

    private static readonly object _internalSyncObject = new object();

    [ThreadStatic]
    private static Delegate[] _staticEventHandlers;

    #endregion Private Fields

    #region Public Events

    /// <summary>Occurs when the value of the <see cref="P:System.Windows.Forms.ToolStripManager.Renderer" /> property changes.</summary>
    public static event EventHandler RendererChanged
    {
      add => TabListManager.AddEventHandler(_staticEventDefaultRendererChanged, value);
      remove => TabListManager.RemoveEventHandler(_staticEventDefaultRendererChanged, value);
    }

    #endregion Public Events

    #region Public Properties

    public static ITabListRenderer Renderer
    {
      get
      {
        return TabListManager._defaultRenderer;
      }
      set
      {
        if (TabListManager._defaultRenderer != value)
        {
          EventHandler eventHandler;

          TabListManager._defaultRenderer = value;

          eventHandler = (EventHandler)TabListManager.GetEventHandler(_staticEventDefaultRendererChanged);

          eventHandler?.Invoke(null, EventArgs.Empty);
        }
      }
    }

    #endregion Public Properties

    #region Private Methods

    private static void AddEventHandler(int key, Delegate value)
    {
      lock (TabListManager._internalSyncObject)
      {
        if (TabListManager._staticEventHandlers == null)
        {
          TabListManager._staticEventHandlers = new Delegate[_staticEventCount];
        }

        TabListManager._staticEventHandlers[key] = Delegate.Combine(TabListManager._staticEventHandlers[key], value);
      }
    }

    private static Delegate GetEventHandler(int key)
    {
      Delegate result;

      lock (TabListManager._internalSyncObject)
      {
        if (TabListManager._staticEventHandlers == null)
        {
          result = null;
        }
        else
        {
          result = TabListManager._staticEventHandlers[key];
        }
      }

      return result;
    }

    private static void RemoveEventHandler(int key, Delegate value)
    {
      lock (TabListManager._internalSyncObject)
      {
        if (TabListManager._staticEventHandlers != null)
        {
          TabListManager._staticEventHandlers[key] = Delegate.Remove(TabListManager._staticEventHandlers[key], value);
        }
      }
    }

    #endregion Private Methods
  }
}
