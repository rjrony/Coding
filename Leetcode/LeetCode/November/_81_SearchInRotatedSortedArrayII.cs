using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _81_SearchInRotatedSortedArrayII
	{
        #region efficient but complex
            public bool Search2(int[] nums, int target)
            {
                int n = nums.Length;
                if (n == 0) return false;
                int end = n - 1;
                int start = 0;

                while (start <= end)
                {
                    int mid = start + (end - start) / 2;

                    if (nums[mid] == target)
                    {
                        return true;
                    }

                    if (!IsBinarySearchHelpful(nums, start, nums[mid]))
                    {
                        start++;
                        continue;
                    }
                    // which array does pivot belong to.
                    bool pivotArray = ExistsInFirst(nums, start, nums[mid]);

                    // which array does target belong to.
                    bool targetArray = ExistsInFirst(nums, start, target);
                    if (pivotArray ^ targetArray)
                    { // If pivot and target exist in different sorted arrays, recall that xor is true when both operands are distinct
                        if (pivotArray)
                        {
                            start = mid + 1; // pivot in the first, target in the second
                        }
                        else
                        {
                            end = mid - 1; // target in the first, pivot in the second
                        }
                    }
                    else
                    { // If pivot and target exist in same sorted array
                        if (nums[mid] < target)
                        {
                            start = mid + 1;
                        }
                        else
                        {
                            end = mid - 1;
                        }
                    }
                }
                return false;
            }

            // returns true if we can reduce the search space in current binary search space
            private bool IsBinarySearchHelpful(int[] arr, int start, int element)
            {
                return arr[start] != element;
            }

            // returns true if element exists in first array, false if it exists in second
            private bool ExistsInFirst(int[] arr, int start, int element)
            {
                return arr[start] <= element;
            }

        #endregion

        #region only divide & conquer
            public bool Search(int[] nums, int target)
            {
                if (nums == null || nums.Length == 0) return false;
                return Find(nums, 0, nums.Length - 1, target);
            }

            private bool Find(int[] nums, int s, int e, int t)
            {
                if (s == e) return nums[s] == t;
                if ((nums[s] < nums[e]) && (nums[s] > t || nums[e] < t)) return false;
                else return Find(nums, s, (s + e) / 2, t) || Find(nums, (s + e) / 2 + 1, e, t);
            }
        #endregion


        public void Test()
		{
            //Console.WriteLine(new _81_SearchInRotatedSortedArrayII().Search(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 0)); //true
            //Console.WriteLine(Search(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 3)); //false
            Console.WriteLine(Search(new int[] { 2, 2, 2, 0, 2, 2 }, 0)); //true
        }
	}
}
