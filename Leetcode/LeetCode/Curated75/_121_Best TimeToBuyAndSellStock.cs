using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Curated75
{
	public class _121_Best_TimeToBuyAndSellStock
	{
		public int MaxProfit(int[] prices)
		{
			var maxProfit = 0;
			var minBuyingPrice = int.MaxValue;
			for (int i = 0; i < prices.Length; i++)
			{
				minBuyingPrice = Math.Min(minBuyingPrice, prices[i]);
				maxProfit = Math.Max(maxProfit, prices[i] - minBuyingPrice);
			}

			return maxProfit;
		}
	}
}
