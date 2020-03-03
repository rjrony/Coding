using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_10_Running_Time_of_Quicksort
{
    class Program
    {
        private static int swapCount = 0;
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
            int[] copyArray = new int[_ar_size];
            _ar.CopyTo(copyArray, 0);

            swapCount = 0;
            QuickSort(_ar, 0, _ar_size - 1);
            var insertionSortCost = insertionSort(copyArray);
            //Console.WriteLine(Math.Abs(insertionSortCost - swapCount));
            Console.WriteLine(insertionSortCost - swapCount);

            Console.ReadKey();
        }

        /*quick sort*/
        public static void QuickSort(int[] iInput, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(iInput, start, end);
                QuickSort(iInput, start, pivot - 1);
                QuickSort(iInput, pivot + 1, end);
            }
        }

        public static int Partition(int[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] <= pivot)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                    swapCount++;
                }
            }
            swapCount++;
            int anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }

        /*end quick sort*/

        /*insertion sort*/
        public static int insertionSort(int[] A)
        {
            var j = 0;
            int shiftCount = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                    shiftCount++;
                }
                A[j + 1] = value;
            }
            return shiftCount;
        }
        /*end insertion sort*/
    }
}
