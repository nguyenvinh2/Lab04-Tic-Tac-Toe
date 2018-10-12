using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
      PlayGame();
		}

		static void PlayGame()
		{
      Player playerOne = new Player();
      Player playerTwo = new Player();
      Console.WriteLine("What is the name of player one?");
      playerOne.Name = Console.ReadLine();
      playerOne.Marker = "X";
      playerOne.IsTurn = true;
      Console.WriteLine("What is the name of player two?");
      playerTwo.Name = Console.ReadLine();
      playerTwo.Marker = "O";
      playerTwo.IsTurn = false;
      Console.WriteLine($"Welcome {playerOne.Name}! You are {playerOne.Marker}.");
      Console.WriteLine($"Welcome {playerTwo.Name}! You are {playerTwo.Marker}.");
      Console.WriteLine("Now let's play Bamboozle. Press any key to continue...");
      Console.ReadKey();

      Board tickytack = new Board();
      tickytack.DisplayBoard();

      Console.ReadKey();

      take

      // TODO: Instantiate your players
      // Create the Game
      // Play the Game
      // Output the winner
    }
	}
}
