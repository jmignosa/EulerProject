using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _45
{
    class Program
    {
        public static long[] tris = new long[90000];
        public static long[] pentas = new long[90000];
        public static long[] hexas = new long[90000];

        static void Main(string[] args)
        {
            Stopwatch stoppy = new Stopwatch();
            stoppy.Start();
            for (long n = 143; n < 90143; n++)
            {
                tris[n - 143] = n * (n + 1) / 2;
                pentas[n - 143] = n * (3*n -1) / 2;
                hexas[n - 143] = n * (2 * n - 1) ;
            }
            for (int i = 0; i < 90000; i++)
            {
                if (Array.IndexOf(pentas, hexas[i]) == -1)
                    continue;
                if (Array.IndexOf(tris, hexas[i]) == -1)
                    continue;
                System.Console.WriteLine("Have a Hit {0}  i={1} ", hexas[i], i);
            }
            stoppy.Stop();
            Console.WriteLine("Elapsed Time {0} ms", stoppy.ElapsedMilliseconds);

        }
    }
}
