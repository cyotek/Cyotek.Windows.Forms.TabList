# TabList Change Log

## 1.0.2.0 (WIP)
### Changes and new features
* Added `this[string]` indexer to the `TabPageList` collection
* Added `RenderList`, `GetStartingPosition` and `GetPreferredSize` methods to `ITabListPageRenderer` to allow greater control over how headers are sized and positioned
* Added new `ListBoxTabListPageRenderer` class. This renderer makes the tab list look like a list box.
* Added new demonstration showing how to use different renderers to change the controls appearance
* Added `ContainsKey` and `IndexOfKey` methods to `TabPageCollection`.

## 1.0.1.0
### Changes and new features
* Added NuGet package
* Added a license file to hopefully cut down on questions about usage. The `TabList` control is licensed under the MIT license, allowing you free reign to use it in your projects, commercial or otherwise. See `tablist-license.txt` for the full text.
* Tidied up the demo a touch

## 1.0.0.2
### Bug fixes
* Fixed the `HoverIndex` property always defaulting to zero.

## 1.0.0.1
### Changes and new features
* Added `ShowTabList` property. When set to `False`, the list of tabs is no longer displayed, and navigation can only occur via code.
* Added `AllowTabSelection` property. When set to `False`, the control can no longer gain focus, mouse hover effects are not displayed, and navigation can only occur via code. This allows you to disable navigation whilst still having the tabs visible.

## 1.0.0.0
* Initial release