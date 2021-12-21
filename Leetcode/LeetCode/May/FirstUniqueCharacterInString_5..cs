using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class FirstUniqueCharacterInString_5
	{
		public int FirstUniqChar(string s)
		{
			var map = new Dictionary<char, int>();
			foreach (var item in s)
			{
				if (!map.TryAdd(item,1)) ++map[item];
			}

			foreach (var item in map)
			{
				if (item.Value==1) return s.IndexOf(item.Key);
			}
			return -1;
		}
	}
}
