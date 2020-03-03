using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_218_PerfectRightAngledTriangles
{
    class Program
    {
        //static long gcd(long a, long b)
        //{
        //    if (a == 0 || b == 0)
        //        return 0;
        //    if (a == b)
        //        return a;
        //    if (a > b)
        //        return gcd(a - b, b);
        //    return gcd(a, b - a);
        //}

        public static long gcd(long p, long q)
        {
            if (q == 0)
            {
                return p;
            }

            long r = p % q;

            return gcd(q, r);
        }

        static long area(long a, long b)
        {
            return a * b / 2;
        }

        public static void Main(string[] args)
        {
            long a, b, c, count = 0;
            long q = Convert.ToInt64(Console.ReadLine());
            for (long k = 0; k < q; k++)
            {
                count = 0;
                long limit = Convert.ToInt64(Console.ReadLine());
                long sqrtValue = (long)Math.Sqrt(limit);
                c = 25;
                //while (c <= limit)
                //{
                //    c = sqrtValue * sqrtValue;
                //    for (a = 1; a < c; a++)
                //    {
                //        b = (long) Math.Sqrt(c*c - a*a);
                //        if (a > b)
                //        {
                //            break;
                //        }

                //        if ((a*a + b*b) == c*c)
                //        {
                //            if (gcd(a, b) == 1 && gcd(b, c) == 1)
                //            {
                //                //if ((area(a, b)%6 != 0) && (area(a, b)%28 != 0))
                //                if (area(a, b)%84 != 0)
                //                {
                //                    count++;
                //                }
                //            }
                //        }
                //    }

                //    sqrtValue = sqrtValue + 1;
                //}

                Console.WriteLine(count);
            }

            //Console.ReadKey();
        }
    }
}
