using System;
using System.Diagnostics;

class seventeen
{

public static void Main()
{
    int sum=0;
    Stopwatch sw = new Stopwatch();

    sw.Start();
    for (int i=1;i<1001;i++)
         sum+=howmanyletters(i);
    sw.Stop();    
    Console.WriteLine("Sum of letters in numbers 1 - 1000 is {0}. Time elapsed {1} ms",sum,sw.ElapsedMilliseconds);
}

public static int howmanyletters(int a)
{
    int hunds=a/100;
    int tens=(a-hunds*100)/10;
    int runningtotal=0;
    int ones=a-(hunds*100)-(tens*10);
    
    if (a==1000)
        return 11;
    
    switch (hunds)
    {
        case 0:
            break;
        case 1:
        case 2:
        case 6:
        runningtotal+=13;
        break;
    
        case 4:
        case 5:
        case 9:
        runningtotal+=14;
        break;
    
        case 3:
        case 7:
        case 8:
        runningtotal+=15;
        break;
    }
    if (a%100==0)   ///no need for hundred and for these 
        {runningtotal-=3;return runningtotal;}
        
    if ((11<=(a-hunds*100))&&((a-hunds*100)<=19))  ///teens...won't need ones just return running total
        {
            switch(a-hunds*100)
            {
                case 11:
                case 12:
                    runningtotal+=6;
                    break;
                case 13:
                case 14:
                case 18:
                case 19:
                    runningtotal+=8;
                    break;
                case 15:
                case 16:
                    runningtotal+=7;
                    break;
                case 17:
                    runningtotal+=9;
                    break;
            }
        return runningtotal;  
        }
    
    switch (tens)
    {
        case 1:
            runningtotal+=3;
            break;
        case 0:
            break;
        case 2:
        case 3:
        case 8:
        case 9:
        runningtotal+=6;
        break;
        
        case 4:
        case 5:
        case 6:
        runningtotal+=5;
        break;
    
        case 7:
        runningtotal+=7;
        break;
    }
switch (ones)
    {
        case 0:
            break;
        case 1:
        case 2:
        case 6:
        runningtotal+=3;
        break;
    
        case 4:
        case 5:
        case 9:
        runningtotal+=4;
        break;
    
        case 3:
        case 7:
        case 8:
        runningtotal+=5;
        break;
    }
    
    //System.Console.WriteLine("hundreds {0} tens {1} ones {2}",hunds,tens,ones);
    return runningtotal;
}


}