using System;
using System.Diagnostics;

class nine{

public static void Main()
{
Stopwatch sw = new Stopwatch();

sw.Start();
for (int a=1;a<=1000;a++)
    {for (int b=a+1;b<=1000;b++)
        {for (int c=b+1;c<=1000;c++)
        {
            if ((a*a+b*b)==(c*c))
                if ((a+b+c)==1000)
                    {
			sw.Stop();
			System.Console.WriteLine("In {1} ms We Have A winner!!!!!!!!!!! answer ={0}",
					(a*b*c),sw.ElapsedMilliseconds);
			return;
		     }
        
        }
        }
    }
}
}
