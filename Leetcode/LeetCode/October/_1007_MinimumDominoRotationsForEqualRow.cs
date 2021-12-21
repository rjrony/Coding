using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _1007_MinimumDominoRotationsForEqualRow
	{
		public int MinDominoRotations(int[] A, int[] B)
		{
			var mapA = new int[6];
			var mapB = new int[6];
			for (int i = 0; i < A.Length; i++)
			{
				++mapA[A[i]-1];
				++mapB[B[i]-1];
			}

			var lickyNo = -1;
			for (int i = 0; i < 6; i++)
			{
				if ((mapA[i] + mapB[i]) >= A.Length)
				{
					lickyNo = i + 1;
					break;
				}
			}

			if (lickyNo == -1)
			{
				return -1;
			}

			var bCount = 0;
			var extra = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == lickyNo)
				{
					if (B[i] == lickyNo) ++extra;
					continue;
				}
				else if(B[i] == lickyNo)
				{
					++bCount;
				}
				else
				{
					return -1;
				}
			}

			var aCount = A.Length - bCount - extra;
			return Math.Min(bCount, aCount);
		}

		public void Test()
		{
			//var a = new int[] { 2, 1, 2, 4, 2, 2 };
			//var b = new int[] { 5, 2, 6, 2, 3, 2 };

			var a = new int[] { 3, 5, 1, 2, 3 };
			var b = new int[] { 3, 6, 3, 3, 4 };

			//var a = new int[] { 3, 3, 1, 1, 3 };
			//var b = new int[] { 1, 3, 3, 3, 3 };

			Console.WriteLine(MinDominoRotations(a, b));
		}
	}
}
