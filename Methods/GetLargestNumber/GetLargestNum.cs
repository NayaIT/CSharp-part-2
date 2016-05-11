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
            GetMax(input);
        }

        public static void GetMax(string input)
        {
            //input = Console.ReadLine();

            var entities = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // splits string with whitespaces into string[]
            var numbers = entities.Select(x => ulong.Parse(x)).ToArray(); // converts string[] to int[]

            //int max = 0;
            var max = numbers[0];
            var b = numbers[1];
            var c = numbers[2];

            if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            }

            //var maxAB = Math.Max(a, b);
            //var maxABC = Math.Max(maxAB, c);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    
            //
            //    //while (numbers[index] > numbers[index + 1])
            //    //{
            //    //     max = numbers[index];
            //    //}
            //}

            Console.WriteLine(max);
            //return; - за void методи

            //return + value; -за всички др методи

        }
    }
}
