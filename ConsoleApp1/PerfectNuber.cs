using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    //28 = 1+2+4+7
    internal class PerfectNuber
    {
        public void  isPerfectNuber() {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPerfect = IsPerfectNumber(number);

            if (isPerfect)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number.");
            }


        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)   //Divide upto  half because contain same value if we run for full
            {
                if (number % i == 0)  //Check with itetaration numbers
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}
