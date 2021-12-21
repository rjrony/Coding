using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.October
{
	public class _456_132Pattern
	{


		//O(N^3)
		public bool Find132pattern3(int[] nums)
		{

			for (int i = 0; i < nums.Length - 2; i++)
			{
				for (int j = i + 1; j < nums.Length - 1; j++)
				{
					if (nums[j] > nums[i])
						for (int k = j + 1; k < nums.Length; k++)
						{
							if (nums[k] > nums[i] && nums[j] > nums[k])
							{
								return true;
							}
						}
				}
			}

			return false;
		}

		//O(N^2)
		public bool Find132pattern2(int[] nums)
		{
			if (nums.Length < 3) return false;

			int min = Int32.MaxValue;
			for (int j = 0; j < nums.Length; j++)
			{
				min = Math.Min(min, nums[j]);
				if (nums[j] == min) continue;

				for (int k = j + 1; k < nums.Length; k++)
				{
					if (nums[j] > nums[k] && nums[k] > min)
					{
						return true;
					}
				}
			}

			return false;
		}

		public bool Find132pattern1(int[] nums)
		{
			MQ queue = new MQ();

			for (int i = nums.Length - 1; i >= 0; i--)
			{
				if (queue.push(nums[i]))
				{
					return true;
				}
			}

			return false;
		}

		private class MQ
		{
			private Queue<int> queue;
			private int prev;

			public MQ()
			{
				queue = new Queue<int>();
				prev = int.MinValue;
			}

			public bool push(int cur)
			{
				if (prev > cur)
				{
					return true;
				}

				while (queue.Count>0 && queue.Peek() < cur)
				{
					prev = queue.Peek();
					queue.Dequeue();
				}

				queue.Enqueue(cur);
				return false;
			}
		}

		public bool Find132pattern(int[] nums)
		{
			var n = nums.Length;
			if (n < 3) return false;

			int[] min = new int[n];
			Stack<int> stack = new Stack<int>();

			min[0] = nums[0];

			// pre compute i values 
			for (int i = 1; i < n; i++)
			{
				min[i] = Math.Min(min[i - 1], nums[i]);
			}

			for (int j = n - 1; j >= 0; j--)
			{
				if (nums[j] > min[j])
				{ // found i,j now lets search for k
					while (stack.Count > 0 && stack.Peek() <= min[j]) // until  a[i]<a[c]) remove elemets from stack
					{
						stack.Pop();
					}
					if (stack.Count > 0 && stack.Peek() < nums[j]) // found k -> a[j]>a[k]
					{
						return true;
					}
					stack.Push(nums[j]);
				}
			}

			return false;
		}

		public void Test()
		{
			Console.WriteLine(Find132pattern(new int[] { 1, 4, 2 }));
			Console.WriteLine(Find132pattern(new int[] { 3, 1, 4, 2 }));
			Console.WriteLine(Find132pattern(new int[] { 1, 0, 1, -4, -3, 5 }));
			Console.WriteLine(Find132pattern(new int[] { 42, 43, 6, 12, 3, 4, 6, 11, 20 }));
		}
	}


}
