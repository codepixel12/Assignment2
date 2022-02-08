using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Conversion
    {
        //declare private integer variable
        private int userAction;
        private double result;

        //Default constructor
        public Conversion()
        {
            this.userAction = 1;
        }

        //parameterized constcuctor
        public Conversion(int userAction)
        {
            this.userAction = userAction;
        }
              
        //ConvertCelciusToFahrenheit  
        public double ConvertCelciusToFahrenheit()
        {
            // convertion of C to F = °C  x  9/5 + 32
            result = ((userAction * 9) / 5) + 32;
            return result;
        }

        //ConvertCelciusToKelvin  
        public double ConvertCelciusToKelvin()
        {
            // convertion of C to K = ℃ + 273.15
            result = (userAction + 273.15);
            return result;
        }

        //ConvertKelvinToFahrenheit  
        public double ConvertKelvinToFahrenheit()
        {
            // convertion of K to F = 1.8 x (K - 273) + 32 
            result = (1.8 * (userAction - 273) + 32);
            return result;
        }

        //ConvertKelvinToCelcius
        public double ConvertKelvinToCelcius()
        {
            // convertion of K to C = K - 273
            result = (userAction - 273);
            return result;
        }

        //ConvertFahrenheitToKelvin
        public double ConvertFahrenheitToKelvin()
        {
            // convertion of F to K = (y °F – 32) ÷ 1.8 + 273.15
            result = ((userAction - 32) / 1.8) + 273.15;
            return result;
        }

        //ConvertFahrenheitToCelcius
        public double ConvertFahrenheitToCelcius()
        {
            // convertion of F to C
            result = ((userAction - 32) / 9) * 5;
            return result;
        }
    }
}
