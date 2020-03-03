using System;

namespace Optiver
{
    public class DarianCalender
    {
        static int calc_days_between(string start, string end)
        {
            int s_day =  Int32.Parse(start.Substring(0, 2));
            int s_month = Int32.Parse(start.Substring(2, 2));
            int s_year = Int32.Parse(start.Substring(4));
            int e_day = Int32.Parse(end.Substring(0, 2));
            int e_month = Int32.Parse(end.Substring(2, 2));
            int e_year = Int32.Parse(end.Substring(4));
            if (s_year == e_year)
            {
                return calc_same_year(s_day, s_month, s_year, e_day, e_month);
            }
            int beginDays = calc_same_year(s_day, s_month, s_year, get_number_of_days_for_month(24, s_year), 24);
            int endDays = calc_same_year(1, 1, e_year, e_day, e_month) + 1;
            int btw = calc_year_between(s_year + 1, e_year - 1);
            return beginDays + endDays + btw;
        }

        private static int calc_same_year(int s_day, int s_month, int year, int e_day, int e_month)
        {
            if (s_month == e_month) return e_day - s_day;
            return remaining_days_of_month(s_day, s_month, year) + e_day + calc_month_between(s_month + 1, e_month - 1, year);
        }

        private static int calc_month_between(int s_month, int e_month, int year)
        {
            int tot = 0;
            for (int i = s_month; i <= e_month; i++)
            {
                tot += get_number_of_days_for_month(i, year);
            }
            return tot;
        }

        private static int remaining_days_of_month(int s_day, int s_month, int year)
        {
            return get_number_of_days_for_month(s_month, year) - s_day;
        }

        private static int calc_year_between(int s_year, int e_year)
        {
            if (s_year > e_year) return 0;
            int numberOfDecades = (e_year - s_year + 1) / 10;
            int res = numberOfDecades * ((6 * 669) + 4 * (668));
            int next = s_year + (numberOfDecades * 10);
            for (int i = next; i <= e_year; i++)
            {
                res += leapYear(i) ? 669 : 668;
            }
            return res;
        }

        private static int get_number_of_days_for_month(int s_month, int s_year)
        {
            // first five month of any quarter
            if (s_month % 6 != 0) return 28;
            if (s_month == 24 && leapYear(s_year)) return 28;
            return 27;
        }

        private static bool leapYear(int s_year)
        {
            return s_year % 10 == 0 || s_year % 2 == 1;
        }

        public static void Main2(string[] args)
        {
            //string start = "01012010"; //Console.ReadLine();
            //string end = "10012010"; //Console.ReadLine();

            //string start = "01012010";
            //string end = "01022010";

            string start = "01012010";
            string end = "01012011";

            int res = calc_days_between(start, end);

            Console.WriteLine(res);
        }
    }
}
