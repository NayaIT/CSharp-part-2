/* 02. Get largest number
Description
Write a method GetMax() with two parameters that returns the larger of two integers. 
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

Input
On the first line you will receive 3 integers separated by spaces

Output
Print the largest of them
*/
using System;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNum
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //var entities = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // splits string with whitespaces into string[]
            //var numbers = entities.Select(x => ulong.Parse(x)).ToArray(); // converts string[] to int[]
            var numbers = input.Split(' ').Select(s => int.Parse(s)).ToArray();

            int a = (int)numbers[0];
            int b = (int)numbers[1];
            int c = (int)numbers[2];

            //int greaterAB = GetMax(a, b);
            //int result = GetMax(c, greaterAB);

            Console.WriteLine(GetMax(c, GetMax(a, b)));
        }

        public static int GetMax(int n, int m)
        {
            //int max = Math.Max(n, m);
            int max = n;

            if (m > n)
            {
                max = m;
            }

            return max;
        }
    }
}
