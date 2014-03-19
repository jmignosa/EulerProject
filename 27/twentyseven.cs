using System;
using System.Diagnostics;

class twentysix
{
    
public static bool isprime(long num)
{
	for (long i=2;i<(Math.Sqrt(num)+1);i++)
	{
		if (num%i==0)
			return false;
	}
	return true;
}



public static void Main()
{
    int a=0;
    int b=0;
    int maxstreak=0;
    long number=0;
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    for (int i=-1000;i<1001;i++)
        for (int j=-1000;j<1001;j++)
        {
            bool streak=true;
	    int n=0;
	    while (streak)
	    {
		number=n*n+(i*n)+j;
		number =Math.Abs(number);
		if (isprime(number))
			n++;
		else
			streak=false;
		if (n>maxstreak)
			{
			maxstreak=n;
			a=i;b=j;
			//Console.WriteLine("Maxstreak {0}  a {1}    b {2} ",maxstreak,a,b);
			}
		
			
	    }
        }
	sw.Stop();
	Console.WriteLine("*******************Maxstreak {0}  a {1}    b {2} product (answer) {3}",maxstreak,a,b,(a*b));
    	Console.WriteLine("Elapsed Time {0} ms",sw.ElapsedMilliseconds);
}
}