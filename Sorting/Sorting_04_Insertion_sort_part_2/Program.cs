using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_04_Insertion_sort_part_2
{
    class Program
    {
        static void display(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] partialInsertionSort(int[] ar, int length)
        {
            var e = ar[length - 1];
            bool flag = false;
            for (int i = length - 2; i >= 0; i--)
            {
                if (e < ar[i])
                {
                    ar[i + 1] = ar[i];
                }
                else
                {
                    ar[i + 1] = e;
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                ar[0] = e;
            }
            return ar;
        }
        static void insertionSort(int[] ar)
        {
            for (int i = 2; i <= ar.Length; i++)
            {
                ar = partialInsertionSort(ar, i);
                display(ar);
            }
        }
        static void Main(string[] args)
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

            insertionSort(_ar);
            Console.ReadKey();
        }
    }
}
