using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class CouponNumber
    {
        public void coupon()
        {
            Console.WriteLine("Enter the number of distinct coupon numbers: ");
            int N = int.Parse(Console.ReadLine());

            int totalRandomNumbersNeeded = GenerateDistinctCoupons(N);

            Console.WriteLine("Total random numbers needed to have all distinct coupons: " + totalRandomNumbersNeeded);
        }

        static int GenerateDistinctCoupons(int N)
        {
            Random random = new Random();
            bool[] distinctCoupons = new bool[N];
            int totalRandomNumbersNeeded = 0;
            int distinctCount = 0;

            while (distinctCount < N)
            {
                int randomNumber = random.Next(N);

                if (!distinctCoupons[randomNumber])
                {
                    distinctCoupons[randomNumber] = true;
                    distinctCount++;
                }

                totalRandomNumbersNeeded++;
            }

            return totalRandomNumbersNeeded;
        }
    }
}
