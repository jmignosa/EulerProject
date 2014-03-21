using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

class sixty {

public bool isprime(long number)
    {
        //skip 5 for the purpose of this problem
        if (number==5)
            return false;
        for (long i=2;i<(Math.Sqrt(number)+1);i++)
            if (number%i==0)
                return false;
        return true;
    }

public static void Main()
{
    new sixty().TheLogic();
}
    
public void TheLogic()
{
    Stopwatch sw = new Stopwatch();
    List<string> primes = new List<string>();
    long primeseed=3;

    sw.Start();
    while (primeseed<10000)
    {
        if (this.isprime(primeseed))
            primes.Add(primeseed.ToString());
        primeseed++;
    }
    Console.WriteLine("Number primes {0}",primes.Count);
    Console.WriteLine("Elapsed Time calcing primes {0} ms. Largest prime stored {1}",sw.ElapsedMilliseconds,primes[primes.Count-1]);

    for (int a=0;a<primes.Count-4;a++)
    for (int b=a+1;b<primes.Count-3;b++)
    for (int c=b+1;c<primes.Count-2;c++)
        {string test1=primes[a].ToString() + primes[c].ToString();string test2=primes[b].ToString()+primes[c].ToString();
        string test3=primes[c].ToString() + primes[a].ToString();string test4=primes[c].ToString()+primes[b].ToString();
        if (!isprime(Int32.Parse(test1))||!isprime(Int32.Parse(test2))||!isprime(Int32.Parse(test3))||!isprime(Int32.Parse(test4)))
            continue;
    for (int d=c+1;d<primes.Count-1;d++)
    {
        string test7=primes[a].ToString() + primes[d].ToString();string test8=primes[b].ToString()+primes[d].ToString();string test9=primes[c].ToString() + primes[d].ToString();
        string test10=primes[d].ToString() + primes[a].ToString();string test5=primes[d].ToString()+primes[b].ToString();string test6=primes[d].ToString() + primes[c].ToString();
        if (!isprime(Int32.Parse(test7))||!isprime(Int32.Parse(test8))||!isprime(Int32.Parse(test9)))
            continue;
        if (!isprime(Int32.Parse(test5))||!isprime(Int32.Parse(test6))||!isprime(Int32.Parse(test10)))
            continue;
    for (int e=d+1;e<primes.Count;e++)
    {
        bool groupnope=false;
        string [] perms= new string[20];
        //Console.WriteLine("Currently at {0}  {1}  {2}  {3}  {4}",primes[a],primes[b],primes[c],primes[d],primes[e]);
        perms= this.FillPerms(primes[a],primes[b],primes[c],primes[d],primes[e]);
        foreach (string test in perms)
        {
            if( !isprime(Int32.Parse(test)))
                {groupnope=true;break;}
        }
        if (!groupnope)
            {
                Console.WriteLine("we Have a hit! {0}  {1}  {2}  {3}  {4}",primes[a],primes[b],primes[c],primes[d],primes[e]);
                Console.WriteLine("Total={0}",(Int32.Parse(primes[a])+Int32.Parse(primes[b])+Int32.Parse(primes[c])+Int32.Parse(primes[d])+Int32.Parse(primes[e])));
		Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
                            }
                }
    }
    }
    sw.Stop();
    Console.WriteLine("Elapsed Time {0}",sw.Elapsed);
}


public string[] FillPerms(string a, string b, string c, string d, string e)
{
    string [] returnval=new string[20];
    returnval[0] = a+b;
    returnval[1] = a+c;
    returnval[2] = a+d;
    returnval[3] = a+e;
    returnval[4] = b+c;
    returnval[5] = b+d;
    returnval[6] = b+e;
    returnval[7] = c+d;
    returnval[8] = c+e;
    returnval[9] = d+e;
    returnval[10] = b+a;
    returnval[11] = c+a;
    returnval[12] = d+a;
    returnval[13] = e+a;
    returnval[14] = c+b;
    returnval[15] = d+b;
    returnval[16] = e+b;
    returnval[17] = d+c;
    returnval[18] = e+c;
    returnval[19] = e+d;
    return returnval;
}
    
}