using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_08_Quicksort_2_Sorting
{
    class Program
    {
        static int[] quickSort2(int[] ar)
        {
            //Console.WriteLine("input: " + string.Join(" ", ar));
            if (ar.Length <= 1) return ar;

            var pivot = ar[0];
            var less = ar.Where(s => s < pivot).ToArray();
            var more = ar.Where(s => s > pivot).ToArray();

            less = quickSort2(less);
            more = quickSort2(more);

            var arr = new List<int>(less);
            arr.Add(pivot);
            arr = arr.Concat(more).ToList();
            if(arr.Count>1) Console.WriteLine(string.Join(" ", arr));

            return arr.ToArray();
        }

        static void quickSort(int[] ar)
        {
            quickSort2(ar);

        }
        /* Tail starts here */
        static void Main(String[] args)
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            quickSort(_ar);
            Console.ReadKey();
        }

    }
}
