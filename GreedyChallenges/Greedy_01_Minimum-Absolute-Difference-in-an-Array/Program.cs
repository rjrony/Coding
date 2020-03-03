using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_01_Minimum_Absolute_Difference_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //var min = Int32.MaxValue;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        var dif = Math.Abs(a[i] - a[j]);
            //        if (min > dif)
            //        {
            //            min = dif;
            //        }
            //    }
            //}
            //Console.WriteLine(min);

            Array.Sort(a);
            int min = Int32.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                var dif = Math.Abs(a[i] - a[i + 1]);
                if (min > dif)
                {
                    min = dif;
                }
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
