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

    /// <summary>
    /// Contains a collection of <see cref="TabListPage"/> objects.
    /// </summary>
    /// <seealso cref="T:System.Collections.IList"/>
    /// <seealso cref="T:System.Collections.Generic.IList{Cyotek.Windows.Forms.TabListPage}"/>
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

      /// <summary>
      /// Gets or sets a <see cref="TabListPage"/> in the collection.
      /// </summary>
      /// <param name="name">The name.</param>
      /// <returns>
      /// The indexed item.
      /// </returns>
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

      /// <summary>
      /// Creates a tab page with the specified text, and adds it to the collection.
      /// </summary>
      /// <param name="text">The text to display on the tab page.</param>
      /// <remarks>The newly created <see cref="TabListPage"/> is added to the end of the collection.</remarks>
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

      /// <summary>
      /// Determines whether the collection contains a tab page with the specified key.
      /// </summary>
      /// <param name="key">The name of the tab page to search for.</param>
      /// <returns>
      /// <c>true</c> to indicate a tab page with the specified key was found in the collection; otherwise, <c>false</c>.
      /// </returns>
      public bool ContainsKey(string key)
      {
        return this.IndexOfKey(key) != -1;
      }

      /// <summary>
      /// Returns the index of the first occurrence of the <see cref="TabListPage"/> with the specified key.
      /// </summary>
      /// <param name="key">The name of the tab page to search for.</param>
      /// <returns>
      /// The zero-based index of the first occurrence of a tab page with the specified key, if found; otherwise, -1.
      /// </returns>
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

      /// <summary>
      /// Removes all the tab pages from the collection.
      /// </summary>
      public void Clear()
      {
        _owner.ClearAllPages();
      }

      /// <summary>
      /// Removes the tab page at the specified index from the collection.
      /// </summary>
      /// <param name="index">The zero-based index of the <see cref="TabListPage"/> to remove.</param>
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

      /// <summary>
      /// Gets the number of tab pages in the collection.
      /// </summary>
      /// <value>
      /// The number of tab pages in the collection.
      /// </value>
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

      /// <summary>
      /// Gets or sets a <see cref="TabListPage"/> in the collection.
      /// </summary>
      /// <param name="index">The zero-based index of the tab page to get or set.</param>
      /// <returns>
      /// The <see cref="TabListPage"/> at the specified index.
      /// </returns>
      public TabListPage this[int index]
      {
        get { return _owner._pages[index]; }
        set
        {
          this.RemoveAt(index);
          this.Insert(index, value);
        }
      }

      /// <summary>
      /// Adds a <see cref="TabListPage"/> to the collection.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
      /// <param name="value">The <see cref="TabListPage"/> to add.</param>
      public void Add(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        _owner.Controls.Add(value);
      }

      /// <summary>
      /// Determines whether a specified tab page is in the collection.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
      /// <param name="value">The <see cref="TabListPage"/> to locate in the collection.</param>
      /// <returns>
      /// <c>true</c> if the specified TabPage is in the collection; otherwise, <c>false</c>.
      /// </returns>
      public bool Contains(TabListPage value)
      {
        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        return this.IndexOf(value) != -1;
      }

      void ICollection<TabListPage>.CopyTo(TabListPage[] array, int arrayIndex)
      {
        this.CopyTo(array, arrayIndex);
      }

      /// <summary>
      /// Returns an enumeration of all the tab pages in the collection.
      /// </summary>
      /// <returns>
      /// An <see cref="IEnumerator{TabListPage}"/> for the <see cref="TabListPageCollection"/>.
      /// </returns>
      public IEnumerator<TabListPage> GetEnumerator()
      {
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (TabListPage page in _owner.GetTabListPages())
        {
          yield return page;
        }
      }

      /// <summary>
      /// Returns the index of the specified tab page in the collection.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
      /// <param name="value">The <see cref="TabListPage"/> to locate in the collection.</param>
      /// <returns>
      /// The zero-based index of the tab page; -1 if it cannot be found.
      /// </returns>
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

      /// <summary>
      /// Creates a new tab page with the specified text and inserts it into the collection at the specified index.
      /// </summary>
      /// <param name="index">The zero-based index location where the tab page is inserted.</param>
      /// <param name="text">The text to display on the tab page.</param>
      public void Insert(int index, string text)
      {
        TabListPage page;

        page = new TabListPage
        {
          Text = text
        };

        this.Insert(index, page);
      }

      /// <summary>
      /// Inserts an existing tab page into the collection at the specified index.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
      /// <param name="index">The zero-based index location where the tab page is inserted.</param>
      /// <param name="value">The <see cref="TabListPage"/> to insert in the collection.</param>
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

      /// <summary>
      /// Removes a <see cref="TabListPage"/> from the collection.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
      /// <param name="value">The <see cref="TabListPage"/> to remove.</param>
      public void Remove(TabListPage value)
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
      }

      bool ICollection<TabListPage>.Remove(TabListPage value)
      {
        int index;

        if (value == null)
        {
          throw new ArgumentNullException(nameof(value));
        }

        index = this.IndexOf(value);

        if (index != -1)
        {
          this.Remove(value);
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
