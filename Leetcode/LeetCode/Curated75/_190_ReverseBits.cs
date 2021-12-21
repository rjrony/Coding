using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	//another approch split it by 4 bits
	//https://leetcode.com/problems/reverse-bits/discuss/868521/C.-32ms.-4-bit-table-lookup.
	public class _190_ReverseBits
	{
		public uint reverseBits(uint n)
		{
			uint result = 0; // result
			int i = 0;
			while (n > 0)
			{
				result <<= 1;
				if ((n & 1) != 0)
					result |= 1;
				n >>= 1;
				++i;
			}

			for (; i < 32; ++i) // 32 bits
			{
				result <<= 1;
			}
			return result;
		}

		//easily understandable version
		public uint reverseBits2(uint n)
		{
			int i = 31;
			uint result = 0;
			while (n > 0 || i >= 0)
			{
				//result += (n % 2) * (uint)Math.Pow(2, i--);
				result += (n % 2) << i--;
				n = n / 2;
			}

			return result;

		}

		public uint reverseBits3(uint n)
		{
			uint result = 0; // result
			for (int i = 0; i < 32; ++i) // 32 bits
			{ 
				result <<= 1;
				if ((n & 1) != 0)
					result |= 1;
				n >>= 1;
			}
			return result;
		}




		/// <summary>
		/// ///////////test//////////////
		/// </summary>
		public void Test()
		{
			Console.WriteLine(reverseBits(5));
			Console.WriteLine(reverseBits(964176192));
			Console.WriteLine(reverseBits(4294967293));

			Console.WriteLine(reverseBits2(5));
			Console.WriteLine(reverseBits2(964176192));
			Console.WriteLine(reverseBits2(4294967293));
		}
	}
}
