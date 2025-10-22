# Ran Utils - Extension Utilities

This package provides a collection of extension methods for Unity and C# types, designed to simplify common tasks and enhance code readability in your Unity projects.

## Features

-   Extension methods for:
    -   `string` and `char`: Whitespace/special character removal, rich text formatting, title case conversion
    -   Numeric types (`float`, `int`, `decimal`): Rounding, clamping, min/max, integer checks, time formatting
    -   `IList<T>` and `IEnumerable<T>`: Swap, shuffle, flatten, distinct by key, for-each, with index, remove nulls
    -   Unity types:
        -   `RectTransform`: Get world corners, global position as Rect
        -   `VisualElement`: Add classes/stylesheets to UI elements
        -   `LayerMask`: Check if a layer is contained
        -   `Coroutine`/`MonoBehaviour`: Wait for all/any coroutines, wait for UnityEvent
        -   `RuntimeAnimatorController`: Check if an animation clip exists

## API Reference

### StringExtension

-   `IsWhitespace(char)`: Checks if a character is whitespace
-   `RemoveWhitespaces(string)`: Removes all whitespace characters
-   `RemoveSpecialCharacters(string)`: Removes all special characters
-   Rich text formatting: `RichColor`, `RichSize`, `RichBold`, `RichItalic`, `RichUnderline`, `RichStrikethrough`, `RichFont`, `RichAlign`, `RichGradient`, `RichRotation`, `RichSpace`
-   `ToTitleCase(string)`: Converts to title case

### NumericExtension

-   `RoundToInt(float)`, `Round(float, int)`, `FloorToInt(float)`, `CeilToInt(float)`: Rounding operations
-   `Clamp`, `Clamp01`, `Max`, `Min`: Clamping and min/max for float/int
-   `IsInteger(float)`: Checks if a float is approximately an integer
-   `ToFormattedTimeString(float)`: Converts seconds to formatted time string

### ListExtension

-   `Swap<T>(IList<T>, int, int)`: Swap elements
-   `Shuffle<T>(IList<T>)`: Shuffle list
-   `Flatten<T>(IList<IList<T>>)`

### IEnumerableExtension

-   `DistinctBy<TSource, TKey>(IEnumerable<TSource>, Func<TSource, TKey>)`: Distinct by key
-   `ForEach<T>(IEnumerable<T>, Action<T>)`: Apply action to each element
-   `Flatten<T>(IEnumerable<IEnumerable<T>>)`
-   `WithIndex<T>(IEnumerable<T>)`: Enumerate with index
-   `RemoveNulls<T>(IEnumerable<T>)`: Remove nulls

### RectTransformExtension

-   `GetWorldCorners(RectTransform)`: Get world space corners
-   `GetGlobalPosition(RectTransform)`: Get global position as Rect

### VisualElementExtension

-   `AddClasses(VisualElement, params string[])`: Add multiple class names
-   `AddStyleSheets(VisualElement, params string[])`: Add style sheets from Resources

### LayerMaskExtension

-   `Contains(LayerMask, LayerMask)`: Check if layer mask contains another

### CoroutineExtension

-   `WaitAll(MonoBehaviour, params IEnumerator[])`: Wait for all coroutines
-   `WaitAny(MonoBehaviour, params IEnumerator[])`: Wait for any coroutine
-   `WaitForEvent(UnityEvent)`: Wait for UnityEvent

### AnimatorExtension

-   `IsAnimationClipExists(RuntimeAnimatorController, string)`: Check if animation clip exists

## Installation

### Option 1: Unity Git Package Manager (Recommended)

Add the following line to your project's `manifest.json` dependencies:

```json
"com.ran-utils.extensions": "https://github.com/khalishzhafran/utils-extensions.git"
```

### Option 2: Manual Copy

Copy the `Runtime/Extensions` folder into your Unity project's `Assets` directory.

## License

Copyright (c) 2025 Ran. Free to use, modify, and distribute for personal and commercial projects as long as this notice remains intact.
