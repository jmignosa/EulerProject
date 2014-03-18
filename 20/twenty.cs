using System;
using System.Numerics;
using System.Diagnostics;

class twenty
{
public static void Main()
{
    BigInteger anumber=1;
    string stringno="";
    int sum=0;
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    for (int a=100;a>1;a--)
       { anumber=anumber*a;
    System.Console.WriteLine(anumber);}
    stringno=anumber.ToString();
    for (int i=0;i<stringno.Length;i++)
        sum+=Int32.Parse(stringno.Substring(i,1));
    sw.Stop();
    Console.WriteLine("sum of digits {0}. Time Elapsed {1} ms",sum,sw.ElapsedMilliseconds);
    
}
}