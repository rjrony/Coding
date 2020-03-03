﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_06_Running_Time_of_Algorithms
{
    class Program
    {
        public static void insertionSort(int[] A)
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
            Console.WriteLine(shiftCount);
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
            Console.ReadKey();
        }
    }
}
