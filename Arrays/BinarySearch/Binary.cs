/* 11. Binary search
Description
Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
On the last line you will receive the number X

Output
Print the index where X is in the array
If there is more than one occurence print the first one
If there are no occurences print -1

Constraints
1 <= N <= 1024
 */

using System;

namespace BinarySearch
{
    class Binary
    {
        static void Main()
        {
            // N numbers of element
            int n = int.Parse(Console.ReadLine());

            //the input array
            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }

            //the target number X
            int x = int.Parse(Console.ReadLine());

            Array.Sort(nArr);

            //Array.BinarySearch<>;
            Console.WriteLine(BinarySurchArr(nArr, x));
        }

        public static int BinarySurchArr(int[] nArr, int element)
        {
            
            int min = 0;
            int max = nArr.Length - 1;

            do
            {
                int middle = (min + max) / 2;

                if (element > nArr[middle])
                {
                    min = middle + 1;
                }
                else if (element < nArr[middle])
                {
                    max = middle - 1;
                }
                else if (element == nArr[middle])
                {
                    return middle;
                }
            } while (min <= max);

            return -1;
        }
    }
}

/* or second way          
            for (int i = 0; i < nArr.Length; i++)
            {
                if (nArr[i] == x)
                {
                    position = i;
                    break;
                }
                else if (nArr[i] != x)
                {
                    position = -1;
                }
            }

            Console.WriteLine(position);

*/
