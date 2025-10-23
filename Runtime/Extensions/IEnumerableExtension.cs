// ------------------------------------------------------------------------------
//  File: IEnumerableExtension.cs
//  Author: Ran
//  Description: Extension methods for IEnumerable collections.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="IEnumerable{T}"/> class.
    /// </summary>
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Returns distinct elements from a sequence based on the keys returned by a key selector function.
        /// </summary>
        /// <typeparam name="TSource">The type of elements in the source sequence.</typeparam>
        /// <typeparam name="TKey">The type of keys used for comparison.</typeparam>
        /// <param name="source">The source sequence to filter.</param>
        /// <param name="keySelector">A function to extract the key from each element.</param>
        /// <returns>An <see cref="IEnumerable{TSource}"/> containing distinct elements, based on the keys returned by the key selector function.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the source or keySelector is null.</exception>
        [Pure]
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

            HashSet<TKey> seenKeys = new();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        /// <summary>
        /// Iterates through the elements of the enumerable and applies the specified action to each element.
        /// </summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="enumerable">The enumerable collection to iterate over.</param>
        /// <param name="action">The action to apply to each element.</param>
        /// <exception cref="ArgumentNullException">Thrown when the enumerable or action is null.</exception>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (action == null) throw new ArgumentNullException(nameof(action));

            foreach (T item in enumerable)
            {
                action(item);
            }
        }

        /// <summary>
        /// Flattens a sequence of sequences into a single sequence.
        /// </summary>
        /// <typeparam name="T">The type of elements in the inner sequences.</typeparam>
        /// <param name="enumerable">The enumerable collection of enumerable collections to flatten.</param>
        /// <returns>A single <see cref="IEnumerable{T}"/> containing all elements from the inner sequences.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the enumerable is null.</exception>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            return enumerable.SelectMany(inner => inner ?? Enumerable.Empty<T>());
        }

        /// <summary>
        /// Returns a sequence of tuples, each containing an element from the source sequence and its index.
        /// </summary>
        /// <typeparam name="T">The type of elements in the source sequence.</typeparam>
        /// <param name="enumerable">The source sequence.</param>
        /// <returns>A sequence of tuples, where each tuple contains an element from the source sequence and its index.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the enumerable is null.</exception>
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            return enumerable.Select((item, index) => (item, index));
        }

        /// <summary>
        /// Removes all null items from the given <see cref="IEnumerable{T}"/> and returns the cleared items.
        /// </summary>
        /// <typeparam name="T">The type of elements in the source sequence.</typeparam>
        /// <param name="source">The source sequence to filter.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> containing only non-null elements.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the source is null.</exception>
        public static IEnumerable<T> RemoveNulls<T>(this IEnumerable<T> source) where T : class
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            return source.Where(item => item != null);
        }
    }
}
