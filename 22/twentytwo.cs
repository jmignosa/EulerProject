using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

class nameData
{
    public int position;
    public string name;
    public long namevalue{
        get
        {
            long number=stringval(name);
            return number*position;
        }
        }
    private long stringval(string aname)
    {
        long nameval=0;
        string bname=aname.ToUpper();
        foreach(char a in bname.ToCharArray())
        {
            string alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            nameval+=(alphabet.IndexOf(a)+1);
            
        }
        return nameval;
    }
    
}

class twentytwo
{
public static void Main()
{
Stopwatch sw = new Stopwatch();
StreamReader theFile= new StreamReader(".\\names.txt");
string buffer="";
string buffer2="";
string []names;
int i=1;
List <nameData> nameList= new List <nameData>();
long totalnamevalue=0;

sw.Start();
buffer2=theFile.ReadLine();
buffer=buffer2.Replace('"','\0');
names=buffer.Split(',');
Array.Sort(names);

foreach (string nam in names)
{
    nameData nameTmp= new nameData();
    nameTmp.name=nam;
    nameTmp.position=i;
    nameList.Add(nameTmp);
    System.Console.WriteLine("Name {0} is {1} value is {2}",i,nam,nameTmp.namevalue);
    totalnamevalue+=nameTmp.namevalue;
    i++;
}
sw.Stop();
Console.WriteLine("Number of entries {0}",(nameList.Count));
Console.WriteLine("Total Value {0}",totalnamevalue);
Console.WriteLine("Elapsed time {0} ms", sw.ElapsedMilliseconds);
}

}