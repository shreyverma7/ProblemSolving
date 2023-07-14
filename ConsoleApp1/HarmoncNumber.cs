using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class HarmoncNumber
    {
        //   1/1 + 1/2 +....+1/n 
       
        public void Harmonic()
        {
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine()); 

            if (N <= 0)  //if number is negative then show error
            {
                Console.WriteLine("Invalid value for N. N should be a positive integer.");
                return;
            }

            double harmonicNumber = CalculateHarmonicNumber(N);

            Console.WriteLine("The " + N + "th harmonic number is: " + harmonicNumber);
        }

        public double CalculateHarmonicNumber(int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)   //Run upto Number of time
            {
                sum += 1.0 / i;      //   1/1 + 1/2 +....+1/n 
            }

            return sum;
        }

    }
}
