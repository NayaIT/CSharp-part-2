/* 10. N Factorial
Description
Write a method that multiplies a number represented as an array of digits by a given integer number. Write a program to calculate N!.

Input
On the first line you will receive the number N

Output
Print N!

Constraints
0 <= N <= 100
 */

using System;
using System.Numerics;

namespace NFactorial
{
    class NFact
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateNFactorial(n));
        }

        private static BigInteger CalculateNFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}