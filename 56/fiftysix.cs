using System;
using System.Numerics;
using System.Diagnostics;

class fiftysix
{
public static void Main()
{
    BigInteger a=5;
    BigInteger b=5;
    BigInteger product=0;
    string stringproduct="";
    int tempdigitsum=0;
    int maxdigitsum=0;
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    for (a=5;a<100;a++)
        for (b=5;b<100;b++)
        {
            tempdigitsum=0;
            product=pow(a,b);
            stringproduct=product.ToString();
            foreach(char c in stringproduct)
                {
                    tempdigitsum+=Int32.Parse((c.ToString()));
                }
            Console.WriteLine("a {0}   b  {1}    tempsum {2}   maxsum {3} ",a,b,tempdigitsum,maxdigitsum);
            if (tempdigitsum>maxdigitsum)
                maxdigitsum=tempdigitsum;
        }
	sw.Stop();
	Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
    
}

public static BigInteger pow(BigInteger num, BigInteger power)
    {
        BigInteger returnVal=num;
        for (BigInteger i=1;i<power;i++)
            returnVal*=num;
        return returnVal;
    }
}