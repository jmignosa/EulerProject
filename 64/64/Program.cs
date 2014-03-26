using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _64
{
class Program
{
static void Main(string[] args)
{
    Stopwatch sw = new Stopwatch();
    int m = 0;
    int d = 1;
    int a = 0;
    int a0 = 0;

    int N = 13;
    int j = 0;
    int odds = 0;
    int steps = 0;

    sw.Start();
    List<int> square = new List<int>();

    for (int i = 2; i < Math.Sqrt(10000) + 1; i++)
    {
        square.Add(i * i);
    }

    for (N = 2; N <= 10000; N++)
    {
        if (square.BinarySearch(N) >= 0)
                continue;
        a0 = (int)Math.Sqrt(N);
        
        a = a0;
        j = 0;
        m = 0;
        d = 1;
        steps = 0;
        
        while (true)
        {
            steps++;
            j++;
            
            m = d * a - m;
            d = (N - m * m) / d;
            a = (a0 + m) / d;
            //Console.WriteLine("a {0}   m   {1}  d   {2}  Number {3}", a, m, d, N);
            if (a == 2*a0) 
                break;
        }
        //Console.WriteLine("-----------------------------");
        if (steps % 2 != 0) odds++;
        //Console.WriteLine("Period of {1} = {0}", steps,N);
    }
    sw.Stop();
    Console.WriteLine("Number of nums with odd periods {0}. Elapsed time {1} ms", odds,sw.ElapsedMilliseconds);
}
}
}
