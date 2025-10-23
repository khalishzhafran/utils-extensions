// ------------------------------------------------------------------------------
//  File: ListExtension.cs
//  Author: Ran
//  Description: Extension methods for List collections.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="IList{T}"/> class.
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Swaps the elements at the specified indices in the list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list in which to swap elements.</param>
        /// <param name="index1">The index of the first element to swap.</param>
        /// <param name="index2">The index of the second element to swap.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when <paramref name="index1"/> or <paramref name="index2"/> is out of the range of the list.
        /// </exception>
        public static void Swap<T>(this IList<T> list, int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);
        }

        /// <summary>
        /// Shuffles the elements in the list using the Fisher-Yates algorithm.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to shuffle.</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                list.Swap(k, n);
            }
        }

        /// <summary>
        /// Flattens a list of lists into a single sequence of elements.
        /// </summary>
        /// <typeparam name="T">The type of elements in the lists.</typeparam>
        /// <param name="list">The list of lists to flatten.</param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> that contains all elements from the inner lists.
        /// </returns>
        public static IEnumerable<T> Flatten<T>(this IList<IList<T>> list)
        {
            foreach (var item in list)
            {
                foreach (var item2 in item)
                {
                    yield return item2;
                }
            }
        }
    }
}
