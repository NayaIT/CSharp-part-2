/*10. Find sum in array
Description
Write a program that finds in given array of integers a sequence of given sum S (if present).

Sample tests
array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5

Submission
You do not have to submit anything for this problem
 */

using System;

namespace FindSumInArray
{
    class FindSumInArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int[] ntArr = new int[n];
            

            for (int index = 0; index < n; index++)
            {
                ntArr[index] = int.Parse(Console.ReadLine());
            }

        }
    }
}
