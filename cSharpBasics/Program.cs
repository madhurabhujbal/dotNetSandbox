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
        }
    }
}
