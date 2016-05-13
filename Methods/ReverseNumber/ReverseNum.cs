/* 07. Reverse number
Description
Write a method that reverses the digits of a given decimal number.

Input
On the first line you will receive a number

Output
Print the given number with reversed digits

Constraints
Time limit: 0.1s
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumber
{
    class ReverseNum
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            ReverseDigits(input);
        }

        private static void ReverseDigits(decimal input)
        {
            string inputAsStr = input.ToString();
            
            string output = string.Empty;

            for (int i = inputAsStr.Length - 1; i >= 0; i--)
            {
                output += inputAsStr[i];
            }

            //or second way convert to char array
            //char[] charArr = inputAsStr.ToCharArray();
            //Array.Reverse(charArr);

            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    output += charArr[i];
            //}

            Console.WriteLine(output);
        }
    }
}
