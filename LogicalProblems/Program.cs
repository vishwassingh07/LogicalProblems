using System;
namespace LogicalProblems
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Problems");
            bool end = true;
            Console.WriteLine("1. Fibonacci Seriesn\n2. End of the program");
            while (end == true)
            {
                Console.WriteLine("Choose the program to execute: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fiboSeries = new FibonacciSeries();
                        fiboSeries.Fibonacci();
                        break;
                    case 2:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Enter the valid option :");
                        break;

                        
                }
            }
        }
    }
}