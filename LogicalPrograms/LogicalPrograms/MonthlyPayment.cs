using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public void LoanInterest()
        {
            double P, Y, R, n, r, payment, EMI;
            Console.WriteLine("Enter the years:");
            Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the principal interest:");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a percent interest:");
            R = double.Parse(Console.ReadLine());
            n = 12 * Y;
            r = R / (12 * 100);
            payment = (P*r)/ (1 - Math.Pow((1+r),-n));
            Console.WriteLine("Your monthly payment is: " + payment);
        }
    }
}
