using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace XUnitTestLab04TicTacToe
{
  public class UnitTest1
  {
    /// <summary>
    /// test if game can switch players
    /// initial conditions:
    /// player two has current turn
    /// indicated by IsTurn = true
    /// after switch, IsTurn for
    /// player two should be false
    /// </summary>
    [Fact]
    public void CanSwitchPlayers()
    {
      Player PlayerOne = new Player();
      Player PlayerTwo = new Player();
      PlayerOne.IsTurn = false;
      PlayerTwo.IsTurn = true;
      Game TestGame = new Game(PlayerOne, PlayerTwo);
      TestGame.SwitchPlayer();
      Assert.False(PlayerTwo.IsTurn);
    }
    /// <summary>
    /// PositionForNumber maps user input to the coordinate
    /// e.g. a choice of "1" would return the position of (0,0)
    /// tests that PositionForNumber can accurate return coordinate
    /// on user input
    /// </summary>
    [Theory]
    [InlineData(new int[] { 0, 0 }, 1)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 0, 2 }, 3)]
    [InlineData(new int[] { 1, 0 }, 4)]
    [InlineData(new int[] { 1, 1 }, 5)]
    [InlineData(new int[] { 1, 2 }, 6)]
    [InlineData(new int[] { 2, 0 }, 7)]
    [InlineData(new int[] { 2, 1 }, 8)]
    [InlineData(new int[] { 2, 2 }, 9)]
    public void CorrectMarkerPosition(int [] expected, int input)
    {
      int[] testArray = { Player.PositionForNumber(input).Row, Player.PositionForNumber(input).Column };
      Assert.Equal(expected, testArray);
    }


  }
}
