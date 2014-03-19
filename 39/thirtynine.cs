using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class triangle{
public int perimeter{get;set;}
public int[] sidea;
public int[] sideb;
public int[] sidec;
public int count {get;set;}
}

public class thirtynine{


public static void Main()
{
    List<int> squares = new List<int>();
    List<int> perims = new List<int>();
    triangle[] triangle= new triangle[1000];
    int perimeter=0;
    int trianglecount=0;
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    for (int i=1;i<=1000;i++)
        squares.Add((i*i));
    
    for (int a=1;a<1000;a++)
        for (int b=1;b<1000;b++)
        {
            if (a>b)
                continue;
            int test = a*a + b*b;
            if (squares.IndexOf(test)==-1)
                continue;
            perimeter=a+b+(int)Math.Sqrt(test);
            if (perimeter>1000)
                continue;
            trianglecount++;
            perims.Add(perimeter);
            Console.WriteLine("Perimeter {0}  Side A {1} B {2}  C {3}",perimeter,a,b,(Math.Sqrt(test)));
        }
        perims.Sort();
        Console.WriteLine("triangles {0}",trianglecount);
        
	var mode = perims.GroupBy(n=> n). 
    	OrderByDescending(g=> g.Count()). 
    	Select(g => g.Key).FirstOrDefault(); 
	sw.Stop();
	Console.WriteLine("Answer is {0}. Elapsed time {1} ms",mode,sw.ElapsedMilliseconds);
    
}
}