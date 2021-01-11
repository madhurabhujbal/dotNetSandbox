using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numberArray = System.IO.File.ReadAllLines(@"C:\C#\CodingPractice\Input.txt");
            Console.WriteLine("Numbers in input text file: ");
            foreach (string numberline in numberArray)
            {
                Console.WriteLine("\t" + numberline);
            }
        }
    }
}
