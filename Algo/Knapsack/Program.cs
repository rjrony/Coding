using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {
        static int max(int a, int b) { return (a > b) ? a : b; }
        // Returns the maximum value that can be put in a knapsack of capacity W
        private static int knapsack(int W, int[] wt, int[] val, int n)
        {
            int i, w;
            /*
             double[][] is called jagged array
             double[,] is called rectangular array
             */
            int[,] K = new int[n + 1, W + 1];

            // Build table K[,] in bottom up manner
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[n,W];
        }

        static void Main(string[] args)
        {
            ////case 1
            //int[] val = { 60, 100, 120 };
            //int[] wt = { 10, 20, 30 };
            //int W = 50;

            ////case 2
            int[] val = {10, 40, 30, 50};
            int[] wt = { 5, 4, 6, 3 };
            int W = 10;

            int n = val.Length;
            int result = knapsack(W, wt, val, n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
