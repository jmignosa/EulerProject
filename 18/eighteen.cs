using System;
using System.IO;
using System.Diagnostics;

class eighteen
{
public static int[,] triangle()
{
  Stopwatch sw = new Stopwatch();
  StreamReader theFile = new StreamReader(@".\triangle.txt");
  int[,] buffer = new int[15,15];
  int i=0;
  string sbuffer;
    
  while ((sbuffer=theFile.ReadLine())!=null)
  {
    int j=0;
    string []numbers = sbuffer.Split(' ');
    foreach (string num in numbers)
    {
     Console.WriteLine("Inserting {0} into array at row {1} column {2}",num,i,j);
     buffer[i,j]= Int32.Parse(num);
     j++;
    }
    i++;
  }
  return buffer;
}

public static void Main()
{
    Stopwatch sw = new Stopwatch();
    int []sums=new int[15]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    int [,] theTriangle = new int[15,15];
    
    sw.Start();
    theTriangle=triangle();
    ///Display triangle
    for (int i=0;i<15;i++)
       { for (int j=0;j<i+1;j++)
        {
            Console.Write(" {0} ",theTriangle[i,j]);
        }
            Console.Write("\n\r");
       }
    //Start summing paths to bottom
    //Tip of triangle first
    theTriangle[1,0]+=theTriangle[0,0];
    theTriangle[1,1]+=theTriangle[0,0];
    
    for (int i=1;i<14;i++)
    { for (int j=0;j<i+1;j++)
     {
        if (j==0)
            theTriangle[i+1,j]+=theTriangle[i,j];
        if (j==i)
            {theTriangle[i+1,j+1]+=theTriangle[i,j];
            continue;}
        
        theTriangle[i+1,j+1]+= (theTriangle[i,j]>theTriangle[i,j+1]) ? theTriangle[i,j]:theTriangle[i,j+1];
        
        
        }
        
       }
       
       //Print last row with sums
       for (int j=0;j<15;j++)
        {
            System.Console.Write(" {0} ",theTriangle[14,j]);
        }
        sw.Stop();
        Console.Write("\n\r Elapsed Time {0}",sw.ElapsedMilliseconds);
       
}

}