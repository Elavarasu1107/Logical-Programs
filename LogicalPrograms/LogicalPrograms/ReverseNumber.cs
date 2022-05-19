using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void DigitReverse()
        {
            Console.WriteLine("Enter a Number:");
            int userInput = Convert.ToInt32(Console.ReadLine()), lastDigit, reverse=0;

            while(userInput > 0)
            {
                lastDigit=userInput%10;
                reverse = (reverse * 10) + lastDigit;
                userInput=userInput/10;
            }
            Console.WriteLine("Reverse value of entered number is:"+reverse);
        }
    }
}
