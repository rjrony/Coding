using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckBalance
{
    class Program
    {
        // Complete the luckBalance function below.
        static int luckBalance(int k, int[][] contests)
        {
            int totalLuck = 0;
            int length = contests.Length;
            int[] importantContests = new int[length];
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                totalLuck += contests[i][0];

                if (contests[i][1] == 1)
                {
                    importantContests[j++] = contests[i][0];
                }
            }

            Array.Sort(importantContests, (a, b) => b.CompareTo(a)); //for descending order
            for (int i = k; i < length; i++)
            {
                totalLuck = totalLuck - 2*importantContests[i];
            }

            return totalLuck;
        }

        static void Main(string[] args)
        {
            //ToDo: will uncomment below line
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[][] contests = new int[n][];

            for (int i = 0; i < n; i++)
            {
                contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
            }

            int result = luckBalance(k, contests);
            Console.WriteLine(result); //ToDo: will remove this line and uncomment below line
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
