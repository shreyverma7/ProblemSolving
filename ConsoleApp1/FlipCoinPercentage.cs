using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class FlipCoinPercentage
    {
        public void coinPercentage()
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of time the coin should be Printed : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int headcount = 0, taiCount = 0;
            for(int i = 0; i < num; i++)
            {
                double check = random.NextDouble(); //0 or 1

                if (check < 0.5)
                {
                    taiCount++;
                }
                else
                {
                    headcount++;
                }
                
            }
            Console.WriteLine("Percentage of Head : " + (headcount * 100)/num);
            Console.WriteLine("Percentage of tail : " + (taiCount * 100) / num); 

        }

    }
}
