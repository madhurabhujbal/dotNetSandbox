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
            // int totalCount = 0;
            int conditionA = 0;
            int conditionB = 0;
            int conditionAB = 0;
            int None = 0;
            string firstLine = numberArray[0];
            string[] newArray = firstLine.Split(',');
            foreach (string element in newArray)
            {
                //Console.Write($"{element} ");
                int num = int.Parse(element);
                if (((num >= 1 && num <= 3) || (num >= 5 && num <= 7)) && ((num >= 6 && num <= 11) || (num >= 33 && num <= 44)))
                {
                    Console.WriteLine($"Condition A & B matched: {num}");
                    conditionA += 1;
                }
                else if ((num >= 1 && num <= 3) || (num >= 5 && num <= 7))
                {
                    Console.WriteLine($"Condition A matched: {num}");
                    conditionB += 1;
                }
                else if ((num >= 6 && num <= 11) || (num >= 33 && num <= 44))
                {
                    Console.WriteLine($"Condition B matched: {num}");
                    conditionAB += 1;
                }
                else
                {
                    Console.WriteLine($"Condition not matched: {num}");
                    None += 1;
                }

                Console.WriteLine($" Only condition A: {conditionA} \n Only condition B: {conditionB} \n Both condition A & B: {conditionAB} \n None: {None}");
            }


            // for (int i = 0; i < numberArray.Length; i++)
            // {
            //     Console.WriteLine(numberArray[i]);
            // }
        }
    }
}
