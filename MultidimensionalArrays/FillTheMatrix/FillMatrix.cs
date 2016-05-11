/* 01. Fill the matrix
Description
Write a program that fills and prints a matrix of size (n, n) as shown below.

Input
On the first line you will receive the number N
On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix

Output
Print the matrix
Numbers on a row must be separated by a single spacebar
Each row must be on a new line

Constraints
1 <= N <= 128
*/
using System;

namespace FillTheMatrix
{
    class FillMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char inputChar = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int[] numbers = new int[n * n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                //Console.WriteLine(numbers[i]);
            }

            //Array.Sort(numbers);

            //check which case matched 
            if (inputChar == 'a')
            {
                FillMatrixCaseA(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'b')
            {
                FillMatrixCaseB(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'c')
            {
                FillMatrixCaseC(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'd')
            {
                FillMatrixCaseD(matrix);
                PrintTheMatrix(matrix);
            }
        }

        /// <summary>
        /// FillMatrixCaseA - method for case 'a' - normal logic
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="numbers"></param>
        private static void FillMatrixCaseA(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = numbers[index];
                    index++;
                }
            }
        }

        /// <summary>
        /// FillMatrixCaseB - method for case 'b' - Odd & Even logic
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="numbers"></param>
        /// 
        private static void FillMatrixCaseB(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // if row is even fill the matrix in normal order
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[col, row] = numbers[index];
                        index++;
                    }
                }
                // if row is odd fill the matrix in reverse order
                else if (row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[col, row] = numbers[index];
                        index++;
                    }
                }
                
            }
        }

        /// <summary>
        /// FillMatrixCaseC - method for case 'c' - diagonally logic
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="numbers"></param>
        private static void FillMatrixCaseC(int[,] matrix, int[] numbers)
        {
            int index = 0;
            int row = 0;
            int col = 0;

            FillElementsInMatrixTillMainDiagonal(matrix, row, col, ref index, numbers);
            FillElementsInMatrixAfterMainDiagonal(matrix, row, col, ref index, numbers);
        }

        /// <summary>
        /// FillElementsInMatrixTillMainDiagonal - submethod for case 'c'
        /// Help to fill the elements in matrix till the main diagonal
        /// By diagonally logic
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="index"></param>
        /// <param name="numbers"></param>
        private static void FillElementsInMatrixTillMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {
            // fill numbers in the matrix till the main diagonal incl.
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        row = i;
                        col = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;

                    if (row == matrix.GetLength(0) - 1)
                    {
                        break;
                    }

                    row++;
                    col++;
                }
            }
        }

        /// <summary>
        /// FillElementsInMatrixAfterMainDiagonal - submethod for case 'c'
        /// Help to fill the elements in matrix after the main diagonal
        /// By diagonally logic
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="index"></param>
        /// <param name="numbers"></param>
        private static void FillElementsInMatrixAfterMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        col = i;
                        row = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;

                    if (col == matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    row++;
                    col++;
                }
            }
        }

        /// <summary>
        /// FillMatrixCaseD -  method for case 'd' - spiral logic matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="numbers"></param>
        private static void FillMatrixCaseD(int[,] matrix)
        {
            int col = 0;
            int row = 0;
            int direction = 0;
            int side = matrix.GetLength(0);

            int[,] nav =
            {
                { 1, 0 },
                { 0, 1 },
                { -1, 0 },
                { 0, -1 }
            };

            for (int i = 1; i <= side * side; i++)
            {
                matrix[col, row] = i;

                var nextX = col + nav[direction, 0];
                var nextY = row + nav[direction, 1];

                if (nextX == side || nextX == -1 || nextY == side || nextY == -1 || matrix[nextX, nextY] != 0)
                {
                    direction++;
                    direction %= 4;
                }

                col += nav[direction, 0];
                row += nav[direction, 1];
            }
        }

        /// <summary>
        /// Universal method for printing the matrix on the console
        /// </summary>
        /// <param name="matrix"></param>
        private static void PrintTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                        continue;
                    }

                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }  
    }
}
