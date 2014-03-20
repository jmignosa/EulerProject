using System;
using System.Diagnostics;

class test
{
public static void Main()
{
Stopwatch sw = new Stopwatch();
string istr;
sw.Start();
for (long i=1234;i<=987654321;i++)
{
    if (!isprime(i))
	continue;
    //istr=i.ToString();
    //if (istr.Contains("0"))
	//continue;
    //if (!ispan(i))
	//continue;	
}
sw.Stop();
Console.WriteLine("Took {0} ms",sw.ElapsedMilliseconds);
}



public static bool isprime (long number)
{
    for (long i=2;i<(Math.Sqrt(number)+1);i++)
        if (number%i==0)
                return false;
    return true;
}

}