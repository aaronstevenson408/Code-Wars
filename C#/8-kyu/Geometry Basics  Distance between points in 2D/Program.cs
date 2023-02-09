/* This series of katas will introduce you to basics of doing geometry with computers.

Point objects have fields X and Y.

Write a function calculating distance between Point a and Point b.

Tests compare expected result and actual answer with tolerance of 1e-6.
*/

using System;
using System.Drawing;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

public class Kata
{ 
    public static void Main(string[] args)
    {
        // run the test cases 
        Point a1 = new Point(3, 3);
        Point b1 = new Point(3, 3);
        Double test1 = DistanceBetweenPoints(a1,b1);
        Console.WriteLine(Math.Round(test1, 6) == 0);
        Point a2 = new Point(1, 6);
        Point b2 = new Point(4, 2);
        Double test2 = DistanceBetweenPoints(a2, b2);
        Console.WriteLine(Math.Round(test2, 6) == 5);
        Point a3 = new Point(-10.2, 12.5);
        Point b3 = new Point(0.3, 14.7);
        Double test3 = DistanceBetweenPoints(a3, b3);
        Console.WriteLine(Math.Round(test3,6));
        Console.WriteLine(Math.Round(test3,6) == 10.728001);
    }
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        
        double dist = Math.Sqrt(Math.Pow((b.X- a.X),2)+ Math.Pow((b.Y - a.Y), 2));

        return dist;   
    }
}