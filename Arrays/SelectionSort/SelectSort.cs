/*07. Selection sort
Description
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
from the rest, move it at the second position, etc.

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

namespace SelectionSort
{
    class SelectSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            var length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minPosition, temp;

            for (int i = 0; i < length - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minPosition])
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    temp = arr[i];
                    arr[i] = arr[minPosition];
                    arr[minPosition] = temp;
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            // 2nd way
            // Array.Sort(arr);
            // 
            // for (int i = 0; i < length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }
        }
    }
}
