/* 05. Larger than neighbours
Description
Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers separated by spaces - the array

Output
Print how many numbers in the array are larger than their neighbours

Constraints
1 <= N <= 1024
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LargerThanNeighbours
{
    class LargerNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // try with array
            List<int> numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            Console.WriteLine(CheckForLargerElemntsThanNeighbours(numbers));
        }

        private static int CheckForLargerElemntsThanNeighbours(List<int> numbers)
        {
            //int currentElement = 1;
            int counter = 0;

            for (int index = 1; index < numbers.Count - 1; index++)
            {
                int currentElement = numbers[index];

                if (currentElement > numbers[index - 1] && currentElement > numbers[index + 1])
                {
                    counter++;
                }
            }

            return counter; 

           //Console.WriteLine(counter);
        }
    }
}

/*
class LargerNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(CheckForLargerElemntsThanNeighbours(numbers));
        }

        private static int CheckForLargerElemntsThanNeighbours(int[] numbers)
        {
            //int currentElement = 1;
            int counter = 0;

            for (int index = 0; index <= numbers.Length - 1; index++)
            {
                int currentElement = numbers[index];

                if (currentElement > numbers[index - 1] && currentElement > numbers[index + 1])
                {
                    counter++;
                }
            }

            return counter; 

           // Console.WriteLine(counter);
        }
    }
}
*/