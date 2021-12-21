using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.October
{
	public class _735_AsteroidCollision
	{
		public int[] AsteroidCollision2(int[] asteroids)
		{
			LinkedList<int> q = new LinkedList<int>();
			int i = 0;
			for (; i < asteroids.Length; i++)
			{
				int speed = asteroids[i];
				if (speed > 0 || q.Count>0 || q.Last.Value < 0)
				{
					q.AddLast(speed);
					continue;
				}
				int pre = q.Last.Value;
				if (pre > -speed)
				{
					continue;
				}
				else if (pre == -speed)
				{
					q.RemoveLast();
				}
				else
				{
					q.RemoveLast();
					i--;
				}
			}

			//int[] res = new int[q.Count];
			//i = 0;
			//foreach (int num in q)
			//{
			//	res[i++] = num;
			//}
			return q.ToArray();
		}

		public int[] AsteroidCollision(int[] asteroids)
		{
			if (asteroids == null || asteroids.Length <= 1) return asteroids;
	
			Stack<int> stack = new Stack<int>();
			foreach (int cur in asteroids)
			{
				if (cur > 0)
				{ // previous one does not matter, no collision forever
					stack.Push(cur);
				}
				else
				{
					while (stack.Count>0 && stack.Peek() > 0 && -cur > stack.Peek())
					{ // destroy the previous positive one(s) 
						stack.Pop();
					}
					if (stack.Count == 0 || stack.Peek() < 0)
					{
						stack.Push(cur);
					}
					else if (stack.Peek() == -cur) //case: [8,-8]
					{
						stack.Pop();
					}
				}
			}

			var arr = stack.ToArray();
			Array.Reverse(arr);
			return arr;
		}

        public void Test()
        {
			Console.WriteLine(string.Join(',', AsteroidCollision2(new int[] { 5, 10, -5 })));
			Console.WriteLine(string.Join(',', AsteroidCollision2(new int[] { 8, -8 })));
			//Console.WriteLine(string.Join(',', AsteroidCollision(new int[] { 10, 2, -5 })));
			//Console.WriteLine(string.Join(',', AsteroidCollision(new int[] { -2, -1, 1, 2 })));

		}
	}
}
