using System;
using System.Diagnostics;

class fourteen{
public static void Main()
{
Stopwatch sw = new Stopwatch();
long maxchainlength=0;
uint maxnum=0;

sw.Start();
for (uint i=1;i<1000000;i++)
{
    long count=0;
    uint seed=i;

    while (seed!=1)
    {
        if (seed%2==0)
            seed/=2;
        else
            seed=3*seed + 1;
        count++;
    }
    if (count>maxchainlength)
        {maxchainlength=count;maxnum=i;}
}
sw.Stop();
Console.WriteLine("Seed = {1}    Chainlength = {0} Elapsed time {2} ms",maxchainlength,maxnum,sw.ElapsedMilliseconds);

}
}