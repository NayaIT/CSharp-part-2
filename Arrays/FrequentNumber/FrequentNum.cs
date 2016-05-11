/*09. Frequent number
Description
Write a program that finds the most frequent number in an array of N elements.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given

Output
Print the most frequent number and how many time it is repeated
Output should be REPEATING_NUMBER (REPEATED_TIMES times)

Constraints
1 <= N <= 1024
0 <= each number in the array <= 10000
There will be only one most frequent number
 */

using System;

namespace FrequentNumber
{
    class FrequentNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nArr);

            int frequentNum = 0;
            int counter = 1;
            int value = 0;

            for (int index = 0; index < nArr.Length - 1; index++)
            {
                if (nArr[index] == nArr[index + 1])
                {
                    counter++;

                    if (counter > frequentNum)
                    {
                        frequentNum = counter;
                        value = nArr[index];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("{0} ({1} times)", value, frequentNum);
        }
    }
}
