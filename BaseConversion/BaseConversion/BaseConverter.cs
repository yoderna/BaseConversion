//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    Base Conversion
//
//    File Name:    BaseConverter.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    Contains the static class BaseConverter, which contains static functions for
//                  converting from base 10 to another base, and from another base to base 10.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Globalization;

namespace BaseConversion
{
    /// <summary>
    /// Contains static functions for converting between number bases
    /// </summary>
    static class BaseConverter
    {
        /// <summary>
        /// Converts a number from base 10 to another base specified by the user
        /// </summary>
        /// <remarks>
        /// The conversion is performed by repeatedely dividing the number to convert by the base
        /// to convert to, and pushing remainders onto a stack. All remainders are then popped off
        /// the stack and appended to the converted number to produce the result.
        /// </remarks>
        /// <param name="number">A string representing the base-10 number to convert</param>
        /// <param name="baseToConvertTo">The base to convert to (2-16)</param>
        /// <param name="minimumDigits">The minimum number of digits in the string returned</param>
        /// <returns>The number converted to the specified base</returns>
        public static string FromDecimal(string number, int baseToConvertTo, int minimumDigits)
        {
            string convertedNumber = "";

            Stack<uint> remainders = new Stack<uint>();

            uint dividend = uint.Parse(number),
                currDigits = 0;

            while (dividend > 0 || currDigits < minimumDigits)
            {
                remainders.Push((uint)(dividend % baseToConvertTo));

                dividend /= (uint)baseToConvertTo;

                currDigits++;
            }

            // Pop all remainders and append them to the result
            while (remainders.Count > 0)
            {
                convertedNumber += remainders.Pop().ToString("X");
            }

            return convertedNumber;
        }

        /// <summary>
        /// Converts a number from some base specified by the user to base 10
        /// </summary>
        /// <param name="number">The number (as a string) to convert to decimal</param>
        /// <param name="baseOfNum">The base of the number that is being converted</param>
        /// <param name="numPlaces">The number of places to display in the result</param>
        /// <returns>The number converted to base 10.</returns>
        public static uint ToDecimal(string number, int baseOfNum, int numPlaces)
        {
            uint convertedNumber = 0;

            checked
            {
                for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    // convertedNumber += currDigit * base^j, where j is number of positions from right end of string
                    convertedNumber +=
                        (uint.Parse(number[i].ToString(), NumberStyles.HexNumber) *
                        (uint)Math.Pow(baseOfNum, j));
                }
            }

            return convertedNumber;
        }
    }
}
