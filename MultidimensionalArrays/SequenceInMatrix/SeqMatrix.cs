/*03. Sequence in matrix
Description
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

Input
On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M strings separated with spaces - the strings in the matrix

Output
Print the length of the longest sequence of equal equal strings in the matrix

Constraints
3 <= N, M <= 128
 */

using System;

class SequenceInMatrix
{
    

    static readonly int[,] changes = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };

    static void Main()
    {
        // Read the matrix dimensions
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        // Create (Allocate) the matrix
        string[,] matrix = new string[n, m];

        // Enter the matrix elements
        for (int row = 0; row < n; row++)
        {
            string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = inputRows[col];
            }
        }

        int maxLength = 0;
        string equalElement = string.Empty;
        FindLongestSequence(matrix, ref equalElement, ref maxLength);

        // Output
        Console.WriteLine(maxLength);
    }

    /// <summary>
    /// FindLongestSequence - method created to find and print the length of the longest sequence of equal equal strings in the matrix[n,m]
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="equalElement"></param>
    /// <param name="maxLength"></param>
    static void FindLongestSequence(string[,] matrix, ref string equalElement, ref int maxLength)
    {
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                int direction = -1;

                while (++direction < 4)
                {
                    int currentRow = row + changes[direction, 0];
                    int currentCol = col + changes[direction, 1];

                    int currentLength = 1;

                    while (InRangeAndEqual(matrix, row, col, currentRow, currentCol))
                    {
                        currentLength++;

                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            equalElement = matrix[row, col];
                        }

                        currentRow += changes[direction, 0];
                        currentCol += changes[direction, 1];
                    }
                }

            }
        }
    }

    static bool InRangeAndEqual(string[,] matrix, int row, int col, int currRow, int currCol)
    {
        return currRow >= 0 && currRow < matrix.GetLongLength(0) 
            && currCol >= 0 && currCol < matrix.GetLongLength(1)
            && matrix[currRow, currCol] == matrix[row, col];
    }

}