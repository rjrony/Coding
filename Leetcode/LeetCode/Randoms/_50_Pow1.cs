using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class _50_Pow1
	{
        // var result = _50_Pow.MyPow(2.00000, -2147483648);
        public static double MyPow(double x, int n)
        {
            double res = 1.0;
            long q = 1 * n;

            if (n < 0)
            {
                q = 0;
                q = (long)(-1) * n;
            }

            while (q>0)
            {
                if ((q & 1) != 0) //if ((q % 2) != 0) //<:equivalent
                {
                    res = res * x;
                }

                q >>= 1; //q=q/2; //<:equivalent
                x = x * x;
            }

            if (n < 0)
            {
                return 1 / res;
            }

            return res;
        }

    }
}
