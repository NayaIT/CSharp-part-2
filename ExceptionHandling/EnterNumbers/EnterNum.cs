/* 01. Square root
Description
Write a program that reads a number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye. Use try-catch-finally block.

Input
On the only line you will receive a real number

Output
Print the square root of the number or Invalid number on the first line
Use 3 digits of precision
Print Good bye on the second line
 */
using System;

namespace EnterNumbers
{
    class EnterNum
    {
        static void Main()
        {
            int[] arr = new int[12];

            arr[0] = 1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            arr[11] = 100;

            for (int i = 0; i < 9; i++)
            {   
                if (ReadNumber(arr[i], arr[i + 1]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }
            
            Console.WriteLine(string.Join(" < ", arr));
        }

        static bool ReadNumber(int start, int end)
        {
            if (start < end)
            {
                return true;
            }

            return false;
        }
    }
}