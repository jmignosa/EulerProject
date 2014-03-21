using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum=0; 
            BigInteger expo=0;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 1; i <= 1000; i++)
            {
                expo = i;
                sum += BigInteger.Pow((int)expo, i);
            }
            sw.Stop();
            Console.WriteLine("Sum's last ten digits {0} Time Elapsed {1}",(sum % 10000000000),sw.ElapsedMilliseconds);
        }
    }
}
