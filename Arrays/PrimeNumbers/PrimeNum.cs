/* 15. Prime numbers
Description
Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. 
The program should print the biggest prime number which is <= N.

Input
On the first line you will receive the number N

Output
Print the biggest prime number which is <= N

Constraints
2 <= N <= 10 000 000
*/

using System;

namespace PrimeNumbers
{
    class PrimeNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var isPrime = new byte[n + 1];
            var biggestPrime = 0;

            for (int index = 2; index <= n; index++)
            {
                if (isPrime[index] == 0)
                {
                    biggestPrime = index;

                    for (int j = index * 2; j <= n; j += index)
                    {
                        isPrime[j] = 1;
                    }
                }
            }

            Console.WriteLine(biggestPrime);
        }
    }
}
