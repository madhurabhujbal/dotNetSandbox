using System;

namespace CodingPractice
{
    class Program
    {

        //Initialise counts
        int countA = 0;
        int countB = 0;
        int countAB = 0;
        int None = 0;
        bool conditionA;
        bool conditionB;
        private bool isConditionA(int numValue)
        {
            if ((numValue >= 1 && numValue <= 3) || (numValue >= 5 && numValue <= 7))
            {
                return true;
            }
            return false;
        }

        private bool isConditionB(int numValue)
        {
            if ((numValue >= 6 && numValue <= 11) || (numValue >= 33 && numValue <= 44))
            {
                return true;
            }
            return false;
        }

        private void processLine(string currLine)
        {
            conditionA = false;
            conditionB = false;
            string[] elements = currLine.Split(',');
            foreach (string element in elements)
            {
                int numValue = int.Parse(element);
                conditionA = conditionA || isConditionA(numValue);
                conditionB = conditionB || isConditionB(numValue);
            }
            updateCounts();
        }

        private void updateCounts()
        {
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

        private void printSummary()
        {
            Console.WriteLine($" Only condition A: {countA} \n Only condition B: {countB} \n Both condition A & B: {countAB} \n None: {None}");

        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            string[] numberArray = System.IO.File.ReadAllLines(@"C:\C#\CodingPractice\Input.txt");

            foreach (string currLine in numberArray)
            {
                // Check for conditions
                obj.processLine(currLine);
            }
            obj.printSummary();
        }
    }
}
