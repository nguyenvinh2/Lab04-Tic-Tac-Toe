using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

    /// <summary>
    /// Just a simple nested for loop to print out the board above
    /// </summary>
		public void DisplayBoard()
		{
      Console.WriteLine();
      for (int i = 0; i < GameBoard.GetLength(0); i++)
      {
        for (int j = 0; j < GameBoard.GetLength(1); j++)
        {
          Console.Write(GameBoard[i, j]);
        }
        Console.WriteLine();
      }
			//TODO: Output the board to the console
		
		}
	}
}
