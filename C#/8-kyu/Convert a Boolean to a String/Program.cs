/*Implement a function which convert the given boolean value into its string representation.

Note: Only valid inputs will be given.*/

using System;

public class kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing MyTest: " + (kata.BooleanToString(true) == "True"));
            Console.WriteLine("Testing MyTest: " + (kata.BooleanToString(false) == "False"));
        }
    }
    public static string BooleanToString(bool b)
    {
        if (b)
        {
            return "True";
        }
        if (!b)
        {
            return "False";
        }
        else
        {
            return "Error";
        }
    }
}