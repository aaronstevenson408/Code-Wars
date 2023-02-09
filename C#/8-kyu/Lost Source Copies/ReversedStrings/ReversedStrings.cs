/*
Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow'

*/

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char [] charArray;
    charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  
    throw new NotImplementedException("TODO: Kata.Solution(string) => string"); // dont remember why i did this 

  }
}