using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.December
{
	public class _1492_TheKthFactorOfn
	{
		public int KthFactor(int n, int k)
		{
			if (k == 1) return 1;
			var count = 1;
			int i = 2;
			for (; i*i <= n; i++)
			{
				if (n%i==0 && ++count==k)
				{
					return i;
				}
			}

			for (i=i-1; 0 < i; --i)
			{
				if (i * i == n) continue;
				if (n % i == 0 && ++count == k)
				{
					return n/i;
				}
			}

			return -1;
		}


		public void Test()
		{
			Console.WriteLine(KthFactor(12, 6)); //12
			Console.WriteLine(KthFactor(12, 5)); //6
			Console.WriteLine(KthFactor(12, 3)); //3
			Console.WriteLine(KthFactor(7, 2)); //7
			Console.WriteLine(KthFactor(4, 4)); //-1 
			Console.WriteLine(KthFactor(1, 1)); //1
			Console.WriteLine(KthFactor(1000, 3)); //4
		}
	}
}
