using System;
using System.Collections.Generic;
using System.Diagnostics;

public class thirtythree
{
public static void Main()
{
Stopwatch sw = new Stopwatch();
int a,b,c,d;
a=b=c=d=0;
float a1,b1,c1,d1;
a1=b1=c1=0;
float orig=0;
int numer=1;
int denom=1;

sw.Start();
   for (int num=10;num<100;num++)
    for (int den=10;den<100;den++)
        {
            
            a=num/10;b=num%10;
            c=den/10;d=den%10;
            if ((num/den)>=1)
                continue;
            if ((a!=c ) && (a!=d) && (b!=c) && (b!=d))
                continue;
              orig=(float)num/(float)den;
              //Console.WriteLine("{0}/{1}",num,den);
              
              if (a==c)
              {
                if (a==0)
                    continue;
                b1=(float)b;d1=(float)d;
                if (orig==(b1/d1))
                	{
			Console.WriteLine("We have a hit {0}/{1}",num,den);
			numer*=num;
			denom*=den;
			}
                continue;
              }
              if (a==d)
              {
                if (a==0)
                    continue;
                b1=(float)b;c1=(float)c;
                if (orig==(b1/c1))
                {
			Console.WriteLine("We have a hit {0}/{1}",num,den);
			numer*=num;
			denom*=den;
			}
                continue;
              }
              if (b==c)
              {
                if (b==0)
                    continue;
                a1=(float)a;d1=(float)d;
                if (orig==(a1/d1))
                {
			Console.WriteLine("We have a hit {0}/{1}",num,den);
			numer*=num;
			denom*=den;
			}
                continue;
              }
              if (b==d)
              {
                if (b==0)
                    continue;
                a1=(float)a;c1=(float)c;
                if (orig==(a1/c1))
                {
			Console.WriteLine("We have a hit {0}/{1}",num,den);
			numer*=num;
			denom*=den;
			}
                continue;
              }
              
        }
sw.Stop();
Console.WriteLine("Elapsed time {0} ms. Unreduced Numerator={1} Unreduced Denom={2}",sw.ElapsedMilliseconds,numer,denom);
}
    
}