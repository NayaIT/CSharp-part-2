/* 04. Hexadecimal to decimal
Description
Write a program that converts a hexadecimal number N to its decimal representation.

Input
On the only line you will receive a hexadecimal number - N
There will not be leading zeros
Letters will be uppercase

Output
Print the decimal representation of N on a single line
There should not be leading zeros

Constraints
1 <= N <= 1018 = DE0B6B3A7640000(16)
 */
using System;

namespace HexadecimalToDecimal
{
    class HexadecimalToDec
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ConvertHexadecimalToDecimal(input));
        }

        private static long ConvertHexadecimalToDecimal(string input)
        {
            long result = 0;

            for (int index = 0; index < input.Length; index++)
            {
                var digit = input[index];
                int symbol;

                switch (digit)
                {

                    case 'A':
                        {
                            symbol = 10;
                            break;
                        }

                    case 'B':
                        {
                            symbol = 11;
                            break;
                        }

                    case 'C':
                        {
                            symbol = 12;
                            break;
                        }

                    case 'D':
                        {
                            symbol = 13;
                            break;
                        }

                    case 'E':
                        {
                            symbol = 14;
                            break;
                        }

                    case 'F':
                        {
                            symbol = 15;
                            break;
                        }
                    default:
                        {   // -48 because of ASCII table
                            symbol = (int)char.GetNumericValue(digit);
                            break; 
                        }
                        
                }

                result += (long)Math.Pow(16, input.Length - 1 - index) * symbol;
            }

            return result;
        }
    }
}
