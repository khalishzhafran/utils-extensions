// ------------------------------------------------------------------------------
//  File: LayerMaskExtension.cs
//  Author: Ran
//  Description: Extension methods for LayerMask class.
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
    /// Extension methods for <see cref="LayerMask"/> class.
    /// </summary>
    public static class LayerMaskExtension
    {
        /// <summary>
        /// Checks if the layer mask contains the specified layer.
        /// </summary>
        /// <param name="layerMask">Layer mask to check.</param>
        /// <param name="expectedLayerMask">Layer mask to check against.</param>
        /// <returns><c>true</c> if the layer mask contains the specified layer; otherwise, <c>false</c>.</returns>
        public static bool Contains(this LayerMask layerMask, LayerMask expectedLayerMask)
        {
            return (layerMask.value & expectedLayerMask.value) == expectedLayerMask.value;
        }
    }
}
