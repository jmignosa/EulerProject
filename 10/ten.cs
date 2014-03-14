using System;
using System.Diagnostics;


class ten
{

public static bool isprime(long num)
{
	if (num==2)
		return true;
	for (long i=2;i<(Math.Sqrt(num)+1);i++)
	{
		if (num%i==0)
			return false;
	}
	return true;
}

public static void Main()
{
	long startnum=2000000;
	long sum=5;
	Stopwatch sw = new Stopwatch();
	
	sw.Start();		
	for (int i=5;i<startnum;i+=2)
	{
		if (isprime(i))
			sum+=i;
	
	}
	sw.Stop();
	Console.WriteLine("Sum of Primes less than {0} is {1}. Time Elapsed {2} ms",startnum,sum,sw.ElapsedMilliseconds);
	return;
}

}