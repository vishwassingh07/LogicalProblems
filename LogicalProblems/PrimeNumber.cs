using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public void CheckingPrime()
        {
            int num, i , k =0 ;
            Console.WriteLine("Enter number for Prime Check : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                { 
                    Console.WriteLine("The given number is not Prime");
                    k = 1;
                    break;
                }  
            }
            if (k == 0)
            {
                Console.WriteLine("The given number is Prime");
            }

        }
    }
}
