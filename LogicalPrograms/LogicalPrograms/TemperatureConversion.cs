using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        public void Units()
        {
            Console.WriteLine("Enter a Value to Convert");
            int userInput=int.Parse(Console.ReadLine());

            double fahrenheit = (userInput * 9 / 5) + 32;
            double celsius = (userInput - 32) * 5 / 9 ;

            Console.WriteLine("Celsius to Fahrenheit= " + fahrenheit);
            Console.WriteLine("Fahrenheit to Celsius= " + celsius);
        }
    }
}
