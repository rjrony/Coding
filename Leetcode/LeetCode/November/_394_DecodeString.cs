using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _394_DecodeString
	{
		public string DecodeString(string s)
		{
            var sb = new StringBuilder();

            var times = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    var stringNumber = new StringBuilder();
                    while (s[i] >= '0' && s[i] <= '9')
                    {
                        stringNumber.Append(s[i]);
                        i++;
                    }

                    times = Int32.Parse(stringNumber.ToString());
                    i++;
                    var decodeString = new StringBuilder();
                    while (s[i] != ']')
                    {
                        decodeString.Append(s[i]);
                        i++;
                    }

                    MultipleAppend(sb, decodeString.ToString(), times);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public void MultipleAppend(StringBuilder sb, string newStr, int times)
        {
            for (int i = 0; i < times; i++)
            {
                sb.Append(newStr);
            }
        }

        public void Test()
		{
			Console.WriteLine(DecodeString("3[a]2[bc]"));

        }
	}
}
