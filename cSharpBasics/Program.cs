﻿using System;

namespace basicC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";
            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senoir Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");
        }
    }
}

