using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
	//Symbol		Value
	//I             1
	//V             5
	//X             10
	//L             50
	//C             100
	//D             500
	//M             1000
	public class RomanToInteger
	{
		//using Dictionary
		public int RomanToInt(string s)
		{
			var romanNumberDict = new Dictionary<char, Int16>() { 
				{ 'I', 1 },
				{ 'V', 5 },
				{ 'X', 10 },
				{ 'L', 50 },
				{ 'C', 100 },
				{ 'D', 500 },
				{ 'M', 1000 }
			};

			var result = 0;
			int i;
			for (i = 0; i < s.Length-1; i++)
			{
				if (romanNumberDict.GetValueOrDefault(s[i]) < romanNumberDict.GetValueOrDefault(s[i+1])) 
					result -= romanNumberDict.GetValueOrDefault(s[i]);
				else
					result += romanNumberDict.GetValueOrDefault(s[i]);
			}
			result += romanNumberDict.GetValueOrDefault(s[i]);
			return result;
		}

		public int RomanToInt2(string s)
		{
			string romanNumber = "IVXLCDM";
			int[] romanNumberValues = new int[] { 1, 5, 10, 50, 100, 500, 1000 };

			var lastValue = romanNumberValues[romanNumber.IndexOf(s[0])];
			var result = lastValue;
			for (int i = 1; i < s.Length; i++)
			{
				if (romanNumber.IndexOf(s[i - 1]) < romanNumber.IndexOf(s[i])) result = result - lastValue - lastValue;
				lastValue = romanNumberValues[romanNumber.IndexOf(s[i])];
				result += lastValue;				
			}
			return result;
		}
	}
}
