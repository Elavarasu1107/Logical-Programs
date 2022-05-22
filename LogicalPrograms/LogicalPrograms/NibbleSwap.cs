using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class NibbleSwap
    {
        public void Binary()
        {
            Console.WriteLine("Enter a Value");
            int userInput = int.Parse(Console.ReadLine());
            string binary1, binary2, firstNibble, secondNibble, temp;
            binary1 = Convert.ToString(userInput, 2).PadLeft(8, '0');
            Console.WriteLine("Binary Value of " + userInput + " is: " + binary1);
            firstNibble = binary1.Substring(0, (binary1.Length/2));
            secondNibble = binary1.Substring((binary1.Length/2), (binary1.Length/2));
            temp = firstNibble;
            firstNibble = secondNibble;
            secondNibble = temp;
            binary2 = firstNibble + secondNibble;
            Console.WriteLine("Binary Value after swapping: " + binary2);
            int output = Convert.ToInt32(binary2, 2);
            Console.WriteLine("New value after swapping Nibbles: " + output);
        }
    }
}
