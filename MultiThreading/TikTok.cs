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
        private readonly AutoResetEvent _autoEventTik = new AutoResetEvent(false);
        private readonly AutoResetEvent _autoEventTok = new AutoResetEvent(false);
        private int _maxCount = 10;

        public TikTok()
        {
            
        }

        public void PrintTik()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                Console.WriteLine("Tik");
                _autoEventTok.Set();
                _autoEventTik.WaitOne();
            }
        }

        public void PrintTok()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                _autoEventTok.WaitOne();
                Console.WriteLine("Tok");
                _autoEventTik.Set();
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
                    _autoEvent.WaitOne(2000);
                }
            }
        }

        private void PrintOdd()
        {
            for (int odd = 0; odd <= 10; odd += 1)
            {
                if (odd % 2 == 1)
                {
                    Console.WriteLine($"{odd}");
                    _autoEvent.WaitOne(2000);
                }
            }
        }
    }
}
