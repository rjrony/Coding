using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class _50_Pow
	{
        // var result = _50_Pow.MyPow(2.00000, -2147483648);
        public static double MyPow(double x, int n)
        {
            double result = 1;
            if (n > 0)
            {
                if (n >= int.MaxValue / 2)
                {
                    result = Power(x, n / 2);
                    result *= result;
                    if (n % 2 == 1)
                    {
                        result *= x;
                    }
                }
                else
                {
                    result = Power(x, n);
                }
            }
            else if (n < 0)
            {
                if (n <= int.MinValue / 2)
                {
                    n = -(n + 1);
                    result = Power(x, n / 2);
                    result *= result;
                    if (n % 2 == 1)
                    {
                        result *= x * x;
                    }
                    else
                    {
                        result *= x;
                    }
                    result = 1 / result;
                }
                else
                {
                    n = -n;
                    result = Power(x, n);
                    result = 1 / result;
                }
            }

            return result;
        }

        private static double Power(double x, int n)
        {
            double sum = 1;
            while (n > 0)
            {
                double subSum = x;
                int j = 2;
                for (; j <= n; j = 2 * j)
                {
                    subSum *= subSum;
                    if (j >= int.MaxValue / 2) break;
                }
                n = n - (j / 2);
                sum *= subSum;
            }
            return sum;
        }
    }
}
