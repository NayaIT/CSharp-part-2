/*02. Maximal sum
Description
Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
Print that sum.

Input
On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix

Output
Print the maximal sum of 3 x 3 square

Constraints
3 <= N, M <= 1024
Numbers in the matrix will be in the interval [ -1000, 1000 ]
 */

using System;
using System.Linq;
namespace MaximalSum
{
    class MaxSum
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
            FindMaxSum(matrix);          
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
        /// FindMaxSum - method created to find the maximal sum of 3 x 3 square in the matrix[n, m]
        /// </summary>
        /// <param name="mat"></param>
        private static void FindMaxSum(int[,] mat)
        {
            int maxSum = int.MinValue;
            int sum = 0;

            for (int row = 0; row < mat.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < mat.GetLength(1) - 2; col++)
                {
                    sum = mat[row, col] + mat[row, col + 1] + mat[row, col + 2]
                            + mat[row + 1, col] + mat[row + 2, col] + mat[row + 1, col + 1] + mat[row + 2, col + 2]
                            + mat[row + 1, col + 2] + mat[row + 2, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            //print max sum
            Console.WriteLine(maxSum);
        }
    }
}
