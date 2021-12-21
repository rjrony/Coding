using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
	public class IsSubsequence_
	{
		public bool IsSubsequence(string s, string t)
		{
			var sLen = s.Length;
			var tLen = t.Length;

			int j = 0;
			for (int i = 0; i < tLen && j < sLen; i++)
			{
				if (s[j] == t[i])
				{
					j++;
				}
			}

			return j == sLen ? true : false;
		}
	}
}
