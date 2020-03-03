using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_07_Quicksort_1_Partition
{
    class Program
    {
        static void partition(int[] ar)
        {
            //int[] leftArray=new int[ar.Length];
            //int[] rightArray = new int[ar.Length];
            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();

            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[0] > ar[i])
                {
                    leftArray.Add(ar[i]);
                }
                else
                {
                    rightArray.Add(ar[i]);
                }
            }
            Console.Write(string.Join(" ",leftArray));
            Console.Write(" " + ar[0] + " ");
            Console.Write(string.Join(" ",rightArray));

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

            partition(_ar);
            Console.ReadKey();
        }
    }
}
