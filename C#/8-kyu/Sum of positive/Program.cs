using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ExampleTest: " + (Kata.PositiveSum(new int[] { 1, 2, 3, 4, 5 }) == 15));
            Console.WriteLine("Testing ExampleTest: " + (Kata.PositiveSum(new int[] { 1, -2, 3, 4, 5 }) == 13));
            Console.WriteLine("Testing ExampleTest: " + (Kata.PositiveSum(new int[] { -1, 2, 3, 4, -5 }) == 9));
            Console.WriteLine("Testing ExampleTest: " + (Kata.PositiveSum(new int[] { }) == 0));
            Console.WriteLine("Testing ExampleTest: " + (Kata.PositiveSum(new int[] { -1, -2, -3, -4, -5 }) == 0));
        }
    }
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {   
            int sum = 0;
            foreach (int i in arr) {
                if (i > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

}
