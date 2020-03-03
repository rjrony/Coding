using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_01_SuperReducedString
{
    class Program
    {
        static string super_reduced_string(string s)
        {
            
            while (true)
            {
                var sLength = s.Length;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Replace(s[i] + s[i + 1].ToString(), string.Empty);
                    }
                }
                var newLength = s.Length;
                if (sLength==newLength)
                {
                    break;
                }
            }
            if (s.Length==0)
            {
                s = "Empty String";
            }
            return s;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = super_reduced_string(s);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
