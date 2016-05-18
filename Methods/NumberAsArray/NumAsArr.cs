/* 08. Number as array
Description
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
the last digit is kept in arr[0]). Write a program that reads two arrays representing positive integers and outputs their sum.

Input
On the first line you will receive two numbers separated by spaces - the size of each array
On the second line you will receive the first array
On the third line you will receive the second array

Output
Print the sum as an array of digits (as described)
Digits should be separated by spaces

Constraints
Each of the numbers that will be added could have up to 10 000 digits.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberAsArray
{
    class NumAsArr
    {
        //static void Main()
        //{
        //    //int input = int.Parse(Console.ReadLine());

        //    Console.ReadLine();


        //    var listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    var listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    CheckEqualsLists(listOne, listTwo);

        //    Console.WriteLine(string.Join(" ", PrintSumOfDigits(listOne, listTwo)));
        //}

        //private static void CheckEqualsLists(List<int> listOne, List<int> listTwo)
        //{
        //    //var length = listOne.Count;
        //    var listMaxCount = Math.Max(listOne.Count, listTwo.Count);

        //    if (listTwo.Count > listOne.Count)
        //    {
        //        listMaxCount = listTwo.Count;

        //        for (int i = listTwo.Count; i < listMaxCount; i++)
        //        {
        //            listTwo.Add(0);
        //        }
        //    }
        //    else if (listOne.Count < listTwo.Count)
        //    {
        //        listMaxCount = listTwo.Count;

        //        for (int i = listOne.Count; i < listMaxCount; i++)
        //        {
        //            listOne.Add(0);
        //        }
        //    }


        //}

        //private static List<int> PrintSumOfDigits(List<int> listOne, List<int> listTwo)
        //{
        //    var length = listOne.Count;

        //    List<int> sumOfLists = new List<int>();
        //    int reminder = 0;

        //    for (int i = 0; i < length; i++)
        //    {
        //        var sum = listOne[i] + listTwo[i] + reminder;
        //        var sumToAdd = sum % 10;

        //        reminder = (sum - sumToAdd) / 10;

        //        sumOfLists.Add(sumToAdd);
        //    }

        //    return sumOfLists;
        //}

        static void Main()
        {
            Console.ReadLine();
            var first = Console.ReadLine().Split().Select(x => byte.Parse(x)).ToArray();
            var second = Console.ReadLine().Split().Select(x => byte.Parse(x)).ToArray();
            var result = AccumulateTwoNumbers(first, second);
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> AccumulateTwoNumbers(byte[] a, byte[] b)
        {
            var result = new List<int>(Math.Max(a.Length, b.Length));
            int carry = 0;
            for (int i = 0; i < result.Capacity; i++)
            {
                int currentDigit = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
                carry = currentDigit / 10;
                result.Add(currentDigit % 10);
            }

            if (carry == 1)
            {
                result.Add(1);
            }

            return result;
        }
    }
}
