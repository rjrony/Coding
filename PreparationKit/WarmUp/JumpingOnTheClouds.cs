using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class JumpingOnTheClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            int count = -1;
            //bool onJump = false;
            //for (var index = 1; index < c.Length; index++)
            //{
            //    var item = c[index];
            //    if (item == 0 && onJump == false)
            //    {
            //        count++;
            //        onJump = true;
            //    }
            //    else if (item == 1 || onJump == true)
            //    {
            //        onJump = false;
            //    }
            //}
            int n = c.Length;
            for (int i = 1; i < n; i++, count++)
            {
                if (i < n - 2 && c[i + 2] == 0) i++;
            }
            return count;
        }

        public static void JumpingOnTheClouds_Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
                ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
