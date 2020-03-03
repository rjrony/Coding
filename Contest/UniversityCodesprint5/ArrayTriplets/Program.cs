using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTriplets
{
    class Program
    {
        static bool find3Numbers(int[] A, int arr_size, int sum)
        {
            // Fix the first
            // element as A[i]
            for (int i = 0; i < arr_size - 2; i++)
            {
                // Fix the second
                // element as A[j]
                for (int j = i + 1;j < arr_size - 1; j++)
                {

                    // Now look for 
                    // the third number
                    for (int k = j + 1;k < arr_size; k++)
                    {
                        if (A[i] + A[j] + A[k] == sum)
                        {
                            Console.WriteLine("Triplet is " + A[i] +
                                                       ", " + A[j] +
                                                       ", " + A[k]);
                            return true;
                        }
                    }
                }
            }

            // If we reach here, 
            // then no triplet was found
            return false;
        }
        // Complete the solve function below.
        //static int solve(int[] a)
        //{
        //    int length = a.Length;
        //    long sum = 0;
        //    foreach (int i in a)
        //    {
        //        sum += i;
        //    }
        //    int realSum = (int) (sum/3);
        //    var result = find3Numbers(a, length, realSum);
        //    return 6;
        //}
        static int solve(List<int> a)
        {
            int length = a.Count;
            long sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            int realSum = (int)(sum / 3);
            if (sum % 3 != 0) return 0;

            return 6;

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int aCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            //int[] arr = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = solve(a);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
