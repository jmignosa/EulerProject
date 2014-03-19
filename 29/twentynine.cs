using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;

class twentynine{
public static void Main()
{
Stopwatch sw = new Stopwatch();
List <BigInteger> expList = new List<BigInteger>();
BigInteger buff=0;

sw.Start();
for (int a=2;a<101;a++)
    for (int b=2;b<101;b++)
    {
        buff=BigInteger.Pow(a,b);
        if (expList.IndexOf(buff)==-1)
            expList.Add(buff);
    }
sw.Stop();
Console.WriteLine("The answer is {0}. Elapsed time {1} ms",(expList.Count),sw.ElapsedMilliseconds);
}
}