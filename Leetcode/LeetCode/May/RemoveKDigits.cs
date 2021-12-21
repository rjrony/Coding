using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/explore/challenge/card/may-leetcoding-challenge/535/week-2-may-8th-may-14th/3328/
namespace LeetCode.May
{
	class RemoveKDigits
	{
		public string RemoveKdigits(string num, int k)
		{
			if (num.Length == k) return "0";

			var arr = num.ToCharArray();
			int j = 0;
			for (int i = 1; i < arr.Length && k>0; i++)
			{
				if (arr[j] < arr[i])
				{
					arr[i] = arr[j];
					arr[j] = '0';
					j++;
					k--;
				}
				else if (arr[j] > arr[i])
				{
					arr[j] = '0';
					j++;
					k--;
				}
			}

			while (k > 0)
			{
				arr[j] = '0';
				j++;
				k--;
			}
			var result = new string(arr).TrimStart('0');
			return result.Length > 0 ? result : "0";
		}
	}
}
