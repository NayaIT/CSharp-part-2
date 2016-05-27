/* 02. Enter numbers
Description
Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 0 < a1 < ... < a10 < 100

Input
You will receive 10 lines of input, each consisted of an integer number
a1
a2
...
a10

Output
Print 0 < a1 < ... < a10 < 100
Or Exception if the above inequality is not true
 */
using System;

namespace NewSqrtRoot
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);

                double result = Math.Sqrt(number);

                if (number < 0 || number == 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number");
                }
                else if (number == double.NaN)
                {
                    throw new FormatException("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:F3}", result);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}