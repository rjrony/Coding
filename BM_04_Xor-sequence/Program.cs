using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace BM_04_Xor_sequence
{
    class Program
    {
        static long f( long n)
        {
            //long[] res = {a, 1, a + 1, 0};
            //return res[a%4];
            long a = n % 8;
            if (a == 0 || a == 1)
                return n;
            else if (a == 2 || a == 3)
                return 2;
            else if (a == 4 || a == 5)
                return n + 2;
            return 0;
        }

        // Complete the xorSequence function below.
        static long xorSequence(long l, long r)
        {
            //var big = f(r);
            //var small = f(l - 1);
            //return big ^ small;
            return f(r) ^ f(l - 1);
            //long sum = 0;
            //for (long i = l; i <= r; i++)
            //{
            //    sum = sum ^ f(i);
            //}
            //return sum;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] lr = Console.ReadLine().Split(' ');

                long l = Convert.ToInt64(lr[0]);

                long r = Convert.ToInt64(lr[1]);

                long result = xorSequence(l, r);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }
            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
