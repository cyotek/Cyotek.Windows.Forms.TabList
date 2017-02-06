using System;
using System.Collections;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2013 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  partial class TabList
  {
    #region Nested type: TabListPageCollection

    public class TabListPageCollection : IList
    {
      #region Constructors

      public TabListPageCollection(TabList owner)
      {
        if (owner == null)
        {
          throw new ArgumentNullException(nameof(owner));
        }

        this.Owner = owner;
      }

      #endregion

      #region Properties

      public virtual TabListPage this[int index]
      {
        get { return this.Owner.GetTabListPages()[index]; }
        set { this.Owner.SelectedIndex = index; }
      }

      public TabListPage this[string name]
      {
        get
        {
          TabListPage[] pages;
          TabListPage result;

          pages = this.Owner.GetTabListPages();
          result = null;

          for (int i = 0; i < pages.Length; i++)
          {
            if (pages[i].Name == name)
            {
              result = pages[i];
              break;
            }
          }

          return result;
        }
      }

      protected TabList Owner { get; set; }

      #endregion

      #region Methods

      public TabListPage Add(string text)
      {
        TabListPage page;

        page = new TabListPage
               {
                 Text = text
               };

        this.Add(page);

        return page;
      }

      public void Add(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        this.Owner.Controls.Add(value);
      }

      public bool Contains(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        return this.IndexOf(value) != -1;
      }

      public bool ContainsKey(string key)
      {
        return this.IndexOfKey(key) != -1;
      }

      public int IndexOf(TabListPage value)
      {
        int index;

        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        index = -1;
        for (int i = 0; i < this.Count; i++)
        {
          if (this[i] == value)
          {
            index = i;
            break;
          }
        }

        return index;
      }

      public virtual int IndexOfKey(string key)
      {
        int result;

        result = -1;

        if (!string.IsNullOrEmpty(key))
        {
          for (int i = 0; i < this.Count; i++)
          {
            if (this[i].Name == key)
            {
              result = i;
              break;
            }
          }
        }

        return result;
      }

      public void Insert(int index, TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        this.Owner.InsertPage(index, value);
        this.Owner.Controls.Add(value);
        this.Owner.Controls.SetChildIndex(value, index);
      }

      public void Remove(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        this.Owner.Controls.Remove(value);
      }

      #endregion

      #region IList Interface

      object IList.this[int index]
      {
        get { return this[index]; }
        set
        {
          if (!(value is TabListPage))
          {
            throw new ArgumentException("Only controls of type TabListPage can be added to this collection.", nameof(value));
          }

          this[index] = (TabListPage)value;
        }
      }

      public void Clear()
      {
        this.Owner.ClearAllPages();
      }

      public void CopyTo(Array array, int index)
      {
        if (this.Count != 0)
        {
          Array.Copy(this.Owner.GetTabListPages(), 0, array, index, this.Count);
        }
      }

      public IEnumerator GetEnumerator()
      {
        TabListPage[] tabPages;

        tabPages = this.Owner.GetTabListPages();
        if (tabPages == null)
        {
          tabPages = new TabListPage[0];
        }

        return tabPages.GetEnumerator();
      }

      public void RemoveAt(int index)
      {
        this.Owner.Controls.RemoveAt(index);
      }

      int IList.Add(object value)
      {
        TabListPage page;

        if (!(value is TabListPage))
        {
          throw new ArgumentException("value");
        }

        page = (TabListPage)value;

        this.Add(page);

        return this.IndexOf(page);
      }

      bool IList.Contains(object value)
      {
        return value is TabListPage && this.Contains((TabListPage)value);
      }

      int IList.IndexOf(object value)
      {
        int index;

        if (value is TabListPage)
        {
          index = this.IndexOf((TabListPage)value);
        }
        else
        {
          index = -1;
        }

        return index;
      }

      void IList.Insert(int index, object value)
      {
        if (!(value is TabListPage))
        {
          throw new ArgumentException("value");
        }

        this.Insert(index, (TabListPage)value);
      }

      void IList.Remove(object value)
      {
        if (value is TabListPage)
        {
          this.Remove((TabListPage)value);
        }
      }

      public int Count
      {
        get { return this.Owner.TabListPageCount; }
      }

      public bool IsFixedSize
      {
        get { return false; }
      }

      public bool IsReadOnly
      {
        get { return false; }
      }

      public bool IsSynchronized
      {
        get { return false; }
      }

      public object SyncRoot
      {
        get { return this; }
      }

      #endregion
    }

    #endregion
  }
}
