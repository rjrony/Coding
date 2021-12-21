using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.December
{
	public class _80_RemoveDuplicatesFromSortedArrayII
	{
		public int RemoveDuplicates(int[] nums)
		{
			if (nums.Length < 3) return nums.Length;

			int i = 1, j = 1;
			int sameCount = 1; 
			while (i<nums.Length)
			{
				sameCount = (nums[i - 1] == nums[i]) ? sameCount + 1 : 1;

				if (sameCount<=2)
				{
					nums[j] = nums[i];
					++j;
				}

				++i;
			}
			return j;
		}

		public void Test()
		{
			var nums = new int[] { 1, 1, 1, 2, 2, 3 };
			int len = RemoveDuplicates(nums);

			for (int i = 0; i < len; i++)
			{
				Console.WriteLine(nums[i]);
			}

			nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
			len = RemoveDuplicates(nums);

			for (int i = 0; i < len; i++)
			{
				Console.WriteLine(nums[i]);
			}

		}
	}
}
