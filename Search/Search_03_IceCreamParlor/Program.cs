using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_03_IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            while (--t >= 0)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                //int[] ar = new int[n];
                string[] temp = Console.ReadLine().Split(' ');
                int[] ar = Array.ConvertAll(temp, int.Parse);

                int i = 0;
                int j = 0;
                bool flag = false;
                for (; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if ((ar[i] + ar[j]) == m)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                Console.WriteLine((i + 1) + " " + (j + 1));
            }

            Console.ReadKey();

        }
    }
}
