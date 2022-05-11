using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var objTikTok = new TikTok();
            Thread threadTik = new Thread(new ThreadStart(objTikTok.PrintTik));
            Thread threadTok = new Thread(new ThreadStart(objTikTok.PrintTok));
            threadTik.Start();
            threadTok.Start();
            threadTik.Join();
            threadTok.Join();
            Console.WriteLine("Printed successfully");
            Console.Read();
        }
    }
}
