using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CouponNumber
    {
        public void Coupon()
        {
            int unique = 0, count = 0, coupon;
            Console.WriteLine("Enter the number :");
            coupon = Convert.ToInt32(Console.ReadLine());
            bool[] listOfCoupons = new bool[coupon];
            while (unique < coupon)
            {
                Random random = new Random();
                int option = random.Next(1, 100);
                int newCoupon = (int)(random.NextDouble() * coupon);
                count++;

                    if (!listOfCoupons[newCoupon])
                {
                    unique++;
                    listOfCoupons[newCoupon] = true;
                }
            }
            Console.WriteLine("Random numbers needed to have all distinct coupons : " + count);
          

        }
    }
}
