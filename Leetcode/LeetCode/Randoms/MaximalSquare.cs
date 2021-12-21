using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class MaximalSquare_
	{
		public int MaximalSquare(char[][] matrix)
		{
			if (matrix == null || matrix.Length == 0) return 0;
			int rows = matrix.Length;
			int columns = matrix[0].Length;
			int max = 0;			

			if (columns == 1)
			{
				for (int i = 0; i < rows; i++)
					if (matrix[i][0] == '1') return 1;
			}
			else if (rows == 1)
			{
				for (int j = 0; j < columns; j++)
					if (matrix[0][j] == '1') return 1;
			}
			else
			{
				var intMatrix = new int[rows, columns];
				for (int i = 0; i < rows; i++)
					if (matrix[i][0] == '1')
					{
						intMatrix[i, 0] = 1;
						max = 1;
					}

				for (int j = 0; j < columns; j++)
					if (matrix[0][j] == '1')
					{
						intMatrix[0, j] = 1;
						max = 1;
					}

				for (int i = 1; i < rows; i++)
				{
					for (int j = 1; j < columns; j++)
					{
						if (matrix[i][j] == '1')
						{
							intMatrix[i, j] = Math.Min(intMatrix[i - 1, j - 1],
								Math.Min(intMatrix[i - 1, j], intMatrix[i, j - 1])) + 1;

							if (max < intMatrix[i, j]) max = intMatrix[i, j];
						}
					}
				}
			}

			return max * max;
		}
	}
}
