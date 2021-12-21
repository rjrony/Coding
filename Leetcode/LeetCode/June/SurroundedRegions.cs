using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
	//https://leetcode.com/problems/surrounded-regions/
	public class SurroundedRegions
	{
		public void Solve(char[][] board)
		{
			for (int i = 0; i < board.Length; i++)
			{
				for (int j = 0; j < board[0].Length; j++)
				{
					if ((i == 0 || i == board.Length-1 || j == 0 || j == board[0].Length-1) && board[i][j] == 'O')
					{
						dfs(board, i, j);
					}
				}
			}

			for (int i = 0; i < board.Length; i++)
			{
				for (int j = 0; j < board[0].Length; j++)
				{
					if (board[i][j] == 'O')
					{
						board[i][j] = 'X';
					}
					else if (board[i][j] == 'R')
					{
						board[i][j] = 'O';
					}
				}
			}
		}

		private void dfs(char[][] board, int i, int j)
		{
			if ((i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)) return;
			else if (board[i][j] != 'O') return;

			board[i][j] = 'R';
			dfs(board, i - 1, j);
			dfs(board, i + 1, j);
			dfs(board, i, j - 1);
			dfs(board, i, j + 1);
		}

		public void Test()
		{
			//X X X X
			//X O O X
			//X X O X
			//X O X X
			var board = new char[][] {
				new char[] { 'X', 'X', 'X', 'X' },
				new char[] { 'X', 'O', 'O', 'X' },
				new char[] { 'X', 'X', 'O', 'X' },
				new char[] { 'X', 'O', 'X', 'X' }
			};

			Solve(board);

			for (int i = 0; i < board.Length; i++)
			{
				Console.WriteLine(string.Join(' ', board[i]));
			}
			
		}
	}
}
