using System;
using System.Collections.Generic;
//using System.Numerics;
using System.Text;

namespace LeetCode
{
	public static class ExtraLongFactorials
	{
		public static void extraLongFactorials(int n)
		{

			System.Numerics.BigInteger factorial = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial = factorial * i;
			}

			Console.WriteLine(factorial);
		}
	}
}
