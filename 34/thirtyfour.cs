using System;
using System.Collections.Generic;
using System.Diagnostics;

public class thirtyfour
{
public static int factorial(int f)
{
    if(f==0)
        return 1;
    return f*factorial(f-1);
}
    
public static void Main()
{
int count=0;
long sum=0;
Stopwatch sw = new Stopwatch();

sw.Start();
for (long i=10;i<Math.Pow(10,7);i++)
{
    long sumofnumberdigits=0;
    foreach(char t in (i.ToString().ToCharArray()))
    {
        int number = (int)char.GetNumericValue(t);
        sumofnumberdigits+=(factorial(number));
    }
    if (sumofnumberdigits==i)
        {
            count++;sum+=i;
            Console.WriteLine("a strange Number {0}",i);
        }
    
    
}
    sw.Stop();
    Console.WriteLine("{0} Strange Numbers  Their sum is {1} Elapsed time is {2} ms ",count,sum,sw.ElapsedMilliseconds);

}
}