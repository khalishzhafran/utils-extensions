// ------------------------------------------------------------------------------
//  File: NumericExtension.cs
//  Author: Ran
//  Description: Extension methods for numeric types.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="float"/>, <see cref="int"/>, <see cref="double"/>, and <see cref="decimal"/> classes.
    /// </summary>
    public static class NumericExtension
    {
        /// <summary>
        /// Rounds a float number to the nearest integer.
        /// </summary>
        /// <param name="number">The float value to round.</param>
        /// <returns>The rounded integer.</returns>
        [Pure]
        public static int RoundToInt(this float number) => Mathf.RoundToInt(number);

        /// <summary>
        /// Rounds a float number to a specified number of decimal places.
        /// </summary>
        /// <param name="number">The float value to round.</param>
        /// <param name="decimalPlaces">The number of decimal places.</param>
        /// <returns>The rounded float value.</returns>
        [Pure]
        public static float Round(this float number, int decimalPlaces) => Mathf.Round(number * Mathf.Pow(10, decimalPlaces)) / Mathf.Pow(10, decimalPlaces);

        /// <summary>
        /// Floors a float number to the nearest integer.
        /// </summary>
        /// <param name="number">The float value to floor.</param>
        /// <returns>The floored integer.</returns>
        [Pure]
        public static int FloorToInt(this float number) => Mathf.FloorToInt(number);

        /// <summary>
        /// Ceils a float number to the nearest integer.
        /// </summary>
        /// <param name="number">The float value to ceil.</param>
        /// <returns>The ceiled integer.</returns>
        [Pure]
        public static int CeilToInt(this float number) => Mathf.CeilToInt(number);

        /// <summary>
        /// Clamps a float value between a minimum and a maximum value.
        /// </summary>
        /// <param name="number">The float value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped float value.</returns>
        [Pure]
        public static float Clamp(this float number, float min, float max) => Mathf.Clamp(number, min, max);

        /// <summary>
        /// Clamps an integer value between a minimum and a maximum value.
        /// </summary>
        /// <param name="number">The integer value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped integer value.</returns>
        [Pure]
        public static int Clamp(this int number, int min, int max) => Mathf.Clamp(number, min, max);

        /// <summary>
        /// Clamps a float value between 0 and 1.
        /// </summary>
        /// <param name="number">The float value to clamp.</param>
        /// <returns>The clamped float value.</returns>
        [Pure]
        public static float Clamp01(this float number) => Mathf.Clamp01(number);

        /// <summary>
        /// Returns the maximum of the given float value and a specified maximum.
        /// </summary>
        /// <param name="number">The float value to compare.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The larger value.</returns>
        [Pure]
        public static float Max(this float number, float max) => Mathf.Max(number, max);

        /// <summary>
        /// Returns the minimum of the given float value and a specified minimum.
        /// </summary>
        /// <param name="number">The float value to compare.</param>
        /// <param name="min">The minimum value.</param>
        /// <returns>The smaller value.</returns>
        [Pure]
        public static float Min(this float number, float min) => Mathf.Min(number, min);

        /// <summary>
        /// Returns the maximum of the given integer value and a specified maximum.
        /// </summary>
        /// <param name="number">The integer value to compare.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The larger value.</returns>
        [Pure]
        public static float Max(this int number, float max) => Mathf.Max(number, max);

        /// <summary>
        /// Returns the minimum of the given integer value and a specified minimum.
        /// </summary>
        /// <param name="number">The integer value to compare.</param>
        /// <param name="min">The minimum value.</param>
        /// <returns>The smaller value.</returns>
        [Pure]
        public static float Min(this int number, float min) => Mathf.Min(number, min);

        /// <summary>
        /// Returns the maximum of the given integer value and a specified maximum.
        /// </summary>
        /// <param name="number">The integer value to compare.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The larger value.</returns>
        [Pure]
        public static int Max(this int number, int max) => Mathf.Max(number, max);

        /// <summary>
        /// Returns the minimum of the given integer value and a specified minimum.
        /// </summary>
        /// <param name="number">The integer value to compare.</param>
        /// <param name="min">The minimum value.</param>
        /// <returns>The smaller value.</returns>
        [Pure]
        public static int Min(this int number, int min) => Mathf.Min(number, min);

        /// <summary>
        /// Determines whether a float value is approximately an integer.
        /// </summary>
        /// <param name="value">The float value to check.</param>
        /// <returns>True if the value is approximately an integer; otherwise, false.</returns>
        [Pure]
        public static bool IsInteger(this float value) => Mathf.Approximately(value, Mathf.Round(value));

        /// <summary>
        /// Converts a float value representing seconds into a formatted time string (HH:mm:ss.mmm).
        /// </summary>
        /// <param name="seconds">The number of seconds.</param>
        /// <returns>A formatted time string.</returns>
        [Pure]
        public static string ToFormattedTimeString(this float seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return $"{(int)timeSpan.TotalHours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}.{timeSpan.Milliseconds:000}";
        }
    }
}
