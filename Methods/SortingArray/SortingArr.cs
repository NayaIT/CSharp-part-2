/* 09. Sorting array
Description
Write a method that returns the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers separated by spaces - the array

Output
Print the sorted array
Elements must be separated by spaces

Constraints
1 <= N <= 1024
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingArray
{
    class SortingArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            PrintSortedArray(numbers);

        }

        private static void PrintSortedArray(int[] numbers)
        {
            Array.Sort(numbers);

            //descending order
            //Array.Reverse(numbers);
            //Array.Sort(numbers);
            string output = string.Empty;

            for (int index = 0; index < numbers.Length; index++)
            {
                output += numbers[index] + " ";
            }

            Console.WriteLine(output);
        }
    }
}
