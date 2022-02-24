using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassFact objFact = new ClassFact();
            double factorial = objFact.Fact(11);
            Console.WriteLine($"Factorial - {factorial}");
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(objFact.Fact(i) + " ");
            }
            Console.Read();
        }
    }
}
