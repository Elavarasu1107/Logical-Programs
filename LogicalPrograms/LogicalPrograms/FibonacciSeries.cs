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
            int userInput = Convert.ToInt32(Console.ReadLine()), indexPosition=2;
            int[] length = new int[userInput];
            Console.WriteLine("Fibinacci Series for "+userInput+" is:");
            length[0] = 0;
            length[1] = 1;
            Console.WriteLine(length[0]);
            Console.WriteLine(length[1]);
            while (indexPosition < userInput)
            {
                length[indexPosition] = length[indexPosition - 2] + length[indexPosition - 1];
                Console.WriteLine(length[indexPosition]);
                indexPosition++;
            }
        }
    }
}
