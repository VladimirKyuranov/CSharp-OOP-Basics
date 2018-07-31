using System;
using System.Linq;

class JediGalaxy
{
    static void Main(string[] args)
    {
        long[][] matrix = Matrix.FillMatrix(Console.ReadLine());

        long sum = 0;
        string command;

        while ((command = Console.ReadLine()) != "Let the Force be with you")
        {
            int[] ivoStartPosition = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] evilStartPosition = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int ivoRow = ivoStartPosition[0];
            int ivoCol = ivoStartPosition[1];
            int evilRow = evilStartPosition[0];
            int evilCol = evilStartPosition[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (ValidPosition(evilRow, evilCol, matrix.Length, matrix[0].Length))
                {
                    matrix[evilRow][evilCol] = 0;
                }

                evilRow--;
                evilCol--;
            }

            while (ivoRow >= 0 && ivoCol < matrix[0].Length)
            {
                if (ValidPosition(ivoRow, ivoCol, matrix.Length, matrix[0].Length))
                {
                    sum += matrix[ivoRow][ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }
        }

        Console.WriteLine(sum);
    }

    public static bool ValidPosition(int row, int col, int rows, int cols)
    {
        return row >= 0 && row < rows && col >= 0 && col < cols;
    }
}