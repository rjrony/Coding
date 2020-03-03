using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Test2
    {
        StringBuilder add(StringBuilder a, StringBuilder b)
        {
            int p1 = a.length() - 1;
            int p2 = b.length() - 1;
            int c = 0;
            StringBuilder sb = new StringBuilder();
            while (p1 >= 0 && p2 >= 0)
            {
                int d1 = a.charAt(p1) - '0';
                int d2 = b.charAt(p2) - '0';
                int s = (d1 + d2 + c);
                int d3 = (s % 10);
                c = s / 10;
                sb.append((char)(d3 + '0'));
                p1--;
                p2--;
            }
            while (p1 >= 0)
            {
                int d1 = a.charAt(p1) - '0';
                int s = (d1 + c);
                int d = s % 10;
                c = s / 10;
                sb.append((char)(d + '0'));
                p1--;
            }
            while (p2 >= 0)
            {
                int d1 = b.charAt(p2) - '0';
                int s = (d1 + c);
                int d = s % 10;
                c = s / 10;
                sb.append((char)(d + '0'));
                p2--;
            }
            if (c > 0) sb.append((char)(c + '0'));
            int sbLen = sb.length() - 1;
            while (sbLen > 0 && sb.charAt(sbLen) == '0')
            {
                sb.deleteCharAt(sbLen);
                sbLen--;
            }
            if (sb.length() == 0) return new StringBuilder("0");
            sb.reverse();
            return sb;
        }

        public string multiply(string num1, string num2)
        {
            StringBuilder ans = new StringBuilder("0");
            int pos = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                StringBuilder currentResult = new StringBuilder();
                for (int x = 0; x < pos; x++)
                {
                    currentResult.Append("0");
                }
                int md = num1[i] - '0';
                int c = 0;
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int cd = num2[j] - '0';
                    int s = (cd * md) + c;
                    int ad = (s % 10); // ans digit
                    c = s / 10;
                    currentResult.Append((char)(ad + '0'));
                }
                if (c > 0)
                {
                    currentResult.Append((char)(c + '0'));
                }
                int sbLen = currentResult.Length - 1;
                while (sbLen > 0 && currentResult[sbLen] == '0')
                {
                    currentResult.Remove(sbLen, 1);
                    sbLen--;
                }
                if (currentResult.Length == 0) currentResult = new StringBuilder("0");
                currentResult.reverse();
                ans = add(ans, currentResult);
                pos++;
            }
            return ans.ToString();
        }

        public static void Main2(string[] args)
        {
            string num1 = "123"; //Console.ReadLine();

            string num2 = "222"; //Console.ReadLine();

            string res = multiply(num1, num2);

            Console.WriteLine(res);
        }
    }
}
