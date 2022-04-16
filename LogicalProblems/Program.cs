using System;
namespace LogicalProblems
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Problems");
            bool end = true;
            Console.WriteLine("1. Fibonacci Seriesn\n2. Perfect Number\n3. " +
                "Prime Number\n4. Reverse Number\n5.Temperature Conversion\n6." +
                "Monthly Payment\n7. Day Of Week\n8. End of the program");
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
                        PerfectNumber num = new PerfectNumber();
                        num.PerfectNum();
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.CheckingPrime();
                        break;
                    case 4:
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.ReverseNum();
                        break;
                    case 5:
                        TemeratureCoversion conversion = new TemeratureCoversion();
                        conversion.CelsiusToFarhenite();
                        conversion.FarheniteToCelsius();
                        break;
                    case 6:
                        MonthlyPayment computation = new MonthlyPayment();
                        computation.PaymentCalculation();
                        break;
                    case 7:
                        DayOfWeek whichday = new DayOfWeek();
                        whichday.Day();
                        break;
                    case 8:
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