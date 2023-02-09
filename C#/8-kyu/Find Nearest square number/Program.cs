/*Your task is to find the nearest square number, nearest_sq(n) or nearestSq(n), of a positive integer n.

For example, if n = 111, then nearest\_sq(n) (nearestSq(n)) equals 121, since 111 is closer to 121, the square of 11, than 100, the square of 10.

If the n is already the perfect square (e.g. n = 144, n = 81, etc.), you need to just return n.

Good luck :)

Check my other katas:

Alphabetically ordered

Case-sensitive!

Not prime numbers

*/
using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NearestSq(1) == 1);
            Console.WriteLine(Kata.NearestSq(2) == 1);
            Console.WriteLine(Kata.NearestSq(10) == 9);
            Console.WriteLine(Kata.NearestSq(111) == 121);
            Console.WriteLine(Kata.NearestSq(9999) == 10000);
        }
    }

    public static class Kata
    {
        public static int NearestSq(int n)
        {
            return Convert.ToInt32(Math.Pow(Math.Round(Math.Sqrt(n)), 2));

            throw new NotImplementedException("NearestSq is not implemented.");
        }
    }
}