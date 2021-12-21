using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	//tricky: revisit again & again
	public class _1_TwoSum
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var length = nums.Length;
			var indices = new int[2];
			Dictionary<int, int> valueIndexLookup = new Dictionary<int, int>();

			//if pre-filled the valueIndexLookup then the problem with scaniro: nums = [3,2,4], target = 6
			//for (int i = 0; i < length - 1; i++)
			//{
			//	valueIndexMap.Add(nums[i], i);
			//}

			for (int i = 0; i < length; i++)
			{
				if (valueIndexLookup.ContainsKey(target-nums[i]))
				{
					indices[0] = valueIndexLookup.GetValueOrDefault(target - nums[i]);
					indices[1] = i;
					break;
				}

				if (!valueIndexLookup.ContainsKey(nums[i]))
				{
					valueIndexLookup.Add(nums[i], i);
				}
			}

			return indices;
		}

		public int[] TwoSum_2(int[] nums, int target)
		{
			int length = nums.Length;
			bool flag = false;
			int i, j = 0;
			for (i = 0; i < length - 1; i++)
			{
				for (j = i + 1; j < length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						flag = true;
						break;
					}
				}
				if (flag) break;
			}
			return new int[2] { i, j };
		}

		public int[] TwoSum_1(int[] nums, int target)
		{
			var length = nums.Length;
			var indices = new int[2];
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = i + 1; j < length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[2] { i, j };
					}
				}
			}

			return indices;
		}
	}
}
