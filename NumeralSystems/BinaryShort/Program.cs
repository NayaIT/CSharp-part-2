/* 08. Binary short
Description
Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

Input
On the only line you will receive a decimal number - N

Output
Print the its binary representation on a single line
There should be exactly 16 digits of output

Constraints
-215 <= N < 215
 */

using System;

namespace BinaryShort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetBinary(short.Parse(Console.ReadLine())));
        }

        static string GetBinary(short s)
        {
            string b = string.Empty;
            for (int i = 0; i < 16; i++) b = (s >> i & 1) + b;
            return b;
        }
    }
}
