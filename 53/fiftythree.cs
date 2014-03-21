using System;
using System.Numerics;
using System.Diagnostics;

class fiftythree{

public static BigInteger Factorial( BigInteger x ){
  if( x<0){
     return -1;
  }else if( x==1 || x==0 )
  {
     return 1;
  }else{
     return x* Factorial(x-1);
  }
}

public static void Main()
{
    BigInteger maxsum=0;
    BigInteger sum=0;
    int count=0;
    Stopwatch sw = new Stopwatch();

    sw.Start();
    for (BigInteger n=10;n<=100;n++)
        for (BigInteger r=1;r<n;r++)
        {
            sum=Factorial(n)/(Factorial(r)*Factorial(n-r));
            if (sum>1000000)
                {count++;Console.WriteLine("****************************************************************");}
            Console.WriteLine("n {0} r {1} sum{2}  count{3}",n,r,sum,count);
        }
    sw.Stop();
    Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
}
}