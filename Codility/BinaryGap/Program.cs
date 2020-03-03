using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        public static int LongestBinaryGap(int number)
        {
            int maxGap = 0;
            while (number != 0)
            {
                if (number%2 != 0)
                {
                    int gap = 0;
                    number = number >> 1;
                    while (number != 0 && (number%2 == 0))
                    {
                        ++gap;
                        number = number >> 1;
                    }

                    if (maxGap < gap)
                    {
                        maxGap = gap;
                    }
                }
                else
                {
                    number = number >> 1;
                }
            }
            return maxGap;
        }

        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            var longestGap = LongestBinaryGap(number);
            Console.WriteLine(longestGap);
            Console.ReadKey();
        }
    }
}
