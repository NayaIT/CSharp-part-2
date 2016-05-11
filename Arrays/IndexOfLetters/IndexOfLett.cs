/*12. Index of letters
Description
Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.

Input
On the first line you will receive the word

Output
Print the index of each of the word's letters in the array
Each index should be on a new line

Constraints
1 <= word length <= 128
Word is consisted of lowercase english letters
 */

using System;

namespace IndexOfLetters
{
    class IndexOfLett
    {
        static void Main()
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] word = Console.ReadLine().ToCharArray();

            int index;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        index = j;
                        Console.WriteLine(index); //(string.Join("", i));
                    }
                }
            }
        }
    }
}
