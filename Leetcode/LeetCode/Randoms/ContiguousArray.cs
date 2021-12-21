using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class ContiguousArray
	{
		//O(n) : use good tricks for checking longest distance pair
		public int FindMaxLength(int[] nums)
		{
			// Map to keep track of sum formed so far till which index
			Dictionary<int, int> sumIdxMap = new Dictionary<int, int>();
			sumIdxMap.Add(0, -1);   // assume sum 0 came at index -1
			int maxLen = 0;
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				// lets model 0 as -1 and 1 as 1
				// this way we need to find longest array with sum 0
				sum += (nums[i] == 0) ? -1 : 1;
				// if same sum encountered again that means elements
				// from that index orwards till current index sum up
				// to zero i.e. equal number of 0 & 1
				if (sumIdxMap.ContainsKey(sum))
				{
					maxLen = Math.Max(maxLen, i - sumIdxMap.GetValueOrDefault(sum));
				}
				else
				{
					sumIdxMap.Add(sum, i);
				}
			}

			return maxLen;
		}

		////O(n^2)
		//public int FindMaxLength(int[] nums)
		//{			
		//	int maxLength = 0;
		//	var length = nums.Length;
		//	for (int i = 0; i < length-1; i++)
		//	{
		//		var currentWindowLength = 0;
		//		int count0 = 0;
		//		int count1 = 0;
		//		for (int j = i; j < length; j++)
		//		{
		//			if (nums[j] == 0) ++count0;
		//			else ++count1;
		//			if (count0 == count1) currentWindowLength = count0 + count1;
		//		}

		//		if (currentWindowLength > maxLength) maxLength = currentWindowLength;
		//	}
		//	return maxLength;
		//}

	}
}
