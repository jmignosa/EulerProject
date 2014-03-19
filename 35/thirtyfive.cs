using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class extender
{
public static void show (this List<int> t)
{
	Console.WriteLine("Total current circular primes {0}",(t.Count));
}

}

class thirtyfive{

public static bool isprime(int num)
{
	if (num==2)
		return true;
	for (int i=2;i<=(Math.Sqrt(num))+1;i++)
	{
		if (num%i==0)
			return false;
	}
	return true;
}

public static void Main()
{
Stopwatch sw = new Stopwatch();
int number=0;
int[] intarray = new int[5] {0,1,3,7,9};  //Any rotation with evens, fives or zeros will fail. 
List <int> primes = new List<int>();      //    Need zeros to build numbers below 111111. Will pull zero's out later.
List <int> finalprimes = new List<int>();

sw.Start();
finalprimes.Add(2);
finalprimes.Add(5);

foreach (int a in intarray)
foreach (int b in intarray)
foreach (int c in intarray)
foreach (int d in intarray)
foreach (int e in intarray)
foreach (int f in intarray)
    {
        number=f+e*10+d*100+c*1000+b*10000+a*100000;
        if (number==1)
            continue;
        ///Pull out numbers with zeros
	if (f==0)
		continue;
        if (number>100 && number<1000 && e==0)
            continue;
        if (number>1000 && number<10000 && ((e==0)||(d==0)))
            continue;
        if (number > 10000 && number<100000 && ((e==0)||(d==0)||(c==0)))
            continue;
        if (number > 100000 && number<1000000 && ((e==0)||(d==0)||(c==0)||(b==0)))
            continue;
	if (isprime(number))
            primes.Add(number);
        else
            continue;
	
        if (number<10)
            {finalprimes.Add(number);continue;}
	
        if (number<100)
            {
		int number2=f*10+e;
		if(number==number2)
			finalprimes.Add(number);
		if ((isprime(number2))&& (finalprimes.IndexOf(number2)==-1) )
			{finalprimes.Add(number);finalprimes.Add(number2);}
                continue;
            }
	
	if (number<1000)
	{
	int number2=e+d*10+f*100;
	int number3=d+f*10+e*100;
	if (!isprime(number2)||!isprime(number3))
		continue;
	if (finalprimes.IndexOf(number)==-1)	
		finalprimes.Add(number);
	if (finalprimes.IndexOf(number2)==-1)	
		finalprimes.Add(number2);
	if (finalprimes.IndexOf(number3)==-1)	
		finalprimes.Add(number3);
	continue;
	}

	
	if (number<10000)
	{
	
	int number2=e+d*10+c*100+f*1000;
	int number3=d+c*10+f*100+e*1000;
	int number4=c+f*10+e*100+d*1000;
	if (!isprime(number2)||!isprime(number3)||!isprime(number4))
		continue;
	if (finalprimes.IndexOf(number)==-1)	
		finalprimes.Add(number);
	if (finalprimes.IndexOf(number2)==-1)	
		finalprimes.Add(number2);
	if (finalprimes.IndexOf(number3)==-1)	
		finalprimes.Add(number3);
	if (finalprimes.IndexOf(number4)==-1)	
		finalprimes.Add(number4);
	continue;
	}
	
	if (number<100000)
	{
	
	int number2=e+d*10+c*100+b*1000+f*10000;
	int number3=d+c*10+b*100+f*1000+e*10000;
	int number4=c+b*10+f*100+e*1000+d*10000;
	int number5=b+f*10+e*100+d*1000+c*10000;
	if (!isprime(number2)||!isprime(number3)||!isprime(number4)||!isprime(number5))
		continue;
	if (finalprimes.IndexOf(number)==-1)	
		finalprimes.Add(number);
	if (finalprimes.IndexOf(number2)==-1)	
		finalprimes.Add(number2);
	if (finalprimes.IndexOf(number3)==-1)	
		finalprimes.Add(number3);
	if (finalprimes.IndexOf(number4)==-1)	
		finalprimes.Add(number4);
	if (finalprimes.IndexOf(number5)==-1)	
		finalprimes.Add(number5);
	continue;
	}
	
	///only putting braces to match logic of first set of circular primes tests
	{
	
	int number2=e+d*10+c*100+b*1000+a*10000+f*100000;
	int number3=d+c*10+b*100+a*1000+f*10000+e*100000;
	int number4=c+b*10+a*100+f*1000+e*10000+d*100000;
	int number5=b+a*10+f*100+e*1000+d*10000+c*100000;
	int number6=a+f*10+e*100+d*1000+c*10000+b*100000;
	if (!isprime(number2)||!isprime(number3)||!isprime(number4)||!isprime(number5)||!isprime(number6))
		continue;
	if (finalprimes.IndexOf(number)==-1)	
		finalprimes.Add(number);
	if (finalprimes.IndexOf(number2)==-1)	
		finalprimes.Add(number2);
	if (finalprimes.IndexOf(number3)==-1)	
		finalprimes.Add(number3);
	if (finalprimes.IndexOf(number4)==-1)	
		finalprimes.Add(number4);
	if (finalprimes.IndexOf(number5)==-1)	
		finalprimes.Add(number5);
	if (finalprimes.IndexOf(number6)==-1)	
		finalprimes.Add(number6);
	continue;
	}
    }
sw.Stop();
Console.WriteLine("Total numbers prime {0}",(primes.Count));
Console.WriteLine("Total circular primes {0}",(finalprimes.Count));
Console.WriteLine("Elapsed Time {0} ms",sw.ElapsedMilliseconds);
//foreach (var prim in finalprimes)
//	System.Console.WriteLine("Prime {0}",prim);
}
}
