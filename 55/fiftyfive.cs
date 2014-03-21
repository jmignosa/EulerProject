using System;
using System.Numerics;
using System.Diagnostics;

public static class stringextension
{
    public static string Reverse(this string s )
    {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
    }
}
class fiftyfive
{

public static BigInteger reverse(BigInteger i)
{
    string numero=i.ToString();
    BigInteger returner=BigInteger.Parse((numero.Reverse()));
    return returner;
}

public static void Main()
{
    int lychrelcount=0;
    Stopwatch sw = new Stopwatch();

sw.Start();
for (int i=10;i<10000;i++)
{
    int count=1;
    bool nonpalin=true;
    BigInteger num=(i + reverse(i));
    while (count<50 && (nonpalin==true))
    {
        
        if (num==reverse(num))
            nonpalin=false;
            
        num+=reverse(num);
        count++;
    }
    if (count==50&&(nonpalin==true))
        lychrelcount++;
    
}
sw.Stop();
Console.WriteLine("LychrelCount {0}. Elapsed time {1} ms",lychrelcount,sw.ElapsedMilliseconds);
}

}