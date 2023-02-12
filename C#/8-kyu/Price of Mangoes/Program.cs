using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing BasicTests: " + (Kata.Mango(3, 3) == 6));
            Console.WriteLine("Testing BasicTests: " + (Kata.Mango(9, 5) == 30));
        }
    }
    public class Kata
    {
        public static int Mango(int quantity, int price)
            // needs to find multiples of 3 , charge for2 , then charge for the remaining ones
        {
            decimal saleQuantity = quantity / 2;
            decimal notSale = quantity%2;
            decimal total = (Math.Floor(saleQuantity)+notSale)*price;
            return Decimal.ToInt32(total);
        }
    }
}
