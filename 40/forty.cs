using System;
using System.Diagnostics;

class forty{

public static void Main()
{
Stopwatch sw = new Stopwatch();
int arraycount=0; //not sure how big this grows yet want to keep array in bounds.
int numbercount=1;
char[] champer=new char[1000000];//char[] champer=new char[1000000];
sw.Start();
while (arraycount<1000000)
{
    foreach (char numbr in (numbercount.ToString().ToCharArray()))
    {champer[arraycount]=numbr;
    
    arraycount++;
    if (arraycount>999999)
        break;
    }
    numbercount++;
}
sw.Stop();
Console.WriteLine("d1={0} d10={1} d100={2} d1000= {3} d10000={4} d100000={5} d1000000={6}", champer[0],champer[9],champer[99],champer[999],champer[9999],champer[99999],champer[999999]);
Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
}
}