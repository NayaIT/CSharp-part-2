/* 04. Sub-string in text
Description
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Input
On the first line you will receive a string - the pattern
On the second line you will receive a string - the text

Output
Print a number on a single line
The number of occurrences

Constraints
The length of the two strings will be <= 4096
 */

using System;

namespace SubStringInText
{
    class SubStringTxt
    {
        static void Main()
        {
            string subStr = Console.ReadLine();
            string input = Console.ReadLine();

            Console.WriteLine(SubStringCounter(subStr, input));
        }

        private static int SubStringCounter(string subStr, string input)
        {
            int counter = 0;

            for (int i = 0; i <= input.Length - subStr.Length; i++)
            {
                if (input.Substring(i, subStr.Length).Equals(subStr, StringComparison.InvariantCultureIgnoreCase)) // case insensitive
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}