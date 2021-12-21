using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Contest.Contest26
{
	public class SimplifiedFractions_
	{
		static int GCD(int num1, int num2)
		{
			int Remainder;

			while (num2 != 0)
			{
				Remainder = num1 % num2;
				num1 = num2;
				num2 = Remainder;
			}

			return num1;
		}

		public IList<string> SimplifiedFractions(int n)
		{
			var list = new List<string>();

			for (int i = 2; i <= n; i++)
			{
				for (int j = 1; j < i; j++)
				{
					if (j > 1 && GCD(i, j)>1) continue;
					list.Add($"{j}/{i}");
				}
			}
			return list;
		}
	}
}
