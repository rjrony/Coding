using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _239_SlidingWindowMaximum
	{
		public int[] MaxSlidingWindow(int[] nums, int k)
		{
			if (k == 1) return nums;
			var len = nums.Length;
			var arr = new int[len - k + 1];
			var count = 0;
			var linkedList = new LinkedList<int>();

			for (int i = 0; i < len; i++)
			{
				if (linkedList.Count > 0 && (linkedList.First.Value + k) <= i)
				{
					linkedList.RemoveFirst();
				}

				while (linkedList.Count > 0 && nums[linkedList.Last.Value]<=nums[i])
				{
					linkedList.RemoveLast();
				}

				linkedList.AddLast(i);

				if (i >= k - 1)
				{
					arr[count++] = nums[linkedList.First.Value];
				}				
			}

			return arr;
		}

		public void Test()
		{
			Console.WriteLine(String.Join(',', MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3)));
			//Console.WriteLine(String.Join(',', MaxSlidingWindow(new int[] { 1, -1 }, 1)));
			//Console.WriteLine(String.Join(',', MaxSlidingWindow(new int[] { 9, 11 }, 2)));
			//Console.WriteLine(String.Join(',', MaxSlidingWindow(new int[] { 4, -2 }, 2)));
			Console.WriteLine(String.Join(',', MaxSlidingWindow(new int[] { 7,2, 4 }, 2)));
		}
	}


}
