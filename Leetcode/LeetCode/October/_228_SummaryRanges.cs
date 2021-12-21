using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _228_SummaryRanges
	{
		public IList<string> SummaryRanges(int[] nums)
		{
			var list = new List<string>();
			var len = nums.Length;
			if (len == 0) return list;

			var previous = nums[0];
			var continueFrom = nums[0];
			for (int i = 1; i < len; i++)
			{
				if ((previous + 1) == nums[i]) //in continue
				{
					previous = nums[i];
					continue;
				}

				//when break continue or last num
				if (previous == continueFrom)
				{
					list.Add(previous.ToString());
				}
				else
				{
					list.Add(continueFrom + "->" + previous);
				}

				previous = nums[i];
				continueFrom = nums[i];
			}

			if (previous == continueFrom)
			{
				list.Add(previous.ToString());
			}
			else
			{
				list.Add(continueFrom + "->" + previous);
			}

			return list;
		}

		public void Test()
		{
			Console.WriteLine(string.Join(',', SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 })));

		}
	}
}
