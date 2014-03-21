using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _69
{
    class Program
    {
        public static List<double> n_overPhi_n = new List<double>();
        public static bool isprime(int num)
        {
            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int maxn = 0;
            double maxnphiofn = 0;
            double phiofn = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int n = 3; n < 1000000; n++)
            {
                int count = 1;
                bool skipcount = false;
                if (isprime(n)) continue;
                if (n%2!=0) continue;
                List <int> divisors = new List<int>();
                for (int j = 1; j < n ; j++)
                {
                    
                    skipcount = false;
                    if (n % j == 0)
                    {
                        if (j == 1)
                            continue;
                        divisors.Add(j);
                        continue; 
                    }
                    foreach (var num in divisors)
                    {
                        if (j % num == 0)
                            skipcount = true;
                    }
                    if (!skipcount)
                        count++;
                    if (((double)n / (double)count)<maxnphiofn) break;
                }
                phiofn = (double)n / (double)count;
                if (phiofn>maxnphiofn)
                {
                    maxn = n;
                    maxnphiofn = (double)n / (double)count;
                    Console.WriteLine("N={0}    Phi of N {1} current max{2}", n, phiofn, maxn);
                }
                
            }
            sw.Stop();
            Console.WriteLine("N={0}    Phi of N {1} elapsed time {2} ms", maxn, maxnphiofn,sw.ElapsedMilliseconds);

        }
    }
}
