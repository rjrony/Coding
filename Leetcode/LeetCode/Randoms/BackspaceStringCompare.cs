using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Randoms
{
	public class BackspaceStringCompare
	{
		public bool BackspaceCompare(string S, string T)
		{
			var isEqual = false;
			var str1 = GetSanitizedString(S);
			var str2 = GetSanitizedString(T);
			if (str1 == str2)
			{
				isEqual = true;
			}

			return isEqual;
		}

		private static string GetSanitizedString(string S)
		{
			StringBuilder sb = new StringBuilder();
			int backspaceCount = 0;
			for (int i = S.Length - 1; i >= 0; i--)
			{
				if (S[i] == '#') ++backspaceCount;
				else if (S[i] != '#' && backspaceCount > 0) --backspaceCount;
				else sb.Append(S[i]);
			}

			return sb.ToString();
		}
	}
}
