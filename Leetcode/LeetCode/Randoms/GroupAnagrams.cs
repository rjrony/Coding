using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class GroupAnagrams
	{
		public IList<IList<string>> GroupAnagrams_(string[] strs)
		{
			var listDict = new Dictionary<string, List<string>>();
			foreach (var str in strs)
			{
				var sortedStr = string.Concat(str.OrderBy(x => x));
				if (listDict.ContainsKey(sortedStr)) listDict[sortedStr].Add(str);
				else listDict.Add(sortedStr, new List<string> { str });
			}
			return listDict.Select(x => x.Value).Cast<IList<string>>().ToList();
		}

		public IList<IList<string>> GroupAnagrams_2(string[] strs)
		{
			var dict = new Dictionary<string, List<string>>();

			foreach (var str in strs)
			{
				var sortedStr = string.Concat(str.OrderBy(c => c));
				if (dict.ContainsKey(sortedStr)) dict[sortedStr].Add(str);
				else dict.Add(sortedStr, new List<string>() { str });
			}

			return dict.Select(kvp => kvp.Value).Cast<IList<string>>().ToList();
		}


		//has code concept
		public static readonly List<int> primes = new List<int>() {
		2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43,
		47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};
		public IList<IList<string>> GroupAnagrams_HasCode(string[] strs)
		{
			var dict = new Dictionary<long, IList<string>>();
			foreach (string s in strs)
			{
				long hash = GetHashCode(s);
				if (!dict.ContainsKey(hash))
					dict.Add(hash, new List<string>() { s });
				else
					dict[hash].Add(s);
			}
			return dict.Values.ToList();
		}

		private long GetHashCode(string s)
		{
			long result = 1;
			for (int i = 0; i < s.Length; i++)
				result *= primes[s[i] - 'a'];
			return result;
		}

	}
}
