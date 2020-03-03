using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CubeLovingNumbers
{
    class Program
    {
        public const long Max_Limit = 10000000;
        public static long[] arr =new long[Max_Limit];
        static int init()
        {
            
            for (long i = 2; 1 < Max_Limit / (i*i*i); i=i+1)
            {
                long val = i*i*i;
                for (long j = 1; 1 < Max_Limit / (val * j); j++)
                {
                    long index = val * j;
                    arr[index]++;
                }
                
            }
            return 0;
        }
        // Complete the solve function below.
        static long solve(long n)
        {
            for (long i = n; i > 0; i--)
            {
                if (arr[i] != 0)
                {
                    return arr[i];
                }
            }
            return 0;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            init();
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = solve(n);
                Console.WriteLine(result);
                //textWriter.WriteLine(result);
            }
            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
