using System;
using Humanizer;

namespace DotNetDependencies
{
    class Program
    {
        int[] array1 = new int[] {7, 3, 47};
        int[] array2 = new int[] {40, 4, 50};
        int[] array3 = new int[] {55, 2, 20};
        int[] array4 = new int[] {38, 6, 12};

        static void HumanizeQuantities() {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        static void HumanizeDates() {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }
    }
}
