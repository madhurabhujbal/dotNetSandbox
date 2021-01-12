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
            int countA = 0;
            int countB = 0;
            int countAB = 0;
            int None = 0;

            foreach (string currLine in numberArray)
            {
                bool conditionA = false;
                bool conditionB = false;

                // Check for conditions
                string[] elements = currLine.Split(',');
                foreach (string element in elements)
                {
                    int numValue = int.Parse(element);
                    if ((numValue >= 1 && numValue <= 3) || (numValue >= 5 && numValue <= 7))
                    {
                        conditionA = true;
                    }
                    if ((numValue >= 6 && numValue <= 11) || (numValue >= 33 && numValue <= 44))
                    {
                        conditionB = true;
                    }
                }

                // Update count based on a condition
                if (conditionA && conditionB)
                {
                    countAB++;
                }
                else if (conditionA)
                {
                    countA++;
                }
                else if (conditionB)
                {
                    countB++;
                }
                else
                {
                    None++;
                }
            }

            Console.WriteLine($" Only condition A: {countA} \n Only condition B: {countB} \n Both condition A & B: {countAB} \n None: {None}");

        }
    }
}
