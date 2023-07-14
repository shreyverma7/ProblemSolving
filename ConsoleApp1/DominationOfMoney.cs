using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class DominationOfMoney
    {
        static int[] cash = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void MoneyChange() {
            Console.WriteLine("Enter the change amount in Rs: ");
            int change = Convert.ToInt32(Console.ReadLine());

            CalculateMinimumNotes(change);
        }

        static void CalculateMinimumNotes(int amount)
        {
            Console.WriteLine("Minimum number of notes needed: ");

            for (int i = 0; i < cash.Length; i++)
            {
                int denomination = cash[i];    //high Money on which it divide according to i
                int count = amount / denomination;

                if (count > 0)   //if is less than 0 next iterationn takes place
                {
                    Console.WriteLine(denomination + " Rs: " + count); //Print 
                    amount -= count * denomination;    //reduct the amount  example a= 4500 -(4*100) = 500 amount
                }
            }
        }
    }
}
