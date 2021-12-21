using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class PerformStringShifts
	{
		public string StringShift(string s, int[][] shift)
		{
			var shiftCount = 0;
			foreach (var item in shift)
			{
				shiftCount += item[0] == 0 ? item[1] : (-1)*item[1];
			}

			var length = s.Length;
			shiftCount %= length;
			if (shiftCount == 0) return s;
			
			StringBuilder sb = new StringBuilder();
			if (shiftCount < 0)
			{
				sb.Append(s.Substring(length + shiftCount));
				sb.Append(s.Substring(0, length + shiftCount));
			}
			else
			{
				sb.Append(s.Substring(shiftCount));
				sb.Append(s.Substring(0, shiftCount));
			}

			return sb.ToString();
		}
	}
}
