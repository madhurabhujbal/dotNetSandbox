using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello\tWorld!");
            // Console.WriteLine("Hello\nWorld!");
            // Console.WriteLine("Hello \"World\"!");
            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine(@"c:\source\repos");

            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + ", " + firstName + "!");
            Console.WriteLine($"{greeting}, {firstName}! ");
        }
    }
}
