using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        public static int fibo(int n)
        {
            if (n <= 2)
                return 1;

            else
                return fibo(n - 2) + fibo(n - 1);
        }

        static void Main2(string[] args)
        {
            Console.WriteLine(fibo(7));
            Console.WriteLine(fibo(10));
            Console.ReadKey();
        }
    }
}
