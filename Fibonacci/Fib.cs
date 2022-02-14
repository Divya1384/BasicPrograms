using System;

namespace Fibonacci
{
    public class Fib
    {
        public int GetFibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;
            return GetFibonacci(n - 2) + GetFibonacci(n - 1);
        }

        public void WriteFibonacci(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{GetFibonacci(i)} ");
            }
        }
    }
}
