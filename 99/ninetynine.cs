using System;
using System.IO;


struct numbers
{
    public long number;
    public long power;
}

class ninetynine
{
    public static numbers[] theNumbers = new numbers[1000];
    public static void Main()
    {
        int largestline=0;
        double largestvalue=0;
        readdata();
        for (int i=0;i<1000;i++)
            {
                Console.WriteLine("i is at {0}",i);
                Console.WriteLine("{0}        {1}",theNumbers[i].number,theNumbers[i].power);
                
                if ((theNumbers[i].power*(Math.Log(theNumbers[i].number))) > largestvalue)
                    {
                        double temp=theNumbers[i].power*(Math.Log(theNumbers[i].number));
                        largestline=i+1;
                        largestvalue=temp;
                        Console.WriteLine("current largest line {0}  largest value {1}  current value{2}",largestline,largestvalue,temp);
                    }
                
            }
        Console.WriteLine("Largest Line is {0}",(largestline));
    }
    
    public static void readdata()
    {
        int i=0;
        string buff="";
        string []stringnum={"",""};
        
        StreamReader sr = new StreamReader("base_exp.txt");
        while (sr.Peek() >= 0) 
                {
                    char[] sep={','};
                    buff=sr.ReadLine();
                    stringnum=buff.Split(sep,StringSplitOptions.RemoveEmptyEntries);
                    theNumbers[i].number=Int64.Parse(stringnum[0]);
                    theNumbers[i].power=Int64.Parse(stringnum[1]);
                    //Console.WriteLine("{0}       {1}",theNumbers[i].number,theNumbers[i].power);
                    i++;
                }
                
    }
    
}