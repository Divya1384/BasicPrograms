using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine($"Value at index 20 before - {numbers[19]}");
            numbers[19] = 25;
            Console.WriteLine($"Value at index 20 after - {numbers[19]}");
            Console.Read();
        }
    }
}
