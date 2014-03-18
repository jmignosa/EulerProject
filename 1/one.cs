using System;
using System.Diagnostics;

class problemOne
{

public static void Main(string[] argv)
{
int limit=1000;
int sum=0;
Stopwatch sw = new Stopwatch();

sw.Start();


Console.WriteLine("Summing 3's and 5's under {0} ", limit);		
for (int i=0;i < limit;i++)
{
	if ((i%3==0) || (i%5==0))
		sum+=i; 
}
sw.Stop();
Console.WriteLine("Sum of numbers mod 3& 5 below 1000 = {0} result took {1} ms",sum,sw.ElapsedMilliseconds);	
}

}