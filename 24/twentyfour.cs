using System.Diagnostics;
using System;



class twentyfour{
static int a,c,b,d,e,f,g,h,i,j; 

public static bool ifcontinue(char whichvar)
{
    switch (whichvar)
    {
    case 'b':
        if (a==b)
            return true;
        return false;
    case 'c':
        if (a==c||b==c)
            return true;
        return false;
    case 'd':
        if (a==d||b==d||c==d)
            return true;
        return false;
    case 'e':
        if (a==e||b==e||c==e||d==e)
            return true;
        return false;
    case 'f':
        if (a==f||b==f||c==f||d==f||e==f)
            return true;
        return false;
    case 'g':
        if (a==g||b==g||c==g||d==g||e==g||f==g)
            return true;
        return false;
    case 'h':
        if (a==h||b==h||c==h||d==h||e==h||f==h||g==h)
            return true;
        return false;
    case 'i':
        if (a==i||b==i||c==i||d==i||e==i||f==i||g==i||h==i)
            return true;
        return false;
    case 'j':
        if (a==j||b==j||c==j||d==j||e==j||f==j||g==j||h==j||i==j)
            return true;
        return false;
    //break;
    }
    return true;
}

public static void Main()
{
a=b=c=d=e=f=g=h=i=j=0;
int index=0;
Stopwatch sw = new Stopwatch();
sw.Start();
    for (a=0;a<10;a++)
    {
        for (b=0;b<10;b++)
        {
            if (ifcontinue('b'))
                continue;
            for (c=0;c<10;c++)
            {
                if (ifcontinue('c'))
                    continue;
                for (d=0;d<10;d++)
                {
                    if (ifcontinue('d'))
                        continue;
                    for (e=0;e<10;e++)
                    {
                        if (ifcontinue('e'))
                            continue;
                        for (f=0;f<10;f++)
                            {
                                if (ifcontinue('f'))
                                    continue;
                            for (g=0;g<10;g++)
                                {
                                    if (ifcontinue('g'))
                                    continue;
                                    for (h=0;h<10;h++)
                                    {
                                        if (ifcontinue('h'))
                                            continue;
                                        for (i=0;i<10;i++)
                                        {
                                            if (ifcontinue('i'))
                                                continue;
                                            for (j=0;j<10;j++)
                                           {
                                                if (ifcontinue('j'))
                                                    continue;
                                                index++;
                                                
                                                if (index==1000000)
                                                    {
							sw.Stop();
							Console.WriteLine("Permutation# {10} =  {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}    {11}",a,b,c,d,e,f,g,h,i,j,index,sw.ElapsedMilliseconds);
							return;
							}
                                           }
                                        }
                                    }
                                }
                            }
                }    }
            }
        }
   }
}
}