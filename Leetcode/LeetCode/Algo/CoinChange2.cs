using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algo
{
	public class CoinChange2
	{
		public int Change(int amount, int[] coins)
		{
            // table[i] will be storing the number of solutions
            // for value i. We need n+1 rows as the table is
            // constructed in bottom up manner using the base
            // case (n = 0)
            var length = coins.Length;
            int[] table = new int[amount + 1];

            // Base case (If given value is 0)
            table[0] = 1;

            // Pick all coins one by one and update the table[]
            // values after the index greater than or equal to
            // the value of the picked coin
            for (int i = 0; i < length; i++)
            {
                for (int j = coins[i]; j <= amount; j++)
                    table[j] += table[j - coins[i]];
                Console.WriteLine(string.Join(" ", table));
            }

            return table[amount];
        }

    }
}
