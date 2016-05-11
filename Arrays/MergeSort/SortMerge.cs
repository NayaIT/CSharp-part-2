/*13. Merge sort
Description
Write a program that sorts an array of integers using the Merge sort algorithm.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the sorted array
Each number should be on a new line

Constraints
1 <= N <= 1024
 */

using System;

namespace MergeSort
{
    class SortMerge
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int[] tmp = new int[n];

            

            MergeSort(nums, tmp, 0, nums.Length - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            
        }

        static void MergeSort(int[] elements, int[] temp, int start, int end)
        {
            if (start >= end)
            {
                return;  // Array with 1 element
            }

            int middle = start + (end - start) / 2; // Define a middle of the array

            MergeSort(elements, temp, start, middle);
            MergeSort(elements, temp, middle + 1, end);
            CompareAndSort(elements, temp, start, middle, end);
        }

        static void CompareAndSort(int[] elements, int[] temp, int start, int middle, int end)
        {
            int i = start; // 'temp' index
            int l = start, m = middle + 1; // 'elements' indexes

            while (l <= middle && m <= end)
            {
                temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];
            }

            while (l <= middle)
            {
                temp[i++] = elements[l++];
            }

            while (m <= end)
            {
                temp[i++] = elements[m++];
            }

            for (int j = start; j <= end; j++)
            {
                elements[j] = temp[j];
            }

        }
    }
}
