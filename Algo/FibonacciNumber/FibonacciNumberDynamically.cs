//https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class FibonacciNumberDynamically
    {
        private static int[] memory = new int[500];
        private static int fibo(int n) //using recursion
        {
            if (n <= 2)
                return 1;

            if (memory[n] != 0)
                return memory[n];

            int s = fibo(n - 1) + fibo(n - 2);
            memory[n] = s;
            return s;
        }

        static int fib(int n) //using loop
        {

            // Declare an array to 
            // store Fibonacci numbers.
            // 1 extra to handle 
            // case, n = 0
            int[] f = new int[n + 2];
            int i;

            /* 0th and 1st number of the series are 0 and 1 */
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers in the series and store it */
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fibo(7));
            Console.WriteLine(fibo(8));
            Console.ReadKey();
        }
    }
}
