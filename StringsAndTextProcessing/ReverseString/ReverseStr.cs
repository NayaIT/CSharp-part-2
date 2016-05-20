/* 02. Reverse string
Description
Write a program that reads a string, reverses it and prints the result on the console.

Input
On the only line you will receive a string

Output
Print the string in reverse on a single line

Constraints
1 <= size of string <= 10000
 */

using System;

namespace ReverseString
{
    class ReverseStr
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(RevereseString(input));
        }

        private static string RevereseString(string input)
        {
            string output = string.Empty;

            for (int index = input.Length - 1; index >= 0; index--)
            {
                output += input[index];
            }

            return output;
        }
    }
}
