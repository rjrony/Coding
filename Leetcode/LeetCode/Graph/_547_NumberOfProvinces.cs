using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Graph
{
	public class _547_NumberOfProvinces
	{
		public int FindCircleNum(int[][] M)
		{
			bool[] visited = new bool[M.Length];
			int groups = 0;

			for (int i = 0; i < M.Length; i++)
			{
				if (!visited[i])
				{
					visited[i] = true;
					dfs(M, i, visited);
					groups++;
				}
			}

			return groups;
		}

		private void dfs(int[][] M, int node, bool[] visited)
		{
			for (int neighbour = 0; neighbour < M.Length; neighbour++)
			{
				if (M[node][neighbour] == 1 && !visited[neighbour])
				{
					visited[neighbour] = true;
					dfs(M, neighbour, visited);
				}
			}
		}

		public int FindCircleNum2(int[][] isConnected)
		{
			var n = isConnected.Length;
			var stack = new Stack<int>();
			bool[] visited = new bool[n];
			var province = n;

			for (int i = 0; i < n; i++)
			{
				if (visited[i]) continue;
				stack.Push(i);
				visited[i] = true;
				while (stack.Count > 0)
				{
					var cur = stack.Pop();
					//if (visited[cur]) continue;

					for (int j = 0; j < n; j++)
					{
						if (!visited[j] && isConnected[cur][j] == 1)
						{
							stack.Push(j);
							province--;
							visited[j] = true;
						}
					}
				}
			}
			return province;
		}

		public void Test()
		{
			var grid = new int[][] {
				new int[] { 1, 1, 0 },
				new int[] { 1, 1, 0 },
				new int[] { 0, 0, 1 }
			};
			var result = FindCircleNum(grid); //[[1, 1, 0],[1, 1, 0],[0, 0, 1]]
			Console.WriteLine(result);
		}
	}
}
