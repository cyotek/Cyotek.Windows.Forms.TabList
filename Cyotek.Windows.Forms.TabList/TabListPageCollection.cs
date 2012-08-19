using System;
using System.Collections;

namespace Cyotek.Windows.Forms
{
  partial class TabList
  {
    #region  Nested Classes


    public class TabListPageCollection
      : IList, ICollection, IEnumerable
    {
      #region  Public Constructors

      public TabListPageCollection(TabList owner)
      {
        if (owner == null)
          throw new ArgumentNullException("owner");

        this.Owner = owner;
      }

      #endregion  Public Constructors

      #region  Public Methods

      public TabListPage Add(string text)
      {
        TabListPage page;

        page = new TabListPage()
        {
          Text = text
        };

        this.Add(page);

        return page;
      }

      public void Add(TabListPage value)
      {
        if (value == null)
          throw new ArgumentNullException("value");

        this.Owner.Controls.Add(value);
      }

      public void Clear()
      {
        this.Owner.ClearAllPages();
      }

      public bool Contains(TabListPage value)
      {
        if (value == null)
          throw new ArgumentNullException("value");

        return this.IndexOf(value) != -1;
      }

      public void CopyTo(Array array, int index)
      {
        if (this.Count != 0)
          Array.Copy(this.Owner.GetTabListPages(), 0, array, index, this.Count);
      }

      public IEnumerator GetEnumerator()
      {
        TabListPage[] tabPages;

        tabPages = this.Owner.GetTabListPages();
        if (tabPages == null)
          tabPages = new TabListPage[0];

        return tabPages.GetEnumerator();
      }

      public int IndexOf(TabListPage value)
      {
        int index;

        if (value == null)
          throw new ArgumentNullException("value");

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

      public void Insert(int index, TabListPage value)
      {
        if (value == null)
          throw new ArgumentNullException("value");

        this.Owner.InsertPage(index, value);
        this.Owner.Controls.Add(value);
        this.Owner.Controls.SetChildIndex(value, index);
      }

      public void Remove(TabListPage value)
      {
        if (value == null)
          throw new ArgumentNullException("value");

        this.Owner.Controls.Remove(value);
      }

      public void RemoveAt(int index)
      {
        this.Owner.Controls.RemoveAt(index);
      }

      #endregion  Public Methods

      #region  Public Properties

      public int Count
      { get { return this.Owner.TabListPageCount; } }

      public bool IsFixedSize
      { get { return false; } }

      public bool IsReadOnly
      { get { return false; } }

      public bool IsSynchronized
      { get { return false; } }

      public object SyncRoot
      { get { return this; } }

      public virtual TabListPage this[int index]
      {
        get { return this.Owner.GetTabListPages()[index]; }
        set { this.Owner.SelectedIndex = index; }
      }

      #endregion  Public Properties

      #region  Private Properties

      object IList.this[int index]
      {
        get { return this[index]; }
        set
        {
          if (!(value is TabListPage))
            throw new ArgumentException("Only controls of type TabListPage can be added to this collection.", "value");

          this[index] = (TabListPage)value;
        }
      }

      #endregion  Private Properties

      #region  Private Methods

      int IList.Add(object value)
      {
        TabListPage page;

        if (!(value is TabListPage))
          throw new ArgumentException("value");

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
          index = this.IndexOf((TabListPage)value);
        else
          index = -1;

        return index;
      }

      void IList.Insert(int index, object value)
      {
        if (!(value is TabListPage))
          throw new ArgumentException("value");

        this.Insert(index, (TabListPage)value);
      }

      void IList.Remove(object value)
      {
        if (value is TabListPage)
          this.Remove((TabListPage)value);
      }

      #endregion  Private Methods

      #region  Protected Properties

      protected TabList Owner { get; set; }

      #endregion  Protected Properties
    }
    #endregion  Nested Classes
  }
}
