using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLongestCommonSubsequence
{
    class Program
    {
        // Complete the longestCommonSubsequence function below.
        static int[] longestCommonSubsequence(int[] a, int[] b)
        {
            int m = a.Length;
            int n = b.Length;
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (a[i - 1] == b[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }

            int index = L[m, n];

            int[] lcs = new int[index];

            //lcs[index] = 0;

            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                if (a[k - 1] == b[l - 1])
                {
                    lcs[index - 1] = a[k - 1];
                    k--;
                    l--;
                    index--;
                }
                else if (L[k - 1, l] > L[k, l - 1])
                    k--;
                else
                    l--;
            }

            return lcs;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
            ;
            int[] result = longestCommonSubsequence(a, b);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();
            //textWriter.WriteLine(string.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
