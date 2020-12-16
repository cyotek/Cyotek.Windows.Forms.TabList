using NUnit.Framework;
using System.Collections.Generic;

namespace Cyotek.Windows.Forms.Tests
{
  [TestFixture]
  public class TabListTests
  {
    #region Public Properties

    public static IEnumerable<TestCaseData> FindNextAvailableTabTestCases
    {
      get
      {
        yield return new TestCaseData(0, 1, true, true, 1).SetName(nameof(FindNextAvailableTabTests) + "Next");
        yield return new TestCaseData(0, 3, true, true, 3).SetName(nameof(FindNextAvailableTabTests) + "NextWithStep");
        yield return new TestCaseData(8, 1, true, true, 0).SetName(nameof(FindNextAvailableTabTests) + "NextWithWrap");
        yield return new TestCaseData(8, 1, true, false, -1).SetName(nameof(FindNextAvailableTabTests) + "NextWithoutWrap");
        yield return new TestCaseData(3, 1, true, true, 5).SetName(nameof(FindNextAvailableTabTests) + "NextWithDisabled");
        yield return new TestCaseData(8, 1, false, true, 7).SetName(nameof(FindNextAvailableTabTests) + "Previous");
        yield return new TestCaseData(8, 3, false, true, 5).SetName(nameof(FindNextAvailableTabTests) + "PreviousWithStep");
        yield return new TestCaseData(0, 1, false, true, 8).SetName(nameof(FindNextAvailableTabTests) + "PreviousWithWrap");
        yield return new TestCaseData(0, 1, false, false, -1).SetName(nameof(FindNextAvailableTabTests) + "PreviousWithoutWrap");
        yield return new TestCaseData(5, 1, false, true, 3).SetName(nameof(FindNextAvailableTabTests) + "PreviousWithDisabled");
      }
    }

    public static IEnumerable<TestCaseData> FindNextAvailableTabWithDisabledWrapTestCases
    {
      get
      {
        yield return new TestCaseData(2, true, 1).SetName(nameof(FindNextAvailableTabWithDisabledWrapTest) + "Next");
        yield return new TestCaseData(1, false, 2).SetName(nameof(FindNextAvailableTabWithDisabledWrapTest) + "Previous");
      }
    }

    #endregion Public Properties

    #region Public Methods

    [Test]
    [TestCaseSource(nameof(FindNextAvailableTabTestCases))]
    public void FindNextAvailableTabTests(int start, int stepSize, bool forwards, bool canWrap, int expected)
    {
      // arrange
      TabList target;
      int actual;

      target = new TabList
      {
        TabListPages =
        {
          new TabListPage(),
          new TabListPage(),
          new TabListPage(),
          new TabListPage(),
          new TabListPage
          {
            Enabled = false
          },
          new TabListPage(),
          new TabListPage(),
          new TabListPage(),
          new TabListPage()
        }
      };

      target.SelectedIndex = start;

      // act
      actual = target.FindNextAvailableTab(stepSize, forwards, canWrap);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCaseSource(nameof(FindNextAvailableTabWithDisabledWrapTestCases))]
    public void FindNextAvailableTabWithDisabledWrapTest(int start, bool forwards, int expected)
    {
      // arrange
      TabList target;
      int actual;

      target = new TabList
      {
        TabListPages =
        {
          new TabListPage
          {
            Enabled = false
          },
          new TabListPage(),
          new TabListPage(),
          new TabListPage
          {
            Enabled = false
          },
        }
      };

      target.SelectedIndex = start;

      // act
      actual = target.FindNextAvailableTab(1, forwards, true);

      // assert
      Assert.AreEqual(expected, actual);
    }

    #endregion Public Methods
  }
}
