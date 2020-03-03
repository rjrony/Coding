using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    public class ReplaceElementsWithGreatestElementOnRightSide
    {
        public static int[] ReplaceElements(int[] arr)
        {
            var max = Int32.MinValue;
            for (int i = 0; i < arr.Length-1; i++)
            {
                
                if (arr[i] < max)
                {
                    arr[i] = max;
                    continue;
                }
                max = Int32.MinValue;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (max < arr[j])
                    {
                        max = arr[j];
                    }
                }

                arr[i] = max;
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }

        public static void Solution()
        {
            int[] input = new int[] {17, 18, 5, 4, 6, 1};
            var output = ReplaceElements(input);
            Console.WriteLine(string.Join(", ", output));

        }
    }
}
