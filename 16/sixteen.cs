using System;
using System.Diagnostics;

class sixteen{

public static int []theNumber = new int[1000];

public static void multiplyby2()
{
    for (int i=0;i<1000;i++)
    {
        theNumber[i]=theNumber[i]*2;
    }
    for (int i=0;i<1000;i++)
    {
        if(theNumber[i]>9)
            {theNumber[i]-=10;
             theNumber[i+1]++;
            }
    }
    
}

public static void Main()
{
    Stopwatch stoppy = new Stopwatch();
    string stringnumber="";
    int digittotal=0;

    stoppy.Start();
    for (int i=1;i<100;i++)
        {theNumber[i]=0;}
    
    theNumber[0]=1;
    for (int i=1;i<=1000;i++)
        multiplyby2();
    
    for (int i=999;i>=0;i--)
    {
        
        stringnumber+=theNumber[i].ToString();
        digittotal+=theNumber[i];
    }
    stoppy.Stop();
    //Console.WriteLine("Final number is {0}",stringnumber);
    Console.WriteLine("Sum of digits is {0}. Time elapsed {1} ms",digittotal,stoppy.ElapsedMilliseconds);
}
}