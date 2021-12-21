using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class CountSquareSubmatricesWithAllOnes
	{
		public int CountSquares(int[][] matrix)
		{
            int count = 0;
            if (matrix == null || matrix.Length == 0) return count;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0) continue;
                    if (i == 0 || j == 0) count++;
                    else
                    {
                        matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i][j - 1], matrix[i - 1][j])) + 1;
                        count += matrix[i][j];
                    }
                }
            }

            return count;
        }
	}
}
