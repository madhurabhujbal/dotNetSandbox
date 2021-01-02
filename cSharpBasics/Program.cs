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
                Console.WriteLine($"Monstor points lost in attack: {attackOnMonstor}");
                monstorPoints -= attackOnMonstor;
                Console.WriteLine($"Monstor points remaining after attack: {monstorPoints}");
                if (monstorPoints <= 0)
                {
                    Console.WriteLine("Hero is the winner");
                    break;
                };

                int attackOnHero = random.Next(1, 11);
                Console.WriteLine($"Hero points lost in attack: {attackOnHero}");
                heroPoints -= attackOnHero;
                Console.WriteLine($"Hero points remaining after attack: {heroPoints}");
                if (heroPoints <= 0)
                {
                    Console.WriteLine("Monstor is the winner");
                    break;
                };

            } while (heroPoints > 0 && monstorPoints > 0);
        }
    }
}

