/* 01. Decimal to binary
Description
Write a program that converts a decimal number N to its binary representation.

Input
On the only line you will receive a decimal number - N
There will not be leading zeros

Output
Print the binary representation of N on a single line
There should not be leading zeros

Constraints
1 <= N <= 1018
 */

using System;

namespace DecimalToBinary
{
    class DecToBinary
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine()); 

            Console.WriteLine(ConvertDecimalToBinary(n));
        }

        private static string ConvertDecimalToBinary(long input)
        {
            string output = string.Empty;

            while (input != 0) 
            {
               long result = input % 2;
               input /= 2;

               output += result.ToString();
            }

            return ReverseString(output);

            //or
            //string output = Convert.ToString(input, 2);

        }

        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}