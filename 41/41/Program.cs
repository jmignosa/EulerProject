using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _41
{
    class Program
    {
        public static bool isprime(long number)
        {
            for (long i = 2; i < (Math.Sqrt(number) + 1); i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        static List<long> pans = new List<long>();

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //long i = 86759321;
            for (long i = 9999999; i > 0; i -= 2)
            {
                if (!isprime(i))
                    continue;
                bool continuecheck = false;

                long[] a = new long[(int)Math.Log10(i) + 1];
                for (int j = (int)Math.Log10(i) + 1; j > 0; j--)
                {

                    a[j - 1] = i / (long)Math.Pow(10, j - 1) % 10;
                    if (a[j - 1] == 0)
                    {
                        continuecheck = true;
                        break;
                    }
                    if (continuecheck)
                        continue;
                }

                for (int j = 1; j <= (int)Math.Log10(i) + 1; j++)
                {
                    if (Array.IndexOf(a, j) < 0)
                        continuecheck = true;
                }

                if (continuecheck)
                    continue;
                else
                {
                    pans.Add(i);

                }
                //Console.WriteLine("{0}", i);

            }
            sw.Stop();
            //foreach (var m in pans)
            //    Console.WriteLine("{0}", m);

            Console.WriteLine("Execution took {0} and found {1} pans largest being {2}", sw.ElapsedMilliseconds, pans.Count,pans[0]);
        }
    }
}
