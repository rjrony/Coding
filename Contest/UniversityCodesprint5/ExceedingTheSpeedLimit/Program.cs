using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceedingTheSpeedLimit
{
    class Program
    {
        // Complete the solve function below.
        static void solve(int s)
        {
            if (s<=90)
            {
                Console.WriteLine("0 No punishment");
            }
            else if (s<=110)
            {
                Console.WriteLine((s - 90)*300 + " Warning");
            }
            else
            {
                Console.WriteLine((s - 90) * 500 + " License removed");
            }
        }

        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine().Trim());

            solve(s);
            Console.ReadKey();
        }
    }
}
