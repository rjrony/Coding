using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_09_DayOfTheProgrammer
{
    class Program
    {
        static bool isLeapYear(int year)
        {
            var isleapyear = false;
            if (year < 1918 && year%4 == 0)
            {
                isleapyear = true;
            }
            else if (year > 1917 && ((year%400 == 0) || (year%4 == 0 && year%100 != 0)))
            {
                isleapyear = true;
            }

            return isleapyear;
        }
        static string solve(int year)
        {
            var first8MonthsDays = isLeapYear(year) ? 244 : 243;
            if (year == 1918)
            {
                first8MonthsDays = 243 - 13;
            }
            return (256 - first8MonthsDays) + ".09." + year;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine());

            string result = solve(year);
            Console.WriteLine(result);
            Console.ReadKey();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
