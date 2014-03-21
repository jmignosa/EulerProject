using System;
using System.Diagnostics;

class fifty
{
public static bool isprime(long num)
{
	if (num==2)
           return true;
	for (long i=2;i<=(Math.Sqrt(num))+1;i++)
	{
		if (num%i==0)
			return false;
	}
	return true;
}

public static void Main()
{
    int maxprime=0;
    int consecprime=0;
    int maxconsecprime=0;
    int maxconsecprimetotal=0;
    Stopwatch sw = new Stopwatch();

    sw.Start();
    for (int j=1;j<100000;j++)
    {
        if (!isprime(j))
            continue;
    int primesum=j;
    consecprime=0;
    for (int i=j+1;i<1000000;i++)
        {
        if (isprime(i))
            {primesum+=i;consecprime++;}
        
        if (isprime(primesum))
            {
                if (primesum>maxprime&&primesum<1000000)
                        {maxprime=primesum;
                if (primesum<1000000&&consecprime>maxconsecprime)
                {
                    maxconsecprimetotal=primesum;
                    maxconsecprime=consecprime;
                }
                System.Console.WriteLine("Prime number found {0} Largest is {1} consec primes {2} #max consec primes {3} Prime with max consec primes {4}"
                                         ,primesum,maxprime,consecprime,maxconsecprime,maxconsecprimetotal);
		}
            }
        if (primesum>1000000)
            {primesum-=i;
            consecprime--;
            break;
            }
        }
    }
sw.Stop();
Console.WriteLine("Largest prime below 1,000,000 thats a sum of consecutive primes is {0}. Elapsed time {1} ms",maxconsecprimetotal,sw.ElapsedMilliseconds);
}
}