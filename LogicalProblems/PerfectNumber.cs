using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void PerfectNum()
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter the number you want to check: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < num; i++)
            {
                if ( num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("The given number is a Perfect Number");
            }
            else
            {
                Console.WriteLine("The given number is not a Perfect Number");
            }
        }
    }
}
