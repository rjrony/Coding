using System;
using System.Collections.Generic;

namespace MS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountValidTime(1, 8, 3, 2));
            Console.ReadKey();
        }

        static int CountValidTime(int a, int b, int c, int d)
        {
            var listOfPermution = Permute(new int[] { a, b, c, d });
            int count = 0;
            foreach (var item in listOfPermution)
            {
                int h = item[0] * 10 + item[1];
                int m = item[2] * 10 + item[3];
                if ( (h>=0 && h < 24) &&  (m>=0 && m< 60))
                {
                    ++count;
                }
            }
            return count;
        }
        static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

    }
}
