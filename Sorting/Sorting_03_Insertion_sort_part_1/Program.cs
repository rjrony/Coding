using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_03_Insertion_sort_part_1
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

        static void insertionSort(int[] ar)
        {
            var e = ar[ar.Length - 1];
            bool flag = false;
            for (int i = ar.Length - 2; i >= 0; i--)
            {
                if (e < ar[i])
                {
                    ar[i + 1] = ar[i];
                    display(ar);
                }
                else
                {
                    ar[i + 1] = e;
                    display(ar);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                ar[0] = e;
                display(ar);
            }
        }

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

            insertionSort(_ar);
            Console.ReadKey();
        }
    }
}
