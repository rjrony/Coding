using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
	public class H_IndexII
	{
		public int HIndex(int[] citations)
		{
			var len = citations.Length - 1;
			var max= len;
			var min = 0;
			var mid = 0;
			while (max>=min)
			{
				mid = (max + min) / 2;
				//if (citations[mid] == (len - mid))
				//{
				//	break;
				//}
				//else 
				if (citations[mid] > (len - mid))
				{
					max = mid - 1;
				}
				else min = mid + 1;
			}
			return len - max;
		}

		public int HIndex2(int[] citations)
		{
			var len = citations.Length - 1;
			var i = len;
			for (; i >= 0; --i)
			{
				Console.WriteLine((len - i) + " " + citations[i]);
				if ((len - i) >= citations[i])
				{
					break;
				}
			}
			return len - i;
		}
	}
}
