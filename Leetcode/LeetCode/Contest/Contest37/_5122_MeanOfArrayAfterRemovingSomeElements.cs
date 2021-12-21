using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Contest.Contest37
{
	public class _5122_MeanOfArrayAfterRemovingSomeElements
	{
		public double TrimMean(int[] arr)
		{
			var len = arr.Length;
			Array.Sort(arr);
			var sum = 0;

			var fivePercent = len / 20;
			var count = 0;
			for (int i = fivePercent; i < len- fivePercent; i++)
			{
				sum += arr[i];
				++count;
			}

			return (double)sum/count;
		}

		public void Test()
		{
			//var arr = new int[] { 6, 2, 7, 5, 1, 2, 0, 3, 10, 2, 5, 0, 5, 5, 0, 8, 7, 6, 8, 0 };
			var arr = new int[] { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 };

			Console.WriteLine(TrimMean(arr));
		}
	}
}
