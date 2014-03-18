//Solution is 40 choose 20 or 40!/20!*20!
//In my solution I reduce that equation to one C# can more readily handle without Bigintegers
//Numer / denom squared

using System;

class fifteen
{


public static void Main()
{
//below vars are notes to help reduce
//Int64 denom=(20*19*18*17*16*15*14*13*12*11*10*9*8*7*6*5*4*3*2;) squared!!!!!!!!
//long numer=40*39*38*37*36*35*34*33*32*31*30*29*28*27*26*25*24*23*22*21;

         
Int64 numera=39*37*35*2;
Int64 numerb=33*31*29*23*2;
long numerc=numera*numerb;

Console.WriteLine("Answer = {0} ", numerc);
}

}