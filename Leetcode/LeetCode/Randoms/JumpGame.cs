using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class JumpGame
	{
		public bool CanJump(int[] nums)
		{
			if (nums.Length < 2) return true;
			var canJump = false;
			var lastIndex = nums.Length - 1;
			var indexCoverage = 0;
			int i = 0;
			while (i < lastIndex)
			{
				if (i > indexCoverage) break;
				else if ((i+nums[i]) > indexCoverage)
				{
					indexCoverage = i + nums[i];
				}

				if (indexCoverage>=lastIndex)
				{
					canJump = true;
					break;
				}
				i++;
			}
			return canJump;
		}
	}
}
