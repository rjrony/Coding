using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class FindAllAnagramsInaString
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

		public IList<int> FindAnagrams(string s, string p)
		{
			var list = new List<int>();
			var n = s.Length;
			var m = p.Length;
			if (n < m) return list;
			var pArr = new int[MAX];
			var sArr = new int[MAX];

			for (int i = 0; i < m; i++)
			{
				pArr[p[i] - 'a']++;
				sArr[s[i] - 'a']++;
			}

			if (IsMatchAnagram(sArr, pArr))
			{
				list.Add(0);
			}

			for (int i = m; i < n; i++)
			{
				sArr[s[i - m] - 'a']--;
				sArr[s[i] - 'a']++;
				if (IsMatchAnagram(sArr, pArr))
				{
					list.Add(i - m + 1);
				}
			}

			return list;
		}
	}
}
