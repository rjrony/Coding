using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLongestIncreasingSubsequence
{
    class Program
    {
        // Binary search (note boundaries in the caller) A[] is ceilIndex in the caller 
        static int CeilIndex(int[] A, int l, int r, int key)
        {
            while (r - l > 1)
            {
                int m = l + (r - l) / 2;

                if (A[m] >= key)
                    r = m;
                else
                    l = m;
            }

            return r;
        }

        static int LongestIncreasingSubsequenceLength(int[] A, int size)
        {
            // Add boundary case, when array size is one 
            int[] tailTable = new int[size];
            int len; // always points empty slot 

            tailTable[0] = A[0];
            len = 1;
            for (int i = 1; i < size; i++)
            {
                if (A[i] < tailTable[0])
                    // new smallest value 
                    tailTable[0] = A[i];
                else if (A[i] > tailTable[len - 1])
                    // A[i] wants to extend largest subsequence 
                    tailTable[len++] = A[i];
                else
                    // A[i] wants to be current end candidate of an existing subsequence.
                    // It will replace ceil value in tailTable 
                    tailTable[CeilIndex(tailTable, -1,
                                 len - 1, A[i])] = A[i];
            }

            return len;
        }
        
        // Complete the longestIncreasingSubsequence function below.
        static int longestIncreasingSubsequence(int[] arr)
        {
            int n = arr.Length;
            int[] lis = new int[n];
            int i, j, max = 0;

            /* Initialize LIS values for all indexes */
            for (i = 0; i < n; i++)
                lis[i] = 1;

            /* Compute optimized LIS values in bottom up manner */
            for (i = 1; i < n; i++)
                for (j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            /* Pick maximum of all LIS values */
            for (i = 0; i < n; i++)
                if (max < lis[i])
                    max = lis[i];

            return max;
        }

        //nlogn complexity
        static int longestIncreasingSubsequence2(int[] array)
        {
            int n = array.Length;
            return LongestIncreasingSubsequenceLength(array, n);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            int result = longestIncreasingSubsequence(arr);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
