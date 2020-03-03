using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UboundedWeightedKnapsack
{
    class Program2
    {
        private static int min(int i, int j)
        {
            return (i < j) ? i : j;
        }

        // Returns the maximum value  
        // with knapsack of W capacity 
        private static int unboundedKnapsack(int W, int n, int[] val, int[] wt)
        {

            // dp[i] is going to store maximum value with knapsack capacity i. 
            int[] dp = new int[W + 1];

            // Fill dp[] using above recursive formula 
            for (int i = 0; i <= W; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (wt[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - wt[j]] + val[j]);
                    }
                }
            }
            return dp[W];
        }

        // Driver program 
        public static void Main()
        {
            int W = 100;
            int[] val = { 10, 30, 20 };
            int[] wt = { 5, 10, 15 };
            int n = val.Length;
            Console.WriteLine(unboundedKnapsack(W, n, val, wt));//should be 300

            W = 12;
            val = new int[]{ 20, 30, 70, 90 };
            wt = new int[] { 1, 2, 4, 8 };
            n = 4;
            Console.WriteLine(unboundedKnapsack(W, n, val, wt));//should be 150
            Console.ReadKey();
        }
    }
}
