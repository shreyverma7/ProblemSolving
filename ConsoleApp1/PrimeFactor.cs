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
            Console.WriteLine("Prime factor number: ");
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + number + ":");
            ComputePrimeFactors(number);
        }
        public void ComputePrimeFactors(int n)
        {
            
           




            // Print the number of 2s that divide n
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            // This condition is to handle the case when
            // n is a prime number greater than 2
            if (n > 2)
                Console.Write(n);
        }

       
        
    }
 }


