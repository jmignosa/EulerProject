using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _51
{
    class Program
    {
        //const int primemax=50000;
        public static List<string> primes = new List<string>();

        public static bool isprime(int number)
        {
            if (number == 2)
                return true;
            for (int i = 2; i < Math.Sqrt(number) + 1; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static void fillprimes()
        {


            for (int i = 100000; i < 1000000; i++)
            {
                if (isprime(i))
                {
                    primes.Add(i.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch stoppy = new Stopwatch();
            stoppy.Start();
            int i = 0;
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            int familycount=0;

            fillprimes();
            foreach (var prime in primes)
            {
                count0 = count1 = count2 = 0;
                familycount = 0;
                foreach (var car in prime.ToCharArray())
                {
                    switch (car)
                    {
                        case '0':
                            count0++;
                            break;
                        case '1':
                            count1++;
                            break;
                        case '2':
                            count2++;
                            break;
                        default:
                            break;
                    }

                }
                if (count1 > 2)//(count0 > 1 || count1 > 1 || count2 > 1)
                {
                    if (primes.IndexOf(prime.Replace("1", "2")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "3")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "4")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "5")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "6")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "7")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "8")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "9")) != -1)
                        familycount++;
                    if (primes.IndexOf(prime.Replace("1", "0")) != -1)
                        familycount++;
                    //Console.WriteLine("fc {0}", familycount);
                    if (familycount >= 7)
                    {
                        Console.WriteLine("Prime number {0} has repeating digits needed", prime);
                        for (int j = 0; j < 10; j++)
                        {
                            if (primes.IndexOf(prime.Replace("1", (j.ToString())))!=-1)
                                System.Console.WriteLine("Family {0}", (prime.Replace("1", (j.ToString())))); 
                        }
                        stoppy.Stop();
                        Console.WriteLine("Elapsed Time {0} ms Last prime {1}", stoppy.ElapsedMilliseconds, primes[primes.Count - 1]);
                        //return;
                    }

                }

            }


        }
    }
}