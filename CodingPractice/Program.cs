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
            string[] newArray = firstLine.Split(',');
            foreach (string element in newArray)
            {
                //Console.Write($"{element} ");
                int num = int.Parse(element);

            }


            // for (int i = 0; i < numberArray.Length; i++)
            // {
            //     Console.WriteLine(numberArray[i]);
            // }
        }
    }
}
