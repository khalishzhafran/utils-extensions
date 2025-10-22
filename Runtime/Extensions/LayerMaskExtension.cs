// Author   : Litsch

using UnityEngine;

namespace Litsch.Utilities
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
