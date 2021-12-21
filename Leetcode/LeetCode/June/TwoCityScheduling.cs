using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
	public class TwoCityScheduling
	{
		public int TwoCitySchedCost(int[][] costs)
		{
			Array.Sort(costs, new Comparison<int[]>(
				(x, y) => { return (x[0] -x[1]) < (y[0]-y[1]) ? -1 : 1; }
			));

			var sum = 0;
			for (int i = 0; i < costs.Length / 2; i++)
			{
				sum += costs[i][0];
			}

			for (int i = costs.Length / 2; i < costs.Length; i++)
			{
				sum += costs[i][1];
			}

			return sum;

			//Array.Sort(costs, new Comparison<int[]>(
			//	(x, y) => { return x[0] < y[0] ? -1 : 1; }
			//));

			//var sum1 = 0;
			//for (int i = 0; i < costs.Length / 2; i++)
			//{
			//	sum1 += costs[i][0];
			//}

			//for (int i = costs.Length / 2; i < costs.Length; i++)
			//{
			//	sum1 += costs[i][1];
			//}


			//Array.Sort(costs, new Comparison<int[]>(
			//	(x, y) => { return x[1] < y[1] ? -1 : 1; }
			//));
			//var sum2 = 0;
			//for (int i = 0; i < costs.Length / 2; i++)
			//{
			//	sum2 += costs[i][1];
			//}

			//for (int i = costs.Length / 2; i < costs.Length; i++)
			//{
			//	sum2 += costs[i][0];
			//}

			//return Math.Min(sum1, sum2);
		}

		public void Test()
		{
			//[[10,20],[30,200],[400,50],[30,20]]
			var costs1 = new int[][] {
				new int[] { 10,20 },
				new int[] { 30, 200 },
				new int[] { 400,50 },
				new int[] { 30, 20 }
			};
			Console.WriteLine(TwoCitySchedCost(costs1));

			int[][] costs2 = new int[][] {
				new int[]{ 259, 770 },
				new int[]{ 926, 667 },
				new int[]{ 577, 469 },
				new int[]{ 448, 54 },
				new int[]{ 184, 139 },
				new int[]{ 840, 118 } };
			Console.WriteLine(TwoCitySchedCost(costs2));
		}
	}
}
