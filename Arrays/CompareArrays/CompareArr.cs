/*02. Compare arrays
Description
Write a program that reads two integer arrays of size N from the console and compares them element by element.

Input
On the first line you will receive the number N
On the next N lines the numbers of the first array will be given
On the next N lines the numbers of the second array will be given

Output
Print Equal if the two arrays are the same and Not equal if they are not

Constraints
1 <= N <= 20
N will always be a valid integer number
 */

using System;

namespace CompareArrays
{
    class CompareArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int index = 0; index < n; index++)
            {
                firstArr[index] = int.Parse(Console.ReadLine());                
            }

            for (int index = 0; index < n; index++)
            {
               secondArr[index] = int.Parse(Console.ReadLine());
            }         

            bool isEqual = true;

            for (int index = 0; index < n; index++)
            {            
                    if (firstArr[index] != secondArr[index])
                    {
                        isEqual = false;
                    }
            }

            Console.WriteLine(isEqual ? "Equal" : "Not equal");
        }
    }
}

//or
//Console.WriteLine(arr1.SequenceEqual(arr2));

//or with only one loop
//for (int i = 0; i < 2 * n; i++)
//{
//    firstArr[i] = int.Parse(Console.ReadLine());
//    secondArr[i] = int.Parse(Console.ReadLine());
//}