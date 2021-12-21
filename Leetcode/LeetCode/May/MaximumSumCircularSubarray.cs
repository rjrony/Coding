using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class MaximumSumCircularSubarray
	{
		public int MaxSubarraySumCircular(int[] A)
		{
			int windowMax = 0;
			int max = A[0];
			int windowMin = 0;
			int min = A[0];
			int sum = 0;
			for (int i = 0; i < A.Length; i++)
			{
				windowMax += A[i];
				windowMax = Math.Max(windowMax, A[i]);
				max = Math.Max(max, windowMax);

				windowMin = Math.Min(windowMin + A[i], A[i]);
				min = Math.Min(min, windowMin);
				sum += A[i];
			}
			return max > 0 ? Math.Max(max, sum - min) : max;
		}
	}
}
