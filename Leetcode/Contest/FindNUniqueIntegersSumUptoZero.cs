using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    public class FindNUniqueIntegersSumUptoZero
    {
        public static  int[] SumZero(int n)
        {
            var arr = new int[n];
            var half = n / 2;
            int i = 0;
            for (; i < half; i++)
            {
                arr[i] = -(half-i);
            }

            if (n%2>0)
            {
                arr[i++] = 0;
            }

            var count = 0;
            for (; i < n; i++)
            {
                arr[i] = ++count;
            }

            return arr;
        }
        public static void Solution()
        {
            var output = SumZero(5);
            Console.WriteLine(string.Join(", ", output));

            output = SumZero(6);
            Console.WriteLine(string.Join(", ", output));

            output = SumZero(1);
            Console.WriteLine(string.Join(", ", output));

            output = SumZero(2);
            Console.WriteLine(string.Join(", ", output));

            output = SumZero(3);
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
