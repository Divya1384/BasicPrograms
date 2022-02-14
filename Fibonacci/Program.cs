using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib objFib = new Fib();
            int value = objFib.GetFibonacci(5);
            Console.WriteLine($"5th fibonacci number - {value}");
            Console.WriteLine();
            objFib.WriteFibonacci(10);
            Console.Read();
        }
    }
}
