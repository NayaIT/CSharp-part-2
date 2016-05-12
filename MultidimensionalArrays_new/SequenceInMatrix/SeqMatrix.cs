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


/* 70p - some problem with the diagonal check

namespace SequenceInMatrix
{
    using System;
    using System.Linq;

    class SeqMatrix
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var entities = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // splits string with whitespaces into string[]
            var numbers = entities.Select(x => ulong.Parse(x)).ToArray(); // converts string[] to int[] or //input.Split(' ').Select(z => Convert.ToInt32(z)).ToArray();

            int n = (int)numbers[0];
            int m = (int)numbers[1];

            int[,] matrix = new int[n, m];

            //int[] elements = new int[n * m];

            FillTheElementsInMatrix(matrix, n);
            PrintTheLengthOfLongestSequence(matrix, n, m);
        }

        /// <summary>
        /// FillTheElementsInMatrix - method created to read the elements in the matrix[n, m] from the console
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="num"></param>
        private static void FillTheElementsInMatrix(int[,] mat, int num)
        {
            for (int row = 0; row < num; row++)
            {
                var text = Console.ReadLine();
                var result = text
                                 .Split(' ')
                                 .Select(z => Convert.ToInt32(z))
                                 .ToArray();

                for (int col = 0; col < result.Length; col++)
                {
                    mat[row, col] = result[col];
                }
            }
        }

        /// <summary>
        /// PrintTheLengthOfLongestSequence - method created to find and print the length of the longest sequence of equal equal strings in the matrix[n,m]
        /// </summary>
        /// <param name="matrix"></param>
        private static void PrintTheLengthOfLongestSequence(int[,] matrix, int n, int m)
        {
            //check by row
            int rowsSequenceCounter = 1;
            int rowsMaxLen = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        rowsSequenceCounter++;
                        //maxLen = Math.Max(counter, maxLen);
                    }     
                }

                if (rowsSequenceCounter > rowsMaxLen)
                {
                    rowsMaxLen = rowsSequenceCounter;
                }

                rowsSequenceCounter = 1;
            }

            //check by col
            int colsSequenceCounter = 1;
            int colsMaxLen = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        colsSequenceCounter++;
                    }
                }

                if (colsSequenceCounter > colsMaxLen)
                {
                    colsMaxLen = colsSequenceCounter;
                }

                colsSequenceCounter = 1;
            }

            //check by right diagonal
            int rightDiagonalSeqCount = 1;
            int rightDiagonalMaxLen = 0;

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (col >= m - 1 || row >= n - 1)
                {
                    break;
                }
                else
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        rightDiagonalSeqCount++;
                    }

                    if (rightDiagonalSeqCount > rightDiagonalMaxLen)
                    {
                        rightDiagonalMaxLen = rightDiagonalSeqCount;
                    }

                    rightDiagonalSeqCount = 1;
                }
            }

            //check by left diagonal
            int leftDiagonalSeqCount = 1;
            int leftDiagonalMaxLen = 0;

            for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col >= 0; row++, col--)
            {
                if (col <= 0 || row >= n - 1)
                {
                    break;
                }
                else
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        leftDiagonalSeqCount++;
                    }

                    if (leftDiagonalSeqCount > leftDiagonalMaxLen)
                    {
                        leftDiagonalMaxLen = leftDiagonalSeqCount;
                    }

                    leftDiagonalSeqCount = 1;
                }
            }

            int[] maxLengthArr = new int[4];
            maxLengthArr [0] = rowsMaxLen;
            maxLengthArr [1] = colsMaxLen;
            maxLengthArr [2] = rightDiagonalMaxLen;
            maxLengthArr[3] = leftDiagonalMaxLen;

            int maxLen = maxLengthArr.Max();

            Console.WriteLine(maxLen);
        }

    }
}
*/