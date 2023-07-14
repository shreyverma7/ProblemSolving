using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class FindDayOfDate
    {
        public  void FindDays()
        {
            Console.Write("Enter the Date  -- ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Day -- ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Year -- ");
            int year = Convert.ToInt32(Console.ReadLine());
             
            DateTime day = new DateTime(year, month, date);  //Calling Date time inbuilt fucntion
            Console.WriteLine(day.DayOfWeek);  //Day class will show us day 
        }
    }
}
