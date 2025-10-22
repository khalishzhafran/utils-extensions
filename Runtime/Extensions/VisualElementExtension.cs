// Author   : Litsch

using UnityEngine.UIElements;

namespace Litsch.Utilities
{
    /// <summary>
    /// Extension methods for <see cref="VisualElement"/> class.
    /// </summary>
    public static class VisualElementExtension
    {
        /// <summary>
        /// Adds multiple class names to the specified <see cref="VisualElement"/>.
        /// </summary>
        /// <param name="element">The <see cref="VisualElement"/> to which the class names will be added.</param>
        /// <param name="classNames">An array of class names to add to the element's class list.</param>
        /// <returns>The modified <see cref="VisualElement"/> with the added class names.</returns>
        public static VisualElement AddClasses(this VisualElement element, params string[] classNames)
        {
            foreach (string className in classNames)
            {
                element.AddToClassList(className);
            }

            return element;
        }

        /// <summary>
        /// Adds multiple style sheets to the specified <see cref="VisualElement"/> by loading them from the Resources folder.
        /// </summary>
        /// <param name="element">The <see cref="VisualElement"/> to which the style sheets will be added.</param>
        /// <param name="styleSheetNames">An array of style sheet names (without file extension) to load and apply to the element.</param>
        /// <returns>The modified <see cref="VisualElement"/> with the added style sheets.</returns>
        public static VisualElement AddStyleSheets(this VisualElement element, params string[] styleSheetNames)
        {
            foreach (string styleSheetName in styleSheetNames)
            {
                StyleSheet styleSheet = UnityEngine.Resources.Load<StyleSheet>(styleSheetName);
                element.styleSheets.Add(styleSheet);
            }

            return element;
        }
    }
}
