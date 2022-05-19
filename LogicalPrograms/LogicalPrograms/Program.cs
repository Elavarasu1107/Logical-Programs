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
                default:
                    {
                        Console.WriteLine("Enter a Number between(1-3)");
                        break;
                    }
            }
        }
    }
}
