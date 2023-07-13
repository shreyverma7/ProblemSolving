using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Divide
    {
        public void divide() {
            Console.WriteLine("Enter dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
