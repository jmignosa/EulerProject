using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _52
{
    class Program
    {
        public static ulong xi, x2i, x3i, x4i, x5i, x6i;
        public static string x, x2, x3, x4, x5, x6;

        public static void set(ulong i)
        {
            xi = i;
            x2i = 2 * i;
            x3i = 3 * i;
            x4i = 4 * i;
            x5i = 5 * i;
            x6i = 6 * i;
            x = xi.ToString();
            x2 = x2i.ToString();
            x3 = x3i.ToString();
            x4 = x4i.ToString();
            x5 = x5i.ToString();
            x6 = x6i.ToString(); 
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool unsolved=true;

            for (ulong i = 125874; unsolved; i++)
            {
                if (i % 100000 == 0) Console.WriteLine("i={0}", i);
                set(i);
                char[] xc = x.ToCharArray();
                char[] xc2 = x2.ToCharArray();
                char[] xc3 = x3.ToCharArray();
                char[] xc4 = x4.ToCharArray();
                char[] xc5 = x5.ToCharArray();
                char[] xc6 = x6.ToCharArray();
                Array.Sort(xc); string y = new string (xc);
                Array.Sort(xc2); string y2 = new string(xc2);
                Array.Sort(xc3); string y3 = new string(xc3);
                Array.Sort(xc4); string y4 = new string(xc4);
                Array.Sort(xc5); string y5 = new string(xc5);
                Array.Sort(xc6); string y6 = new string(xc6);
                
                if ((y == y2) && (y2 == y3) && (y3 == y4) && (y4 == y5) && (y5 == y6))
                {
                    unsolved = false;
                    Console.WriteLine("Answer is {0}   {1}    {2}     {3}     {4}    {5}  {6}", i,x,x2,x3,x4,x5,x6);
                }
            }
            sw.Stop();
            Console.WriteLine("Elapsed time {0} ms", sw.ElapsedMilliseconds);

        }
    }
}
