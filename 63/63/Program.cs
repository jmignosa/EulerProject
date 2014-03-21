using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            BigInteger i = 0;
            BigInteger power = 1;
            BigInteger exponent=0;
            List<BigInteger> answers = new List<BigInteger>();
            int lastanswers = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            while (condition)
            {

                long start = 1; 
                long stop = 10000;
                    for (i = start; i <= stop; i++)
                    {
                        if (i==start) lastanswers = answers.Count;
                        exponent = (BigInteger)Math.Pow((double)i, (double)power);
                        if (exponent.ToString().Length == power)
                            answers.Add(exponent);
                        if (exponent.ToString().Length < power)
                            continue;
                         if (exponent.ToString().Length > power)
                             break;
                    }
                  power++;
                  if (lastanswers == answers.Count)
                      condition = false;
            }
            sw.Stop();
            Console.WriteLine("The answer is {0} the highest power is {1}. Elapsed time {2} ms", answers.Count, (power - 1),sw.ElapsedMilliseconds);
        }
    }
}
