using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _41_FirstMissingPositive
	{
		//with constand memory & O(n)
		public int FirstMissingPositive(int[] nums)
		{
			int i = 0, len = nums.Length;
			while (i < len)
			{
				if ((nums[i] != i+1) && (nums[i] > 0 && nums[i] <= len) && (nums[nums[i]-1] != nums[i]))
					swap(nums, i, nums[i]-1);
				else
					i++;
			}

			for (i = 0; i < len; i++)
				if (nums[i] != i + 1)
					return i + 1;
			return len + 1;
		}

		private void swap(int[] nums, int i, int j)
		{
			int temp = nums[i];
			nums[i] = nums[j];
			nums[j] = temp;
		}

		//with memory: using hashset 
		public int FirstMissingPositive2(int[] nums)
		{
			var hashSet = new HashSet<int>();

			var min = -1;
			foreach (var n in nums)
			{
				hashSet.Add(n);
				if (min > n) min = n;
			}

			if (min > 1) return 1;

			for (int i = 1; i <= nums.Length+1; i++)
			{
				if (!hashSet.Contains(i)) return i;
			}

			return 1;
		}


		public void Test()
		{
			var a = new int[] { 3, 5, 1, 2, 3 };

			Console.WriteLine(FirstMissingPositive(a));
			Console.WriteLine(FirstMissingPositive(new int[] { 1, 2, 0 }));
			Console.WriteLine(FirstMissingPositive(new int[] { 3, 4, -1, 1 }));
			Console.WriteLine(FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 }));
		}
	}
}
