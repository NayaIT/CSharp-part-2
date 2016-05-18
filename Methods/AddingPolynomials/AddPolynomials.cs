/* 11. Adding polynomials
Description
Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials
and prints their sum.

Input
On the first line you will receive the number N
On the second line you will receive the first polynomial as coefficients separated by spaces
On the third line you will receive the second polynomial as coefficients separated by spaces

Output
Print the sum of the polynomials

Constraints
1 <= N <= 1024
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace AddingPolynomials
{
    class AddPolynomials
    {
        static void Main()
        {

            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            var listOne = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            var listTwo = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            Console.WriteLine(string.Join(" ", PrintSumOfDigits(listOne, listTwo)));
        }

        private static List<int> PrintSumOfDigits(List<int> listOne, List<int> listTwo)
        {
            var length = listOne.Count;

            List<int> sumOfLists = new List<int>();

            for (int i = 0; i < length; i++)
            {
                var sum = listOne[i] + listTwo[i];

                sumOfLists.Add(sum);
            }

            return sumOfLists;
        }
    }
}

