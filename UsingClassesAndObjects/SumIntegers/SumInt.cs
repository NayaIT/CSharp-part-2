/* 08. Sum integers
Description
You are given a sequence of positive integer values written into a string, separated by spaces. 
Write a function that reads these values from given string and calculates their sum.
Write a program that reads a string of positive integers separated by spaces and prints their sum.

Input
On the only line you will receive a string consisted of positive integers

Output
Print the sum of the integers

Constraints
Each number will be in the interval [ 1, 1000 ]
There will not be more than 1000 numbers
 */


using System;
using System.Linq;

namespace SumIntegers
{
    class SumInt
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            Console.WriteLine(sum);

            //2nd way
            //Console.WriteLine(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray().Sum());
        }
    }
}
