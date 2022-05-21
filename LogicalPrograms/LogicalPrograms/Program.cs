using System;

namespace LogicalPrograms
{
    internal class MainClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a value to choose the Program");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        Console.WriteLine("Fibonacci Series");
                        FibonacciSeries getMethod = new FibonacciSeries();
                        getMethod.Fibonacci();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Perfect Number Program");
                        PerfectNumber getMethod = new PerfectNumber();
                        getMethod.PerfectNumberCheck();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Prime Number Program");
                        PrimeNumber getMethod = new PrimeNumber();
                        getMethod.PrimeCheck();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Reverse Number Program");
                        ReverseNumber getMethod = new ReverseNumber();
                        getMethod.DigitReverse();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("StopWatch Program");
                        StopWatch getMethod = new StopWatch();
                        getMethod.TimeElapsed();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Vending Machine Program");
                        VendingMachine getMethod = new VendingMachine();
                        getMethod.MoneyChanger();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Temperature Conversion Program");
                        TemperatureConversion getMethod = new TemperatureConversion();
                        getMethod.Units();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Day of Week Program");
                        DayofWeek getMethod = new DayofWeek();
                        getMethod.Calender();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Monthly Payment Program");
                        MonthlyPayment getMethod = new MonthlyPayment();
                        getMethod.LoanInterest();
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Square Root Program");
                        SquareRoot getMethod = new SquareRoot();
                        getMethod.Root();
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("ToBinary Program");
                        ToBinary getMethod = new ToBinary();
                        getMethod.BinaryConverter();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Number between(1-11)");
                        break;
                    }
            }
        }
    }
}
