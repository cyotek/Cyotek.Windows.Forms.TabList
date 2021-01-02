# TabList Change Log

## 2.1.0

### Added

* Added `Ctrl+Tab` hotkey to cycle tabs, when the `TabList` or a
  hosted control has focus.
* Added `TabListManager` class with a `Renderer` property, the
  original `TabListRenderer.DefaultRenderer` has been marked as
  obsolete and will be removed in a future update
* The `Enabled` property is now exposed for `TabListPage`
  instances and the control will now correctly behave and render
  according to the enabled state of individual pages, and the
  overall control

### Changed

* The default `VisualStudioTabListRenderer` no longer draws a
  solid fill for tab buttons in a default state, allowing the
  background image (if set) to appear
* The `TabList.Renderer` property no longer appears in
  Properties windows or serialised by the designer
* The misspelled `ListBoxTabListeRenderer` class has been marked
  as obsolete and will be removed in a future update. Please use
  the correctly named `ListBoxTabListRenderer` class instead

### Fixed

* The previous speculative fix didn't work correctly

## 2.0.1

### Fixed

* Speculative fix for a resize bug when applying a font during load
* Fixed a issue where mouse clicks may not be processed properly

## 2.0.0

### Added

* Designer now supports **Dock in Parent Container** and
  **Undock in Parent Container** commands
* Added new `Selecting`, `Selected`, `Deselecting` and
  `Deselected` events, mirroring similar events in a standard
  `TabControl`
* Added overloads of `HitTest` and `GetPageAt` that accept x-
  and y-coordinates
* Added missing XML comments documentation

### Changed

* Now uses semantic versioning
* `TabListPageCollection` now implements `IList<TabListPage>`
* `TabList.HoverIndex` renamed to `HotIndex`
* `TabList.TabListBounds` renamed to `TabListDisplayRectangle`
* `GetItemAtPoint` renamed to `GetPageAt`
* `DefaultTabListPageRenderer` renamed to
  `VisualStudio2012TabListRenderer`
* Any type containing `TabListPageRenderer` has been renamed to
  be `TabListRenderer`

### Removed

* Removed the explicit implementation of `ITabListPageRenderer`
  from `TabListPageRenderer` as it added nothing over the
  implicit
* The `TabListPageCollection` and `TabListControlCollection`
  classes are now sealed and without public constructors
* Removed public `IsReadOnly`, `IsFixedSize`, `IsSynchronized`
  and `SyncRoot` properties, these are now available only via
  explicit interface casting
* Removed the `virtual` attribute from most properties
* Some previously protected virtual methods have been made
  private

### Fixed

* Unused events now have no additional overhead
* Focus rectangles are now drawn using the Win32 `DrawFocusRect`
  API rather than the utterly awful .NET implementation
* Correct background wasn't painted when a `TabList` was hosted
  inside a `TabControl`
* Demonstration program is now a little more robust

## 1.0.2.0

### Added

* Added `this[string]` indexer to the `TabPageList` collection
* Added `RenderList`, `GetStartingPosition` and
  `GetPreferredSize` methods to `ITabListPageRenderer` to allow
  greater control over how headers are sized and positioned
* Added new `ListBoxTabListPageRenderer` class. This renderer
  makes the tab list look like a list box.
* Added new demonstration showing how to use different renderers
  to change the controls appearance
* Added `ContainsKey` and `IndexOfKey` methods to
  `TabPageCollection`.

## 1.0.1.0

### Added

* Added NuGet package
* Added a license file to hopefully cut down on questions about
  usage. The `TabList` control is licensed under the MIT
  license, allowing you free reign to use it in your projects,
  commercial or otherwise. See `tablist-license.txt` for the
  full text.

### Changed

* Tidied up the demo a touch

## 1.0.0.2

### Fixed

* Fixed the `HoverIndex` property always defaulting to zero.

## 1.0.0.1

### Added

* Added `ShowTabList` property. When set to `False`, the list of
  tabs is no longer displayed, and navigation can only occur via
  code.
* Added `AllowTabSelection` property. When set to `False`, the
  control can no longer gain focus, mouse hover effects are not
  displayed, and navigation can only occur via code. This allows
  you to disable navigation whilst still having the tabs
  visible.

## 1.0.0.0

* Initial release
