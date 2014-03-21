using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace _57
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BigInteger[] a = new BigInteger[1000];    //numerator
            BigInteger[] b = new BigInteger[1000];    //denominator
            int i = 0;
            int numeratorlargercount = 0;
            a[0] = 3; b[0] = 2;
            checked
            {
                while (i < 999)
                {
                    i++;
                    b[i] = a[i - 1] + b[i - 1];
                    a[i] = b[i] + b[i - 1];
                    if (a[i].ToString().Length > b[i].ToString().Length)
                        numeratorlargercount++;
                }
            }
            sw.Stop();
            Console.WriteLine("answer = {0}\r\n Took {1} ms", numeratorlargercount,sw.ElapsedMilliseconds);
        }
    }
}
