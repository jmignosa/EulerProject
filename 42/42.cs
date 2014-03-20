using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

class fortytwo
{

public static string[] words;
public static List<int> triangles = new List<int>();

public static void fillTriangles()
{
    
for (int i=0;i<100;i++)
    {int triangle=(i*(i+1))/2;triangles.Add(triangle);}
}

public static void Main()
{
Stopwatch sw=new Stopwatch();
sw.Start();
StreamReader sr = new StreamReader(@"words.txt");
int count=0;
    
fillTriangles();
foreach(var triangle in  triangles)
    Console.WriteLine("Triangle Number.....{0}",triangle);

string wordtext="";

while(sr.Peek()>-1)
{
   wordtext=sr.ReadLine();
}
words=wordtext.Replace("\"","").Split(',');
foreach(var word in words)
{
    int temp=0;
    temp=wordScore(word);//get Value
    if (triangles.IndexOf(temp)!=-1)
        count++;
}
sw.Stop();
Console.WriteLine("There were {0} triangle words",count);
Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
}//end main

public static int wordScore(string word)
{
    int wordscore=0;
    foreach(var letter in word.ToLower())
    {
        switch (letter)
        {
            case 'a':
                wordscore+=1;
                break;
            case 'b':
                wordscore+=2;
                break;
            case 'c':
                wordscore+=3;
                break;
            case 'd':
                wordscore+=4;
                break;
            case 'e':
                wordscore+=5;
                break;
            case 'f':
                wordscore+=6;
                break;
            case 'g':
                wordscore+=7;
                break;
            case 'h':
                wordscore+=8;
                break;
            case 'i':
                wordscore+=9;
                break;
            case 'j':
                wordscore+=10;
                break;
            case 'k':
                wordscore+=11;
                break;
            case 'l':
                wordscore+=12;
                break;
            case 'm':
                wordscore+=13;
                break;
            case 'n':
                wordscore+=14;
                break;
            case 'o':
                wordscore+=15;
                break;
            case 'p':
                wordscore+=16;
                break;
            case 'q':
                wordscore+=17;
                break;
            case 'r':
                wordscore+=18;
                break;
            case 's':
                wordscore+=19;
                break;
            case 't':
                wordscore+=20;
                break;
            case 'u':
                wordscore+=21;
                break;
            case 'v':
                wordscore+=22;
                break;
            case 'w':
                wordscore+=23;
                break;
            case 'x':
                wordscore+=24;
                break;
            case 'y':
                wordscore+=25;
                break;
            case 'z':
                wordscore+=26;
                break;
            default:
                break;
        }
    }
    return wordscore;
}//end wordScore
}//end class