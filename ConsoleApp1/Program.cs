using System;
namespace ProblemSolving
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Problem solving!");
            FlipCoinPercentage flipCoinPercentage = new FlipCoinPercentage();
            //  flipCoinPercentage.coinPercentage();
            LargestAmongThree largestAmongThree = new LargestAmongThree();
            // largestAmongThree.Largest();

            Divide divide = new Divide();
            //  divide.divide();

            LeapYear leapYear = new LeapYear();
            // leapYear.Lyear();


            HarmoncNumber harmoncNumber = new HarmoncNumber();
            //  harmoncNumber.Harmonic();

            PowerOfTwo powerOfTwo = new PowerOfTwo();
            // powerOfTwo.checkPowerOfTwo();

            PerfectNuber perfectNuber = new PerfectNuber();
            // perfectNuber.isPerfectNuber();

            ReverseNumber reverseNumber = new ReverseNumber();
            // reverseNumber.checkReverseNumber();

            StopClock clock = new StopClock();  
            // clock.checkStopClock();
            
            PrimeFactor primeFactor = new PrimeFactor();
            primeFactor.ToPrimeFactor();





        }
    }
}