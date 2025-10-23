// ------------------------------------------------------------------------------
//  File: RectTransformExtension.cs
//  Author: Ran
//  Description: Extension methods for RectTransform class.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using UnityEngine;

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="RectTransform"/> class.
    /// </summary>
    public static class RectTransformExtension
    {
        /// <summary>
        /// Gets the world space corners of the RectTransform.
        /// </summary>
        /// <param name="rectTransform">The RectTransform to get corners from.</param>
        /// <returns>An array of Vector3 containing the world space corners of the RectTransform.</returns>
        public static Vector3[] GetWorldCorners(this RectTransform rectTransform)
        {
            Vector3[] corners = new Vector3[4];
            rectTransform.GetWorldCorners(corners);
            return corners;
        }

        /// <summary>
        /// Gets the global position of the RectTransform in world space as a Rect.
        /// </summary>
        /// <param name="rectTransform">The RectTransform to get global position from.</param>
        /// <returns>A Rect representing the global position of the RectTransform.</returns>
        public static Rect GetGlobalPosition(this RectTransform rectTransform)
        {
            Vector3[] corners = rectTransform.GetWorldCorners();
            return new Rect(corners[0].x, corners[0].y, corners[2].x - corners[0].x, corners[2].y - corners[0].y);
        }
    }
}
