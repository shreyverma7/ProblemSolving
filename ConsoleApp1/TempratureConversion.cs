using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class TempratureConversion
    {
       
         public void convertion()
        {
            Console.WriteLine("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the conversion type (1 .. For 'CtoF' or 2..'FtoC'): ");
            int conversionType = Convert.ToInt32(Console.ReadLine());

            double convertedTemperature = TemperatureConversion(temperature, conversionType);

            Console.WriteLine("Converted temperature: " + convertedTemperature);
        }

        public  double TemperatureConversion(double temperature, int conversionType)
        {
            double convertedTemperature = 0; //intitalizing temprature

            if (conversionType == 1 )
            {
                convertedTemperature = (temperature * 9 / 5) + 32;
            }
            else if (conversionType == 2)
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Invalid conversion type. Please provide either 1 for 'CtoF'   or   2 for'FtoC'.");
            }

            return convertedTemperature;
        }
    }
}
