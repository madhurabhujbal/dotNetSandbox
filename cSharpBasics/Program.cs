using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");

            Random coin = new Random();
            int flipResult = coin.Next(0, 2);
            Console.WriteLine((flipResult == 0) ? "heads" : "tails");
        }
    }
}
