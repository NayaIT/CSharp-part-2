/* 02. Binary to decimal
Description
Write a program that converts a binary number N to its decimal representation.

Input
On the only line you will receive a binary number - N
There will not be leading zeros

Output
Print the decimal representation of N on a single line
There should not be leading zeros

Constraints
1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
*/

using System;

namespace BinaryToDecimal
{
    class BinaryToDec
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ConvertBinaryToDecimal(input));
        }

        private static long ConvertBinaryToDecimal(string binary)
        {
            long result = 0;

            for (int index = 0; index < binary.Length; index++)
            {
                var digit = binary[index];

                if (digit == '0')
                {
                    continue;
                }

                result += (long)Math.Pow(2, binary.Length - 1 - index);
            }

            return result;

            //or 2nd way
            //Console.WriteLine(Convert.ToInt32(input, 2).ToString());

            //or 3rd way
            //Console.WriteLine(Convert.ToInt64(input, 2));
        }
    }
}
