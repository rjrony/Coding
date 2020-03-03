using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingBoards
{
    class Program
    {
        // Complete the boardCutting function below.
        static int boardCutting(int[] cost_y, int[] cost_x)
        {
            Array.Sort(cost_y, (a, b) => b.CompareTo(a)); //for descending order
            Array.Sort(cost_x, (a, b) => b.CompareTo(a)); //for descending order
            int length_y = cost_y.Length;
            int length_x = cost_x.Length;

            int ht_segments = 1;
            int vt_segments = 1;
            long cost = 0;

            int i = 0;
            int j = 0;

            while (i<length_y || j<length_x)
            {
                if (i >= length_y)
                {
                    cost += (long)cost_x[j] * vt_segments;
                    ++j;
                    ++ht_segments;
                }
                else if (j >= length_x)
                {
                    cost += (long)cost_y[i] * ht_segments;
                    ++i;
                    ++vt_segments;
                }
                else if (cost_y[i] >= cost_x[j])
                {
                    cost += (long)cost_y[i] * ht_segments;
                    ++i;
                    ++vt_segments;
                }
                else if (cost_y[i] < cost_x[j])
                {
                    cost += (long)cost_x[j] * vt_segments;
                    ++j;
                    ++ht_segments;
                }
                //else
                //{
                //    if (length_y > length_x)
                //    {
                //        cost += cost_y[i] * ht_segments;
                //        ++i;
                //        ++vt_segments;
                //    }
                //    else
                //    {
                //        cost += cost_x[j] * vt_segments;
                //        ++j;
                //        ++ht_segments;
                //    }
                //}

                cost = cost%1000000007;
            }

            int ans = (int) (cost%1000000007);
            return ans;
        }

        static void Main(string[] args)
        {
            //ToDo: will uncomment below line
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] mn = Console.ReadLine().Split(' ');

                int m = Convert.ToInt32(mn[0]);

                int n = Convert.ToInt32(mn[1]);

                int[] cost_y = Array.ConvertAll(Console.ReadLine().Split(' '), cost_yTemp => Convert.ToInt32(cost_yTemp));

                int[] cost_x = Array.ConvertAll(Console.ReadLine().Split(' '), cost_xTemp => Convert.ToInt32(cost_xTemp));
                int result = boardCutting(cost_y, cost_x);

                Console.WriteLine(result); //ToDo: will remove this line and uncomment below lines
                Console.ReadKey();
                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
