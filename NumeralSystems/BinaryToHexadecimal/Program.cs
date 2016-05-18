/* 06. Binary to hexadecimal
Description
Write a program to convert binary numbers to hexadecimal numbers (directly).

Input
On the only line you will receive a decimal number - N
There will not be leading zeros

Output
Print the its binary representation on a single line
There should not be leading zeros
Use uppercase letters

Constraints
1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
 */

using System;
using System.Text;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var binary = new StringBuilder(input);
            bool isNegative = false;
            if (binary[0] == '-')
            {
                isNegative = true;
                binary.Remove(0, 1);
            }

            for (int i = 0, length = binary.Length; i < (4 - length % 4) % 4; i++) //padding leading zeros
            {
                binary.Insert(0, '0');
            }

            var hexadecimal = new StringBuilder();
            var word = new StringBuilder("0000");
            for (int i = 0; i < binary.Length; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    word[j % 4] = binary[j];
                }

                switch (word.ToString())
                {
                    case "0000": hexadecimal.Append('0'); break;
                    case "0001": hexadecimal.Append('1'); break;
                    case "0010": hexadecimal.Append('2'); break;
                    case "0011": hexadecimal.Append('3'); break;
                    case "0100": hexadecimal.Append('4'); break;
                    case "0101": hexadecimal.Append('5'); break;
                    case "0110": hexadecimal.Append('6'); break;
                    case "0111": hexadecimal.Append('7'); break;
                    case "1000": hexadecimal.Append('8'); break;
                    case "1001": hexadecimal.Append('9'); break;
                    case "1010": hexadecimal.Append('A'); break;
                    case "1011": hexadecimal.Append('B'); break;
                    case "1100": hexadecimal.Append('C'); break;
                    case "1101": hexadecimal.Append('D'); break;
                    case "1110": hexadecimal.Append('E'); break;
                    case "1111": hexadecimal.Append('F'); break;
                    default: throw new ArgumentException("Invalid number.");
                }
            }

            if (isNegative)
            {
                hexadecimal.Insert(0, '-');
            }

            Console.WriteLine(hexadecimal);
        }
    }
}