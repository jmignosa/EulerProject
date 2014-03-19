using System;
using System.Diagnostics;

class thirtytwo
{
public static void Main()
{
Stopwatch stoppy = new Stopwatch();
ulong x=1;
ulong y=1;
ulong z=0;
string Tester;
ulong sum=0;

stoppy.Start();
for (x=1;x<(5000);x++)
for (y=x+1;y<(5000);y++)
{
    if (x>100&&y>100)
        continue;
    z=x*y;
    Tester=z.ToString()+x.ToString()+y.ToString();
    if (Tester.Length!=9)
        continue;
    //Console.WriteLine("Correct length {0}  {1}  {2}     {3}",x,y,z,Tester);
    if (!Tester.Contains("9"))
        continue;
    if (!Tester.Contains("8"))
        continue;
    if (!Tester.Contains("7"))
        continue;
    if (!Tester.Contains("6"))
        continue;
    if (!Tester.Contains("5"))
        continue;
    if (!Tester.Contains("4"))
        continue;
    if (!Tester.Contains("3"))
        continue;
    if (!Tester.Contains("2"))
        continue;
    if (!Tester.Contains("1"))
        continue;
    Console.WriteLine("We have a Pandigital {0}  {1}   {2} current sum {3}",x,y,z,sum);
    sum+=z;
    
}

long bb=(long)z;
stoppy.Stop();
Console.WriteLine("Elapsed time {0} ms    and sum={1}",stoppy.ElapsedMilliseconds,(sum-(5346+5796)));
}
}