using System;
using System.Diagnostics;

class seventyone{
public static void Main(){
Stopwatch sw = new Stopwatch();
long numer=3;
long denom=7;

sw.Start();
long multiplier=999999/denom;
long new_numer=multiplier*numer;
long answer=new_numer-1;
sw.Stop();
Console.WriteLine("The answer to this one is {0} Elapsed time / ticks {1}/{2}",answer,sw.ElapsedMilliseconds,sw.ElapsedTicks);


}
}