using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algo
{
	public class SortColors_
	{
		//with 1 loop
		public void SortColors(int[] nums)
		{
			var reds = 0;
			var blues = nums.Length-1;

			for (int i = 0; i <= blues; i++)
			{
				if (nums[i] == 2)
				{
					var temp = nums[i];
					nums[i] = nums[blues];
					nums[blues] = temp;
					blues--;
					i--;
				}
				else if (nums[i] == 0)
				{
					var temp = nums[i];
					nums[i] = nums[reds];
					nums[reds] = temp;
					reds++;
				}
			}
		}

		public void SortColors2(int[] nums)
		{
			int count0 = 0;
			int count1 = 0;
			int count2 = 0;
			int i = 0;
			for (; i < nums.Length; i++)
			{
				if (nums[i] == 0) count0++;
				else if (nums[i] == 1) count1++;
				else count2++;
			}

			i = 0;
			for (; i < count0; i++)
			{
				nums[i] = 0;
			}
			for (; i < count0+count1; i++)
			{
				nums[i] = 1;
			}
			for (; i < nums.Length; i++)
			{
				nums[i] = 2;
			}
		}

		public void Test()
		{
			var arr = new int[] { 2, 0, 2, 1, 1, 0 };
			var arr2 = new int[] { 2, 1, 2 };
			new SortColors_().SortColors(arr);
			Console.WriteLine(string.Join(',', arr));

			new SortColors_().SortColors(arr2);
			Console.WriteLine(string.Join(',', arr2));
		}
	}
}
