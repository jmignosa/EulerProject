using System;
using System.Diagnostics;

class seven
{
private static bool isprime(long num)
{
	if (num==2)
		return true;
   	for (long i=2; i<=(long)Math.Sqrt(num)+1;i++)
    	{
        	if (num %i ==0)
            	return false;
    	}
    	return true;
}

public static void Main()
{
int primeindex=5; //Start after 11 kind of arbitrarily.
long number=12;
Stopwatch sw = new Stopwatch();

sw.Start();
while (primeindex !=10001)
{
    
    if (isprime(number)==true)
            primeindex++;
    number++;
}
sw.Stop();
Console.WriteLine("Prime Number {0} is {1} Elapsed Time {2}",primeindex,--number,sw.Elapsed);
    
}


}
