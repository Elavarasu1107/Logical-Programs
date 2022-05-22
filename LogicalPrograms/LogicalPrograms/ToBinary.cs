using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ToBinary
    {
        public void BinaryConverter()
        {
            Console.WriteLine("Enter a Value:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] binaryValue = new int[userInput];
            int remainder, indexPosition = 0;

            while (userInput > 0)
            {
                remainder = userInput % 2;
                binaryValue[indexPosition] = remainder;
                userInput = userInput / 2;
                indexPosition++;  
            }
            Console.WriteLine();
            Console.Write("Binary number is: ");
            while (indexPosition >= 0)
            {
                Console.Write(binaryValue[indexPosition]);
                indexPosition--;
            }
        }
    }
}
