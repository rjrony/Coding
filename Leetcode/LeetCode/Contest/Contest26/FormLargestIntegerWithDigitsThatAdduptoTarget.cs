using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/contest/biweekly-contest-26/problems/form-largest-integer-with-digits-that-add-up-to-target/
namespace LeetCode.Contest.Contest26
{
	public class FormLargestIntegerWithDigitsThatAdduptoTarget
	{
        //private static int unboundedKnapsack(int W, int n, int[] wt)
        static void printknapSack(int W, int[] wt, int n, int[] val)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];

            // Build table K[][] in bottom up manner  
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] +
                                K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            // stores the result of Knapsack  
            int res = K[n, W];
            Console.WriteLine(res);

            w = W;
            for (i = n; i > 0 && res > 0; i--)
            {

                // either the result comes from the top  
                // (K[i-1][w]) or from (val[i-1] + K[i-1]  
                // [w-wt[i-1]]) as in Knapsack table. If  
                // it comes from the latter one/ it means  
                // the item is included.  
                if (res == K[i - 1, w])
                    continue;
                else
                {
                    // This item is included.  
                    Console.Write(wt[i - 1] + " ");

                    // Since this weight is included its  
                    // value is deducted  
                    res = res - val[i - 1];
                    w = w - wt[i - 1];
                }
            }
        }

        public string LargestNumber(int[] cost, int target)
		{
            var val = new int[cost.Length];
            for (int i = 0; i < cost.Length; i++)
            {
                val[i] = i + 1;
            }

            printknapSack(target, cost, cost.Length, val);

            return null;
		}
	}
}
