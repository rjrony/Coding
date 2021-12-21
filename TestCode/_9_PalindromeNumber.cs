using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _9_PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            var num = x;
            var num2 = x;
            var isPalindrome = false;
            var maxDivisor = 1;
            var list = new List<int>();
            while ( x > 10)
            {
                maxDivisor = maxDivisor * 10;
                list.Add(x % maxDivisor);
                x /= maxDivisor;
            }

            //for (int i = 10; i < maxDivisor;)
            //{
            //    var y = num % i;
            //    var z = num2 % maxDivisor;
            //}

            return isPalindrome;
        }

        public static void Solution()
        {
            var result = IsPalindrome(121);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
