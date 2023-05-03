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
      string rock = "r";
      string paper = "p";
      string scissors = "s";
      if (Input1.ToLower() == rock && Input2.ToLower() == paper)
      {
        return "Player 2 Wins";
      }
      else if (Input1.ToLower() == paper && Input2.ToLower() == scissors)
      {
        return "Player 2 Wins";
      }
      else if (Input1.ToLower() == scissors && Input2.ToLower() == rock)
      {
        return "Player 2 Wins";
      }
      else if (Input1.ToLower() == Input2.ToLower())
      {
        return "TIE GAME";
      }
      else if (Input1.ToLower() != "r" || Input1.ToLower() != "p" || Input1.ToLower() != "s")
      {
        throw new ArgumentException("Illegal Move!");
      }
      else if (Input2.ToLower() != "r" || Input2.ToLower() != "p" || Input2.ToLower() != "s")
      {
        throw new ArgumentException("Illegal Move!");
      }
      else
      {
        return "Player1 Wins";
      }
    }
  }
}
