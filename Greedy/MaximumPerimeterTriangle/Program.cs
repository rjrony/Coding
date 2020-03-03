using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPerimeterTriangle
{
    class Program
    {
        // Complete the maximumPerimeterTriangle function below.
        static int[] maximumPerimeterTriangle(int[] sticks)
        {
            int[] triangle = new int[3] ;
            Array.Sort(sticks, (a, b) => b.CompareTo(a)); //for descending order
            int length = sticks.Length;
            bool hasTriangle = false;
            for (int i = 0; i < length-2; i++)
            {
                if (sticks[i] < (sticks[i + 1] + sticks[i + 2]))
                {
                    triangle[0] = sticks[i + 2];
                    triangle[1] = sticks[i + 1];
                    triangle[2] = sticks[i];
                    hasTriangle = true;
                    break;
                }
            }

            return hasTriangle ? triangle : new int[] {-1};
        }

        static void Main(string[] args)
        {
            //ToDo: will uncomment below line
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp))
            ;
            int[] result = maximumPerimeterTriangle(sticks);

            Console.WriteLine(string.Join(" ", result)); //ToDo: will remove this line and uncomment below line
            Console.ReadKey();
            //textWriter.WriteLine(string.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
