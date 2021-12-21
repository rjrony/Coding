using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class MinimumPathSum
	{
		//using dp knowledge
		public int MinPathSum(int[][] grid)
		{
			if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
			int rows = grid.Length, cols = grid[0].Length;
			int[] minSums = new int[cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (i == 0)
					{
						minSums[j] = (j == 0) ? grid[0][0] : minSums[j - 1] + grid[i][j];
					}
					else if (j == 0) minSums[j] += grid[i][j];
					else minSums[j] = Math.Min(minSums[j - 1], minSums[j]) + grid[i][j];
				}
			}

			return minSums[cols - 1];
		}

		//using dfs but Time Limit Exceeded 
		public int MinPathSum2(int[][] grid)
		{
			if (grid == null || grid.Length == 0) return 0;
			return MinPathDfs(grid, 0, 0, 0);
		}

		public int MinPathDfs(int[][] grid,int i, int j, int sum)
		{
			if (i == grid.Length-1 && j == grid[0].Length-1)
			{
				return sum + grid[i][j];
			}
			if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return int.MaxValue;
			sum += grid[i][j];

			var sum1 = MinPathDfs(grid, i + 1, j, sum);
			var sum2 = MinPathDfs(grid, i, j + 1, sum);
			return sum1 < sum2 ? sum1 : sum2;
		}
	}
}
