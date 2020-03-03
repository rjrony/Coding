using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaximumSubarray
{
    class Program
    {
        public static int FindGreatestSumOfSubArray(int[] array)
        {
            //if (array.length == 0) return 0; int maxSum = array[0];
            int arr = array[0];
            int maxSum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (arr < 0)
                {
                    arr = array[i];
                }
                else
                {
                    arr += array[i];
                }
                maxSum = maxSum > arr ? maxSum : arr;
            }
            return maxSum;
        }

        public static int MaxSumOfSubArray(int[] array)
        {
            int max_ending_here = array[0];
            int max_so_far = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                var x = array[i];
                max_ending_here = Math.Max(x, max_ending_here + x);
                max_so_far = Math.Max(max_so_far, max_ending_here);
            }
            return max_so_far;
        }

        public static int MaxSumSubsequence(int[] array)
        {
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                maxSum = Math.Max(maxSum, maxSum + array[i]);
                maxSum = Math.Max(maxSum, array[i]);
            }
            return maxSum;
        }


        // Complete the maxSubarray function below.
        static int[] maxSubarray(int[] arr)
        {
            int maxSumSubArray = MaxSumOfSubArray(arr);
            int maxSumSubsequence = MaxSumSubsequence(arr);

            return new int[] {maxSumSubArray, maxSumSubsequence};
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
                int[] result = maxSubarray(arr);

                Console.WriteLine(string.Join(" ", result));
                //textWriter.WriteLine(string.Join(" ", result));
            }
            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
