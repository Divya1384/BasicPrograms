using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogCrossingRiver
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossingRiver objCrossRiver = new CrossingRiver();
            int noOfWays = objCrossRiver.Num_Ways(10);
            Console.WriteLine($"Number of ways to cross the river - {noOfWays}");
            Console.Read();
        }
    }
}
