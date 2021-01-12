using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // string inputText = System.IO.File.ReadAllText(@"C:\C#\CodingPractice\Input.txt");
            // Console.WriteLine(inputText);

            string[] numberArray = System.IO.File.ReadAllLines(@"C:\C#\CodingPractice\Input.txt");
            string firstLine = numberArray[0];
            Console.WriteLine(firstLine);
            string[] newArray = firstLine.Split(',');
            foreach (var element in newArray)
            {
                Console.Write($"{element} ");
            }

            // for (int i = 0; i < numberArray.Length; i++)
            // {
            //     Console.WriteLine(numberArray[i]);
            // }
        }
    }
}
