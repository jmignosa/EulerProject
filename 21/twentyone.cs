using System;
using System.Collections.Generic;
using System.Diagnostics;

class twentyone
{
public static int GetDivisorSum(int number)
{
    int result=0;
    for (int i=1;i<number;i++)
    {
        if (number%i==0)
            {result+=i;
            //System.Console.WriteLine("Have a divisor {0}",i);
            }
    }
    //System.Console.WriteLine("Divisor Sum {0}",result);
    return result;        
}

public static void Main()
{

List <int[]> amicableNumbers  = new List <int[]>() ; //in case we want to use them later
int amicablesum=0;
Stopwatch sw = new Stopwatch();

sw.Start();
for (int i=2;i<10001;i++)
{
    int divisorsumi=0;
    int divisorsumj=0;
    divisorsumi=GetDivisorSum(i);
    divisorsumj=GetDivisorSum(divisorsumi);
    
    if (i==divisorsumj&&i!=divisorsumi)
        {
            int [] nums = {divisorsumi,i};
            Console.WriteLine("Amicable PAIR!!!! {0}   {1}",divisorsumi,i);
            amicableNumbers.Add(nums);  //for future use
            amicablesum+=i;
        }
    
}
sw.Stop();
Console.WriteLine("Amicablenumber count={0}",amicableNumbers.Count); 
Console.WriteLine("Amicablenumber sum={0}",amicablesum);    
Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
}
}