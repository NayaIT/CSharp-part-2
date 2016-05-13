/* 03. English digit
Description
Write a method that returns the last digit of given integer as an English word. Write a program that reads a number and prints the result of the method.

Input
On the first line you will receive a number

Output
Print the last digit of the number as an English word

Constraints
Time limit: 0.1s
 */


namespace EnglishDigit
{
    using System;

    class EnDigit
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            IntAsEnglishLetter(input);

        }

        private static void IntAsEnglishLetter(long input)
        {
            var lastDigit = 0;

            lastDigit = (int)input % 10;

            string[] digitsAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            
            string output = string.Empty;

            for (int i = 0; i < digitsAsWords.Length; i++)
            {
                if (lastDigit == i)
                {
                    output = digitsAsWords[i];
                }
            }    
           /* 2nd way with swich - case statement, but is slower than array with for-loop
                switch (lastDigit)
                {
                    case 0:
                        {
                            output = "zero";
                            break;
                        }
                    case 1:
                        {
                            output = "one";
                            break;
                        }
                    case 2:
                        {
                            output = "two";
                            break;
                        }
                    case 3:
                        {
                            output = "three";
                            break;
                        }
                    case 4:
                        {
                            output = "four";
                            break;
                        }
                    case 5:
                        {
                            output = "five";
                            break;
                        }
                    case 6:
                        {
                            output = "six";
                            break;
                        }
                    case 7:
                        {
                            output = "seven";
                            break;
                        }
                    case 8:
                        {
                            output = "eight";
                            break;
                        }
                    case 9:
                        {
                            output = "nine";
                            break;
                        }
                }
            */

                Console.WriteLine(output);
            
        }
    }
}
