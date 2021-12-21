using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Rony
{
    //https://leetcode.com/problems/snakes-and-ladders/discuss/?currentPage=1&orderBy=most_relevant&query=c%23

    public class _909_SnakesAndLadders
	{
        public int SnakesAndLadders(int[][] board)
        {
            int n = board.Length;
            var queue = new Queue<int>();
            queue.Enqueue(1);
            var visited = new bool[n * n + 1];

            for (int move = 0; queue.Count > 0; move++)
            {
                for (int size = queue.Count; size > 0; size--)
                {
                    int num = queue.Dequeue();
                    if (visited[num])
                        continue;
                    visited[num] = true;
                    if (num == n * n)
                        return move;
                    for (int i = 1; i <= 6 && num + i <= n * n; i++)
                    {
                        int next = num + i; // this is the number of location
                        int value = GetBoardValue(board, next); // this is the value on the board
                        if (value > 0) // in this locaiton, value is not -1 then there is ladder or snake 
                            next = value; // next location will be the value 
                        if (!visited[next])
                            queue.Enqueue(next);
                    }
                }
            }
            return -1;
        }

        private int GetBoardValue(int[][] board, int num)
        {
            int n = board.Length;
            int r = (num - 1) / n;
            int x = n - 1 - r;
            int y = r % 2 == 0 ? num - 1 - r * n : n + r * n - num; // calculate the y index 
            return board[x][y];
        }

        public void Test()
		{
			//[[-1,-1,-1,-1,-1,-1],
			//[-1,-1,-1,-1,-1,-1],
			//[-1,-1,-1,-1,-1,-1],
			//[-1,35,-1,-1,13,-1],
			//[-1,-1,-1,-1,-1,-1],
			//[-1,15,-1,-1,-1,-1]]
			var board = new int[][] {
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1, 35, -1, -1, 13, -1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1, 15, -1, -1, -1, -1 }
            };

			Console.WriteLine(SnakesAndLadders(board));
		}
    }
}
