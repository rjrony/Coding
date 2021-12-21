using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _189_RotateArray
	{
        public void Rotate(int[] nums, int k)
        {
            var len = nums.Length;
            k = k % len;

            Reverse(nums, 0, len - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, len - 1);
        }

        void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public void Rotate_1(int[] nums, int k)
        {
            var len = nums.Length;
            k = k % len;

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, len - k);
        }

        public void Rotate_2(int[] nums, int k)
        {
            var len = nums.Length;
            k = k % len;

            var arr = new int[k];

            Array.Copy(nums, len - k, arr, 0, k);
            Array.Copy(nums, 0, nums, k, len - k);
            Array.Copy(arr, 0, nums, 0, k);
        }

        public void Test()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            new _189_RotateArray().Rotate(arr, 3);
            Console.WriteLine(string.Join(',', arr));
        }
    }
}
