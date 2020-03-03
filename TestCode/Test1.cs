using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Test1
    {
        static string multiply(string num1, string num2)
        {
            return "tested";
        }

        public static int countNonUnique(List<int> numbers)
        {
            var count = 0;
            var arr = new Int32[1001];
            foreach (var item in numbers)
            {
                if (arr[item]>1)
                {
                    ++count;
                }
                else if (arr[item] > 0)
                {
                    arr[item] = 1;
                }

                
            }
            return count;
        }

        public static int arraySum(List<int> numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        public static string lastLetters(string word)
        {
            var len = word.Length;
            var result = word[len - 1] + " " + word[len - 2];
            return result;
        }

        public static void Main2(string[] args)
        {
            string num1 = "123"; //"1235421415454545454545454544"; //Console.ReadLine();

            string num2 = "0"; //"1714546546546545454544548544544545"; //Console.ReadLine();

            //string res = multiply(num1, num2);

            string str = "tttttt";//Console.ReadLine();
            var arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 5 != 0) arr[i] = ' ';
                else if (i % 3 != 0) arr[i] = Char.ToUpper(arr[i]);
            }

            Console.WriteLine(arr);
        }
    }
}
