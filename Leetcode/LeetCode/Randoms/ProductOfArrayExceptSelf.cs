using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class ProductOfArrayExceptSelf
	{
        ////2 separate loops
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int len = nums.Length;
            int[] result = new int[len];
            //Array.Fill(result, 1);
            int left = 1;
            for (int i = 0; i < len; i++)
            {
                result[i] = left;
                left *= nums[i];
            }
            int right = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }
            return result;
        }

        ////2 separate loops, without Extra Space
        public int[] ProductExceptSelf_withoutExtraSpace(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++) result[i] = result[i - 1] * nums[i - 1];
            for (int i = nums.Length - 2; i >= 0; nums[nums.Length - 1] *= nums[i--]) result[i] *= nums[nums.Length - 1];
            return result;
        }

        ////3 separate loops
        public int[] ProductExceptSelf3(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int len = nums.Length;
            int[] result = new int[len];

            int[] leftProduct = new int[len];
            leftProduct[0] = 1;
            for (int i = 1; i < len; i++)
            {
                leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
            }

            int[] rightProduct = new int[len];
            rightProduct[len-1] = 1;
            for (int i = len - 2; i >= 0; i--)
            {
                rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < len; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }
            return result;
        }


	}
}
