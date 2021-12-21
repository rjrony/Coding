using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class CountingElements
	{
		public int CountElements(int[] arr)
		{
			int count = 0;
			var hashArr = new int[1002];
			foreach (var item in arr)
			{
				hashArr[item] = 1;
			}

			foreach (var item in arr)
			{
				if (hashArr[item + 1] == 1) count++;
			}

			return count;
		}
	}
}
