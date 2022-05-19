using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNumberCheck()
        {
            Console.WriteLine("Enter a Value:");
            int userInput = Convert.ToInt32(Console.ReadLine()), temp=0;

            if(userInput % 2 == 0)
            {
                for(int i = 1; i < userInput;i++)
                {
                    if (userInput % i == 0)
                    {
                        temp = temp + i;
                    }
                }
                if(temp == userInput)
                {
                    Console.WriteLine("Entered Number " + userInput + " is a Perfect Number");
                }
                else
                {
                    Console.WriteLine("Entered Number " + userInput + " is not a Perfect Number");
                }
            }
            else
            {
                Console.WriteLine("Entered Number " + userInput + " is not a Perfect Number");
            }
        }
    }
}
