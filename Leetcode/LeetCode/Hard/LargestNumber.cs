using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Hard
{
	public class LargestNumber_
	{
		//1- simple
		public string LargestNumber(int[] nums)
		{
			var list = (nums.Select(item => item.ToString())).ToList(); //convert from int array to string list
			list.Sort((x, y) => -(x + y).CompareTo(y + x)); //soring with comparing by joining two number. For example: 2,10 now compare with by joining those two numbers (210 & 102)
			var largestNumber = string.Join("", list); //convert the list to single string 
			return largestNumber[0].Equals('0') ? "0" : largestNumber; //if all the input are 0 then only return 0
		}


		//2-write down compare methhod for comparing with every char of both numbers
		public string LargestNumber2(int[] nums)
		{
			
			var list = (nums.Select(item => item.ToString())).ToList();
			list.Sort(Compare);
			return string.Join("", list);
		}

		private int Compare(string s1, string s2)
		{
			int m = s1.Length, n = s2.Length;

			for (int i = 0, j = 0; i < m && j < n;)
			{
				if (s1[i] != s2[j]) return s1[i] - s2[j];   // not equal
				if (i == m - 1 && j == n - 1) return -1; // equal
				else if (i == m - 1) { i = 0; ++j; }        // i back to begin
				else if (j == n - 1) { j = 0; ++i; }        // j back to begin
				else { ++i; ++j; }
			}
			return -1;
		}

		//public int compare(String s1, String s2)
		//{
		//	int len1 = s1.Length;
		//	int len2 = s2.Length;
		//	int i = 0;
		//	while (i < 2 * len1 || i < 2 * len2)
		//	{
		//		int index1 = i % len1;
		//		int index2 = i % len2;
		//		if (s1.ElementAt(index1) > s2.ElementAt(index2)) return -1;
		//		else if (s1.ElementAt(index1) < s2.ElementAt(index2)) return 1;
		//		i++;
		//	}
		//	return 0;
		//}
	}
}
