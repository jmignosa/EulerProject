using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _44
{
    class Program
    {
        public static long[] pentas = new long[10000];
        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();
            long diff = 10000000000;
            
            stopper.Start();
            for (long i = 1; i < 10001; i++)
            {
                pentas[i - 1] = (i * (3 * i - 1)) / 2;
                //Console.WriteLine("Penta {0}",pentas[i-1]);
            }
            for (int i=0;i<9999;i++)
                for (int j = i + 1; j < 10000; j++)
                {
                    long checkplus = pentas[i] + pentas[j];
                    if (Array.BinarySearch(pentas, checkplus) < 0)
                    //if (Array.IndexOf(pentas, checkplus) == -1)
                        continue;
                    long checkminus = pentas[j] - pentas[i];
                    if (Array.BinarySearch(pentas, checkminus) < 0 )
                        continue;
                    if (checkminus < diff)
                        diff = checkminus;
                    //System.Console.WriteLine("Hit!!!!!! {0}  {1} diff {2}  sum {3}", pentas[i], pentas[j], checkminus, checkplus);
                }
            stopper.Stop();
            Console.WriteLine("Time elapsed {0}. D{1}", stopper.ElapsedMilliseconds,diff);
        }
    }
}
