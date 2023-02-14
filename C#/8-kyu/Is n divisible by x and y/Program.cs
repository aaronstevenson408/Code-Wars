/*
 * Create a function that checks if a number n is divisible by two numbers x AND y. 
 * 
 * All inputs are positive, non-zero numbers.
 */
using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DivisibleNb.IsDivisible(12, 4, 3) == true);
        Console.WriteLine(DivisibleNb.IsDivisible(3, 3, 4) == false);
        Console.WriteLine(DivisibleNb.IsDivisible(8, 3, 4) == false);
    }

    public class DivisibleNb
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            bool xDiv = false;
            bool yDiv = false;
            if (n%x == 0) {
                xDiv = true;
            }
            if (n % y == 0)
            {
                yDiv = true;
            }
            return xDiv && yDiv;
        }
    }

}