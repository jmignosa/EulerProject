using System;
using System.Diagnostics;

class problem6
{
public static void Main()
{
    	long sum,squaresum;
    	long difference=0;
	sum=squaresum=0;
    	Stopwatch sw = new Stopwatch();
        sw.Start();

    	for (long i=1;i<101;i++)
    	{
        	sum+=i;
        	squaresum+=(i*i);
        	//Console.WriteLine("i {2} Sum {0}   Squaresum {1}",sum,squaresum,i);
    	}
    	difference=(sum*sum) - squaresum;
	sw.Stop();
    	Console.WriteLine(@"Sum of the squares {0}. Sum of the numbers {1} difference between
                             the sum of the squares and square of the sum{2} Elapased Time {3}",
				squaresum,(sum*sum),difference,sw.ElapsedMilliseconds);
}

}