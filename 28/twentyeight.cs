using System;
using System.Diagnostics;

class twentyeight
{
public static void Main()
{
    long NE,NW,SE,SW;
    long sumNE,sumNW,sumSE,sumSW;
    sumNE=sumNW=sumSE=sumSW=0;
    NE=NW=SE=SW=1;
    long answer=0;
    int matrixlength=1001;
    Stopwatch sw = new Stopwatch();
        
    sw.Start();
    for (int i=0;i<(matrixlength/2);i++)
    {
        NE+=(2+(i*8));
        sumNE+=NE;
        NW+=(4+(i*8));
        sumNW+=NW;
        SW+=(6+(i*8));
        sumSW+=SW;
        SE+=(8+(i*8));
        sumSE+=SE;
        System.Console.WriteLine("NE {0}  NW {1}  SW {2} SE {3}",NE,NW,SW,SE); 
    }
    answer=1+sumNE+sumNW+sumSE+sumSW;
    sw.Stop();
    Console.WriteLine("The Diagonals are NE {0}  NW {1}  SW {2} SE {3}    Answer = {4}",sumNE,sumNW,sumSW,sumSE,answer);   
    Console.WriteLine("Elapsed Time {0} ms",sw.ElapsedMilliseconds);
}    
}