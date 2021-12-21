using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _1217_MinimumCostToMoveChipsToTheSamePosition
	{
		public int MinCostToMoveChips(int[] position)
		{
			int odd = 0, even = 0;
			for (int i = 0; i < position.Length; i++)
			{
				if (position[i] % 2 == 0) even++;
				else odd++;
			}
			return Math.Min(even, odd);
		}

		public void Test()
		{
			Console.WriteLine(MinCostToMoveChips(new int[] { 1, 0, 0, 0, 1, 0, 1 }));
		}
	}
}
