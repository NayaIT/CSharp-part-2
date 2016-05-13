/* 04. Appearance count
Description
Write a method that counts how many times given number appears in a given array. Write a test program to check if the method is working correctly.

Input
On the first line you will receive a number N - the size of the array
On the second line you will receive N numbers separated by spaces - the numbers in the array
On the third line you will receive a number X

Output
Print how many times the number X appears in the array

Constraints
1 <= N <= 1024
 */

using System;
using System.Linq;


namespace AppearanceCount
{
    class AppearCount
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            //int[] nArr = new int[n];

            //FillArray(nArr, n);

            int x = int.Parse(Console.ReadLine());

            AppearanceCount(numbers, x);

        }


        //private static void FillArray(int[] arr, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //}


        private static void AppearanceCount(int[] nArr, int x)
        {
            int counter = 0;

            foreach (var element in nArr)
            {
                if (element == x)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
