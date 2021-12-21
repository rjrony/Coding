using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
	public class _326_PowerOfThree
	{
        //using Math logic
        // It follows that 3 ^ X == N
        // It follows that log(3 ^ X) == log N
        // It follows that X log 3 == log N
        // It follows that X == (log N) / (log 3)
        // if N == Pow(3,Math.Round(X)) then true
        public bool IsPowerOfThree(int n)
		{
            if (n == 0) return false;

            return n == Math.Pow(3, Math.Round(Math.Log(n) / Math.Log(3)));
        }

        //tricky
        //largest power of 3 under int.MaxValue is 3^19=1162261467
        //here 3 is prime and 19 is prime number
        public bool IsPowerOfThree_tricky(int n)
        {
            return n > 0 && (1162261467 % n == 0);
        }

        //Recursion
        public bool isPowerOfThree(int n)
        {
            if (n == 0)
                return false;

            if (n == 1)
                return true;

            if (n > 1)
                return n % 3 == 0 && isPowerOfThree(n / 3);
            else
                return false;
        }

        //Iteration
        public bool isPowerOfThree_Iteration(int n)
        {
            if (n == 1) return true;

            bool result = false;

            while (n > 0)
            {
                int m = n % 3;
                if (m == 0)
                {
                    n = n / 3;
                    if (n == 1)
                        return true;
                }
                else
                {
                    return false;
                }
            }

            return result;
        }
    }
}
