/*
 * This is to print 2 threads alternatively.
 * It can be used to print 2 strings or print even and odd numbers alternatively
 */
using System;
using System.Threading;

namespace MultiThreading
{
    public class TikTok
    {
        private readonly AutoResetEvent _autoEventOne = new AutoResetEvent(false);
        private readonly AutoResetEvent _autoEventTwo = new AutoResetEvent(false);
        private int _maxCount = 10;

        public TikTok()
        {
            
        }

        public void PrintTik()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                Console.WriteLine("Tik");
                _autoEventTwo.Set();
                _autoEventOne.WaitOne();
            }
        }

        public void PrintTok()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                _autoEventTwo.WaitOne();
                Console.WriteLine("Tok");
                _autoEventOne.Set();
            }
        }

        private void PrintTik1()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                lock (this)
                {
                    Console.WriteLine("Tik");
                    Thread.Sleep(1000);
                }
            }
        }

        private void PrintTok1()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                lock (this)
                {
                    Console.WriteLine("Tok");
                    Thread.Sleep(1000);
                }
            }
        }

        private void PrintEven()
        {
            for (int even = 0; even <= 10; even += 1)
            {
                if (even % 2 == 0)
                {
                    Console.WriteLine($"{even}");
                    _autoEventTwo.Set();
                    _autoEventOne.WaitOne();
                }
            }
        }

        private void PrintOdd()
        {
            for (int odd = 0; odd <= 10; odd += 1)
            {
                if (odd % 2 == 1)
                {
                    _autoEventTwo.WaitOne();
                    Console.WriteLine($"{odd}");
                    _autoEventOne.Set();
                }
            }
        }
    }
}
