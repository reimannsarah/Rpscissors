using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rpscissors.Models;

namespace Rpscissors.Tests
{
  [TestClass]

  public class GameTests

  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("filler", "whatevs");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void GameConstructor_CreatesGamesWithTwoChoices_Game()
    {
      string choice1 = "derp";
      Game newGame = new Game(choice1, "drap");
      string result = newGame.Input1;
      Assert.AreEqual(choice1, result);
    }
    [TestMethod]
    public void DeclareWinnerMethod_UsesBranchingToOutputAString_String()
    {
      string choice1 = "r";
      string choice2 = "p";
      Game newGame = new Game(choice1, choice2);
      string expected = "Player 2 Wins";
      Assert.AreEqual(expected, newGame.DeclareWinner());
    }
  }
}