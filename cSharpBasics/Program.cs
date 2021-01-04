using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroPoints = 10;
            int monstorPoints = 10;
            int randomAttack;
            Random random = new Random();
            while (heroPoints > 0 && monstorPoints > 0)
            {
                randomAttack = random.Next(1, 11);
                monstorPoints -= randomAttack;
                Console.WriteLine($"Monstor was damaged and lost {randomAttack} health and now has: {monstorPoints} health");
                if (monstorPoints <= 0)
                {
                    Console.WriteLine("Hero wins!!!");
                    continue;
                };

                randomAttack = random.Next(1, 11);
                heroPoints -= randomAttack;
                Console.WriteLine($"Hero was damaged and lost {randomAttack} health and now has: {heroPoints} health");
                if (heroPoints <= 0)
                {
                    Console.WriteLine("Monstor wins!!!");
                    continue;
                };
            }
        }
    }
}

