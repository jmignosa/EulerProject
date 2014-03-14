using System;
using System.Diagnostics;

class five
{
public static void Main()
{
    bool allfactors=false;
    Stopwatch sw = new Stopwatch();

    sw.Start();    
    for (long i=2520;i<(2520*19*17*16*13*11);i++)
    {
        for (long j=1;j<21;j++)
        {
            allfactors=true;
            if (i%j!=0)
                {allfactors=false;
                break;}
            
        }
        if (allfactors)
            {
		sw.Stop();
		Console.WriteLine("{0} is divisible by all. Time taken {1}",i,sw.Elapsed); 
		return;
	    }
        
    }
}
}