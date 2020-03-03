using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    public class CountingValleys
    {
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int count = 0;
            foreach (char c in s)
            {
                if (c=='U')
                {
                    if (++level == 0)
                        count++;
                }
                else
                {
                    --level;
                }
            }

            return count;
        }

        public static void CountingValleys_Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 8; //Convert.ToInt32(Console.ReadLine());

            string s = "UDDDUDUU"; //Console.ReadLine();

            int result = countingValleys(n, s);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
