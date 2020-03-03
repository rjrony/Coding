using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    public class SumOfMutatedArrayClosestToTarget
    {
        public static int FindBestValue(int[] arr, int target)
        {
            Array.Sort(arr);
            var items = arr.Length;
            var divisor = target / items;
            var low = divisor * items;
            var high = (divisor + 1) * items;
            var diff = target - low;
            if ((target - low) > (high - target))
            {
                diff = (high - target);
                divisor = divisor + 1;
            }

            var value = divisor;
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var diff2 = Math.Abs(((sum + arr[i] * (items - i)) - target));
                if ((diff2 <= diff) )
                {
                    if (diff2 == diff && divisor <= arr[i])
                    {
                        continue;
                    }
                    value = arr[i];
                }

                sum += arr[i];
            }

            return value;
        }

        public static void Solution()
        {
            int[] input = new int[] { 4, 9, 3 };
            var output = FindBestValue(input,10);
            Console.WriteLine(string.Join(", ", output));

            //input = new int[] { 2, 3, 5 };
            //output = FindBestValue(input, 10);
            //Console.WriteLine(string.Join(", ", output));

            //input = new int[] { 60864, 25176, 27249, 21296, 20204 };
            //output = FindBestValue(input, 56803);
            //Console.WriteLine(string.Join(", ", output));

            input = new int[] { 1547, 83230, 57084, 93444, 70879 };
            output = FindBestValue(input, 71237);
            Console.WriteLine(string.Join(", ", output));

        }
    }
}
