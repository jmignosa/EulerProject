using System;
using System.Diagnostics;

class four
{
public static void Main()
{
    Stopwatch sw = new Stopwatch();
    int largest=0;
    int factori,factorj; factori=factorj=0;

    sw.Start();
    for (int i=(100);i<(1000);i++)
    {
        for (int j=i;j<(1000);j++)
        {
            string product=(i*j).ToString();
            char []temparray=product.ToCharArray();
            Array.Reverse(temparray);
            
            string reverse = new string (temparray);
        if (product==reverse)
            {
            if ((i*j) > largest)
                largest=(i*j);
            factori=i;factorj=j;
            }
        }
    }
    sw.Stop();
    Console.WriteLine("Largest Palindrome {0} found as a product of {1} and {2} Solution took {3}",largest,factori,factorj,sw.Elapsed);
}
}
