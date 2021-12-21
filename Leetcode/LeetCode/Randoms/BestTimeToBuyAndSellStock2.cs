using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class BestTimeToBuyAndSellStock2
	{
		//https://medium.com/@punitkmr/best-time-to-buy-and-sell-stock-ii-7826845144eb
		//Simple One Pass: Time complexity : O(n), Space complexity: O(1)
		public static int MaxProfit(int[] prices)
		{
			int diff = 0;
			for (int i = 1; i < prices.Length; i++)
			{
				if (prices[i] > prices[i - 1])
				{
					diff += prices[i] - prices[i - 1];
				}
			}
			return diff;
		}

		////Peak Valley Approach: Time complexity : O(n), Space complexity : O(1)
		//public static int MaxProfit(int[] prices)
		//{
		//	int i = 0;
		//	int valley = prices[0];
		//	int peak = prices[0];
		//	int maxprofit = 0;
		//	while (i < prices.Length - 1)
		//	{
		//		while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
		//			i++;
		//		valley = prices[i];
		//		while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
		//			i++;
		//		peak = prices[i];
		//		maxprofit += peak - valley;
		//	}
		//	return maxprofit;
		//}

		////Recursive function: Time complexity : O(n^n), Space complexity : O(n)
		//public static int MaxProfit(int[] prices)
		//{
		//	return calculate(prices, 0);
		//}
		//public static int calculate(int[] prices, int s)
		//{
		//	if (s >= prices.Length) return 0;
		//	int max = 0;
		//	for (int start = s; start < prices.Length; start++)
		//	{
		//		int maxprofit = 0;
		//		for (int i = start + 1; i < prices.Length; i++)
		//		{
		//			if (prices[start] < prices[i])
		//			{
		//				int profit = calculate(prices, i + 1) + prices[i] - prices[start];
		//				if (profit > maxprofit)maxprofit = profit;
		//			}
		//		}
		//		if (maxprofit > max) max = maxprofit;
		//	}
		//	return max;
		//}
	}
}
