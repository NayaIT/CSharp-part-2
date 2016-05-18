/* 14. Integer calculations
Description
Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

Input
On the first line you will receive 5 numbers separated by spaces

Output
Print their minimum, maximum, average, sum and product
Each on a new line
The average value should be printed with two digits of precision

Constraints
Each of the five numbers will be in the interval [ -1000, 1000 ]
 */

using System;
using System.Linq;
using System.Numerics;

namespace IntegerCalculations
{
    class IntCalculations
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            PrintMinMaxAvgProduct(numbers);
        }

        private static void PrintMinMaxAvgProduct(int[] numbers)
        {
            //Array.Sort(numbers);
            int max = numbers.Max();
            int min = numbers.Min();
            double avg = numbers.Average();

            long sum = 0;
            BigInteger product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];
            }

            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", min, max, avg, sum, product);
        }
    }
}
