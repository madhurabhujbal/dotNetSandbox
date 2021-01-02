using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroPoints = 10, monstorPoints = 10;
            Random random = new Random();

            do
            {
                int attackOnMonstor = random.Next(1, 11);
                monstorPoints -= attackOnMonstor;
                Console.WriteLine($"Monstor was damaged and lost {attackOnMonstor} health and now has: {monstorPoints} health");
                if (monstorPoints <= 0)
                {
                    Console.WriteLine("Hero wins!!!");
                    break;
                };

                int attackOnHero = random.Next(1, 11);
                heroPoints -= attackOnHero;
                Console.WriteLine($"Hero was damaged and lost {attackOnHero} health and now has: {heroPoints} health");
                if (heroPoints <= 0)
                {
                    Console.WriteLine("Monstor wins!!!");
                    break;
                };

            } while (heroPoints > 0 && monstorPoints > 0);
        }
    }
}

