using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace _66
{
    class Program
    {
        public static bool issquare(BigInteger test)
        {
            BigInteger a;
            a = (BigInteger)Math.Sqrt((double)test);
            if (a * a == test )
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            checked
            {
                Stopwatch sw = new Stopwatch();
                List<BigInteger> squares = new List<BigInteger>();
                
                BigInteger pmax = 0;

                sw.Start();
                for (BigInteger i = 1; i < 1000; i++)
                {
                    //Console.WriteLine(i);
                    BigInteger temp = i * i;
                    squares.Add(temp);
                }

                for (int D = 2; D < 1001; D++)
                {
                    if (squares.BinarySearch(D) >= 0) continue;
                    BigInteger limit = (BigInteger)Math.Sqrt(D);
                    int result = 0;
                    
                    BigInteger m = 0;
                    BigInteger d = 1;
                    BigInteger a = limit;

                    BigInteger x1 = 1;
                    BigInteger x = a;

                    BigInteger y1 = 0;
                    BigInteger y = 1;

                    while (x * x - D * y * y != 1)
                    {
                        m = d * a - m;
                        d = (D - m * m) / d;
                        a = (limit + m) / d;

                        BigInteger numm2 = x1;
                        x1 = x;
                        BigInteger denm2 = y1;
                        y1 = y;

                        x = a * x1 + numm2;
                        y = a * y1 + denm2;
                    }

                    if (x > pmax)
                    {
                        pmax = x;
                        result = D;
                        Console.WriteLine("*************D={0}     Y={1}      x={2}", D, y, x);
                    }
                }


                sw.Stop();
                Console.WriteLine("Elapsed time {0} ms", sw.ElapsedMilliseconds);
            }
            
        }
    }
}
