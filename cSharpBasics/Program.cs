using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random(); //stateful method
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);
            Console.WriteLine(roll1); //stateless method
            Console.WriteLine(roll2);
            Console.WriteLine(roll3);
        }
    }
}
