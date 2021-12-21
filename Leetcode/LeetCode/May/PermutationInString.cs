using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class PermutationInString
	{
		const int MAX = 26;
		private bool IsMatchAnagram(int[] s, int[] p)
		{
			for (int i = 0; i < MAX; i++)
			{
				if (s[i] != p[i]) return false;
			}
			return true;
		}

		public bool CheckInclusion(string s1, string s2)
		{
			var m = s1.Length;
			var n = s2.Length;
			if (n < m) return false;
			var pArr = new int[MAX]; //subString
			var sArr = new int[MAX]; //main string

			for (int i = 0; i < m; i++)
			{
				pArr[s1[i] - 'a']++;
				sArr[s2[i] - 'a']++;
			}

			if (IsMatchAnagram(sArr, pArr)) return true;

			for (int i = m; i < n; i++)
			{
				sArr[s2[i - m] - 'a']--;
				sArr[s2[i] - 'a']++;
				if (IsMatchAnagram(sArr, pArr)) return true;
			}
			return false;
		}
	}
}
