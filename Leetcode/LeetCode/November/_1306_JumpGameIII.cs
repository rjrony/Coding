using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.November
{
	public class _1306_JumpGameIII
	{
		//public bool CanReach(int[] arr, int start) ///tricky solution; without dectionary
		//{
		//	if (start >= arr.Length || start < 0) return false;
		//	if (arr[start] == 0) return true;

		//	int jump = arr[start];
		//	arr[start] = arr.Length; //trick is here; jump outside array

		//	if (CanReach(arr, start + jump))
		//	{
		//		return true;
		//	}

		//	if (CanReach(arr, start - jump))
		//	{
		//		return true;
		//	}

		//	return false;
		//}

		//with dictionary
		Dictionary<int, bool> memo = new Dictionary<int, bool>();
		public bool CanReach(int[] arr, int start)
		{
			if (start >= arr.Length || start < 0) return false;
			if (memo.ContainsKey(start)) return memo[start];

			bool res = false;
			memo.Add(start, res);   //to avoid cycles

			if (arr[start] == 0) res = true;
			else
			{
				int offset = arr[start];
				res = CanReach(arr, start + offset);
				if (!res)
					res = CanReach(arr, start - offset);
			}

			memo[start] = res;
			return res;
		}

		public void Test()
		{

			Console.WriteLine(CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 5)); //true
		}
	}
}
