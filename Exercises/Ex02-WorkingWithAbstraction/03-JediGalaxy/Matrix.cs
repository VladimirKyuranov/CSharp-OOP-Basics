using System;
using System.Linq;

public class Matrix
{
    public static long[][] FillMatrix(string input)
    {
        int[] dimestions = input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = dimestions[0];
        int cols = dimestions[1];
        long[][] matrix = new long[rows][];
        long value = 0;

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new long[cols];
            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = value++;
            }
        }

        return matrix;
    }
}