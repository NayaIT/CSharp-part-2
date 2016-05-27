/* 08. Extract sentences
Description
Write a program that extracts from a given text all sentences containing given word.

Input
On the first line you will receive a string - the word
On the second line you will receive a string - the text

Output
Print only the sentences containing the word on a single line

Constraints
Sentences are separated by . and the words – by non-letter symbols
 */

using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        var sentences = text.Split('.');

        var result = new StringBuilder();

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(new[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (Array.IndexOf(words, word) > -1)
            {
                result.Append(sentence.Trim());
                result.Append(". ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}