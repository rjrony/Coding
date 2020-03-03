using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_06_Missing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] aArray = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            Console.ReadLine();
            int[] bArray = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();

            int[] counterAArray = new int[10000];
            int[] counterBArray = new int[10000];
            foreach (var item in bArray)
            {
                counterBArray[item]++;
            }
            foreach (var item in aArray)
            {
                counterAArray[item]++;
            }
            var minVal = bArray.Min();
            for (int i = minVal; i < minVal+101; i++)
            {
                if (counterBArray[i] > counterAArray[i])
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
