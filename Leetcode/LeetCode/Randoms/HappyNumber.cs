using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class HappyNumber
	{

		public static bool IsHappy(int n)
		{
			var result = false;
			HashSet<int> hashSet = new HashSet<int>();
			while (true)
			{
				if (!hashSet.Add(n)) break;

				var sum = 0;
				while (n > 0)
				{
					var digit = n % 10;
					n /= 10;
					sum += digit * digit;
				}
				if (sum == 1)
				{
					result = true;
					break;
				}
				n = sum;
			}

			return result;
		}

	}
}
