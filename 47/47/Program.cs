using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _47
{
    class Program
    {
        public static int[] primes = new int[1000];

        public static bool isprime(int number)
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

        public static int dpf(int number)
        {
            int uniqueprimecount = 0;
            bool hityet = false;
  
            foreach(var prime in primes)
            {
                if (prime>number)
                    break;
                hityet = false;
                while (number % prime == 0)
                {
                    number = number / prime;
                    if (!hityet)
                        uniqueprimecount++;
                    hityet = true;
                }
            }

            return uniqueprimecount;
        }

        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();
            stopper.Start();
            int i = 0; 
            int numbers = 2;
            
            while (i < 1000) 
            {
                if (isprime(numbers))
                {
                    primes[i]=numbers;
                    i++;
                }
                numbers++;
            }
            int a, b, c, d; a = b = c = d = 0;
            int n = 0;
            for (n = 120; true; ++n)
            {
                
                a=dpf(n);
                b=dpf(n+1);
                c=dpf(n+2);
                d=dpf(n+3);
                if ((a == b) && (b == c) && (c == d) && (d == 4))
                    break; 
            }
            stopper.Stop();
            Console.WriteLine("The numers are {0} {1} {2} {3} ", n, n+1, n+2, n+3);
            Console.WriteLine("Elapsed time {0} ms", stopper.ElapsedMilliseconds);
        }
    }
}
