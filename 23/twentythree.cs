using System;
using System.Collections.Generic;
using System.Diagnostics;

class twentythree
{

public static bool isAbundant(int num)
{
int factorsum=0;
for (int i=1;i<=(num/2);i++)
{
    if (num%i==0)
        factorsum+=i;
}
if (factorsum>num)
    return true;
else
    return false;
}

public static void Main()
{
Stopwatch sw = new Stopwatch();
List <int> abundantnos = new List<int>();
int nonabundantsum=0;

sw.Start();
abundantnos.Add(12); //First abundant number


for (int i=1;i<=28123;i++)
{
    if (isAbundant(i))
        abundantnos.Add(i);
}

for (int i=1;i<28123;i++)
{
    //System.Console.WriteLine("Currently on {0}",i);
bool dontadd=false;
foreach (int abundantnum in abundantnos)
{

int abundtest=0;

if (abundantnum>i)
        {
            break;
        }
abundtest=i-abundantnum;

if (abundantnos.IndexOf(abundtest)!=-1)
    {
        dontadd=true;
        break;
    }
    
}
if (!dontadd)
    nonabundantsum+=i;
   
}
sw.Stop();
System.Console.WriteLine("# Abundant Numbers {0} nonabundantsum {1}. Elapsed time {2}"
	,abundantnos.Count,nonabundantsum,sw.ElapsedMilliseconds);
//end of main
}
/////end of class
}