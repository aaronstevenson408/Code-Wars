/*
Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).

For example,

[true, true, true, false,
  true, true, true, true,
  true, false, true, false,
  true, false, false, true,
  true, true, true, true,
  false, false, true, true]
The correct answer would be 17.

Hint: Don 't forget to check for bad values like null/undefined
*/


using System;

public static class Kata
{
    public static void Main(string[] args)
    {
        bool[] sheeps = new bool[] {true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true };

        int result = CountSheeps(sheeps);
        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
    public static int CountSheeps(bool[] sheeps)
    {   
        sheeps = sheeps.Where(x => x == true).ToArray();
        return sheeps.Length;
    }
}