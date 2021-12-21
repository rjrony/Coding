using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _217_ContainsDuplicate
	{
		public bool ContainsDuplicate(int[] nums)
		{
			var hashSet = new HashSet<int>();
			foreach (var num in nums)
			{
				if (hashSet.Contains(num))return true;
				else hashSet.Add(num);
			}
			return false;
		}
	}
}
