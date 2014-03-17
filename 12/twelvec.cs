using System;
using System.Collections.Generic;
using System.Diagnostics;

class twelve
{
public static void Main()
{
    long counter=0;
    long triangle=0;
    bool lessthan500factors=true;
    int factors = 1;
    Stopwatch sw = new Stopwatch();

    sw.Start();
    while (lessthan500factors)
    {
        factors=1;
        counter++;
        triangle+=counter;
        long factorednum=triangle;

        for (long i=1;i<=Math.Sqrt(triangle)+1;i++)
        {
            if (factorednum%i==0)
            {
                factors+=2;
                //factorednum=factorednum/i;
            }
        }
        if(factors>=500)
            lessthan500factors=false;
    }
    sw.Stop();
    System.Console.WriteLine("Triangle number is {0} number of factors is {1} Time taken {2} ms", triangle, factors,sw.ElapsedMilliseconds);
}
}