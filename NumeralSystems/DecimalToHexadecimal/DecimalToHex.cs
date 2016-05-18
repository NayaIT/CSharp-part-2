/* 03. Decimal to hexadecimal
Description
Write a program that converts a decimal number N to its hexadecimal representation.

Input
On the only line you will receive a decimal number - N
There will not be leading zeros

Output
Print the hexadecimal representation of N on a single line
There should not be leading zeros
Use uppercase letters

Constraints
1 <= N <= 1018
 */


using System;
using System.Text;

namespace DecimalToHexadecimal
{
    class DecimalToHex
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            Console.WriteLine(ConvertDecimalToHex(input));

        }

        private static StringBuilder ConvertDecimalToHex(long input)
        {
            StringBuilder sb = new StringBuilder();

            while (input != 0)
            {
                var hex = input % 16;
                input /= 16;

                sb.Insert(0, hex.ToString("X"));
            }

            return sb;
        }
    }
}
