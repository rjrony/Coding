using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    public class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            int length = s.Length;
            long count = 0;
            foreach (var item in s)
            {
                if (item == 'a') count++;
            }

            long totalCount = n / length * count;
            long remaining = n - (n / length) * length;
            for (int i = 0; i < remaining; i++)
            {
                if (s[i] == 'a') totalCount++;
            }
            return totalCount;

        }

        public static void RepeatedString_Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
