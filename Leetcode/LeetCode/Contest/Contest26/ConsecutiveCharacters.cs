using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Contest.Contest26
{
	public class ConsecutiveCharacters
	{
		
		public int MaxPower(string s)
		{
			int consecutiveCount = 1;
			int max = 1;
			
			for (int i = 1; i < s.Length; i++)
			{
				if (s[i]==s[i-1])
				{
					consecutiveCount++;
				}
				else
				{
					max = Math.Max(max, consecutiveCount);
					consecutiveCount = 1;
				}
			}

			return Math.Max(max, consecutiveCount);
		}
	}
}
