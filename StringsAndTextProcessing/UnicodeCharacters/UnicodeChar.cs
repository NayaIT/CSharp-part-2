/* 10. Unicode characters
Description
Write a program that converts a string to a sequence of C# Unicode character literals.

Input
On the only input line you will receive a string

Output
Print the string in C# Unicode character literals on a single line

Constraints
Time limit: 0.1s
 */

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < input.Length; i++)
        {
            answer.AppendFormat("\\u{0:X4}", (int)input[i]);
        }

        Console.WriteLine(answer.ToString());
    }
}

/*
    var input = Console.ReadLine();
    var sb = new StringBuilder();

    foreach (var letter in input)
    {
        sb.AppendFormat(@"\u{0:x4}", (int)letter);
    }

    Console.WriteLine(sb);
*/