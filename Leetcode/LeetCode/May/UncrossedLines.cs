using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class UncrossedLines
	{
		public int MaxUncrossedLines(int[] A, int[] B)
		{
			var n = A.Length;
			var m = B.Length;

			var dp = new int[n + 1, m + 1];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					dp[i + 1, j + 1] = Math.Max(Math.Max(dp[i, j + 1], dp[i + 1, j]),
						dp[i, j] + (A[i] == B[j] ? 1 : 0));
				}

			}

			////print
			//for (int i = 0; i <= n; i++)
			//{
			//	for (int j = 0; j <= m; j++)
			//	{
			//		Console.Write(dp[i, j] + " ");
			//	}
			//	Console.WriteLine();
			//}

			return dp[n,m];
		}
	}
}
