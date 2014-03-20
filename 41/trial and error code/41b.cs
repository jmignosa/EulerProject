using System;
using System.Diagnostics;
using System.Collections.Generic;

class fourone
{

public static bool ispan(string pstr)
{
	//string pstr=p.ToString();
	for (int j=1;j<=pstr.Length;j++)
	{
		if (pstr.IndexOf(j.ToString())<0)
			return false;
	}
	//Console.WriteLine("Found pandigital {0}",p);
	return true;
}


public static bool isprime (long number)
{
    for (long i=2;i<(Math.Sqrt(number)+1);i++)
        if (number%i==0)
                return false;
    return true;
}


public static void Main()
{
Stopwatch sw = new Stopwatch();
long i=2144;
string istr="";
List<long> pandigital = new List<long>();

sw.Start();
for (i=987654321;i>0;i-=2)
{
    if (!isprime(i))
        continue;
    istr=i.ToString();
    if (istr.Contains("0"))
	continue;
    if (!ispan(istr))
	continue;
    if (!istr.Contains("1"))
        continue;
    if (!istr.Contains("2"))
        continue;
    if (!istr.Contains("3"))
        continue;
    if (!istr.Contains("4"))
        continue;
    if (istr.Length==4)
        {System.Console.WriteLine("******************* Got One {0}",istr);continue;}
    if (!istr.Contains("5"))
        continue;
    if (istr.Length==5)
        {System.Console.WriteLine("******************* Got One {0}",istr);continue;}
    if (!istr.Contains("6"))
        continue;
    if (istr.Length==6)
        {System.Console.WriteLine("******************* Got One {0}",istr);continue;}
    if (!istr.Contains("7"))
        continue;
    if (istr.Length==7)
        {System.Console.WriteLine("******************* Got One {0}",istr);continue;}
    if (!istr.Contains("8"))
        continue;
    if (istr.Length==8)
        {System.Console.WriteLine("******************* Got One {0}",istr);continue;}
    if (!istr.Contains("9"))
        continue;
    if (istr.Length==9)
        {Console.WriteLine("******************* Got One {0}",istr);break;}
    
}
sw.Stop();
Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
}
}