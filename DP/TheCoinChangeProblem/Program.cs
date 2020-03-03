using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoinChangeProblem
{
    class Program
    {
        // Complete the getWays function below.
        static long getWays(long n, long[] c)
        {
            long m = c.Length;
            long[] table = new long[n + 1];

            // Initialize all table values as 0
            for (long i = 0; i < table.Length; i++)
            {
                table[i] = 0;
            }

            // Base case (If given value is 0)
            table[0] = 1;

            for (long i = 0; i < m; i++)
                for (long j = c[i]; j <= n; j++)
                    table[j] += table[j - c[i]];

            return table[n];
        }

        static void Main(string[] args)
        {
            //ToDo: will uncomment below line
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            long[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt64(cTemp))
            ;
            // Print the number of ways of making change for 'n' units using coins having the values given by 'c'

            long ways = getWays(n, c);

            Console.WriteLine(ways); //ToDo: will remove this line and uncomment below lines
            Console.ReadKey();
            //textWriter.WriteLine(ways);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
