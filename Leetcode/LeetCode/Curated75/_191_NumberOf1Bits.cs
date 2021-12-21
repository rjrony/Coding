using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _191_NumberOf1Bits
	{
		//7%2=1; 3
		//3%2=1; 1
		//1%2=1; 0

		//16%2=0; 8
		//8%2=0; 4
		//4%2=0; 2
		//2%2=0; 1
		//1%2=1; 0
		public int HammingWeight(uint n)
		{
			var count = 0;
			while (n > 0)
			{
				if (n % 2 == 1) ++count;
				n /= 2;
			}

			return count;
		}
	}
}
