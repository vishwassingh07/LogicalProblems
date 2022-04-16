using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class MonthlyPayment
    {
        int  Year;
        double r, n ,Principal, Rate ;
        
        public void PaymentCalculation()
        {
            Console.WriteLine("Enter the principal amount :");
            Principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year :");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate percentage :");
            Rate = Convert.ToDouble(Console.ReadLine());

            n = 12 * Year;
            r = (Rate) / (12 * 100) ;

            double Payment = (Principal * r) / 1 - Math.Pow((1 + r),-n);
            Console.WriteLine("Monthly Payment : "+ Payment);
        }
    }
}
