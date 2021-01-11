using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = System.IO.File.ReadAllText(@"C:\C#\CodingPractice\Input.txt");
            Console.WriteLine(inputText);

            string[] numberArray = System.IO.File.ReadAllLines(@"C:\C#\CodingPractice\Input.txt");
            Console.WriteLine("Numbers in input text file: ");
            foreach (string numberline in numberArray)
            {
                Console.WriteLine("\t" + numberline);
            }
        }
    }
}
