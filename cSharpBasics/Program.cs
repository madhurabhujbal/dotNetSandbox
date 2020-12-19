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
        }
    }
}
