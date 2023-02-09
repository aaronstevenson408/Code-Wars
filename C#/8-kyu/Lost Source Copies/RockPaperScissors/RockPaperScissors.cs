/*
Let's play! You have to return which player won! In case of a draw return Draw!.

Examples(Input1, Input2 --> Output):

"scissors", "paper" --> "Player 1 won!"
"scissors", "rock" --> "Player 2 won!"
"paper", "paper" --> "Draw!"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public string Rps(string p1, string p2)
    {
        string[] combination = new string[2] ;
        combination[0] = p1;
        combination[1] = p2;
        int winner;
        // rock beats scissors
        if(combination.Contains("rock") && combination.Contains("scissors"))
        {
            winner = Array.IndexOf(combination,"rock");

        }
        // sissors beats paper
        else if(combination.Contains("scissors") && combination.Contains("paper"))
        {
            winner = Array.IndexOf(combination, "scissors");
        }
        // paper beats rock
        else if (combination.Contains("paper") && combination.Contains("rock"))
        {
            winner = Array.IndexOf(combination, "paper");
        }
        // same vs same = draw
        else 
        { 
            winner = 2;
        }
        string winState;
        if (winner == 0)
        {
            return "Player 1 won!";
        }
        else if (winner == 1)
        {
            return "Player 2 won!";
        }
        else
        {
            return "Draw!";
        }

    }
}