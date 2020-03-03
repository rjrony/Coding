using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitXOR
{
    class Program
    {
        // Complete the solve function below.
        static int solve(List<int> a, int k)
        {
            int count = 0;
            int val = 0;
            int length = a.Count;
            for (int i = 0; i < length; i++)
            {
                val = 0;
                for (int j = i; j < length; j++)
                {
                    if (i==j && a[i] < k)
                    {
                        ++count;
                        val = a[i];
                    }
                    else
                    {
                        val = val ^ a[j];
                        if (val < k)
                        {
                            ++count;
                        }
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = solve(a, k);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
