using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_01_big_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = Console.ReadLine();
            }

            Array.Sort(unsorted, CompareDinosByLength);

            foreach (var item in unsorted)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }


        private static int CompareDinosByLength(string x, string y)
        {
            //if (x == null)
            //{
            //    return y == null ? 0 : -1;
            //}

            //if (y == null)
            //{
            //    return 1;
            //}

            //int retval = x.Length.CompareTo(y.Length);
            //return retval != 0 ? retval : x.CompareTo(y);
            return x.Length == y.Length ? string.Compare(x, y, StringComparison.Ordinal) : (x.Length > y.Length ? 1 : -1);
        }
    }
}
