using System;
using System.Diagnostics;

class two
{
public static void Main(string[] argv)
{
	
int fibsum=0;
int fibnow=0;
int fiblast=1;
int fibfirst=0;
int limit=4000000;
Stopwatch sw=new Stopwatch();

sw.Start();
while (fibnow < limit)
{
	
	fibnow=fibfirst+fiblast;
	if ((fibnow%2)==0)
		fibsum+=fibnow;
	fibfirst=fiblast;fiblast=fibnow;
}
sw.Stop();
System.Console.WriteLine("Fib Sum for evens under 4,000,000={0} Elapsed time={1}",fibsum,sw.Elapsed);
}
}