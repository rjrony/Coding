using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class RemoveDuplicateLetters_
	{
		public string RemoveDuplicateLetters(string s)
		{
			int[] arr = new int[26];
			StringBuilder sb = new StringBuilder();
			foreach (var item in s)
			{
				if (arr[(item - 'a')] == 0)
				{
					arr[(item - 'a')] = 1;
				}
			}

			for (int i = 0; i < 26; i++)
			{
				if (arr[i] == 1) sb.Append((char)(i + 'a'));
			}

			return sb.ToString();
		}
	}
}
