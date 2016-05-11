/*06. Maximal K sum
Description
Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find the maximal sum of K elements in the array.

Input
On the first line you will receive the number N
On the second line you will receive the number K
On the next N lines the numbers of the array will be given

Output
Print the maximal sum of K elements in the array

Constraints
1 <= N <= 1024
1 <= K <= N
 */

using System;

namespace MaximalKSum
{
    class MaxKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var sum = 0;

            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nArr);
            Array.Reverse(nArr);
            
            for (int i = 0; i < k; i++)
            {
                sum += nArr[i];
            }

            Console.WriteLine(sum);
        }
    }
}

//or without Reverse
//for (int i = length - 1; i >= 0; i--)
//{
//
//}