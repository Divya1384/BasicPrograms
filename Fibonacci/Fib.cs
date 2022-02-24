using System;

namespace Fibonacci
{
    public class Fib
    {
        public double GetFibonacci(int n)
        {
            //Time complexity - 2^n
            if (n == 0 || n == 1) return 1;
            return GetFibonacci(n - 2) + GetFibonacci(n - 1);
        }

        public double GetNthFibonacciInLoop(int n)
        {
            //Time complexity - n
            double[] fib = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib[i] = 1;
                }
                else
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }
            }

            return fib[n - 1];
        }

        public void PrintFibonacci(int n)
        {
            int[] fib = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib[i] = 1;
                }
                else
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }

                Console.Write($"{fib[i]} ");
            }
        }
    }
}
