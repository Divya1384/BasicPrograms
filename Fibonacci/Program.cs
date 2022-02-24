using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib objFib = new Fib();
            //int value = objFib.GetFibonacci(100);
            //Console.WriteLine($"5th fibonacci number - {value}");
            Console.WriteLine();
            objFib.PrintFibonacci(10);
            Console.WriteLine();
            Console.WriteLine($"Fibonacci number at 10th position: {objFib.GetNthFibonacciInLoop(100)}");
            Console.Read();
        }
    }
}
