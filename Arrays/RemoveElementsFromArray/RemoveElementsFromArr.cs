/*18. Remove elements from array
Description
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the 
remaining array is sorted in increasing order. Print the minimal number of elements that need to be removed in order for the
array to become sorted.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the minimal number of elements that need to be removed

Constraints
1 <= N <= 1024
*/

using System;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }        

            int[] lengths = new int[n];

            for (int index = 0; index < n; index++)
            {
                lengths[index] = 1;
            }

            int max = 1;

            for (int j = 1; j < n; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    if (nArr[j] >= nArr[k] && lengths[j] <= lengths[k] + 1)
                    {
                        lengths[j] = lengths[k] + 1;

                        if (max < lengths[j])
                        {
                            max = lengths[j];
                        }
                    }
                }
            }

            Console.WriteLine(n - max);
        }
    }
}
