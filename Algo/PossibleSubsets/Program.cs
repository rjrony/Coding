using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleSubsets
{
    class Program
    {
        static void possibleSubsets(char[] A, int N)
        {
            for (int i = 0; i < (1 << N); ++i)
            {
                for (int j = 0; j < N; ++j)
                    if ((i & (1 << j)) > 0)
                        Console.Write(A[j]+" ");
                Console.WriteLine();
            }
        }

        // Print all subsets of given set[] 
        static void printSubsets(char[] set)
        {
            int n = set.Length;

            // Run a loop for printing all 2^n subsets one by obe 
            for (int i = 0; i < (1 << n); i++)
            {
                Console.Write("{ ");

                // Print current subset 
                for (int j = 0; j < n; j++)

                    // (1<<j) is a number with jth bit 1 so when we 'and' them with the 
                    // subset number we get which numbers are present in the subset and which are not 
                    if ((i & (1 << j)) > 0)
                        Console.Write(set[j] + " ");

                Console.WriteLine("}");
            }
        }
        static void Main(string[] args)
        {
            var A= new char[] {'a', 'b', 'c'};
            possibleSubsets(A, 3);

            char[] set = { 'a', 'b', 'c' };
            printSubsets(set);
            Console.ReadKey();
        }
    }
}
