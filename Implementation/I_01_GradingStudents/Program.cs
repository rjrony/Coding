﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_01_GradingStudents
{
    class Program
    {
        static int[] gradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > 37)
                {
                    var mod = grades[i]%5;
                    if (mod > 2)
                    {
                        grades[i] += (5-mod);
                    }
                }
            }
            return grades;
        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            tw.WriteLine(string.Join("\n", result));

            tw.Flush();
            tw.Close();
        }
    }
}
