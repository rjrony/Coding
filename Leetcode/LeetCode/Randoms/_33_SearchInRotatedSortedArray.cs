using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class _33_SearchInRotatedSortedArray
	{
        public int Search2(int[] nums, int target)
        {
            var n = nums.Length;
            int lo = 0, hi = n - 1;
            // find the index of the smallest value using binary search.
            // Loop will terminate since mid < hi, and lo or hi will shrink by at least 1.
            // Proof by contradiction that mid < hi: if mid==hi, then lo==hi and loop would have been terminated.
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > nums[hi]) lo = mid + 1;
                else hi = mid;
            }
            // lo==hi is the index of the smallest value and also the number of places rotated.
            int rot = lo;
            lo = 0; hi = n - 1;
            // The usual binary search and accounting for rotation.
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                int realmid = (mid + rot) % n;
                if (nums[realmid] == target) return realmid;
                if (nums[realmid] < target) lo = mid + 1;
                else hi = mid - 1;
            }
            return -1;
        }

        //my solution: accepted
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            var minValueIndex = FindMinValueIndex(nums);

            int index = -1;
            if (nums[0] <= target && minValueIndex > 0)
            {
                index = BinarySearchRecursive(nums, target, 0, minValueIndex);
            }
            else
            {
                index = BinarySearchRecursive(nums, target, minValueIndex, nums.Length - 1);
            }

            return index;
        }

        //good coding 
        public int FindMinValueIndex(int[] nums)
        {
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] > nums[end]) start = mid + 1;
                else end = mid;
            }
            return start;
        }

        //bad coding
        public static int FindMinValueIndex2(int[] inputArray)
        {
            if (inputArray.Length == 1) return 0;
            if (inputArray.Length == 2) return inputArray[0] < inputArray[1] ? 0 : 1;

            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (inputArray[min] < inputArray[mid])
                {
                    if (mid == inputArray.Length - 1) return 0;
                    min = mid + 1;
                    if (inputArray[mid] > inputArray[min]) return min;
                }
                else if (inputArray[min] == inputArray[mid]) return max;
                else
                {
                    max = mid - 1;
                    if (inputArray[max] > inputArray[mid]) return mid;
                }
            }
            return 0;
        }

        public static int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max) return -1;           
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public void Test()
        {
            Console.WriteLine(new _33_SearchInRotatedSortedArray().Search(new int[] { 6, 8, 9, 2 }, 1));
            Console.WriteLine(new _33_SearchInRotatedSortedArray().Search(new int[] { 9, 1, 2, 3, 4, 5, 6, 7, 8 }, 1));
            Console.WriteLine(new _33_SearchInRotatedSortedArray().Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
        }
    }
}
