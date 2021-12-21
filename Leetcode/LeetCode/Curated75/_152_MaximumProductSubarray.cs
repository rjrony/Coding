using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _152_MaximumProductSubarray
	{

		public int MaxProduct(int[] nums)
		{
			int max_curr = nums[0], min_curr = nums[0], res = nums[0];

			for (int i = 1; i < nums.Length; i++)
			{

				int c1 = max_curr * nums[i];
				int c2 = min_curr * nums[i];
				max_curr = Math.Max(nums[i], Math.Max(c2, c1));
				min_curr = Math.Min(nums[i], Math.Min(c1, c2));
				res = Math.Max(max_curr, res);
			}
			return res;
		}

		public int MaxProduct2(int[] nums)
		{
			var maxProduct = nums[0];
			var currentWindowMaxProduct = nums[0];
			var currentWindowMinProduct = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				var temp = currentWindowMaxProduct;
				currentWindowMaxProduct = Math.Max(currentWindowMaxProduct * nums[i], nums[i]);
				currentWindowMaxProduct = Math.Max(currentWindowMaxProduct, currentWindowMinProduct * nums[i]);
				maxProduct = Math.Max(maxProduct, currentWindowMaxProduct);

				currentWindowMinProduct = Math.Min(nums[i], Math.Min(currentWindowMinProduct * nums[i], temp * nums[i]));
			}

			return maxProduct;
		}

		public int MaxProduct1(int[] nums)
		{
			var maxProduct = nums[0];
			for (int i = 0; i < nums.Length; i++)
			{
				var currentWindowProduct = 1;
				for (int j = i; j < nums.Length; j++)
				{
					currentWindowProduct *= nums[j];
					maxProduct = Math.Max(maxProduct, currentWindowProduct);
				}	
			}

			return maxProduct;
		}
	}
}
