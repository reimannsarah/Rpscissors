using System;
using Rpscissors.Models;
using Rpscissors.UserinterfaceModels;

namespace Rpscissors
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Are you ready to...");
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("Enter the ring? (y/n)");

      string input1 = Console.ReadLine();
      if (input1.ToLower() == "y") 
      {
        GamePlay();
      }
      else
      {
        Console.WriteLine("ARE YOU SURE?! (y/n)");
        string input2 = Console.ReadLine();
        if (input2.ToLower() == "y")
        {
          Console.WriteLine("fine, get outta here");
        }
        else
        {
          Console.WriteLine("you've chosen wisely, young warrior");
          GamePlay();
        }
      }
    }
    static void GamePlay()
    {
      {
      Console.WriteLine("Player 1, throw thy hand");
      Console.WriteLine("'r'= rock");
      Console.WriteLine("'p' = paper");
      Console.WriteLine("'s' = scissors");
      string handThrow1 = CatchHands();
      Console.ResetColor();
      Console.WriteLine("hmmm interesting choice...");
      }
      Console.WriteLine("Player 2, throw thy hand");
      Console.WriteLine("'r'= rock");
      Console.WriteLine("'p' = paper");
      Console.WriteLine("'s' = scissors");
      string handThrow2 = CatchHands();
      Console.ResetColor();
      Console.WriteLine("unorthodox...");
      Game newGame = new Game(handThrow1, handThrow2);
      Console.WriteLine(newGame.DeclareWinner());
    }
    static string CatchHands()
    {
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Cyan;
      string handThrow = Console.ReadLine();
      if (handThrow.ToLower() != "r" || handThrow.ToLower() != "p" || handThrow.ToLower() != "s")
      {
        Console.ResetColor();
        Console.WriteLine("Illegal move! Try again!");
        CatchHands();
      }
      else
      {
      return handThrow;
      }
      
    }
  }
}