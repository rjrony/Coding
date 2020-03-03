using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    public class CoinChangeDynamically
    {
        static long countWays(int[] S, int m, int n)
        {
            //Time complexity of this function: O(mn)
            //Space Complexity of this function: O(n)

            // table[i] will be storing the number of solutions
            // for value i. We need n+1 rows as the table is
            // constructed in bottom up manner using the base
            // case (n = 0)
            int[] table = new int[n + 1];

            // Initialize all table values as 0
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = 0;
            }

            // Base case (If given value is 0)
            table[0] = 1;

            // Pick all coins one by one and update the table[]
            // values after the index greater than or equal to
            // the value of the picked coin
            for (int i = 0; i < m; i++)
            {
                for (int j = S[i]; j <= n; j++)
                    table[j] += table[j - S[i]];
                Console.WriteLine(string.Join(" ", table));
            }

            return table[n];
        }

        // Driver Function
        public static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int m = arr.Length;
            int n = 4;
            Console.WriteLine(countWays(arr, m, n));

            int[] arr2 = { 2, 5, 3, 6 };
            m = arr2.Length;
            n = 10;
            Console.WriteLine(countWays(arr2, m, n));
            Console.ReadKey();
        }
    }
}
