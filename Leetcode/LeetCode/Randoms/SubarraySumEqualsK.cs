using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	//https://leetcode.com/problems/subarray-sum-equals-k/
	//ToDo: write some explanation in leetcode 
	public class SubarraySumEqualsK
	{
		//O(n)
		//https://leetcode.com/problems/subarray-sum-equals-k/discuss/535507/Explanation-to-why-map.get(sum-k)-is-done-than-count%2B%2B
		public int SubarraySum(int[] nums, int k)
		{
			int count = 0, sum = 0;
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(0, 1);
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				count += dict.GetValueOrDefault((sum - k), 0);
				dict[sum] = dict.GetValueOrDefault(sum, 0) + 1;
			}
			return count;
		}

		//O(n)
		//https://leetcode.com/problems/subarray-sum-equals-k/discuss/535507/Explanation-to-why-map.get(sum-k)-is-done-than-count%2B%2B
		public int SubarraySum_Understandable(int[] nums, int k)
		{
			//step.1: calculate prefix sum
			//step.2: calculate prefix sum
			int count = 0, sum = 0;
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(0, 1);
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				count += dict.GetValueOrDefault((sum - k), 0);
				dict[sum] = dict.GetValueOrDefault(sum, 0) + 1;
			}
			return count;
		}

		//O(n^2)
		public int SubarraySum2(int[] nums, int k)
		{
			var count = 0;
			var length = nums.Length;
			for (int i = 0; i < length; i++)
			{
				var sum = 0;
				for (int j = i; j < length; j++)
				{
					sum += nums[j];
					if (sum == k)
					{
						++count;
						//break; // may have all zeros
					}
					//else if (sum > k) break; //because may have negative numbers 
				}
			}
			return count;
		}
	}
}
