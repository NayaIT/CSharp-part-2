/*05. Maximal increasing sequence
Description
Write a program that finds the length of the maximal increasing sequence in an array of N integers.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the length of the maximal increasing sequence

Constraints
1 <= N <= 1024
 */

using System;

namespace MaximalIncreasingSequence
{
    class MaxIncreasingSeq
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            var length = arr.Length;

            for (int index = 0; index < length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int maxSequence = 0;

            for (int i = 1; i < length; i++) 
            {
                if (arr[i - 1] < arr[i])
                {
                    counter++;
                    maxSequence = Math.Max(counter, maxSequence);
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
