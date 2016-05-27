/* 06. String length
Description
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.

Input
On the only line you will receive a string

Output
Output a string with length 20

Constraints
The length of the given string will be <= 20
 */

using System;

namespace StringLength
{
    class StrLength
    {
        static void Main()
        {

            var input = Console.ReadLine().Replace(@"\", string.Empty);
            Console.WriteLine(input.Length == 20 ? input : input.PadRight(20, '*'));
        }
    }
}

/*

        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ApendElements(input));
        }

        private static StringBuilder ApendElements(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            //input.PadRight(20, '*'));

            for (int i = input.Length; i < 20; i++)
            {
                //sb.Append('*'); 

                //if (input.Length < 20)
                //{
                //    sb.Append('*');
                //}
            }

            return sb;
        }
*/
