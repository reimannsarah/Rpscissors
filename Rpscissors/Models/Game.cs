using System;
using System.Collections.Generic;

namespace Rpscissors.Models
{
  public class Game
  {
    public string Input1 { get; set; }
    public string Input2 { get; set; }
    public Game(string choice1, string choice2)
    {
      Input1 = choice1;
      Input2 = choice2;
    }
    public string DeclareWinner()
    {
      string rock = "rock";
      string paper = "paper";
      // string scissors = "scissors";
      if (Input1.ToLower() == rock && Input2.ToLower() == paper)
      {
        return "Player 2 Wins";
      }
      else if (Input1.ToLower() == Input2.ToLower())
      {
        return "TIE GAME";
      }
      else
      {
        return "Player1 Wins";
      }
    }
  }
}