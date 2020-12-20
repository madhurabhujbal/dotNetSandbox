using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation of array
            string[] stringArray = new string[3];
            stringArray[0] = "ABC";
            stringArray[1] = "FFD";
            stringArray[2] = "ETD";
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            //Initialise and add values in array at same time
            int[] inverntory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inverntory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum}) ");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }
}
