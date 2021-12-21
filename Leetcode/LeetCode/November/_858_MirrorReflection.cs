using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _858_MirrorReflection
	{
		public int MirrorReflection(int p, int q)
		{
            //while (p % 2 == 0 && q % 2 == 0) {p >>= 1; q >>= 1;}
            while (p % 2 == 0 && q % 2 == 0)
            {
                p /= 2;
                q /= 2;
            }

            return 1 - p % 2 + q % 2;

            /*if (p % 2 == 0 && q % 2 == 1) return 2;
            if (p % 2 == 1 && q % 2 == 1) return 1;
            if (p % 2 == 1 && q % 2 == 0) return 0;
            return -1;
            */
        }
    }
}
