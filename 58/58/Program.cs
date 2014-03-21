using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _58
{
    class Program
    {
        public static bool isprime(long num)
        {
            for (long i=3;i<Math.Sqrt(num)+1;i+=2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {checked
            {
                Stopwatch stoppy = new Stopwatch();
                stoppy.Start();
            
                long[] ne = new long[32000];
                long[] se = new long[32000];
                long[] nw = new long[32000];
                long[] sw = new long[32000];
                long[] ring = new long[32000];
                int diagcount = 1;
                int primecount = 0;
                ne[0] = 3; nw[0] = 5;  sw[0] = 9; ring[0] = 3;se[0] = 7;
                for (long i = 1; i < 32000; i++)
                {
                    ne[i] = ne[i - 1] + 2 + (i) * 8;
                    nw[i] = nw[i - 1] + 4 + (i) * 8;
                    sw[i] = sw[i - 1] + (i+1) * 8;
                    se[i] = se[i - 1] + 6+(i) * 8;
                    ring[i] = ring[i - 1] + 2;
                }
                for (int i = 0; i < 100; i++)
                    Console.WriteLine("{0}   {1}     {2}    {3}  ring# {4}", ne[i], nw[i], se[i], sw[i], ring[i]);
                for (long i = 0; i < 32000; i++)
                {
                    double percentage = 0;
                    diagcount += 4;
                    if (isprime(ne[i]))
                        primecount++;
                    if (isprime(se[i]))
                        primecount++;
                    if (isprime(nw[i]))
                        primecount++;
                    if (isprime(sw[i]))
                        primecount++;
                    percentage = (double)primecount / (double)diagcount;
                    //if (i%1000==0)
                        Console.WriteLine("Ring # {0} Primes {1}  % primes {2}", ring[i], primecount, percentage);
                    if (percentage < .1)
                    {
                        Console.WriteLine("Ring # {0} Primes {1}  % primes {2}", ring[i], primecount, percentage);
                        break; 
                    }
                }
                stoppy.Stop();      
                Console.WriteLine("largest num {0}  elapsed time {1} ms",se[31999],stoppy.ElapsedMilliseconds);
                //for (int i = 0; i < 100; i++)
                //    Console.WriteLine("{0}   {1}     {2}    {3}  ring# {4}", ne[i], nw[i], se[i], sw[i], ring[i]);
            }
        }
    }
}
