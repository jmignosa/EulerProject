using System;
using System.Numerics;
using System.Diagnostics;

class twentyfive
{
public static void Main()
{

bool lessthan1k=true;
BigInteger fib1=1;
BigInteger fiblast=0;
BigInteger fibnexttolast=1;
int counter=1;
Stopwatch stopper = new Stopwatch();

stopper.Start();
while (lessthan1k)
{
    //if (fib1.ToString().Length<50)
    //    System.Console.WriteLine("Number {1} Fib is {0}",fib1,counter);
    //else
    //    System.Console.WriteLine("Number {1} Fiblength is {0}",fib1.ToString().Length,counter);
    fib1=fiblast+fibnexttolast;
    fiblast=fibnexttolast;
    fibnexttolast=fib1;
    counter++;
    if  (fib1.ToString().Length==1000)
        {lessthan1k=false;stopper.Stop();}
}
System.Console.WriteLine("Number {1} Fiblength is {0} Elapsed Time {2} ms",
	fib1.ToString().Length,counter,stopper.ElapsedMilliseconds);
}
    
}