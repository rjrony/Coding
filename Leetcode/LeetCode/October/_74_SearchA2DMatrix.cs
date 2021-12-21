using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _74_SearchA2DMatrix
	{
		public static int BinarySearch(int[] inputArray, int key)
		{
			int min = 0;
			int max = inputArray.Length - 1;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (key == inputArray[mid])
				{
					return mid;
				}
				else if (key < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return -1;
		}

		private int SearchRow(int[][] matrix, int target)
		{
			if (matrix.Length == 1) return 0;
			else if (matrix.Length == 2)
			{
				return matrix[1][0] <= target ? 1 : 0;
			}

			var min = 0;
			var max = matrix.Length - 1;

			while (min <= max)
			{
				var mid = (min + max) / 2;
				if (mid == 0 || mid == matrix.Length - 1)
				{
					return mid;
				}

				if (matrix[mid][0]<=target && matrix[mid+1][0] > target)
				{
					return mid;
				}
				else if (matrix[mid+1][0] <= target)
				{
					min = mid + 1;
				}
				else
				{
					max = mid - 1;
				}
			}

			return max;
		}

		public bool SearchMatrix(int[][] matrix, int target)
		{
			if (matrix.Length == 0 || matrix[0].Length == 0) return false;

			var row = SearchRow(matrix, target);
			var index = Array.BinarySearch(matrix[row], target);
			//var index = BinarySearch(matrix[row], target);

			return index > -1;
		}

		public bool SearchMatrix2(int[][] matrix, int target)
		{
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (matrix[i][j] == target) return true;
				}

			}

			return false;
		}

		public void Test()
		{
			//[[1,3,5,7],[10,11,16,20],[23,30,34,50]]
			var matrix = new int[][] {
				new int[] { 1,3,5,7 },
				new int[] { 10,11,16,20 },
				new int[] { 23,30,34,50 }
			};
			Console.WriteLine(SearchMatrix(matrix, 23));
			Console.WriteLine(SearchMatrix(new int[][] { new int[] { 1 }, new int[] { 3 } }, 3));

		}
	}
}
