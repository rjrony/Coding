using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class LastStoneWeight
	{
		public int LastStoneWeight1(int[] stones)
		{
			if (stones.Length == 1) return stones[0];

			int length = stones.Length;
			Array.Sort(stones);
			while (stones[length - 2] > 0)
			{
				stones[length - 1] = stones[length - 1] - stones[length - 2];
				stones[length - 2] = 0;
				Array.Sort(stones);
			}
			return stones[length - 1];
		}
	}
}
