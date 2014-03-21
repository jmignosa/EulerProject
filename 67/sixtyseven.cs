using System;
using System.IO;
using System.Diagnostics;

class eighteen
{
public static int[,] triangle()
{
  StreamReader theFile = new StreamReader(@".\triangle.txt");
  int[,] buffer = new int[100,100];//{1,2,3,4,5};
  int i=0;
  string sbuffer;
    
  while ((sbuffer=theFile.ReadLine())!=null)
  {
    int j=0;
    string []numbers = sbuffer.Split(' ');
    foreach (string num in numbers)
    {System.Console.WriteLine("Inserting {0} into array at row {1} column {2}",num,i,j);
     buffer[i,j]= Int32.Parse(num);
     j++;
    }
    i++;
  }
  return buffer;
}

public static void Main()
{
    int []sums=new int[100];
    int [,] theTriangle = new int[100,100];
    Stopwatch sw = new Stopwatch();

    sw.Start();
    theTriangle=triangle();
    ///Display triangle
    for (int i=0;i<100;i++)
       { for (int j=0;j<i+1;j++)
        {
            System.Console.Write(" {0} ",theTriangle[i,j]);
        }
        System.Console.Write("\n\r");
       }
    //Start summing paths to bottom
    //Tip of triangle first
    theTriangle[1,0]+=theTriangle[0,0];
    theTriangle[1,1]+=theTriangle[0,0];
    
    for (int i=1;i<99;i++)
    { for (int j=0;j<i+1;j++)
     {
        if (j==0)
            theTriangle[i+1,j]+=theTriangle[i,j];
        if (j==i)
            {theTriangle[i+1,j+1]+=theTriangle[i,j];
            continue;}
        
        theTriangle[i+1,j+1]+= (theTriangle[i,j]>theTriangle[i,j+1]) ? theTriangle[i,j]:theTriangle[i,j+1];
        
        
        }
        //System.Console.Write("\n\r");
       }
       
       //Print last row with sums
       for (int j=0;j<100;j++)
        {
          sums[j]=theTriangle[99,j];
            System.Console.Write(" {0} ",theTriangle[99,j]);
        }
        System.Console.Write("\n\r");

Array.Sort(sums);
sw.Stop();
System.Console.WriteLine("\n\r Max sum = {0} Elapsed time {1}", sums[99],sw.ElapsedMilliseconds);
}

}