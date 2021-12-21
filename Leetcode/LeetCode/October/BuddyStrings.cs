using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class BuddyStrings_
	{
		public bool BuddyStrings(string A, string B)
		{
			var len = A.Length;
			if (len < 2 || A.Length != B.Length) return false;

			var misMatchIndex = -1;
			var secondIndex = -1;
			for (int i = 0; i < len; i++)
			{
				if (A[i] != B[i] && misMatchIndex == -1) misMatchIndex = i;
				else if (A[i] != B[i] && misMatchIndex > -1)
				{
					secondIndex = i;
					break;
				}
			}


			if (misMatchIndex > -1 && secondIndex > -1)
			{
				var sb = new StringBuilder(A);
				var misChar = A[misMatchIndex];
				sb[misMatchIndex] = sb[secondIndex];
				sb[secondIndex] = misChar;

				var newA = sb.ToString();
				//var newA = A.Substring(0, misMatchIndex) + A[secondIndex]
				//	+ A.Substring(misMatchIndex + 1, secondIndex - misMatchIndex - 1)
				//	+ A[misMatchIndex] + A.Substring(secondIndex + 1);

				if (newA == B) return true;
			}
			else if (misMatchIndex == -1 ) //case: "aa","aa"
			{
				var hashSet = new HashSet<char>(A);
				if (hashSet.Count < len) return true;
			}

			return false;
		}
	}
}
