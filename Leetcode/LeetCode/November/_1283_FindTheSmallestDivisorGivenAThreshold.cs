using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _1283_FindTheSmallestDivisorGivenAThreshold
	{
		public int SmallestDivisor(int[] nums, int threshold)
		{
			var len = nums.Length;
			var max = -1;

			foreach (var n in nums)
			{
				max = Math.Max(max, n);
			}
			if (threshold == len) return max;

			var left = 1;
			var right = max;

			while (left < right)
			{
				var mid = (left + right) / 2;
				
				if (IsValid(nums, threshold, mid)) right = mid;
				else left = mid + 1;
			}

			return left;
		}

		private bool IsValid(int[] nums, int threshold, int divisor)
		{
			var sum = 0;
			foreach (var n in nums)
			{
				sum += (int)Math.Ceiling(1.0 * n / divisor);
			}

			return sum <= threshold;
		}

		public void Test()
		{
			Console.WriteLine(SmallestDivisor(new int[] { 1, 2, 5, 9 }, 6)); // 5
			Console.WriteLine(SmallestDivisor(new int[] { 2, 3, 5, 7, 11 }, 11)); //3
			Console.WriteLine(SmallestDivisor(new int[] { 19 }, 5)); //4
		}
	}
}
