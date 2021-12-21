using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class CountfSmallerNumbersAfterSelf_315
	{
		//https://leetcode.com/problems/count-of-smaller-numbers-after-self/discuss/546596/Simple-recursive-C-solution-that-builds-and-searches-on-a-binary-tree-to-get-the-rank
		//https://leetcode.com/problems/count-of-smaller-numbers-after-self/discuss/552808/O(n-logn)-solution-using-TreeSet-and-Binary-Indexed-Tree

		public IList<int> CountSmaller(int[] nums)
		{
			var list = new List<int>();

			return list;
		}

		////time complexity: n^2
		//public IList<int> CountSmaller(int[] nums)
		//{
		//	var list = new List<int>();
		//	var length = nums.Length;
		//	for (int i = 0; i < length; i++)
		//	{
		//		int count = 0;
		//		for (int j = i+1; j < length; j++)
		//		{
		//			if (nums[i] > nums[j]) count++;
		//		}
		//		list.Add(count);
		//	}

		//	return list;
		//}

	}
}
