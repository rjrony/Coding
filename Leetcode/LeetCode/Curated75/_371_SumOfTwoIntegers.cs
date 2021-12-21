using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	//https://stackoverflow.com/questions/38557464/sum-of-two-integers-without-using-operator-in-python
	//https://leetcode.com/problems/sum-of-two-integers/discuss/830857/Java-Beats-100-percent-runtime-(Please-do-upVote-if-you-like-it)


	public class _371_SumOfTwoIntegers
	{
		public int GetSum(int a, int b)
		{
			while (b!=0)
			{
				//var temp = a ^ b;
				//b = (a & b) << 1;
				//a = temp;
				int carry = a & b;
				a = a ^ b;
				b = carry << 1;
			}
			return a;
		}
	}
}
