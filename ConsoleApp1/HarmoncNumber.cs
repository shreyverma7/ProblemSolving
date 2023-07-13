using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class HarmoncNumber
    {
        public double CalculateHarmonicNumber(int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }
        public void Harmonic()
        {
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine()); 

            if (N <= 0)
            {
                Console.WriteLine("Invalid value for N. N should be a positive integer.");
                return;
            }

            double harmonicNumber = CalculateHarmonicNumber(N);

            Console.WriteLine("The " + N + "th harmonic number is: " + harmonicNumber);
        }

    }
}
