using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter a value to get a Fibinacci Series:");
            int userInput = Convert.ToInt32(Console.ReadLine()); 
            int indexPosition=0;
            int[] length = new int[userInput];
            Console.WriteLine("Fibinacci Series for "+userInput+" is:");

            while(indexPosition<userInput)
            {
                if(indexPosition == 0 || indexPosition == 1)
                {
                    length[indexPosition] = indexPosition;
                    Console.WriteLine(length[indexPosition]);
                    indexPosition++;
                }
                else
                {
                    while (indexPosition < userInput)
                    {
                        length[indexPosition] = length[indexPosition - 2] + length[indexPosition - 1];
                        Console.WriteLine(length[indexPosition]);
                        indexPosition++;
                    }
                }
            } 
        }
    }
}
