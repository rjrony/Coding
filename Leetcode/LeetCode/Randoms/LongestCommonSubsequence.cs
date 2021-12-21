using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class LongestCommonSubsequence_
	{
		public int LongestCommonSubsequence(string text1, string text2)
		{
			var length1 = text1.Length;
			var length2 = text2.Length;
			var dp = new int[length1+1, length2+1];

			for (int i = 1; i <= length1; i++)
			{
				for (int j = 1; j <= length2; j++)
				{
					if (text1[i-1]==text2[j-1])
					{
						dp[i, j] = dp[i - 1, j - 1] + 1;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
					}
				}
			}

			return dp[length1, length2];
		}
	}
}
