using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.October
{
	public class _187_RepeatedDNASequences
	{
		//two HashSets : better less time & memory
		public IList<string> FindRepeatedDnaSequences(string s)
		{
			if (s.Length < 11) return new List<string>();

			var set = new HashSet<string>();
			var resultSet = new HashSet<string>();
			for (int i = 0; i < s.Length - 9; i++)
			{
				var subStr = s.Substring(i, 10);

				if (set.Contains(subStr))
				{
					resultSet.Add(subStr);
				}
				else
				{
					set.Add(subStr);
				}
			}

			return resultSet.ToList(); //need System.Linq
		}

		//Dictionary & HashSet
		public IList<string> FindRepeatedDnaSequences2(string s)
		{
			if (s.Length < 11) return new List<string>();

			var map = new Dictionary<string, int>();
			var set = new HashSet<string>();
			for (int i = 0; i < s.Length - 9; i++)
			{
				var subStr = s.Substring(i, 10);

				if (map.ContainsKey(subStr))
				{
					set.Add(subStr);
				}
				else
				{
					map.Add(subStr, 1);
				}
			}

			return set.ToList(); //need System.Linq

			//foreach (var item in map)
			//{
			//	if (item.Value>1)
			//	{
			//		list.Add(item.Key);
			//	}
			//}

			//foreach (var item in set)
			//{
			//	list.Add(item);
			//}
			
		}

		public void Test()
		{
			Console.WriteLine(string.Join(',', FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT")));
			Console.WriteLine(string.Join(',', FindRepeatedDnaSequences("AAAAAAAAAAA")));
		}
	}
}
