using System;
using System.Collections.Generic;
using System.Diagnostics;

class fortythree
{

public static List<string> pdnumbers = new List<string>();

public static void Main()
{
Stopwatch stoppy = new Stopwatch();
int counter=0;
long sum=0;
stoppy.Start();
buildlist();
Console.WriteLine("\r\nThere are {0} Pandigitals total",pdnumbers.Count);
Console.WriteLine("\r\n......Elapsed Time building list {0}",stoppy.Elapsed);
Console.WriteLine("Checking Primive sub divisibility now");

foreach (var pdnum in pdnumbers)
{
//Console.WriteLine("debug {0}    {1}",counter,pdnum);
int sub234=0;
int sub345=0;
int sub456=0;
int sub567=0;
int sub678=0;
int sub789=0;
int sub890=0;
sub234=Int32.Parse(pdnum.Substring(1,3));
if (sub234%2!=0)
    continue;
sub345=Int32.Parse(pdnum.Substring(2,3));
if (sub345%3!=0)
    continue;
sub456=Int32.Parse(pdnum.Substring(3,3));
if (sub456%5!=0)
    continue;
sub567=Int32.Parse(pdnum.Substring(4,3));
if (sub567%7!=0)
    continue;
sub678=Int32.Parse(pdnum.Substring(5,3));
if (sub678%11!=0)
    continue;
sub789=Int32.Parse(pdnum.Substring(6,3));
if (sub789%13!=0)
    continue;
sub890=Int32.Parse(pdnum.Substring(7,3));
if (sub890%17!=0)
    continue;
sum+=Int64.Parse(pdnum);
counter++;
Console.WriteLine("another hit!  {0}  total now {1}",pdnum,counter);
}

stoppy.Stop();
Console.WriteLine("\r\n......Total elapsed Time {0}",stoppy.ElapsedMilliseconds);
Console.WriteLine("answer =  {0} ",sum);
}

public static void buildlist()
{
string snumber="";
long number=0;
long a,b,c,d,e,f,g,h,i,j;
bool []checker= new bool[45];

for (a=1;a<10;a++)
for (b=0;b<10;b++)
for (c=0;c<10;c++)
for (d=0;d<10;d++)
for (e=0;e<10;e++)
for (f=0;f<10;f++)
for (g=0;g<10;g++)
for (h=0;h<10;h++)
for (i=0;i<10;i++)
for (j=0;j<10;j++)
{
    if (a==b||a==c||a==d||a==e)//||b==c||b==d||b==e||c==d
        continue;
    if ((a+b+c+d+e+f+g+h+i+j)!=45)
        continue;
    checker[0]=(a==b); checker[8]=(b==c);checker[15]=(c==d);checker[21]=(d==e);checker[26]=(e==f);
    checker[1]=(a==c); checker[9]=(b==d);checker[16]=(c==e);checker[22]=(d==f);checker[27]=(e==g);
    checker[2]=(a==d);checker[10]=(b==e);checker[17]=(c==f);checker[23]=(d==g);checker[28]=(e==h);
    checker[3]=(a==e);checker[11]=(b==f);checker[18]=(c==g);checker[24]=(d==h);checker[29]=(e==i);
    checker[4]=(a==f);checker[12]=(b==g);checker[19]=(c==h);checker[25]=(d==i);checker[40]=(e==j);
    checker[5]=(a==g);checker[13]=(b==h);checker[20]=(c==i);checker[39]=(d==j);
    checker[6]=(a==h);checker[14]=(b==i);checker[38]=(c==j);
    checker[7]=(a==i);checker[37]=(b==j);
    checker[36]=(a==j);
    //////////////////////////////////////////////////////////////////////////////////////////
    checker[30]=(f==g);checker[33]=(g==h);checker[35]=(h==i);checker[44]=(i==j);
    checker[31]=(f==h);checker[34]=(g==i);checker[43]=(h==j);
    checker[32]=(f==i);checker[42]=(g==j);
    checker[41]=(f==j);
    if (Array.IndexOf(checker,true)!=-1)
        continue;
    number=(j+i*10+h*100+g*1000+f*10000+e*100000+d*1000000+c*10000000+b*100000000+a*1000000000);
    snumber=number.ToString();
    pdnumbers.Add(snumber);
}

}
}

