using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        // Returns the count of ways we can 
        // sum S[0...m-1] coins to get sum n
        static int count(int[] S, int m, int n)
        {
            // If n is 0 then there is 1 solution 
            // (do not include any coin)
            if (n == 0)
                return 1;

            // If n is less than 0 then no 
            // solution exists
            if (n < 0)
                return 0;

            // If there are no coins and n 
            // is greater than 0, then no
            // solution exist
            if (m <= 0 && n >= 1)
                return 0;

            // count is sum of solutions (i) 
            // including S[m-1] (ii) excluding S[m-1]
            return count(S, m - 1, n) +
                count(S, m, n - S[m - 1]);
        }

        // Driver program
        public static void Main2()
        {

            int[] arr = { 1, 2, 3 };
            int m = arr.Length;
            Console.Write(count(arr, m, 4));
            Console.ReadKey();

        }
    }
}
