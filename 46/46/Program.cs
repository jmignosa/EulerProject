using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _46
{
    class Program
    {
        public static long [] squares = new long [10000];
        public static long [] primes = new long [10000];

        public static bool isprime(long number)
        {
            if (number==2)
                return true;
            for (int i=2;i<Math.Sqrt(number)+1;i++)
            {
                if (number%i==0)
                    return false;
                
            }
            return true;
        }


        static void Main(string[] args)
        {
            int i=0;
            int counter=3;
            bool gbtrue=false;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (long n = 1; n <= 10000; n++)
            {
                squares[n - 1] = n * n;
            }
            while (i<10000)
            {
                if (isprime(counter))
                { primes[i] = counter; i++; }
                counter++;
            }

            for (long j=137;j<20000000;j+=2)
            {
                if (isprime(j))
                    continue;
                Console.WriteLine("Testing j={0} ", j);   
                i=0;
                gbtrue = false;
                while ( !gbtrue && (squares[i]*2)<j)
                {
                    if (isprime(j-2*squares[i]))
                        gbtrue=true;
                    i++;
                }
                if (!gbtrue)
                {
                    Console.WriteLine("*****We have a hit on {0} ", j);
                    sw.Stop();
                    Console.WriteLine("elapsed time {0} ms", sw.ElapsedMilliseconds);
                    return;
                }
            }
        }
    }
}
