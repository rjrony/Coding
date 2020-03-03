using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Greedy_02_Marcs_Cakewalk
{
    class Program
    {
        static long Power(long n, int r)
        {
            if (r == 0) return 1;          
            return n << (r - 1);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] calories_temp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
            
            Array.Sort(calories, (a, b) => b - a);

            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += calories[i] * Power(2, i);
                //sum += calories[i] * (long)Math.Pow(2, i); //this is also workable
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
