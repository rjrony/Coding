using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _56_MergeIntervals
	{
		public int[][] Merge(int[][] intervals)
		{
			//Array.Sort(intervals, Compare);
			Array.Sort(intervals, (x, y) => (x[0]-y[0]));
			var list = new List<int[]>();

			var interval = intervals[0];
			for (int i = 1; i < intervals.Length; i++)
			{
				if (interval[1] >= intervals[i][0])
				{
					interval[1] = Math.Max(interval[1], intervals[i][1]);
				}
				else
				{
					list.Add(interval);
					interval = intervals[i];
				}
			}

			list.Add(interval);
			return list.ToArray();
		}

		private int Compare(int[] s1, int[] s2)
		{
			return s1[0]-s2[0];
		}

		public void Test()
		{
			////[[1,3],[2,6],[8,10],[15,18]]
			//var intervals = new int[][] {
			//	new int[] { 2,6 },
			//	new int[] { 1,3 },
				
			//	new int[] { 8,10 },
			//	new int[] { 15, 18 }
			//};

			//var newIntervals = Merge(intervals); //[[1,6],[8,10],[15,18]]
			//foreach (var list in newIntervals)
			//{
			//	Console.WriteLine(string.Join(',', list));
			//}

			//[[1,4],[2,3]]
			var intervals2 = new int[][] {
				new int[] { 1,4 },
				new int[] { 2, 3 }
			};

			var newIntervals2 = Merge(intervals2); //[[1,4]]
			foreach (var list in newIntervals2)
			{
				Console.WriteLine(string.Join(',', list));
			}
		}
	}
}
