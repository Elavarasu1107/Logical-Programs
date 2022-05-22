using System;

namespace LogicalPrograms
{
    internal class MainClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter 1 to Fibonacci Series Program");
            Console.WriteLine("Enter 2 to Perfect Number Program");
            Console.WriteLine("Enter 3 to Prime Number Program");
            Console.WriteLine("Enter 4 to Reverse Number Program");
            Console.WriteLine("Enter 5 to StopWatch Program");
            Console.WriteLine("Enter 6 to Vending Machine Program");
            Console.WriteLine("Enter 7 to Temperature Conversion Program");
            Console.WriteLine("Enter 8 to Day of Week Program");
            Console.WriteLine("Enter 9 to Monthly Payment Program");
            Console.WriteLine("Enter 10 to Square Root Program");
            Console.WriteLine("Enter 11 to ToBinary Program");
            Console.WriteLine("Enter 12 to Coupon Number Program");

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
                case 12:
                    {
                        Console.WriteLine("Coupon Number Program");
                        CouponNumber getMethod = new CouponNumber();
                        getMethod.Distinct();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Number between(1-12)");
                        break;
                    }
            }
        }
    }
}
