/* 08. Number as array
Description
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Write a program that reads two arrays representing positive integers and outputs their sum.

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
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        }
    }
}
