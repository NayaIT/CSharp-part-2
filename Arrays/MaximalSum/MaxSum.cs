/*08. Maximal sum
Description
Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

Can you do it with only one loop (with single scan through the elements of the array)?

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the maximal sum of consecutive numbers

Constraints
1 <= N <= 1024
*/

using System;

namespace MaximalSum
{
    class MaxSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sum = 0;
            var maxSum = int.MinValue;

            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());

                sum += nArr[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                else if (sum < nArr[i])
                {
                    sum = nArr[i];
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
