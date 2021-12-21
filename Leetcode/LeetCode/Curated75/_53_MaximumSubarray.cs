using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _53_MaximumSubarray
	{
		//O(n)
		public int MaxSubArray(int[] nums)
		{
			int currentWindowSum = nums[0];
			int maxSum = nums[0];
			var length = nums.Length;
			for (int i = 1; i < length; i++)
			{
				currentWindowSum = Math.Max(currentWindowSum + nums[i], nums[i]);
				maxSum = Math.Max(maxSum, currentWindowSum);
			}
			return maxSum;
		}

		////O(n)
		//public static int MaxSubArray(int[] nums)
		//{
		//	int max = nums[0], sum = 0;
		//	var length = nums.Length;
		//	for (int i = 0; i < length; i++)
		//	{
		//		sum += nums[i];
		//		max = Math.Max(sum, max);
		//		sum = Math.Max(sum, 0);
		//	}
		//	return max;
		//}


		////O(n^2)
		//public static int MaxSubArray(int[] nums)
		//{
		//	int result = nums[0];
		//	var length = nums.Length;
		//	for (int i = 0; i < length; i++)
		//	{
		//		int maxSum = nums[i];
		//		var sum = 0;
		//		for (int j = i; j < length; j++)
		//		{
		//			sum += nums[j];
		//			if (sum > maxSum) maxSum = sum;
		//		}

		//		if (maxSum > result) result = maxSum;
		//	}
		//	return result;
		//}
	}
}
