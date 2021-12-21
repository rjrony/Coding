using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class CountingBits
	{
		public int[] CountBits(int num)
		{
            var result = new List<int>();
            result.Add(0);

            int p = 0;
            int m = 2;

            for (int i = 1; i <= num; i++)
            {
                if (i == m)
                {
                    m *= 2;
                    p = 0;
                }
                result.Add(result[p++] + 1);
            }
            return result.ToArray();
        }
	}
}
