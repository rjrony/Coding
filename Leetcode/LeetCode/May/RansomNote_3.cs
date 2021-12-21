using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
	public class RansomNote_3
	{
		public bool CanConstruct(string ransomNote, string magazine)
		{
			var arr = magazine.ToCharArray();
			foreach (var item in ransomNote)
			{
				var isFound = false;
				for (int i = 0; i < arr.Length; i++)
				{
					if (item == arr[i])
					{
						arr[i] = '0';
						isFound = true;
						break;
					}
				}
				if (isFound==false)
				{
					return false;
				}
			}

			return true;
		}
	}
}
