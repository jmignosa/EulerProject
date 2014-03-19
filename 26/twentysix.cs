using System;
using System.Collections.Generic;
using System.Diagnostics;

class twentyfive{
// if prime factors are only 2 and 5 then it is a terminating decimal
public static int remove2sandor5s(int num)
{    
while (num%2==0)
{
    num=num/2;
}
if (num==1)
    return 1;
while (num%5==0)
{
num=num/5;        
}
return num;
}


public static void Main()
{
long remainder=0;
long divisor=1;
bool isrepeating=false;
List <long> remainderhist = new List<long>();
List <int> number = new List<int>();
int count=0;
int deccount=0;
int maxcount=0;
Stopwatch sw = new Stopwatch();

sw.Start();
for (int i=7;i<1001;i++)
{
    remainderhist.Clear();
    if (remove2sandor5s(i)==1)
        {
            Console.WriteLine("1/{0} terminates and does not repeat",i);
            continue;
        }
    
    remainder=1;
    divisor=i;
    isrepeating=false;
    while(!isrepeating)
    {
        count=0;
        while(remainder>=divisor)
        {
            remainder-=divisor;
            count++;
        }
        number.Add(count);
        remainder*=10;
        if (remainderhist.IndexOf(remainder)==-1)
            {remainderhist.Add(remainder);}
        else
            {isrepeating=true;}     
    }
    deccount=(remainderhist.Count - remainderhist.IndexOf(remainder));
    if (deccount>maxcount)
        maxcount=deccount;
    Console.WriteLine("For 1/{0} Length of repeating decimal {1}    longest{2}",i,deccount,maxcount);

}
	sw.Stop();
	Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);  
} //main

} //class