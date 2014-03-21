using System;
using System.Collections.Generic;
using System.Diagnostics;

class fortynine
{
public static List<int> primes = new List<int>();

public static bool isprime(int number)
{
    for (int i=2;i<(Math.Sqrt(number)+1);i++)
            if (number%i==0)
                return false;
    return true;
}

public static void Main()
{
    Stopwatch sw = new Stopwatch();
    int a,b,c,count; a=b=c=0;
    
    sw.Start();
    for (int i=1001;i<=9999;i+=2)
    {
        if (isprime(i))
            primes.Add(i);
    }
    count=primes.Count;
    
    for (a=0;a<count-2;a++)
    for (b=a+1;b<count-1;b++)
    for (c=b+1;c<count;c++)
    {
        if((primes[b]-primes[a])==(primes[c]-primes[b]))
           {
            char []one=primes[a].ToString().ToCharArray();
            char []two=primes[b].ToString().ToCharArray();
            char []thr=primes[c].ToString().ToCharArray();
            Array.Sort(one);Array.Sort(two);Array.Sort(thr);
              
            if ((new string(one))==(new string(two))&&(new string(two))==(new string(thr)))
                Console.WriteLine("A {0} B {1}  C {2}  diff {3} concat={0}{1}{2}{3}",primes[a],primes[b],primes[c],(primes[b]-primes[a]));
                
            }
    }
Console.WriteLine("Elapsed Time {0} ms",sw.ElapsedMilliseconds);
}

}//end class