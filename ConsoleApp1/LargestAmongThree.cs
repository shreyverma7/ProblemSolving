using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class LargestAmongThree
    {
        public void Largest() {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = Math.Max(Math.Max(number1, number2), number3);

            Console.WriteLine("The largest number is: " + largestNumber);

        }
    }
}
