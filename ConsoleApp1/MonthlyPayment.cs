using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Principle value :");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number of Years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Interest Rate: \"");
            double annualRate = Convert.ToDouble(Console.ReadLine());

            // Calculate monthly interest rate
            double monthlyRate = annualRate / 1200;

            // Calculat montly payment
            double monthlyPayment = loanAmount * monthlyRate / (1 - 1 / Math.Pow(1 + monthlyRate, years * 12));

            // Display montly payment
            Console.WriteLine("Monthly Payment:", monthlyPayment);

            // Display total payment
            Console.WriteLine("Total Payment:", (monthlyPayment * 12) * years);

            // Create amortization schedule
            double balance = loanAmount,
                     principal, interest;
            Console.WriteLine("Payment     Interest     Principal     Balance");
            for (int i = 1; i <= years * 12; i++)
            {
                interest = monthlyRate * balance;
                principal = monthlyPayment - interest;
                balance = balance - principal;
                Console.WriteLine( i+"         "+ Math.Round(interest,2) + "      " + Math.Round(principal, 2) + "        " + Math.Round(balance, 2));
            }
        }
    }
}
