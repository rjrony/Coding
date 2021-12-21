using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
	public class SearchInsertPosition
	{
		public int SearchInsert(int[] nums, int target)
		{
			var min = 0;
			var max = nums.Length-1;

			while (min <= max)
			{
				var mid = (min + max) / 2;
				if (nums[mid] == target)return mid;
				else if (nums[mid] > target) max = mid - 1;
				else min = mid + 1;
			}
			return min;
		}
	}
}
