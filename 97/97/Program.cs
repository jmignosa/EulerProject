using System;
using System.Collections.Generic;
using System.Numerics;

namespace _97
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 28433 * BigInteger.Pow(2, 7830457) + 1;
            
            Console.WriteLine("Large Non Mersenne Prime alst 10 digits {0}", result%10000000000);
        }
    }
}
