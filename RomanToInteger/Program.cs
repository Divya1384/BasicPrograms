using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var objSolution = new RomanToInteger();
            Console.WriteLine($"{objSolution.RomanToInt("MCMXCIV")}");
            var objInt = new IntegerToRoman();
            Console.WriteLine($"{objInt.IntToRoman(40)}");
            Console.Read();
        }
    }
}
