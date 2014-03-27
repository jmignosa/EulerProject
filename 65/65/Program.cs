using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace _65
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            BigInteger d=1;
            BigInteger n=2;
            string number = "";
            int digitsum = 0;

            sw.Start();
            for (int i = 2; i <= 100; i++)
            {
                BigInteger buffer = d;
                int c;
                if (i % 3 == 0)
                    c = 2 * (i / 3);
                else
                    c = 1;
                d = n;
                n = c * d + buffer;
            }
            number = n.ToString();
            foreach (var num in number)
            {
                digitsum += (num -'0');
            }
            sw.Stop();
            Console.WriteLine("Digit sum of 100th numerator {0} completed in {1} ms",digitsum,sw.ElapsedMilliseconds);
        }
    }
}
