using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        public void MoneyChanger()
        {
            Console.WriteLine("Enter an Amount");
            int moneyInput = Convert.ToInt32(Console.ReadLine());
            int[] availableNotes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] change = new int[9];
            int initialIndex = 0, totalIndex = 8;

            while (initialIndex < totalIndex)
            {
                if (moneyInput >= availableNotes[initialIndex])
                {
                    change[initialIndex] = moneyInput / availableNotes[initialIndex];
                    moneyInput = moneyInput - (change[initialIndex] * availableNotes[initialIndex]);
                }
                initialIndex++;
            }
            Console.WriteLine("Change for an Entered Amount:");
            initialIndex = 0;
            while (initialIndex < totalIndex)
            {
                Console.WriteLine(availableNotes[initialIndex] + " Notes are: " + change[initialIndex]);
                initialIndex++;
            }
        }
    }
}
