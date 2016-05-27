/* 05. Parse tags
Description
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.

Input
On the only line you will receive a string - the text

Output
Print the changed string on one line

Constraints
The tags will not be nested.
String length will be <= 10000
 */

using System;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTag
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ParseTags(input));
        }

        private static string ParseTags(string input)
        {
            string output = string.Empty;

            output = Regex.Replace(input, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());

            return output;
        }
    }
}
