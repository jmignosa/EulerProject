using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _38
{
    class Program
    {
        static int dcount(int number)
        {
            string thenumber = number.ToString();
            return thenumber.Length;
        }

        static void Main(string[] args)
        {
            Stopwatch stoppy = new Stopwatch();
            stoppy.Start();
            int digitcount = 0;
            long max = 0;
            for (int n = 2; n <= 9999; n++)
            {
                digitcount = 0;
                int x = 1; int temp = 0;
                string numero = "";
                while (digitcount < 9)
                {
                    temp = x * n;
                    if ((dcount(temp) + digitcount) > 9)
                        break;
                    numero += temp.ToString();
                    x++;
                    digitcount = numero.Length;
                }
                if (numero.Contains("0"))
                    continue;
                if (digitcount < 9)
                    continue;
                if (!numero.Contains("9"))
                    continue;
                if (!numero.Contains("8"))
                    continue;
                if (!numero.Contains("7"))
                    continue;
                if (!numero.Contains("6"))
                    continue;
                if (!numero.Contains("5"))
                    continue;
                if (!numero.Contains("4"))
                    continue;
                if (!numero.Contains("3"))
                    continue;
                if (!numero.Contains("2"))
                    continue;
                if (!numero.Contains("1"))
                    continue;
                Console.WriteLine("We have a pandigital {0} n={1}", numero,n);
                if (Int64.Parse(numero) > max)
                    max = Int64.Parse(numero);
            }
        stoppy.Stop();
        Console.WriteLine("Elapsed Time {0} ms", stoppy.ElapsedMilliseconds);
        Console.WriteLine("largest {0} ", max);
        }
        
    }
}
