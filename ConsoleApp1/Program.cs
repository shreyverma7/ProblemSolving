using System;
using System.Reflection.Emit;
using System.Transactions;

namespace ProblemSolving
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Problem solving!");
           
            Console.WriteLine("\n1.flipCoinPercentage \n2.Largest among threee \n3.divide \n4.LeapYear \n5.Haromonic Number \n6.PowerOFtwo \n7.perfectNumber \n8.reverseNumber \n9.Stop Clock \n10.Prime Factor \n11.Coupon Number \n12.Domination with money \n13.Temprature Conversion \n14.Monthly Payment  \n15.Find Out day");
            Console.WriteLine("Enter an Input from menu :");
            int num = Convert.ToInt32(Console.ReadLine());

              switch (num) {
                  case 1:
                     FlipCoinPercentage flipCoinPercentage = new FlipCoinPercentage();
                      flipCoinPercentage.coinPercentage();
                    break;
                  case 2:
                    LargestAmongThree largestAmongThree = new LargestAmongThree();
                    largestAmongThree.Largest();
                    break;

                  case 3:
                    Divide divide = new Divide();
                    divide.divide();
                    break;

                  case 4:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Lyear();
                    break;

                  case 5:
                    HarmoncNumber harmoncNumber = new HarmoncNumber();
                    harmoncNumber.Harmonic();
                    break;

                  case 6:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.checkPowerOfTwo();
                    break;
                  case 7:
                    PerfectNuber perfectNuber = new PerfectNuber();
                    perfectNuber.isPerfectNuber();
                    break;
                  case 8:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.checkReverseNumber();
                    break;

                  case 9:
                    StopClock clock = new StopClock();
                    clock.checkStopClock();    
                    break;

                  case 10:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.ToPrimeFactor(); 
                    break;

                  case 11:
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.coupon(); // (NOT COMPLETED)
                    break;

                  case 12:
                    DominationOfMoney dominationOfMoney = new DominationOfMoney();
                    dominationOfMoney.MoneyChange();
                    break;
                  case 13:
                    TempratureConversion temperatureConversion = new TempratureConversion();
                    temperatureConversion.convertion();
                    break;
                  case 14:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Payment();
                    break;
                  case 15:
                    FindDayOfDate findDayOfDate = new FindDayOfDate();  
                    findDayOfDate.FindDays();
                    break;
                 default:
                    Console.WriteLine("Enter a vaild input :");
                  
                    break;
                    




            }
              


           

           
           


            

            

           

            

           

           

            

           

           

            






        }
    }
}