using System;
using System.Collections.Generic;
using System.Diagnostics;

class thirtyone
{
public static void Main()
{
Stopwatch sw = new Stopwatch();
const int p1=1;      
const int p2=2;     
const int p5=5;
const int p10=10;
const int p20=20;
const int p50=50;
const int l=100;
List <int[]> twopound =new List<int[]>();
int sum=0;

sw.Start();
for (int a=0;a<=2;a++)
        for (int b=0;b<=4;b++)
        for (int c=0;c<=10;c++)
        for (int d=0;d<=20;d++)
        for (int e=0;e<=40;e++)
        for (int f=0;f<=100;f++)
        for (int g=0;g<=200;g++)
        {
            sum=a*l + b*p50 + c*p20 + d*p10 + e*p5 + f*p2 + g*p1 ;
            if (sum==200)
                {twopound.Add(new int[]{a,b,c,d,e,f,g});
                //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}  ",a,b,c,d,e,f,g);
		}
        }
sw.Stop();
Console.WriteLine("The answer is {0} + 1 for 2Lb Note. Elapsed Time {1} ms",(twopound.Count),sw.ElapsedMilliseconds);
}
}