using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        // Complete the maxMin function below.
        static int maxMin(int k, int[] arr)
        {
            Array.Sort(arr);          
            int length = arr.Length - k;
            int minimumUnfairness = arr[arr.Length - 1] - arr[0];
            for (int i = 0; i <= length; i++)
            {
                int unfairness = arr[i + k - 1] - arr[i];
                if (unfairness < minimumUnfairness)
                {
                    minimumUnfairness = unfairness;
                }
            }

            return minimumUnfairness;
        }

        static void Main(string[] args)
        {
            //ToDo: will uncomment below line
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            int result = maxMin(k, arr);
            Console.WriteLine(result); //ToDo: will remove this line and uncomment below line
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
