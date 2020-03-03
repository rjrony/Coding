using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_01_Hackerland_Radio_Transmitters
{
    class Program
    {
        static int nearestTransmitterLocation(int[] arr, int coverage, int startingIndex)
        {
            var location = arr[startingIndex] + coverage;
            int i = 0;
            for (i = startingIndex; i < arr.Length; i++)
            {
                if (arr[i] > location)
                {
                    break;
                }
            }
            return arr[i - 1];
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);

            Array.Sort(x);
            var count = 1;
            var transmitterLocation = nearestTransmitterLocation(x, k, 0);
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > (transmitterLocation + k))
                {
                    transmitterLocation = nearestTransmitterLocation(x, k, i);
                    count++;
                }
            }
            
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
