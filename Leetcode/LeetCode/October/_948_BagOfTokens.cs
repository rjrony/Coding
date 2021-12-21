using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _948_BagOfTokens
	{
		public int BagOfTokensScore(int[] tokens, int P)
		{
            int points = 0;
            int len = tokens.Length - 1;
            Array.Sort(tokens);

            for (int i = 0; i <= len; i++)
            {
                if (P < tokens[i])
                {
                    if (points == 0) return 0;
                    if (i-- == len) break;
                    P += tokens[len--];
                    points--;
                }
                else
                {
                    P -= tokens[i];
                    points++;
                }
            }

            return points;
        }

		public void Test()
		{
			Console.WriteLine(BagOfTokensScore(new int[] { 100, 200, 300, 400 }, 200 ));
		}
	}
}
