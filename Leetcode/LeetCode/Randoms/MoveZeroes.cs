using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class MoveZeroes
	{
		//using same array
		public static void MoveZeroesFunc(int[] nums)
		{
			var length = nums.Length;
			var zeros = 0;

			for (int i = 0; i < length; i++)
			{
				if (nums[i] == 0) ++zeros;
				else nums[i - zeros] = nums[i];
			}
			for (int i = length-zeros; i < length; i++)
			{
				nums[i] = 0;
			}

			Console.WriteLine(string.Join(',', nums));
		}

		////using two pointers
		//public static void moveZeroes(int[] nums)
		//{
		//	for (int i = 0, ci = 0; i < nums.Length; i++)
		//	{
		//		if (nums[i] != 0)
		//		{
		//			if (ci != i)
		//			{
		//				nums[ci] = nums[i];
		//				nums[i] = 0;
		//			}
		//			ci++;
		//		}
		//	}
		//}
	}
}
