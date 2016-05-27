/* 03. Correct brackets
Description
Write a program to check if in a given expression the ( and ) brackets are put correctly.

Input
On the only line you will receive an expression

Output
Print Correct if the brackets are correct
Incorrect otherwise

Constraints
1 <= length of expression <= 10000
 */

using System;

namespace CorrectBrackets
{
    class CheckBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(CheckForCorrectBrackets(input));
        }

        private static string CheckForCorrectBrackets(string input)
        {
            
            bool isCorrect = true;
            int openBracketCounter = 0;
            int closeBracketCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketCounter++;
                }
                else if (input[i] == ')')
                {
                    closeBracketCounter++;
                }             
            }

            if (openBracketCounter != closeBracketCounter)
            {
                isCorrect = false;
            }

            return (isCorrect ? "Correct" : "Incorrect");
        }
    }
}