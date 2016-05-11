/* 01. Allocate array
Description
Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

Input
On the only line you will receive the number N

Output
Print the obtained array on the console.
Each number should be on a new line

Constraints
1 <= N <= 20
N will always be a valid integer number */

namespace AllocateArray
{
    using System;

    class AllocateArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                var element = i * 5;

                Console.WriteLine(element);
            }
        }
    }
}