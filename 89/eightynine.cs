using System;
using System.IO;
using System.Text;
using System.Diagnostics;

class eightynine
{
public static void Main(){
StreamReader sr=new StreamReader(@"roman.txt");
string [] numbers = new string[1000];
string [] optnumbers = new string[1000];
Stopwatch sw = new Stopwatch();
int i=0;
int sumold=0;
int sumopt=0;

sw.Start();
while (sr.Peek()>=0)
{
numbers[i]=sr.ReadLine();
i++;
}

for (int j=0;j<1000;j++)
    sumold+=numbers[j].Length;
 
Console.WriteLine("Pre optimized count {0}",sumold);

StreamWriter w = File.AppendText("roman2.txt");
for (int j=0;j<1000;j++)
{
    StringBuilder sb = new StringBuilder(numbers[j]);
    //5 char replacements
    sb.Replace("VIIII","IX");
    sb.Replace("LXXXX","XC");
    sb.Replace("DCCCC","CM");
    //4 char replacements
    sb.Replace("IIII","IV");
    sb.Replace("XXXX","XL");
    sb.Replace("CCCC","CD");
    //2 char replacements
    sb.Replace("VV","X");
    sb.Replace("LL","C");
    sb.Replace("DD","M");
    optnumbers[j]=sb.ToString();
    w.WriteLine(optnumbers[j]);
}

for (int j=0;j<1000;j++)
    {sumopt+=optnumbers[j].Length;
    //Console.WriteLine("line {0} length {1}",j,numbers[j].Length);
    }
sw.Stop();
Console.WriteLine("Optimized count {0}. In a time of {1} ms. A savings of {2}",sumopt,sw.ElapsedMilliseconds,sumold-sumopt);


}
}