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
        try
        {
          GamePlay();
        }
        catch
        {
          ErrorHandle();
        }
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
          try
          {
            GamePlay();
          }
          catch
          {
            ErrorHandle();
          }
        }
      }
    }
    static void GamePlay()
    {
      Console.WriteLine("Player 1, throw thy hand");
      Console.WriteLine("'r'= rock");
      Console.WriteLine("'p' = paper");
      Console.WriteLine("'s' = scissors");
      string handThrow1 = CatchHands1();
      Console.ResetColor();
      Console.WriteLine("hmmm interesting choice...");

      Console.WriteLine("Player 2, throw thy hand");
      Console.WriteLine("'r'= rock");
      Console.WriteLine("'p' = paper");
      Console.WriteLine("'s' = scissors");
      string handThrow2 = CatchHands2();
      Console.ResetColor();
      Console.WriteLine("unorthodox...");
      Game newGame = new Game(handThrow1, handThrow2);
      Console.WriteLine(newGame.DeclareWinner());
      Console.WriteLine("Would you like a rematch? (y/n)");
      string rematch = Console.ReadLine();
      if (rematch.ToLower() == "y")
      {
        GamePlay();
      }
      else
      {
        Console.WriteLine("Well fought. Come back when you're stronger!");
      }
    }
    static string CatchHands1()
    {
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Cyan;
      string handThrow = Console.ReadLine();
      return handThrow;
    }
    static string CatchHands2()
    {
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Cyan;
      string handThrow = Console.ReadLine();
      return handThrow;
    }
    static void ErrorHandle()
    {
      Console.ResetColor();
      Console.WriteLine("Illegal move detected! Stay thy hands!");
      Console.WriteLine("Resetting Ring...");
      Console.WriteLine("No funny business... I'm watching you...");
      GamePlay();
    }
  }
}