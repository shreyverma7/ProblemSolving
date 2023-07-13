using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class PrimeFactor
    {
        public void ToPrimeFactor() {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + number + ":");
            ComputePrimeFactors(number);
        }
        public void ComputePrimeFactors(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
