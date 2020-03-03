using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class SockMerchant
    {
        static int sockMerchant(int n, int[] ar)
        {
            ////version 1
            //var count = 0;
            //int[] arr = new int[100];
            //foreach (var item in ar)
            //{
            //    if (arr[item] > 0)
            //    {
            //        ++count;
            //        arr[item] = 0;
            //    }
            //    else
            //    {
            //        arr[item] = 1;
            //    }
            //}
            //return count;

            ////version 2
            var count = 0;
            bool[] arr = new Boolean[101];
            foreach (var item in ar)
            {
                if (arr[item])
                {
                    ++count;
                }
                arr[item] = !arr[item];
            }
            return count;
        }

        public static void SockMerchant_Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = 9; 
            //var list = "10 20 20 10 10 30 50 10 20"; 
            int n = Convert.ToInt32(Console.ReadLine());
            var list = Console.ReadLine();
            int[] ar = Array.ConvertAll(list.Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
