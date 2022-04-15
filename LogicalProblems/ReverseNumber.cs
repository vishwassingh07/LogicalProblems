using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        int num, rev = 0, rem;
        public void ReverseNum()
        {
            Console.WriteLine("Enter any number to reverse : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse of the given number is :"+ rev);
        }
    }
}
