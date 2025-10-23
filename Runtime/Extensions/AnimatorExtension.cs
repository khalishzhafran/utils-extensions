// ------------------------------------------------------------------------------
//  File: AnimatorExtension.cs
//  Author: Ran
//  Description: Extension methods for Animator components in Unity.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using System.Linq;
using UnityEngine;

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="RuntimeAnimatorController"/> class.
    /// </summary>
    public static class AnimatorExtension
    {
        /// <summary>
        /// Checks if an animation clip with the specified name exists in the provided RuntimeAnimatorController.
        /// </summary>
        /// <param name="controller">The RuntimeAnimatorController to check.</param>
        /// <param name="animationClipName">The name of the animation clip to search for.</param>
        /// <returns>Returns <c>true</c> if the animation clip exists; otherwise, <c>false</c>.</returns>
        public static bool IsAnimationClipExists(this RuntimeAnimatorController controller, string animationClipName)
        {
            return controller.animationClips.Any(clip => clip.name == animationClipName);
        }
    }
}
