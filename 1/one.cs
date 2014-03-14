//Euler Problem 1
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000

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