using System;
using System.Diagnostics;

class onehundred
{
public static void Main()
{
Stopwatch sw = new Stopwatch();
double rad=0;
double i=756872320000;
rad=.5+(.5)*Math.Sqrt((8*i*i)-(8*i)+1);
bool test=false;
double testvalue=0;
double numer=0;
double denom=0;

sw.Start();
while (!test||rad<Math.Pow(10,12))
{
	i++;
	rad=.5+(.5)*Math.Sqrt((8*i*i)-(8*i)+1);
	numer=i*(i-1);
	denom=(rad)*(rad-1);
	testvalue=numer/denom;
					
	Console.WriteLine("Blue ={0}                     b={1}   test {2} ",i,rad, testvalue );
	if ( rad==(long)rad)
		test=true;		
}
sw.Stop();
Console.WriteLine("problem 100 blue {0} red {1}",i,(rad-i));
Console.WriteLine("problem blue + red {0}",rad);
Console.WriteLine("Solution took {0} ms",sw.ElapsedMilliseconds);
}
}