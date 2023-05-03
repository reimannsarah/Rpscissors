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
  }
}