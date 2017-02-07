using System;
using System.Collections;
using System.Collections.Generic;

namespace Cyotek.Windows.Forms
{
  // Cyotek TabList
  // Copyright (c) 2012-2017 Cyotek.
  // https://www.cyotek.com
  // https://www.cyotek.com/blog/tag/tablist

  // Licensed under the MIT License. See LICENSE.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  partial class TabList
  {
    #region Nested type: TabListPageCollection

    public sealed class TabListPageCollection : IList, IList<TabListPage>
    {
      #region Constants

      private readonly TabList _owner;

      #endregion

      #region Constructors

      internal TabListPageCollection(TabList owner)
      {
        if (owner == null)
        {
          throw new ArgumentNullException(nameof(owner));
        }

        _owner = owner;
      }

      #endregion

      #region Properties

      public TabListPage this[string name]
      {
        get
        {
          TabListPage[] pages;
          TabListPage result;

          pages = _owner.GetTabListPages();
          result = null;

          // ReSharper disable once ForCanBeConvertedToForeach
          for (int i = 0; i < pages.Length; i++)
          {
            TabListPage page;

            page = pages[i];

            if (page.Name == name)
            {
              result = page;
              break;
            }
          }

          return result;
        }
      }

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

      public bool ContainsKey(string key)
      {
        return this.IndexOfKey(key) != -1;
      }

      public int IndexOfKey(string key)
      {
        int result;

        result = -1;

        if (!string.IsNullOrEmpty(key))
        {
          TabListPage[] pages;

          pages = _owner.GetTabListPages();

          for (int i = 0; i < pages.Length; i++)
          {
            if (pages[i].Name == key)
            {
              result = i;
              break;
            }
          }
        }

        return result;
      }

      private void CopyTo(Array array, int index)
      {
        TabListPage[] pages;

        pages = _owner.GetTabListPages();

        if (pages.Length != 0)
        {
          Array.Copy(pages, 0, array, index, pages.Length);
        }
      }

      #endregion

      #region IList Interface

      object IList.this[int index]
      {
        get { return this[index]; }
        set
        {
          TabListPage page;

          page = value as TabListPage;

          if (page == null)
          {
            throw new ArgumentException("Only controls of type TabListPage can be added to this collection.", nameof(value));
          }

          this[index] = page;
        }
      }

      public void Clear()
      {
        _owner.ClearAllPages();
      }

      public void RemoveAt(int index)
      {
        _owner.Controls.RemoveAt(index);
      }

      int IList.Add(object value)
      {
        TabListPage page;

        page = value as TabListPage;

        if (page == null)
        {
          throw new ArgumentException("Value must be a TabListPage", nameof(value));
        }

        this.Add(page);

        return this.IndexOf(page);
      }

      bool IList.Contains(object value)
      {
        TabListPage page;

        page = value as TabListPage;

        return page != null && this.Contains(page);
      }

      void ICollection.CopyTo(Array array, int index)
      {
        this.CopyTo(array, index);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return this.GetEnumerator();
      }

      int IList.IndexOf(object value)
      {
        int index;
        TabListPage page;

        page = value as TabListPage;

        if (page != null)
        {
          index = this.IndexOf(page);
        }
        else
        {
          index = -1;
        }

        return index;
      }

      void IList.Insert(int index, object value)
      {
        TabListPage page;

        page = value as TabListPage;

        if (page == null)
        {
          throw new ArgumentException("Value must be a TabListPage", nameof(value));
        }

        this.Insert(index, page);
      }

      void IList.Remove(object value)
      {
        TabListPage page;

        page = value as TabListPage;

        if (page == null)
        {
          throw new ArgumentException("Value must be a TabListPage", nameof(value));
        }

        this.Remove(page);
      }

      public int Count
      {
        get { return _owner.TabListPageCount; }
      }

      bool IList.IsFixedSize
      {
        get { return false; }
      }

      bool IList.IsReadOnly
      {
        get { return false; }
      }

      bool ICollection.IsSynchronized
      {
        get { return false; }
      }

      object ICollection.SyncRoot
      {
        get { return this; }
      }

      #endregion

      #region IList<TabListPage> Interface

      public TabListPage this[int index]
      {
        get { return _owner.GetTabListPages()[index]; }
        set { _owner.SelectedIndex = index; }
      }

      public void Add(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        _owner.Controls.Add(value);
      }

      public bool Contains(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        return this.IndexOf(value) != -1;
      }

      public void CopyTo(TabListPage[] array, int arrayIndex)
      {
        this.CopyTo((Array)array, arrayIndex);
      }

      public IEnumerator<TabListPage> GetEnumerator()
      {
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (TabListPage page in _owner.GetTabListPages())
        {
          yield return page;
        }
      }

      public int IndexOf(TabListPage value)
      {
        int index;
        TabListPage[] pages;

        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        index = -1;
        pages = _owner.GetTabListPages();

        for (int i = 0; i < pages.Length; i++)
        {
          if (pages[i] == value)
          {
            index = i;
            break;
          }
        }

        return index;
      }

      public void Insert(int index, TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        _owner.InsertPage(index, value);
        _owner.Controls.Add(value);
        _owner.Controls.SetChildIndex(value, index);
      }

      public bool Remove(TabListPage value)
      {
        int index;

        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        index = this.IndexOf(value);

        if (index != -1)
        {
          _owner.Controls.RemoveAt(index);
        }

        return index != -1;
      }

      bool ICollection<TabListPage>.IsReadOnly
      {
        get { return false; }
      }

      #endregion
    }

    #endregion
  }
}
