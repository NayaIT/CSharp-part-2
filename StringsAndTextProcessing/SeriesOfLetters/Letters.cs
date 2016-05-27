/* 23. Series of letters
Description
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Input
On the only input line you will receive a string

Output
Print the string without consecutive identical letters

Constraints
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	                Output
aaaaabbbbbcdddeeeedssaa	abcdedsa
 */

using System;
using System.Text;

namespace SeriesOfLetters
{
    class Letters
    {
        static void Main()
        {
            var text = Console.ReadLine().Trim();
            var output = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                output.Append(letter);

                while (i < text.Length && text[i] == letter)
                {
                    i++;
                }

                i--;
            }

            Console.WriteLine(output);
        }
    }
}
