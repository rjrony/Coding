using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avira
{
    class Program
    {
        public static int solution(int[] A)
        {
            var result = -9;
            foreach (var item in A)
            {
                if (item < 10 && item > -10 && result<item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static int solution2(int[] A)
        {
            int result = 0;

            var list = A.ToList();
            list.Sort();
            var sortedArray = list.ToArray();

            int i = 0;
            int j = A.Length-1;

            while (sortedArray[i] < 0)
            {
                while (sortedArray[j] > -sortedArray[i])
                {
                    --j;
                }

                if (sortedArray[j] == -sortedArray[i])
                {
                    result = sortedArray[j];
                    break;
                }

                ++i;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var result = solution2(new[] {3, 2, -1, 5, -2,3,-10000000, 10000000 });
            Console.WriteLine(result);
            //DecodingMorseCode.Main2(args);
            //MultiplyBigInteger.Main2(args);
            //DarianCalender.Main2(args);

            Dictionary<string, string> openWith =
                new Dictionary<string, string>();

            Console.ReadKey();
        }
    }
}
