using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.December
{
	class _59_SpiralMatrixII
	{
		public int[][] GenerateMatrix(int n)
		{
			int[][] matrix = new int[n][];

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{

				}

			}

			return matrix;
		}

		public void Test()
		{
			var matrix = GenerateMatrix(3);

			for (int i = 0; i < matrix.Length; i++)
			{
				Console.WriteLine(String.Join(',', matrix[i]));
			}
			

		}
	}
}
