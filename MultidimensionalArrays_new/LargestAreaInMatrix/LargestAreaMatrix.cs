/* 07. Largest area in matrix
Description
Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

Input
On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix

Output
Print the size of the lasrgest area of equal neighbour elements

Constraints
3 <= N, M <= 1024
 */

using System;
namespace LargestAreaInMatrix
{
    class LargestAreaMatrix
    {


        private static bool[,] visited;
        private static short[,] matrix;
        private static short maxCountEqualElements = 0;
        private static short currentCountEqualNeighbourElements = 0;
        private static short rows; // matrix.GetLength(0)
        private static short cols; // matrix.GetLength(1)

        static void Main()
        {
            // Read the matrix dimensions
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            rows = short.Parse(input[0]);
            cols = short.Parse(input[1]);

            // Create (Allocate) the matrix
            matrix = new short[rows, cols];

            // Enter the matrix elements
            for (short row = 0; row < rows; row++) // rows = matrix.GetLength(0);  
            {
                string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (short col = 0; col < cols; col++) //cols = matrix.GetLength(1);
                {
                    matrix[row, col] = short.Parse(inputRows[col]);
                }
            }

            // the bool matrix
            visited = new bool[rows, cols];

            // Find the largest area of equal neighbour elements
            for (short i = 0; i < rows; i++)
            {
                for (short j = 0; j < cols; j++)
                {
                    FindLargestArea(i, j, matrix[i, j]);

                    if (maxCountEqualElements < currentCountEqualNeighbourElements)
                    {
                        maxCountEqualElements = currentCountEqualNeighbourElements;
                    }

                    currentCountEqualNeighbourElements = 0;
                }
            }

            // Output
            Console.WriteLine(maxCountEqualElements);
        }

        /// <summary>
        /// FindLargestArea - method created to find the largest area of equal neighbour elements in a rectangular matrix[n,m]
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="currentElement"></param>
        private static void FindLargestArea(short row, short col, short currentElement)
        {
            //returns if we are out of the matrix or the element is not the same
            if ((row < 0) || (row >= rows)
                || (col < 0) || (col >= cols)
                || currentElement != matrix[row, col])
            {
                return;
            }


            if (visited[row, col])
            {
                return;
            }


            visited[row, col] = true;

            currentCountEqualNeighbourElements++;

            FindLargestArea((short)(row - 1), col, currentElement); // up
            FindLargestArea((short)(row + 1), col, currentElement); // down    
            FindLargestArea(row, (short)(col - 1), currentElement); // left        
            FindLargestArea(row, (short)(col + 1), currentElement); // right  
        }

    }
}
