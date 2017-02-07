using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2017 Cyotek Ltd.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal class EventsListBox : ListBox
  {
    #region Constructors

    public EventsListBox()
    {
      base.IntegralHeight = false;
      base.HorizontalScrollbar = true;
    }

    #endregion

    #region Properties

    [DefaultValue(true)]
    public new bool HorizontalScrollbar
    {
      get { return base.HorizontalScrollbar; }
      set { base.HorizontalScrollbar = value; }
    }

    [DefaultValue(false)]
    public new bool IntegralHeight
    {
      get { return base.IntegralHeight; }
      set { base.IntegralHeight = value; }
    }

    #endregion

    #region Methods

    public void AddEvent(string eventName)
    {
      this.AddEvent(eventName, null);
    }

    public void AddEvent(string eventName, IDictionary<string, object> values)
    {
      this.AddEvent(null, eventName, values);
    }

    public void AddEvent(Control sender, string eventName)
    {
      this.AddEvent(sender, eventName, EventArgs.Empty);
    }

    public void AddEvent(Control sender, string eventName, EventArgs args)
    {
      this.AddEvent(sender, eventName, this.GetArgumentParameters(args));
    }

    public void AddEvent(Control sender, string eventName, IDictionary<string, object> values)
    {
      StringBuilder eventData;

      eventData = new StringBuilder();

      eventData.Append(DateTime.Now.ToLongTimeString());
      eventData.Append('\t');
      if (sender != null)
      {
        eventData.Append(sender.Name);
        eventData.Append('.');
      }
      eventData.Append(eventName);
      eventData.Append('(');

      if (values != null)
      {
        int index;

        index = 0;

        foreach (KeyValuePair<string, object> value in values)
        {
          eventData.Append(value.Key);
          eventData.Append(" = ");
          eventData.Append(value.Value);

          if (index < values.Count - 1)
          {
            eventData.Append(", ");
          }

          index++;
        }
      }
      eventData.Append(')');

      this.Items.Add(eventData.ToString());
      this.TopIndex = this.Items.Count - this.ClientSize.Height / this.ItemHeight;
    }

    public IDictionary<string, object> GetArgumentParameters(EventArgs args)
    {
      IDictionary<string, object> values;

      values = new Dictionary<string, object>();

      foreach (PropertyInfo pi in args.GetType().GetProperties())
      {
        object value;

        if (pi.GetIndexParameters().Length == 0)
        {
          try
          {
            value = pi.GetValue(args, null);
          }
          catch
          {
            // ignore errors
            value = null;
          }
        }
        else
        {
          // Not going to try and handler indexers
          value = null;
        }

        values.Add(pi.Name, value);
      }

      return values;
    }

    #endregion
  }
}
