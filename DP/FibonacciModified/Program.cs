using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciModified
{
    class Program
    {
        // Complete the fibonacciModified function below.
        static string fibonacciModified(int t1, int t2, int n)
        {
            BigInteger b1 = new BigInteger(t2);
            BigInteger a1 = new BigInteger(t1);
            for (int i = 3; i < n + 1; i++)
            {
                BigInteger temp = BigInteger.Pow(b1, 2) + a1;
                a1 = b1;
                b1 = temp;
            }
            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (b1 != 0)
            {
                ans.Add(b1 % p10);
                b1 /= p10;
            }
            //Console.Write(ans[ans.Count - 1]);
            var str = ans[ans.Count - 1].ToString();
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                //var str = ans[i].ToString();
                //Console.Write("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
                str = str + fmt.Substring(0, 100 - ans[i].ToString().Length) + ans[i];
            }
            return str;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] t1T2n = Console.ReadLine().Split(' ');

            int t1 = Convert.ToInt32(t1T2n[0]);

            int t2 = Convert.ToInt32(t1T2n[1]);

            int n = Convert.ToInt32(t1T2n[2]);

            var result = fibonacciModified(t1, t2, n);
            Console.WriteLine(result);
            Console.ReadKey();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
