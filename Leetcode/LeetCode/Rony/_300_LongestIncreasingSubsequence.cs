using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Rony
{
	//https://www.geeksforgeeks.org/longest-monotonically-increasing-subsequence-size-n-log-n/
	//https://stackoverflow.com/questions/2631726/how-to-determine-the-longest-increasing-subsequence-using-dynamic-programming
	public class _300_LongestIncreasingSubsequence
	{

		//O(nLogN)
		public int BinarySearchCeil(int[] a, int left, int right, int element)
		{
			while (right - left > 1)
			{
				int middle = (right + left) / 2;
				if (a[middle] >= element)
					right = middle;
				else
					left = middle;
			}
			return right;
		}
		public int LengthOfLIS(int[] nums)
		{
			int n = nums.Length;
			int len = 0;
			if (n > 0)
			{
				len = 1;
				int[] dp = new int[n];
				dp[0] = nums[0];
				for (int i = 1; i < n; i++)
				{
					if (nums[i] < dp[0])
						dp[0] = nums[i];
					else if (nums[i] > dp[len - 1])
						dp[len++] = nums[i];
					else
						dp[BinarySearchCeil(dp, -1, len - 1, nums[i])] = nums[i];
				}
			}
			return len;
		}
		//O(nLogN) use library BinarySearch
		public int LengthOfLIS3(int[] nums)
		{
			var dp = new List<int>(new int[nums.Length]);
			int len = 0;
			foreach (var num in nums)
			{
				int i = dp.BinarySearch(0, len, num, null);
				if (i < 0)
				{
					i = ~i;
				}
				dp[i] = num;
				if (i == len)
				{
					len++;
				}
			}
			return len;
		}

		//n^2
		public int LengthOfLIS2(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return 0;
			else if (nums.Length == 1)
				return 1;

			int currentLength = 1;
			int[] continousLength = new int[nums.Length];

			for (int i = 0; i <= nums.Length - 1; i++)
			{
				continousLength[i] = 1;

				for (int j = 0; j < i; j++)
					if (nums[j] < nums[i])
						continousLength[i] = Math.Max(continousLength[j] + 1, continousLength[i]);

				currentLength = Math.Max(continousLength[i], currentLength);
			}

			return currentLength;
		}

		public void Test()
		{
			Console.WriteLine(LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }));
			//Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0 }));
			//Console.WriteLine(MaxDistToClosest(new int[] { 0, 1 }));
			//Console.WriteLine(MaxDistToClosest(new int[] { 0, 0, 1, 0, 0, 0 }));
		}
	}
}
