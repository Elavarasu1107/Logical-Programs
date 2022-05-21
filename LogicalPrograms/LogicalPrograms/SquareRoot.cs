using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public void Root()
        {
            Console.WriteLine("Enter a Value:");
            int c = int.Parse(Console.ReadLine());
            double t;

            t = c;
            while (Math.Abs(t - c / t) > ((1e-15) * t))
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine("Square Root of "+c+" is:" + t);
        }
    }
}
