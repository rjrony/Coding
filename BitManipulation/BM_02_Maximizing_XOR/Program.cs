using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM_02_Maximizing_XOR
{
    class Program
    {
        static int maxXor(int l, int r)
        {
            var max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    var xorVal = i ^ j;
                    if (xorVal > max)
                    {
                        max = xorVal;
                    }
                }
            }

            return max;
        }

        static void Main(String[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
