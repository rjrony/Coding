using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class ValidParenthesisString
	{
		public bool CheckValidString(string s)
		{
			int bal = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(' || s[i] == '*') bal++;
				else if (bal-- == 0) return false;
			}
			if (bal == 0) return true;
			bal = 0;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (s[i] == ')' || s[i] == '*') bal++;
				else if (bal-- == 0) return false;
			}
			return true;
		}

		//my try
		public bool CheckValidString_(string s)
		{
			var isValid = true;
			var stack = new Stack<char>();

			foreach(var ch in s)
			{
				if (ch == '(')
				{
					stack.Push(ch);
				}
				else if (ch == ')')
				{
					if (stack.Count==0)
					{
						isValid = false;
						break;
					}

					var tempCh = stack.Pop();
					if (tempCh!='(')
					{
						isValid = false;
						break;
					}
				}
			}

			if (isValid==true && stack.Count==0)
			{
				isValid = true;
			}

			return isValid;
		}
	}
}
