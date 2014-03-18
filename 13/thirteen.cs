using System;
using System.IO;
using System.Diagnostics;

class thirteen
{

public static string[] snumbers= new string[100];
public static long[,] numbers = new long[100,5];

public static void Main()
{
    Stopwatch sw = new Stopwatch();
    
    sw.Start();
    readdata();
    long tens1,tens2,tens3,tens4,tens5;
    tens1=tens2=tens3=tens4=tens5=0;
    
    for (int i=0;i<100;i++)
    {
        tens1+=numbers[i,0];
        tens2+=numbers[i,1];
        tens3+=numbers[i,2];
        tens4+=numbers[i,3];
        tens5+=numbers[i,4]; 
    }
    Console.WriteLine("1st num {0}  2nd num {1}   3rd num {2}   4th num {3}    5th num {4}",tens1,tens2,tens3,tens4,tens5);
    long tmp=tens5/(10000000000);
    tens4+=tmp;
    Console.WriteLine(" new 4th tens {0}",tens4);
    tmp= tens4/10000000000;
    tens3+=tmp;
    Console.WriteLine(" new 3rd tens {0}",tens3);
    tmp= tens3/10000000000;
    tens2+=tmp;
    Console.WriteLine(" new 2nd tens {0}",tens2);
    tmp= tens2/10000000000;
    tens1+=tmp;
    //Console.WriteLine(" last tmp {0}",tmp); Used for Debug only
    Console.WriteLine(" new 1st tens {0}",tens1);
    Console.WriteLine("Elapsed Time {0} ms",sw.ElapsedMilliseconds);
    sw.Stop();

}



public static void readdata()
{
    StreamReader datareader = new StreamReader(@".\data.txt");
    int count=0;
    
    while (datareader.Peek()>=0)
    {
        snumbers[count]=datareader.ReadLine();
        numbers[count,0]=Int64.Parse(snumbers[count].Substring(0,10));
        numbers[count,1]=Int64.Parse(snumbers[count].Substring(10,10));
        numbers[count,2]=Int64.Parse(snumbers[count].Substring(20,10));
        numbers[count,3]=Int64.Parse(snumbers[count].Substring(30,10));
        numbers[count,4]=Int64.Parse(snumbers[count].Substring(40,10));
        count++;
    }
}


}