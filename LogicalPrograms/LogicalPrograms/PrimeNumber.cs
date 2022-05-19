using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void PrimeCheck()
        {
            Console.WriteLine("Enter a Value:");
            int userInput = Convert.ToInt32(Console.ReadLine()), initialValue = 0;

            if(userInput >= 2)
            {
                for (int i = 2; i < userInput; i++)
                {
                    if (userInput % i == 0)
                    {
                        initialValue++;
                    }
                    if(initialValue>=1)
                    {
                        break;
                    }
                }
                if (initialValue == 0)
                {
                    Console.WriteLine("Entered number " + userInput + " is a Prime Number");
                }
                else
                {
                    Console.WriteLine("Entered number " + userInput + " is not a Prime Number");
                }
            }
            else
            {
                Console.WriteLine("Entered number " + userInput + " is neither a Prime nor a Composite Number");
            }

        }
    }
}
