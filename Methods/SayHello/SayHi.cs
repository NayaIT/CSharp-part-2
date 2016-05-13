/*
Description
Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

Input
On the first line you will receive a name

Output
Print Hello, <name>!
 */

using System;

namespace SayHello
{
    class SayHi
    {
        static void Main()
        {
            AskForName();
        }

        public static void AskForName()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}
