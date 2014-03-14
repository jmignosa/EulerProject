using System;
using System.Diagnostics;

class Problem3{

protected static bool isprime(long num)
{
	if (num==2)
		return true;
	for (long i=2; i<= (long)Math.Sqrt(num)+1;i++)
	{if (num%i==0)
		return false;
	}
	return true;
}

public static void Main()
{
	long testnum=600851475143;
	long largestprime=1;
	long startnum=0;
	Stopwatch sw = new Stopwatch();

	sw.Start();
	startnum=(long)testnum/2;
	
	for (long i=1;i<(long)Math.Sqrt(testnum);i+=2)
	{
		if (!isprime(i))
			continue;
		if (testnum%i!=0)
			continue;
		largestprime=i;
	}
	sw.Stop();
	Console.WriteLine("Largest prime is {0} solution took {1} ms",largestprime,sw.ElapsedMilliseconds);	
}
}