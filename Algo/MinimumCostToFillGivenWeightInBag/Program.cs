using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCostToFillGivenWeightInBag
{
    class Program
    {
        private const int INF = 1000000;
        // cost[] initial cost array including unavailable packet 
        // W capacity of bag 
        private static int MinimumCost(int[] cost, int n, int W)
        {
            // val[] and wt[] arrays val[] array to store cost of 'i' kg packet of orange 
            // wt[] array weight of packet of orange 
            List<int> val = new List<int>(), wt=new List<int>();

            // traverse the original cost[] array and skip unavailable packets and make val[] 
            //and wt[] array. size variable tells the available number of distinct weighted packets 
            int size = 0;
            for (int i = 0; i < n; i++)
            {
                if (cost[i] != -1)
                {
                    val.Add(cost[i]);
                    wt.Add((int)Math.Pow(2, i));
                    size++;
                }
            }

            n = size;
            int[,] min_cost = new int[n + 1, W + 1];
  
            // fill 0th row with infinity 
            for (int i=0; i<=W; i++) 
                min_cost[0,i] = INF; 
  
            // fill 0'th column with 0 
            for (int i=1; i<=n; i++) 
                min_cost[i,0] = 0; 
  
            // now check for each weight one by one and fill the matrix according to the condition 
            for (int i=1; i<=n; i++) 
            { 
                for (int j=1; j<=W; j++) 
                { 
                    //// wt[i-1]>j means capacity of bag is less then weight of item 
                    //if (wt[i - 1] > j) 
                    //    min_cost[i,j] = min_cost[i - 1,j]; 
  
                    //// here we check we get minimum cost either by including it or excluding it 
                    //else
                        min_cost[i,j] = Math.Min(min_cost[i - 1,j], min_cost[i,j - wt[i - 1]] + val[i - 1]);
                }
            } 
  
            // exactly weight W can not be made by given weights 
            return (min_cost[n,W]==INF)? -1: min_cost[n,W]; 
        } 
  
        // Driver program to run the test case 
        public static void Main()
        {
            int[] cost = new int[]{ 1, 2, 3, 4, 5 };
            int W = 5;
            int n = cost.Length;
            //Console.WriteLine(MinimumCost(cost, n, W)); //output should be 5

            //cost = new int[]{ 20, 30, 70, 90 };
            //W = 12;
            //n = cost.Length;
            //Console.WriteLine(MinimumCost(cost, n, W)); //output should be 150

            cost = new int[] { 10000, 1000, 100, 10 };
            W = 3;
            n = cost.Length;
            Console.WriteLine(MinimumCost(cost, n, W)); //output should be 10

            cost = new int[] { 10, 100, 1000, 10000 };
            W = 3;
            n = cost.Length;
            Console.WriteLine(MinimumCost(cost, n, W)); //output should be 30

            Console.ReadKey();
        }

    }
}
