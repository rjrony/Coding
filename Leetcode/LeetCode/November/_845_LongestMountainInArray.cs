using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _845_LongestMountainInArray
	{
		public int LongestMountain(int[] A)
		{
            int res = 0, up = 0, down = 0;
            for (int i = 1; i < A.Length; ++i)
            {
                //If we are going down and current element is greater than prev MEANS last mountain ended
                //And the current mountain began (Up will be updated below)
                if (down > 0 && A[i - 1] < A[i] || A[i - 1] == A[i])
                    up = down = 0;

                //If current element is greater then previous then we are going up
                //Else we are going down the mountain
                //_ = A[i] > A[i - 1] ? up++ : down++;
                if (A[i - 1] < A[i]) up++;
                if (A[i - 1] > A[i]) down++;

                if (up > 0 && down > 0)
                    res = Math.Max(res, up + down + 1);
            }
            return res;
        }

        public int LongestMountain2(int[] A)
        {
            if (A == null || A.Length < 3)
                return 0;
            int ans = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {  // i is a peak
                    int left = i - 1;    // find leftmost of the peak
                    while (left > 0 && A[left - 1] < A[left])
                        left--;

                    int right = i + 1;  // find rightmost of the peak
                    while (right < A.Length - 1 && A[right + 1] < A[right])
                        right++;

                    ans = Math.Max(ans, right - left + 1);  // get the width using left and rightmost

                }
            }
            return ans;
        }

        public void Test()
		{
            Console.WriteLine(LongestMountain(new int[] { 2, 1, 4, 7, 3, 2, 5 })); // 5
            Console.WriteLine(LongestMountain(new int[] { 2, 2, 2 })); // 0
        }
	}
}
