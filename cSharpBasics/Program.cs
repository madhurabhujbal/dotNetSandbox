using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            //Will give the correct exact quotient
            decimal decimalQuotient = 7 / 5m;
            Console.WriteLine("Decimal quotient is: " + decimalQuotient);

            //Will not give the decimal part of quotient after division
            decimal decimalQt = 7 / 5;
            Console.WriteLine("Decimal quotient is: " + decimalQt);

            //Division after casting the number type
            decimal decimalQtCast = (decimal)7 / (decimal)5;
            Console.WriteLine("Decimal quotient is: " + decimalQtCast);

            //Calculating modulus
            Console.WriteLine("Mod of number not completely divisible " + (200 % 3));
            Console.WriteLine("Mod of number completely divisible " + (200 % 5));

        }
    }
}
