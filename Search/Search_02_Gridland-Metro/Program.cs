using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_02_Gridland_Metro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);

            var n = x[0];
            var m = x[1];
            var k = x[2];
            int[][] trainTrack = new int[k][];

            for (int i = 0; i < k; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int[] kArray = Array.ConvertAll(temp, Int32.Parse);

                trainTrack[i] = new int[3]
                {
                    kArray[0], kArray[1], kArray[2]
                };
            }

            var sum = 0;
            int[,] trainTrackByRow = new int[1001, 2];
            for (int i = 0; i < k; i++)
            {
                sum += trainTrack[i][2] - trainTrack[i][1] + 1;
            }

            Console.WriteLine(m*n - sum);
            Console.ReadKey();
        }
    }
}
