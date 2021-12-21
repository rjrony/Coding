using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class BitwiseANDofNumbersRange
	{
		public int RangeBitwiseAnd(int m, int n)
		{
			int result = 0;

			while (m>0 && n>0)
			{
				int msb1 = FindMsb(m);
				int msb2 = FindMsb(n);

				if (msb1 != msb2) break;

				int msb_val= 1 << msb1;
				result += msb_val;
				m -= msb_val;
				n -= msb_val;
			}
			return result;
		}

		public int FindMsb(int num)
		{
			int msb = -1;
			while (num > 0)
			{
				num >>= 1;
				msb++;
			}
			return msb;
		}

		//shortest solutions, good but complex
		int RangeBitwiseAnd2(int m, int n)
		{
			int i = 0;
			while (m != n)
			{
				n >>= 1;
				m >>= 1;
				++i;
			}
			return (m << i);
		}
	}
}
