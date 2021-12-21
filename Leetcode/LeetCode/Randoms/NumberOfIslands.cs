using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class NumberOfIslands
	{
		//without extra memory
		public int NumIslands(char[][] grid)
		{
			if (grid == null || grid.Length == 0) return 0;
			int count = 0;

			for (int i = 0; i < grid.Length; i++)
			{
				for (int j = 0; j < grid[0].Length; j++)
				{
					if (grid[i][j] == '1')
					{
						dfs(grid, i, j);
						count++;
					}
				}
			}
			return count;
		}

		private void dfs(char[][] grid, int i, int j)
		{
			if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return;
			else if (grid[i][j] != '1') return;

			grid[i][j] = 'X';
			dfs(grid, i - 1, j);
			dfs(grid, i + 1, j);
			dfs(grid, i, j - 1);
			dfs(grid, i, j + 1);
		}

		//with extra memory
		public int NumIslands2(char[][] grid)
		{
			if (grid == null || grid.Length == 0)
			{
				return 0;
			}

			int N = grid.Length;
			int M = grid[0].Length;
			var visited = new bool[N,M];
			int count = 0;

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < M; j++)
				{

					if (grid[i][j] == '1' && !visited[i,j])
					{
						dfs2(grid, i, j, visited);
						count++;
					}
				}
			}
			return count;
		}

		private void dfs2(char[][] grid, int i, int j, bool[,] visited)
		{
			if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
			{
				return;
			}
			else if (visited[i,j] || grid[i][j] != '1')
			{
				return;
			}

			visited[i,j] = true;
			dfs2(grid, i - 1, j, visited);
			dfs2(grid, i + 1, j, visited);
			dfs2(grid, i, j - 1, visited);
			dfs2(grid, i, j + 1, visited);
		}

		//brute force: my solution but not 100% working
		public int NumIslands3(char[][] grid)
		{
			int islands = 0;
			var initialWrongCount = new HashSet<char>();
			for (int i = 0; i < grid.Length; i++)
			{
				for (int j = 0; j < grid[i].Length; j++)
				{
					if (grid[i][j]!='0' && (j==0 || grid[i][j-1]=='0') && (i==0 || grid[i-1][j]=='0'))
					{
						grid[i][j] = (char)(++islands + '0');
						//if ((j == grid[i].Length-1 || grid[i][j + 1] == '0') && (i == grid.Length-1 || grid[i + 1][j] == '0'))
						//{
						//	grid[i][j] = (char)(++islands + '0');
						//}
						//else if(islands == 0)
						//{
						//	grid[i][j] = (char)(++islands + '0');
						//}

					}
					else if (grid[i][j] != '0' && ((j > 0 && grid[i][j - 1] != '0') || (i > 0 && grid[i - 1][j] != '0')))
					{
						var left = (j > 0 && grid[i][j - 1] != '0') ? grid[i][j - 1] : '0';
						var top = (i > 0 && grid[i - 1][j] != '0') ? grid[i - 1][j] : '0';
						if (left != '0' && top != '0')
						{
							if (left == top)
							{
								grid[i][j] = left;
							}
							else
							{
								grid[i][j] = left < top ? left : top;
								initialWrongCount.Add(left > top ? left : top);
							}
						}
						else if(left != '0')
						{
							grid[i][j] = left;
						}
						else
						{
							grid[i][j] = top;
						}
					}
				}
			}

			return islands- initialWrongCount.Count;
		}
	}
}
