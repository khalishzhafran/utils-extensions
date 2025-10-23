// ------------------------------------------------------------------------------
//  File: StringExtension.cs
//  Author: Ran
//  Description: Extension methods for string manipulation.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

namespace ran.utilities
{
    /// <summary>
    /// Extension methods for <see cref="char"/> and <see cref="string"/> classes.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Determines whether the specified character is considered a whitespace character.
        /// </summary>
        /// <param name="character">The character to check.</param>
        /// <returns><c>true</c> if the character is a whitespace character; otherwise, <c>false</c>.</returns>
        public static bool IsWhitespace(this char character)
        {
            return character switch
            {
                '\u0020' or
                '\u00A0' or
                '\u1680' or
                '\u2000' or
                '\u2001' or
                '\u2002' or
                '\u2003' or
                '\u2004' or
                '\u2005' or
                '\u2006' or
                '\u2007' or
                '\u2008' or
                '\u2009' or
                '\u200A' or
                '\u202F' or
                '\u205F' or
                '\u3000' or
                '\u2028' or
                '\u2029' or
                '\u0009' or
                '\u000A' or
                '\u000B' or
                '\u000C' or
                '\u000D' or
                '\u0085' => true,
                _ => false,
            };
        }

        /// <summary>
        /// Removes all whitespace characters from the specified string.
        /// </summary>
        /// <param name="text">The string from which to remove whitespace characters.</param>
        /// <returns>A new string without any whitespace characters.</returns>
        public static string RemoveWhitespaces(this string text)
        {
            int textLength = text.Length;

            char[] textCharacters = text.ToCharArray();

            int currentWhitespacelessTextLength = 0;

            for (int currentCharacterIndex = 0; currentCharacterIndex < textLength; ++currentCharacterIndex)
            {
                char currentTextCharacter = textCharacters[currentCharacterIndex];

                if (currentTextCharacter.IsWhitespace()) continue;

                textCharacters[currentWhitespacelessTextLength++] = currentTextCharacter;
            }

            return new string(textCharacters, 0, currentWhitespacelessTextLength);
        }

        /// <summary>
        /// Removes all special characters from the specified string, leaving only letters, digits, and whitespace characters.
        /// </summary>
        /// <param name="text">The string from which to remove special characters.</param>
        /// <returns>A new string containing only letters, digits, and whitespace characters.</returns>
        public static string RemoveSpecialCharacters(this string text)
        {
            int textLength = text.Length;

            char[] textCharacters = text.ToCharArray();

            int currentWhitespacelessTextLength = 0;

            for (int currentCharacterIndex = 0; currentCharacterIndex < textLength; ++currentCharacterIndex)
            {
                char currentTextCharacter = textCharacters[currentCharacterIndex];

                if (!char.IsLetterOrDigit(currentTextCharacter) && !currentTextCharacter.IsWhitespace())
                {
                    continue;
                }

                textCharacters[currentWhitespacelessTextLength++] = currentTextCharacter;
            }

            return new string(textCharacters, 0, currentWhitespacelessTextLength);
        }

        /// <summary>
        /// Converts the first character of the input string to uppercase and the rest to lowercase.
        /// </summary>
        /// <param name="text">The input string to convert.</param>
        /// <returns>The converted string with the first character in uppercase and the rest in lowercase.</returns>
        public static string ToTitleCase(this string text) => text[..1].ToUpper() + text[1..].ToLower();

        /// <summary>
        /// Adds rich text color formatting to the input string.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="color">The color to apply (e.g., "red", "#FF0000").</param>
        /// <returns>The formatted string with color applied.</returns>
        public static string RichColor(this string text, string color) => $"<color={color}>{text}</color>";

        /// <summary>
        /// Adds rich text size formatting to the input string.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="size">The font size to apply.</param>
        /// <returns>The formatted string with size applied.</returns>
        public static string RichSize(this string text, int size) => $"<size={size}>{text}</size>";

        /// <summary>
        /// Makes the input string bold using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <returns>The formatted string with bold applied.</returns>
        public static string RichBold(this string text) => $"<b>{text}</b>";

        /// <summary>
        /// Makes the input string italic using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <returns>The formatted string with italic applied.</returns>
        public static string RichItalic(this string text) => $"<i>{text}</i>";

        /// <summary>
        /// Adds an underline to the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <returns>The formatted string with underline applied.</returns>
        public static string RichUnderline(this string text) => $"<u>{text}</u>";

        /// <summary>
        /// Adds a strikethrough to the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <returns>The formatted string with strikethrough applied.</returns>
        public static string RichStrikethrough(this string text) => $"<s>{text}</s>";

        /// <summary>
        /// Changes the font of the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="font">The font to apply (e.g., "Arial").</param>
        /// <returns>The formatted string with the specified font applied.</returns>
        public static string RichFont(this string text, string font) => $"<font={font}>{text}</font>";

        /// <summary>
        /// Aligns the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="align">The alignment to apply (e.g., "left", "center", "right").</param>
        /// <returns>The formatted string with the specified alignment applied.</returns>
        public static string RichAlign(this string text, string align) => $"<align={align}>{text}</align>";

        /// <summary>
        /// Applies a gradient color effect to the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="color1">The starting color of the gradient (e.g., "#FF0000").</param>
        /// <param name="color2">The ending color of the gradient (e.g., "#0000FF").</param>
        /// <returns>The formatted string with gradient color applied.</returns>
        public static string RichGradient(this string text, string color1, string color2) => $"<gradient={color1},{color2}>{text}</gradient>";

        /// <summary>
        /// Rotates the input string by a specified angle using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="angle">The angle in degrees to rotate the text.</param>
        /// <returns>The formatted string with rotation applied.</returns>
        public static string RichRotation(this string text, float angle) => $"<rotate={angle}>{text}</rotate>";

        /// <summary>
        /// Adjusts the spacing of the input string using rich text formatting.
        /// </summary>
        /// <param name="text">The input string to format.</param>
        /// <param name="space">The amount of space to apply between characters.</param>
        /// <returns>The formatted string with spacing applied.</returns>
        public static string RichSpace(this string text, float space) => $"<space={space}>{text}</space>";

    }
}
