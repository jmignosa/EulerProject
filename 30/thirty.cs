using System;
using System.Collections.Generic;
using System.Diagnostics;

class thirty{
public static void Main()
{
    List <int> goodNums=new List<int>();
    int sum=0;
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    for (int i=2;i<=999999;i++)
    {
        int z,a,b,c,d,e;
        z=i/100000;
        a=(i-z*100000)/10000;
        b=(i-z*100000-a*10000)/1000;
        c=(i-z*100000-a*10000-b*1000)/100;
        d=(i-z*100000-a*10000-b*1000-c*100)/10;
        e=(i-z*100000-a*10000-b*1000-c*100-d*10);
        //System.Console.WriteLine("i={0}   a={1}  b={2} c={3} d={4} e={5}",i,a,b,c,d,e);
        if ((Math.Pow(z,5)+Math.Pow(a,5)+Math.Pow(b,5)+Math.Pow(c,5)+Math.Pow(d,5)+Math.Pow(e,5))==i)
            {System.Console.WriteLine("We have a hit on {0}",i);
            goodNums.Add(i);
            sum+=i;
            }
    }
    sw.Stop();
    Console.WriteLine("The answer is {0} Elapsed Time {1} ms",sum,sw.ElapsedMilliseconds);
}
}