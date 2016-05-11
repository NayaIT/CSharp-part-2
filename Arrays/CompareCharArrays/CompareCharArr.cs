/*03. Compare char arrays
Write a program that compares two char arrays lexicographically (letter by letter).

Input
On the first line you will receive the first char array as a string
On the second line you will receive the second char array as a string

Output
Print < if the first array is lexicographically smaller
Print > if the second array is lexicographically smaller
Print = if the arrays are equal

Constraints
1 <= size of arrays <= 128
 */


using System;

namespace CompareCharArrays
{
    class CompareCharArr
    {
        static void Main()
        {

            string first = Console.ReadLine();
            string second = Console.ReadLine();

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    return;
                }
            }

            if (first.Length == second.Length)
            {
                Console.WriteLine("=");
            }
            else if (first.Length > second.Length)
            {
                Console.WriteLine(">");
            }
            else if (first.Length < second.Length)
            {
                Console.WriteLine("<");
            }
            
        }
    }
}