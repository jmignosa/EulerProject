using System;
using System.Diagnostics;

public static class extender{
public static string Reverse( this string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}
}


class thirtysix
{
public static void Main(string []args)
{
Stopwatch sw = new Stopwatch();
int palindromecount=0;
int palindromesum=0;
string binary ="";

sw.Start();
for (int i=1;i<1000000;i++)
{
    if (i.ToString()!=i.ToString().Reverse())
        continue;
    binary=Convert.ToString(i, 2);
    if (binary.ToString()==binary.ToString().Reverse())
    {
        palindromecount++;
        palindromesum+=i;
        Console.WriteLine("We have a hit numero {0}   its binary {1}",i,binary);
    }
}
sw.Stop();
Console.WriteLine("The answer is {0}. Took {1} ms ",palindromesum,sw.ElapsedMilliseconds);  
}
}