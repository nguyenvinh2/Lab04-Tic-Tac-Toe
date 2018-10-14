using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
    /// <summary>
    /// calls up game
    /// </summary>
    /// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
      PlayGame();
		}
    /// <summary>
    /// overall game sequence for game
    /// creates player one and two
    /// creates game and runs it
    /// prints out winner after game is over
    /// </summary>
    static void PlayGame()
    {

      //Sets up players
      Player PlayerOne = new Player();
      Player PlayerTwo = new Player();
      //Asks for player one info
      Console.WriteLine("What is the name of player one?");
      PlayerOne.Name = Console.ReadLine();
      PlayerOne.Marker = "X";
      PlayerOne.IsTurn = true;
      //asks for player two info
      Console.WriteLine("What is the name of player two?");
      PlayerTwo.Name = Console.ReadLine();
      PlayerTwo.Marker = "O";
      PlayerTwo.IsTurn = false;
      //tells info to players
      Console.WriteLine($"Welcome {PlayerOne.Name}! You are {PlayerOne.Marker}.");
      Console.WriteLine($"Welcome {PlayerTwo.Name}! You are {PlayerTwo.Marker}.");
      Console.WriteLine("Now let's play Bamboozle. Press any key to continue...");
      Console.ReadKey();
      //instantiates the game
      Game Bamboozle = new Game(PlayerOne, PlayerTwo);
      //plays the game by trigger Bamboozle.Play;
      string winner = Bamboozle.Play().Name;
      if (winner != "There is no winner") 
      {
        Console.WriteLine($"Congratulations {winner}, you won!!!");
      }
      else
      {
        Console.WriteLine("Nobody won :(");
      }
      Console.ReadKey();
      // TODO: Instantiate your players
      // Create the Game
      // Play the Game
      // Output the winner
    }
	}
}
