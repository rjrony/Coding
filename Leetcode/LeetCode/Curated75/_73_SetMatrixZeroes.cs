using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _73_SetMatrixZeroes
	{
		public void SetZeroes(int[][] matrix)
		{
			var cols = new HashSet<int>();
			for (int i = 0; i < matrix.Length; i++)
			{
				var rowContainsZero = false;
				for (int j = 0; j < matrix[0].Length; j++)
				{
					if (matrix[i][j]==0)
					{
						cols.Add(j);
						rowContainsZero = true;
					}
				}

				if (rowContainsZero)
				{
					for (int j = 0; j < matrix[0].Length; j++)
					{
						matrix[i][j] = 0;
					}
				}
			}

			foreach (var item in cols)
			{
				for (int i = 0; i < matrix.Length; i++)
				{
					matrix[i][item] = 0;
				}
			}
		}

		public void Test()
		{
			//[[1,1,1],[1,0,1],[1,1,1]]
			//Output: [[1, 0, 1],[0,0,0],[1,0,1]]

			var matrix = new int[][] {
					new int[] { 1,1,1 },
					new int[] { 1,0,1},
					new int[] { 1, 1, 1 }
			};

			SetZeroes(matrix);

			foreach (var item in matrix)
			{
				Console.WriteLine(string.Join(',', item));
			}
		}
	}
}
