using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace PE_193_SquarefreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);
            int n = iInput[0];
            int p = iInput[1];
            int result = 0;
            int maxCount = n >> p;
            //for (int i = 2; i <= maxCount; i++)
            //{
            //    double temp = n >> i;
            //}

            Console.WriteLine(n - maxCount - 1);
            //Console.WriteLine(n >> p);
            Console.ReadKey();
        }
    }
}
