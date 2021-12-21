using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
    //revise again
	public class _213_HouseRobberII
	{
		public int Rob(int[] nums)
		{
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            // 1st option: including the 1st and excluding the last house
            int resultWithFirst = CalculateRobbingMoney(nums, 0, nums.Length - 2);
            // 2nd option: excluding the 1st and including the last house
            int resultWithLast = CalculateRobbingMoney(nums, 1, nums.Length - 1);

            // Return the maximum of the two results
            return Math.Max(resultWithFirst, resultWithLast);
        }

        public int CalculateRobbingMoney(int[] nums, int start, int end)
        {
            if (start == end) return nums[start];

            int[] money = new int[nums.Length];

            /* Base cases */
            money[start] = nums[start];

            // At the 2nd house, we decide to rob
            // either the 1st house or the 2nd
            // This is the core idea of the transition function
            money[start + 1] = Math.Max(nums[start + 1], nums[start]);

            for (int i = start + 2; i <= end; ++i)
                /* At ith house we have two options:
                 1. not rob it, keeping the money from the (i-1)th house
                 2. rob it after the (i-2)th house, skipping the (i-1)th house
                  We choose the one that gives the max amount */
                money[i] = Math.Max(money[i - 1], money[i - 2] + nums[i]);

            // Return the sum that we have at the last house
            return money[end];
        }
    }
}
