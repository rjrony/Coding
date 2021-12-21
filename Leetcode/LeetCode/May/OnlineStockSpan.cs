using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
    public class StockSpanner
    {
        Stack<int> stack;
        Dictionary<int, int> dict;
        public StockSpanner()
        {
            stack = new Stack<int>();
            dict = new Dictionary<int, int>();
        }

        public int Next(int price)
        {
            var count = 1;
            while (stack.Count>0 && stack.Peek()<=price)
            {
                count += dict.GetValueOrDefault(stack.Pop());
            }

            stack.Push(price);
            if (dict.ContainsKey(price)) dict[price] = count;
            else dict.Add(price, count);
            return count;
        }
    }

    public class OnlineStockSpan
	{
        public void Test()
        {
            StockSpanner obj = new StockSpanner();
            int param_1 = obj.Next(100);
             param_1 = obj.Next(80);
        }
	}
}
