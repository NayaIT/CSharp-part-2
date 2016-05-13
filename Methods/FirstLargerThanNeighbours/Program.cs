/* 06. First larger than neighbours
Description
Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers sepated by spaces - the array

Output
Print the index of the first element that is larger than its neighbours or -1 if none are

Constraints
1 <= N <= 1024
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class Program
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
            int firstElement = 0;

            for (int index = 1; index < numbers.Count - 1; index++)
            {
                if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                {
                    firstElement = index;
                    break;
                }
            }

            return firstElement;
        }
    }
}
