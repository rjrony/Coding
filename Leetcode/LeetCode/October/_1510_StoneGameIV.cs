using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
    //https://leetcode.com/problems/stone-game-iv/discuss/909380/Recurrence-Tree-Diagram-or-Top-Down-DP-or-Bottom-Up-DP-Visual
    //https://leetcode.com/problems/stone-game-iv/discuss/730942/Standard-DP-question-Explained-BEST-ALL-you-need-to-know

    public class _1510_StoneGameIV
	{
		public bool WinnerSquareGame(int n)
		{
            var dp = new bool[n + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    if (!dp[i - j * j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }
	}
}
