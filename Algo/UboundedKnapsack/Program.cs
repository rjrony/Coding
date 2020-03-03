﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UboundedKnapsack
{
    class Program
    {
        private static int max(int i, int j)
        {
            return (i > j) ? i : j;
        }

        // Returns the maximum value 
        // with knapsack of W capacity
        private static int unboundedKnapsack(int W, int n,int[] val, int[] wt)
        {

            // dp[i] is going to store maximum value
            // with knapsack capacity i.
            int[] dp = new int[W + 1];

            // Fill dp[] using above recursive formula
            for (int i = 0; i <= W; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (wt[j] <= i)
                    {
                        dp[i] = Math.Max(dp[i], dp[i - wt[j]] + val[j]);
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
            Console.WriteLine(unboundedKnapsack(W, n, val, wt));
            Console.ReadKey();
        }
    }
}
